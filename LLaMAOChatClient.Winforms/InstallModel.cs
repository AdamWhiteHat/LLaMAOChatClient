using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Threading;

namespace LLaMAOChatClient.Winforms
{
    public partial class InstallModel : Form
    {
        public string SelectedModel { get; private set; }

        public static string ModelsData_Filename = "AvailableModels.txt";
        public static string[] ModelsData_Columns = new string[]
        {
            "Name", "Description", "URL", "Download", "Last Updated", "Category", "Parameters", "File Size"
        };

        private DataTable _modelsData;

        public InstallModel()
        {
            InitializeComponent();
            HideAllPanels();
            panelPleaseWait.Visible = true;
            panelPleaseWait.Dock = DockStyle.Fill;
            this.Shown += Form_Shown;
        }

        private void Form_Shown(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;

            new Thread(delegate ()
            {
                Core.OllamaStatus serverStatus = LLaMAOChatClient.Core.System.AiServerStatus();

                if (serverStatus == Core.OllamaStatus.OllamaProgramNotInstalled)
                {
                    DownloadOllamaApp();
                }
                else if (serverStatus == Core.OllamaStatus.OllamaProgramNotRunning)
                {
                    if (!LLaMAOChatClient.Core.System.ExecOllamaServer())
                    {
                        OllamaAppNotRunning();
                    }
                }
                else if (serverStatus == Core.OllamaStatus.OllamaModelNotInstalled)
                {
                    InstallOllamaModel();
                }
                else if (serverStatus == Core.OllamaStatus.Success)
                {
                    List<string> installedModels = LLaMAOChatClient.Core.System.GetInstalledModels();
                    if (installedModels.Count == 0)
                    {
                        InstallOllamaModel();
                    }
                    else if (installedModels.Count == 1)
                    {
                        SelectModel(installedModels.First());
                    }
                    else if (installedModels.Count > 1)
                    {
                        SelectOllamaModel(installedModels);
                    }
                }
            }).Start();
        }

        private void SelectModel(string model)
        {
            this.BeginInvoke(new Action(() =>
            {
                SelectedModel = model;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }));
        }

        private void DownloadOllamaApp()
        {
            this.BeginInvoke(new Action(() =>
            {
                HideAllPanels();

                panelDownloadOllama.Visible = true;
                panelDownloadOllama.Dock = DockStyle.Fill;
            }));
        }

        private void OllamaAppNotRunning()
        {
            this.BeginInvoke(new Action(() =>
            {
                HideAllPanels();
                this.DialogResult = DialogResult.Retry;
                textboxOllamaExecutableLocation.Text = Core.System.OllamaServerExecutablePath;
                panelNotRunning.Visible = true;
                panelNotRunning.Dock = DockStyle.Fill;
            }));
        }

        private void InstallOllamaModel()
        {
            this.BeginInvoke(new Action(() =>
            {
                HideAllPanels();

                panelInstallModel.Visible = true;
                panelInstallModel.Dock = DockStyle.Fill;
                LoadModelsData();
            }));
        }

        private void SelectOllamaModel(List<string> installedModels)
        {
            this.BeginInvoke(new Action(() =>
            {
                HideAllPanels();

                panelSelectModel.Visible = true;
                panelSelectModel.Dock = DockStyle.Fill;

                comboBoxAiModels.Items.Clear();

                foreach (string model in installedModels)
                {
                    comboBoxAiModels.Items.Add(model);
                }

                comboBoxAiModels.SelectedIndex = 0;
            }));
        }

        private void HideAllPanels()
        {
            panelPleaseWait.Dock = DockStyle.None;
            panelPleaseWait.Visible = false;

            panelNotRunning.Dock = DockStyle.None;
            panelNotRunning.Visible = false;

            panelDownloadOllama.Dock = DockStyle.None;
            panelDownloadOllama.Visible = false;

            panelInstallModel.Dock = DockStyle.None;
            panelInstallModel.Visible = false;

            panelSelectModel.Dock = DockStyle.None;
            panelSelectModel.Visible = false;
        }

        private void LoadModelsData()
        {
            string[] lines = File.ReadAllLines(ModelsData_Filename);

            string[] headers = lines[0].Split('\t');

            lines = lines.Skip(1).ToArray();

            _modelsData = new DataTable();
            _modelsData.Columns.AddRange(headers.Select(s => new DataColumn(s)).ToArray());
            _modelsData.Columns["MB"].DataType = typeof(Decimal);
            _modelsData.Columns.Add(new DataColumn("SizeUnits") { Expression = "IIF(MB/1024>0, 'GB', 'MB')", DataType = typeof(System.String) });
            _modelsData.Columns.Add(new DataColumn("GB") { Expression = "MB/1024", DataType = typeof(Decimal) });
            _modelsData.Columns.Add(new DataColumn("Size") { Expression = "IIF(GB>1, Convert(GB, 'System.String') + ' ' + SizeUnits, Convert(MB, 'System.String') + ' ' + SizeUnits)" });

            foreach (string line in lines)
            {
                DataRow row = _modelsData.NewRow();
                row.ItemArray = line.Split('\t');
                _modelsData.Rows.Add(row);
            }

            //ReplaceColumnValues(_modelsData, "MB", FormatMegabytes);


            //_modelsData.Columns["MB"].Caption
            //_modelsData.Columns["MB"].Expression
            //_modelsData.Columns["MB"].ExtendedProperties

            //dataGridView1.CellFormatting += DataGridView1_CellFormatting;

            Font headerFont = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                BackColor = Color.DarkGray,
                ForeColor = Color.White,
                SelectionBackColor = Color.DarkGray,
                SelectionForeColor = Color.White,
                Font = headerFont
            };
            dataGridView1.EnableHeadersVisualStyles = true;

            dataGridView1.DataSource = _modelsData;
            dataGridView1.Columns["URL"].Visible = false;
            dataGridView1.Columns["Description"].Width = 650;
            //dataGridView1.Columns["MB"].ValueType = typeof(Decimal);

            //dataGridView1.Columns["MB"].Visible = false;
            //dataGridView1.Columns["GB"].Visible = false;
            //dataGridView1.Columns["SizeUnits"].Visible = false;
            dataGridView1.Columns["Size"].DisplayIndex = 2;
        }


        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                string name = e.Row.Cells["Name"].Value.ToString();
                string size = e.Row.Cells["Size"].Value.ToString();
                labelModelSelected.Text = name;
                labelSpaceRequired.Text = size;
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(labelModelSelected.Text))
            {
                return;
            }

            SelectedModel = labelModelSelected.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonSelectAiModel_Click(object sender, EventArgs e)
        {
            SelectedModel = comboBoxAiModels.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonLaunchOllamaServer_Click(object sender, EventArgs e)
        {
            Core.System.ExecOllamaServer();
        }
    }
}
