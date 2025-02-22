using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LLaMAOChatClient.Core;

namespace LLaMAOChatClient.Winforms
{
    public partial class ChatClient : Form
    {
        public string ModelId { get; private set; }

        private ChatClientWithHistory _chatCore;

        public ChatClient(string modelId)
        {
            ModelId = modelId;
            InitializeComponent();
            this.Shown += ChatClient_Shown;
            this.FormClosing += ChatClient_FormClosing;
            //tbInput.Text = "Find the value of $x$ and $y$ that make the following equation evaluate to zero: $144 * x * y + 12 * y - 12 * x - 3218148$";
        }

        private void ChatClient_Shown(object? sender, EventArgs e)
        {
            _chatCore = new ChatClientWithHistory(richChatBox, ModelId);
            this.Text = string.Format("AI Chat Interface - Loaded Model: {0}", ModelId);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendPrompt();
        }

        private void ChatClient_FormClosing(object? sender, FormClosingEventArgs e)
        {
            _chatCore.Shutdown();
        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendPrompt();
            }
        }

        private void SendPrompt()
        {
            string prompt = tbInput.Text;
            tbInput.Clear();
            _chatCore.PromptModel(prompt);
        }
    }
}
