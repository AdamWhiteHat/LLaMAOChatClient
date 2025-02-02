using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLaMAOChatClient.Winforms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationContext ctx = new ApplicationContext();


            InstallModel installModelForm = new InstallModel();
            Application.Run(installModelForm);

            if (installModelForm.DialogResult != DialogResult.OK)
            {
                return;
            }

            string modelId = "qwen2-math:72b";//installModelForm.SelectedModel;

            ChatClient chatClientForm = new ChatClient(modelId);

            Application.Run(chatClientForm);
        }
    }
}
