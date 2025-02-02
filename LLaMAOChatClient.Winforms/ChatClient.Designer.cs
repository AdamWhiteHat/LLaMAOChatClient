using System.Windows.Forms;

namespace LLaMAOChatClient.Winforms
{
    partial class ChatClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            tbInput = new System.Windows.Forms.TextBox();
            btnSend = new System.Windows.Forms.Button();
            richChatBox = new System.Windows.Forms.RichTextBox();
            SuspendLayout();
            // 
            // tbInput
            // 
            tbInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbInput.Location = new System.Drawing.Point(6, 443);
            tbInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbInput.Name = "tbInput";
            tbInput.Size = new System.Drawing.Size(702, 27);
            tbInput.TabIndex = 1;
            tbInput.Text = "Find the value of $x$ and $y$ that make the following equation evaluate to zero: $144 * x * y + 12 * y - 12 * x - 3218148$";
            tbInput.KeyDown += tbInput_KeyDown;
            // 
            // btnSend
            // 
            btnSend.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSend.Location = new System.Drawing.Point(715, 440);
            btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(84, 30);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // richChatBox
            // 
            richChatBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richChatBox.BackColor = System.Drawing.SystemColors.Window;
            richChatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            richChatBox.BulletIndent = 3;
            richChatBox.HideSelection = false;
            richChatBox.Location = new System.Drawing.Point(6, 4);
            richChatBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            richChatBox.Name = "richChatBox";
            richChatBox.ReadOnly = true;
            richChatBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richChatBox.ShowSelectionMargin = true;
            richChatBox.Size = new System.Drawing.Size(793, 428);
            richChatBox.TabIndex = 3;
            richChatBox.Text = "";
            // 
            // ChatClient
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(806, 478);
            Controls.Add(richChatBox);
            Controls.Add(btnSend);
            Controls.Add(tbInput);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ChatClient";
            Text = "AI Chat Interface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox richChatBox;
    }
}