using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.AI;
using OllamaSharp.Models;

namespace LLaMAOChatClient.Winforms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.Shown += FormShown;
        }

        private void FormShown(object? sender, EventArgs e)
        {
            OllamaSharp.OllamaApiClient.Configuration cfg = new OllamaSharp.OllamaApiClient.Configuration()
            {
                Model = "",
                Uri = new Uri("")
            };

            ChatOptions chatOptions = new ChatOptions()
            {
                TopK = 40,
                TopP = 0.9f,
                Temperature = 0.8f,
                FrequencyPenalty = 1.1f,
                MaxOutputTokens = 16000,
                PresencePenalty = 0.0f,
                Seed = 0,
                ResponseFormat = ChatResponseFormat.Text,
                ToolMode = ChatToolMode.Auto,
                AdditionalProperties = new AdditionalPropertiesDictionary(),
                // Tools = new AITool[] { new AITool() }
            };

            OllamaOption ollamaOption = new OllamaOption("");

            //OllamaSharp.ChatOptionsExtensions.AddOllamaOption()
        }

        /*
        //
        // Summary:
        //     Enable f16 key/value. (Default: False)
        public static OllamaOption F16kv { get; } = new OllamaOption("f16_kv");
        
        
        //
        // Summary:
        //     The penalty to apply to tokens based on their frequency in the prompt. (Default:
        //     0.0)
        public static OllamaOption FrequencyPenalty { get; } = new OllamaOption("frequency_penalty");
        
        
        //
        // Summary:
        //     Return logits for all the tokens, not just the last one. (Default: False)
        public static OllamaOption LogitsAll { get; } = new OllamaOption("logits_all");
        
        
        //
        // Summary:
        //     Enable low VRAM mode. (Default: False)
        public static OllamaOption LowVram { get; } = new OllamaOption("low_vram");
        
        
        //
        // Summary:
        //     This option controls which GPU is used for small tensors. The overhead of splitting
        //     the computation across all GPUs is not worthwhile. The GPU will use slightly
        //     more VRAM to store a scratch buffer for temporary results. By default, GPU 0
        //     is used.
        public static OllamaOption MainGpu { get; } = new OllamaOption("main_gpu");
        
        
        //
        // Summary:
        //     Alternative to the top_p, and aims to ensure a balance of quality and variety.min_p
        //     represents the minimum probability for a token to be considered, relative to
        //     the probability of the most likely token.For example, with min_p=0.05 and the
        //     most likely token having a probability of 0.9, logits with a value less than
        //     0.05*0.9=0.045 are filtered out. (Default: 0.0)
        public static OllamaOption MinP { get; } = new OllamaOption("min_p");
        
        
        //
        // Summary:
        //     Enable Mirostat sampling for controlling perplexity. (default: 0, 0 = disabled,
        //     1 = Mirostat, 2 = Mirostat 2.0)
        public static OllamaOption MiroStat { get; } = new OllamaOption("mirostat");
        
        
        //
        // Summary:
        //     Influences how quickly the algorithm responds to feedback from the generated
        //     text. A lower learning rate will result in slower adjustments, while a higher
        //     learning rate will make the algorithm more responsive. (Default: 0.1)
        public static OllamaOption MiroStatEta { get; } = new OllamaOption("mirostat_eta");
        
        
        //
        // Summary:
        //     Controls the balance between coherence and diversity of the output. A lower value
        //     will result in more focused and coherent text. (Default: 5.0)
        public static OllamaOption MiroStatTau { get; } = new OllamaOption("mirostat_tau");
        
        
        //
        // Summary:
        //     Enable NUMA support. (Default: False)
        public static OllamaOption Numa { get; } = new OllamaOption("numa");
        
        
        //
        // Summary:
        //     Prompt processing maximum batch size. (Default: 512)
        public static OllamaOption NumBatch { get; } = new OllamaOption("num_batch");
        
        
        //
        // Summary:
        //     Sets the size of the context window used to generate the next token. (Default:
        //     2048)
        public static OllamaOption NumCtx { get; } = new OllamaOption("num_ctx");
        
        
        //
        // Summary:
        //     The number of layers to send to the GPU(s). On macOS it defaults to 1 to enable
        //     metal support, 0 to disable.
        public static OllamaOption NumGpu { get; } = new OllamaOption("num_gpu");
        
        
        //
        // Summary:
        //     The number of GQA groups in the transformer layer. Required for some models,
        //     for example it is 8 for llama2:70b
        public static OllamaOption NumGqa { get; } = new OllamaOption("num_gqa");
        
        
        //
        // Summary:
        //     Number of tokens to keep from the initial prompt. (Default: 4, -1 = all)
        public static OllamaOption NumKeep { get; } = new OllamaOption("num_keep");
        
        
        //
        // Summary:
        //     Maximum number of tokens to predict when generating text. (Default: 128, -1 =
        //     infinite generation, -2 = fill context)
        public static OllamaOption NumPredict { get; } = new OllamaOption("num_predict");
        
        
        //
        // Summary:
        //     Sets the number of threads to use during computation. By default, Ollama will
        //     detect this for optimal performance. It is recommended to set this value to the
        //     number of physical CPU cores your system has (as opposed to the logical number
        //     of cores).
        public static OllamaOption NumThread { get; } = new OllamaOption("num_thread");
        
        
        //
        // Summary:
        //     Penalize newline tokens (Default: True)
        public static OllamaOption PenalizeNewline { get; } = new OllamaOption("penalize_newline");
        
        
        //
        // Summary:
        //     The penalty to apply to tokens based on their presence in the prompt. (Default:
        //     0.0)
        public static OllamaOption PresencePenalty { get; } = new OllamaOption("presence_penalty");
        
        
        //
        // Summary:
        //     Sets how far back for the model to look back to prevent repetition. (Default:
        //     64, 0 = disabled, -1 = num_ctx)
        public static OllamaOption RepeatLastN { get; } = new OllamaOption("repeat_last_n");
        
        
        //
        // Summary:
        //     Sets how strongly to penalize repetitions. A higher value (e.g., 1.5) will penalize
        //     repetitions more strongly, while a lower value (e.g., 0.9) will be more lenient.
        //     (Default: 1.1)
        public static OllamaOption RepeatPenalty { get; } = new OllamaOption("repeat_penalty");
        
        
        //
        // Summary:
        //     Sets the random number seed to use for generation. Setting this to a specific
        //     number will make the model generate the same text for the same prompt. (Default:
        //     0)
        public static OllamaOption Seed { get; } = new OllamaOption("seed");
        
        
        //
        // Summary:
        //     Sets the stop sequences to use. When this pattern is encountered the LLM will
        //     stop generating text and return. Multiple stop patterns may be set by specifying
        //     multiple separate stop parameters in a modelfile.
        public static OllamaOption Stop { get; } = new OllamaOption("stop");
        
        
        //
        // Summary:
        //     The temperature of the model. Increasing the temperature will make the model
        //     answer more creatively. (Default: 0.8)
        public static OllamaOption Temperature { get; } = new OllamaOption("temperature");
        
        
        //
        // Summary:
        //     Tail free sampling is used to reduce the impact of less probable tokens from
        //     the output. A higher value (e.g., 2.0) will reduce the impact more, while a value
        //     of 1.0 disables this setting. (default: 1)
        public static OllamaOption TfsZ { get; } = new OllamaOption("tfs_z");
        
        
        //
        // Summary:
        //     Reduces the probability of generating nonsense. A higher value (e.g. 100) will
        //     give more diverse answers, while a lower value (e.g. 10) will be more conservative.
        //     (Default: 40)
        public static OllamaOption TopK { get; } = new OllamaOption("top_k");
        
        
        //
        // Summary:
        //     Works together with top-k. A higher value (e.g., 0.95) will lead to more diverse
        //     text, while a lower value (e.g., 0.5) will generate more focused and conservative
        //     text. (Default: 0.9)
        public static OllamaOption TopP { get; } = new OllamaOption("top_p");
        
        
        //
        // Summary:
        //     The typical-p value to use for sampling. Locally Typical Sampling implementation
        //     described in the paper https://arxiv.org/abs/2202.00666. (Default: 1.0)
        public static OllamaOption TypicalP { get; } = new OllamaOption("typical_p");
        
        //
        // Summary:
        //     Lock the model in memory to prevent swapping. This can improve performance, but
        //     it uses more RAM and may slow down loading. (Default: False)
        public static OllamaOption UseMlock { get; } = new OllamaOption("use_mlock");
        
        
        //
        // Summary:
        //     Models are mapped into memory by default, which allows the system to load only
        //     the necessary parts as needed. Disabling mmap makes loading slower but reduces
        //     pageouts if you're not using mlock. If the model is bigger than your RAM, turning
        //     off mmap stops it from loading. (Default: True)
        public static OllamaOption UseMmap { get; } = new OllamaOption("use_mmap");
        
        
        //
        // Summary:
        //     Load only the vocabulary, not the weights. (Default: False)
        public static OllamaOption VocabOnly { get; } = new OllamaOption("vocab_only");
         
         */
        /*
        F16kv           
        FrequencyPenalty
        LogitsAll       
        LowVram         
        MainGpu         
        MinP            
        MiroStat        
        MiroStatEta     
        MiroStatTau     
        Numa            
        NumBatch        
        NumCtx          
        NumGpu          
        NumGqa          
        NumKeep         
        NumPredict      
        NumThread       
        PenalizeNewline 
        PresencePenalty 
        RepeatLastN     
        RepeatPenalty   
        Seed            
        Stop            
        Temperature     
        TfsZ            
        TopK            
        TopP            
        TypicalP        
        UseMlock        
        UseMmap         
        VocabOnly
        */
    }
}
