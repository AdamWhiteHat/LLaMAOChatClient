using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Microsoft.SemanticKernel.ChatCompletion;
using OllamaSharp;
using OllamaSharp.Models;

namespace LLaMAOChatClient.Core
{

    public class ChatClientWithHistory
    {
        public string ModelId { get; private set; }

        private List<ChatMessage> _chatHistory;
        private IDistributedCache _chatCache;

        private IChatClient _chatClient;
        private StringBuilder _chatResponseBuffer;
        private RichTextBox _textboxControl;

        private string _chatOutputLogFilenme = "Chat.Output.log.txt";

        public ChatClientWithHistory(RichTextBox outputTextbox, string modelId)
        {
            if (outputTextbox == null) throw new ArgumentNullException(nameof(outputTextbox));
            if (string.IsNullOrWhiteSpace(modelId)) throw new ArgumentException("Must provide a model name", nameof(modelId));

            ModelId = modelId;
            _textboxControl = outputTextbox;


            _chatCache = new MemoryDistributedCache(Options.Create(new MemoryDistributedCacheOptions()));

            _chatClient = new OllamaChatClient(LLaMAOChatClient.Core.System.DefaultServerUrl, ModelId)
              .AsBuilder()
            .UseDistributedCache(_chatCache)
            .Build();

            _chatHistory = new List<ChatMessage>();
            _chatResponseBuffer = new StringBuilder();

            WriteChatOutput(ChatRole.System, "You are a helpful AI math assistant. Please reason step by step, and put your final answer within \\boxed{}.");
        }

        public async void PromptModel(string userPrompt)
        {
            WriteChatOutput(ChatRole.User, userPrompt);

            _chatResponseBuffer.Clear();
            _chatResponseBuffer.Append(await _chatClient.CompleteAsync(_chatHistory));

            WriteChatOutput(ChatRole.Assistant, _chatResponseBuffer.ToString());
        }

        public void WriteChatOutput(ChatRole role, string message)
        {
            string logLine = string.Format("{0}: {1}{2}{2}", ChatOutputPrefix[role], message, Environment.NewLine);
            if (role != ChatRole.System)
            {
                _textboxControl.Text += logLine;
            }
            _chatHistory.Add(new ChatMessage(role, message));
            File.AppendAllText(_chatOutputLogFilenme, logLine);

        }

        private static Dictionary<ChatRole, string> ChatOutputPrefix = new Dictionary<ChatRole, string>()
        {
            { ChatRole.System, "<|System|>" },
            { ChatRole.User, "<YOU>" },
            { ChatRole.Assistant, "<ChatbotAI>" }
        };

        public void Shutdown()
        {
            ModelId = string.Empty;
            _textboxControl = null;
            _chatResponseBuffer.Clear();
            _chatResponseBuffer = null;
            _chatHistory.Clear();
            _chatClient.Dispose();
            //_chatCache;
        }
    }
}