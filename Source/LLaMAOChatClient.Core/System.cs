using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OllamaSharp.Models;
using OllamaSharp;
using static System.Net.WebRequestMethods;
using Microsoft.SemanticKernel;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace LLaMAOChatClient.Core
{
    public enum OllamaStatus
    {
        Success,
        OllamaProgramNotInstalled,
        OllamaProgramNotRunning,
        OllamaModelNotInstalled,
        OllamaModelInUse,
        OtherError,
    }

    public static class System
    {
        public static string OllamaServerExecutablePath = Environment.ExpandEnvironmentVariables(@"%LOCALAPPDATA%\Programs\Ollama\ollama app.exe");

        private static Process _ollamaServerProcess;

        public static OllamaStatus AiServerStatus()
        {
            if (!OllamaProgramInstallationCheck())
            {
                return OllamaStatus.OllamaProgramNotInstalled;
            }

            if (!OllamaModelInstallationCheck())
            {
                return OllamaStatus.OllamaModelNotInstalled;
            }

            if (!IsOllamaServerRunning())
            {
                if (!ExecOllamaServer())
                {
                    return OllamaStatus.OllamaProgramNotRunning;
                }

                Thread.Sleep(5000);

                if (!IsOllamaServerRunning())
                {
                    return OllamaStatus.OllamaProgramNotRunning;
                }
            }

            return OllamaStatus.Success;
        }

        public static bool OllamaProgramInstallationCheck()
        {
            if (!InstallCheck_Method1())
            {
                return false;
            }

            if (!InstallCheck_Method2())
            {
                return false;
            }

            return true;
        }

        private static bool InstallCheck_Method1()
        {
            // i.e. "C:\Users\CodeNinja"
            string pathUserProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            // i.e. "C:\Users\CodeNinja\AppData\Local"
            string pathLocalApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            string ollamaProgramFiles = Environment.ExpandEnvironmentVariables(@"%LOCALAPPDATA%\Programs\Ollama");
            string ollamaModels = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\.ollama\models");
            string ollamaHisory = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\.ollama\history");

            if (!Directory.Exists(ollamaProgramFiles))
            {
                return false;
            }

            if (!Directory.Exists(ollamaModels))
            {
                return false;
            }

            /*
            if (!Directory.Exists(ollamaHisory))
            {
                return false;
            }
            */

            return true;
        }

        private static bool InstallCheck_Method2()
        {
            //  HKEY_CURRENT_USER\Environment -  PATH Environment Variable, with appended: "%LOCALAPPDATA%\Programs\Ollama"
            string pathEnvVar = Environment.GetEnvironmentVariable("PATH");
            if (pathEnvVar != null)
            {
                if (!pathEnvVar.Contains(@"\Programs\Ollama", StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }

            // Uninstall registry keys; check for the existence of:
            // HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Uninstall\{44E83376-CE68-45EB-8FC1-393500EB558C}_is1

            return true;
        }

        public static bool OllamaModelInstallationCheck()
        {
            string ollamaModelPath = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\.ollama\models\manifests\registry.ollama.ai\library\");
            if (ollamaModelPath == null)
            {
                return false;
            }
            return true;
        }

        public static List<string> GetInstalledModels()
        {
            // Get installed models via path structure:
            string ollamaModelPath = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\.ollama\models\manifests\registry.ollama.ai\library\");
            if (ollamaModelPath == null)
            {
                return new List<string>();
            }

            // {subfolder-name}\{filename} => {model-name}:{parameter-size}
            // i.e.:
            // %USERPROFILE%\.ollama\models\manifests\registry.ollama.ai\library\qwen2-math\72b
            // => "qwen2-math:72b"

            List<string> results = new List<string>();

            foreach (string modelName in Directory.EnumerateDirectories(ollamaModelPath))
            {
                foreach (string parameterSize in Directory.EnumerateFiles(Path.Combine(ollamaModelPath, modelName)))
                {
                    results.Add($"{modelName}:{parameterSize}");
                }
            }

            return results;
        }

        public static bool IsOllamaServerRunning()
        {
            bool isRunning = false;
            try
            {
                Uri uri = new Uri("http://localhost:11434"); //Default Ollama endpoint
                OllamaApiClient ollama = new OllamaApiClient(uri);
                isRunning = ollama.IsRunningAsync().Result;
            }
            catch
            {
                return false;
            }
            return isRunning;
        }

        public static bool ExecOllamaServer()
        {
            bool newProcessStarted = false;
            try
            {
                // Execute: "%LOCALAPPDATA%\Programs\Ollama\ollama app.exe"                

                string arguments = Environment.ExpandEnvironmentVariables(@"START CMD /D /Q /C ""%LOCALAPPDATA%\Programs\Ollama\ollama app.exe""");

                Process ollamaServerProcess = new Process();
                ollamaServerProcess.StartInfo.FileName = "cmd.exe";
                ollamaServerProcess.StartInfo.Arguments = arguments;
                ollamaServerProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                ollamaServerProcess.StartInfo.UseShellExecute = true;
                ollamaServerProcess.StartInfo.LoadUserProfile = true;
                ollamaServerProcess.StartInfo.ErrorDialog = true;

                newProcessStarted = ollamaServerProcess.Start();
            }
            catch (Exception ex)
            {
                return false;
            }

            return newProcessStarted;
        }
    }
}
