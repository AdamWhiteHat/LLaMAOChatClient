using System.Windows.Forms;

namespace LLaMAOChatClient.Winforms
{
    partial class InstallModel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallModel));
            dataGridView1 = new DataGridView();
            btnInstall = new Button();
            labelSpaceRequired = new Label();
            label2 = new Label();
            label3 = new Label();
            labelModelSelected = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelSpacer = new Label();
            panelInstallModel = new Panel();
            label9 = new Label();
            panelDownloadOllama = new Panel();
            linkOllamaDownload = new LinkLabel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panelPleaseWait = new Panel();
            labelStatusMessage = new Label();
            pictureBox_PleaseWaitThrobber = new PictureBox();
            label8 = new Label();
            panelSelectModel = new Panel();
            buttonSelectAiModel = new Button();
            comboBoxAiModels = new ComboBox();
            label1 = new Label();
            panelNotRunning = new Panel();
            textboxOllamaExecutableLocation = new TextBox();
            label13 = new Label();
            buttonLaunchOllamaServer = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            timerStatusMessageTicker = new Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panelInstallModel.SuspendLayout();
            panelDownloadOllama.SuspendLayout();
            panelPleaseWait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_PleaseWaitThrobber).BeginInit();
            panelSelectModel.SuspendLayout();
            panelNotRunning.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.GridColor = System.Drawing.Color.Black;
            dataGridView1.Location = new System.Drawing.Point(27, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new System.Drawing.Size(922, 424);
            dataGridView1.TabIndex = 2;
            dataGridView1.RowStateChanged += dataGridView1_RowStateChanged;
            // 
            // btnInstall
            // 
            btnInstall.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInstall.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnInstall.Location = new System.Drawing.Point(691, 465);
            btnInstall.Name = "btnInstall";
            btnInstall.Size = new System.Drawing.Size(265, 29);
            btnInstall.TabIndex = 3;
            btnInstall.Text = "Download this model  ";
            btnInstall.UseVisualStyleBackColor = true;
            btnInstall.Click += btnInstall_Click;
            // 
            // labelSpaceRequired
            // 
            labelSpaceRequired.AutoSize = true;
            labelSpaceRequired.Location = new System.Drawing.Point(608, 0);
            labelSpaceRequired.Margin = new Padding(0);
            labelSpaceRequired.MinimumSize = new System.Drawing.Size(0, 29);
            labelSpaceRequired.Name = "labelSpaceRequired";
            labelSpaceRequired.Size = new System.Drawing.Size(51, 29);
            labelSpaceRequired.TabIndex = 4;
            labelSpaceRequired.Text = "{0}GB";
            labelSpaceRequired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(477, 0);
            label2.Margin = new Padding(0);
            label2.MinimumSize = new System.Drawing.Size(0, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(131, 29);
            label2.TabIndex = 5;
            label2.Text = "Space Required:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(286, 0);
            label3.Margin = new Padding(0);
            label3.MinimumSize = new System.Drawing.Size(0, 29);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(131, 29);
            label3.TabIndex = 6;
            label3.Text = "Model Selected:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelModelSelected
            // 
            labelModelSelected.AutoSize = true;
            labelModelSelected.Location = new System.Drawing.Point(417, 0);
            labelModelSelected.Margin = new Padding(0);
            labelModelSelected.MinimumSize = new System.Drawing.Size(0, 29);
            labelModelSelected.Name = "labelModelSelected";
            labelModelSelected.Size = new System.Drawing.Size(30, 29);
            labelModelSelected.TabIndex = 7;
            labelModelSelected.Text = "{0}";
            labelModelSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(labelSpaceRequired);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(labelSpacer);
            flowLayoutPanel1.Controls.Add(labelModelSelected);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold);
            flowLayoutPanel1.Location = new System.Drawing.Point(27, 462);
            flowLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 29);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(659, 35);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // labelSpacer
            // 
            labelSpacer.Location = new System.Drawing.Point(447, 0);
            labelSpacer.Margin = new Padding(0);
            labelSpacer.MaximumSize = new System.Drawing.Size(30, 29);
            labelSpacer.MinimumSize = new System.Drawing.Size(30, 29);
            labelSpacer.Name = "labelSpacer";
            labelSpacer.Size = new System.Drawing.Size(30, 29);
            labelSpacer.TabIndex = 8;
            labelSpacer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInstallModel
            // 
            panelInstallModel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelInstallModel.Controls.Add(label9);
            panelInstallModel.Controls.Add(dataGridView1);
            panelInstallModel.Controls.Add(btnInstall);
            panelInstallModel.Controls.Add(flowLayoutPanel1);
            panelInstallModel.Location = new System.Drawing.Point(39, 0);
            panelInstallModel.Margin = new Padding(0);
            panelInstallModel.Name = "panelInstallModel";
            panelInstallModel.Size = new System.Drawing.Size(961, 500);
            panelInstallModel.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(8, 9);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(350, 20);
            label9.TabIndex = 8;
            label9.Text = "Choose an AI model to download and install:";
            // 
            // panelDownloadOllama
            // 
            panelDownloadOllama.Controls.Add(linkOllamaDownload);
            panelDownloadOllama.Controls.Add(label7);
            panelDownloadOllama.Controls.Add(label6);
            panelDownloadOllama.Controls.Add(label5);
            panelDownloadOllama.Controls.Add(label4);
            panelDownloadOllama.Location = new System.Drawing.Point(1, 3);
            panelDownloadOllama.Name = "panelDownloadOllama";
            panelDownloadOllama.Size = new System.Drawing.Size(994, 222);
            panelDownloadOllama.TabIndex = 9;
            // 
            // linkOllamaDownload
            // 
            linkOllamaDownload.AutoSize = true;
            linkOllamaDownload.Location = new System.Drawing.Point(314, 180);
            linkOllamaDownload.Margin = new Padding(0);
            linkOllamaDownload.Name = "linkOllamaDownload";
            linkOllamaDownload.Size = new System.Drawing.Size(208, 20);
            linkOllamaDownload.TabIndex = 1;
            linkOllamaDownload.TabStop = true;
            linkOllamaDownload.Text = "https://ollama.com/download";
            linkOllamaDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(516, 180);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(208, 20);
            label7.TabIndex = 5;
            label7.Text = " to download the Ollama app.";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(236, 180);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(81, 20);
            label6.TabIndex = 3;
            label6.Text = "Please visit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(236, 157);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(217, 20);
            label5.TabIndex = 2;
            label5.Text = "The Ollama app was not found!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(216, 128);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(84, 20);
            label4.TabIndex = 0;
            label4.Text = "Attention:";
            // 
            // panelPleaseWait
            // 
            panelPleaseWait.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            panelPleaseWait.Controls.Add(labelStatusMessage);
            panelPleaseWait.Controls.Add(pictureBox_PleaseWaitThrobber);
            panelPleaseWait.Controls.Add(label8);
            panelPleaseWait.Location = new System.Drawing.Point(3, 12);
            panelPleaseWait.Name = "panelPleaseWait";
            panelPleaseWait.Size = new System.Drawing.Size(994, 476);
            panelPleaseWait.TabIndex = 10;
            // 
            // labelStatusMessage
            // 
            labelStatusMessage.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelStatusMessage.Location = new System.Drawing.Point(0, 278);
            labelStatusMessage.Name = "labelStatusMessage";
            labelStatusMessage.Size = new System.Drawing.Size(992, 22);
            labelStatusMessage.TabIndex = 5;
            labelStatusMessage.Text = "Initializing...";
            labelStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_PleaseWaitThrobber
            // 
            pictureBox_PleaseWaitThrobber.BackgroundImageLayout = ImageLayout.None;
            pictureBox_PleaseWaitThrobber.Image = (System.Drawing.Image)resources.GetObject("pictureBox_PleaseWaitThrobber.Image");
            pictureBox_PleaseWaitThrobber.Location = new System.Drawing.Point(363, 203);
            pictureBox_PleaseWaitThrobber.Name = "pictureBox_PleaseWaitThrobber";
            pictureBox_PleaseWaitThrobber.Size = new System.Drawing.Size(64, 64);
            pictureBox_PleaseWaitThrobber.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_PleaseWaitThrobber.TabIndex = 4;
            pictureBox_PleaseWaitThrobber.TabStop = false;
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(0, 225);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(992, 20);
            label8.TabIndex = 3;
            label8.Text = "Please wait...";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSelectModel
            // 
            panelSelectModel.Controls.Add(buttonSelectAiModel);
            panelSelectModel.Controls.Add(comboBoxAiModels);
            panelSelectModel.Controls.Add(label1);
            panelSelectModel.Location = new System.Drawing.Point(1, 160);
            panelSelectModel.Name = "panelSelectModel";
            panelSelectModel.Size = new System.Drawing.Size(993, 254);
            panelSelectModel.TabIndex = 11;
            // 
            // buttonSelectAiModel
            // 
            buttonSelectAiModel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonSelectAiModel.Location = new System.Drawing.Point(724, 141);
            buttonSelectAiModel.Name = "buttonSelectAiModel";
            buttonSelectAiModel.Size = new System.Drawing.Size(242, 29);
            buttonSelectAiModel.TabIndex = 4;
            buttonSelectAiModel.Text = "Use this model  ";
            buttonSelectAiModel.UseVisualStyleBackColor = true;
            buttonSelectAiModel.Click += buttonSelectAiModel_Click;
            // 
            // comboBoxAiModels
            // 
            comboBoxAiModels.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxAiModels.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            comboBoxAiModels.FormattingEnabled = true;
            comboBoxAiModels.Items.AddRange(new object[] { "Ollama", "OpenAI" });
            comboBoxAiModels.Location = new System.Drawing.Point(60, 107);
            comboBoxAiModels.Name = "comboBoxAiModels";
            comboBoxAiModels.Size = new System.Drawing.Size(805, 28);
            comboBoxAiModels.TabIndex = 2;
            comboBoxAiModels.Text = "Ollama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(24, 75);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(207, 20);
            label1.TabIndex = 3;
            label1.Text = "Select an AI model to use:";
            // 
            // panelNotRunning
            // 
            panelNotRunning.Controls.Add(textboxOllamaExecutableLocation);
            panelNotRunning.Controls.Add(label13);
            panelNotRunning.Controls.Add(buttonLaunchOllamaServer);
            panelNotRunning.Controls.Add(label12);
            panelNotRunning.Controls.Add(label11);
            panelNotRunning.Controls.Add(label10);
            panelNotRunning.Dock = DockStyle.Fill;
            panelNotRunning.Location = new System.Drawing.Point(0, 0);
            panelNotRunning.Name = "panelNotRunning";
            panelNotRunning.Size = new System.Drawing.Size(1000, 500);
            panelNotRunning.TabIndex = 12;
            // 
            // textboxOllamaExecutableLocation
            // 
            textboxOllamaExecutableLocation.BackColor = System.Drawing.SystemColors.Window;
            textboxOllamaExecutableLocation.Location = new System.Drawing.Point(237, 296);
            textboxOllamaExecutableLocation.Name = "textboxOllamaExecutableLocation";
            textboxOllamaExecutableLocation.ReadOnly = true;
            textboxOllamaExecutableLocation.Size = new System.Drawing.Size(515, 27);
            textboxOllamaExecutableLocation.TabIndex = 6;
            textboxOllamaExecutableLocation.Text = "%LOCALAPPDATA%\\Programs\\Ollama\\ollama app.exe";
            textboxOllamaExecutableLocation.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label13.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            label13.Location = new System.Drawing.Point(1, 179);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(996, 22);
            label13.TabIndex = 5;
            label13.Text = "And then looking for a llama icon in your system tray.";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLaunchOllamaServer
            // 
            buttonLaunchOllamaServer.Location = new System.Drawing.Point(366, 147);
            buttonLaunchOllamaServer.Name = "buttonLaunchOllamaServer";
            buttonLaunchOllamaServer.Size = new System.Drawing.Size(271, 29);
            buttonLaunchOllamaServer.TabIndex = 4;
            buttonLaunchOllamaServer.Text = "Launch Ollama Server";
            buttonLaunchOllamaServer.UseVisualStyleBackColor = true;
            buttonLaunchOllamaServer.Click += buttonLaunchOllamaServer_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            label12.Location = new System.Drawing.Point(5, 118);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(990, 22);
            label12.TabIndex = 3;
            label12.Text = "You can try launching the application again by clicking on this button:";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            label11.Location = new System.Drawing.Point(5, 65);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(990, 22);
            label11.TabIndex = 1;
            label11.Text = "The AI model server appears to not be running, and attempts to start the application programmatically have failed.";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(1, 247);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(994, 43);
            label10.TabIndex = 0;
            label10.Text = "If that doesn't work,                                                                                      \r\nyoull need to manually run the executable found at the following location:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerStatusMessageTicker
            // 
            timerStatusMessageTicker.Tick += StatusMessageTimer_Tick;
            // 
            // InstallModel
            // 
            ClientSize = new System.Drawing.Size(1000, 500);
            Controls.Add(panelPleaseWait);
            Controls.Add(panelDownloadOllama);
            Controls.Add(panelSelectModel);
            Controls.Add(panelInstallModel);
            Controls.Add(panelNotRunning);
            Name = "InstallModel";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Install a LLM Model";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panelInstallModel.ResumeLayout(false);
            panelInstallModel.PerformLayout();
            panelDownloadOllama.ResumeLayout(false);
            panelDownloadOllama.PerformLayout();
            panelPleaseWait.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_PleaseWaitThrobber).EndInit();
            panelSelectModel.ResumeLayout(false);
            panelSelectModel.PerformLayout();
            panelNotRunning.ResumeLayout(false);
            panelNotRunning.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInstall;
        private Label labelSpaceRequired;
        private Label label2;
        private Label labelModelSelected;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelSpacer;
        private Panel panelInstallModel;
        private Panel panelDownloadOllama;
        private Label label5;
        private LinkLabel linkOllamaDownload;
        private Label label4;
        private Label label6;
        private Label label7;
        private Panel panelPleaseWait;
        private Label label8;
        private PictureBox pictureBox_PleaseWaitThrobber;
        private Panel panelSelectModel;
        private Label label9;
        private Button buttonSelectAiModel;
        private ComboBox comboBoxAiModels;
        private Label label1;
        private Panel panelNotRunning;
        private Label label10;
        private Label label11;
        private Label label13;
        private Button buttonLaunchOllamaServer;
        private Label label12;
        private TextBox textboxOllamaExecutableLocation;
        private Label labelStatusMessage;
        private Timer timerStatusMessageTicker;
    }
}

