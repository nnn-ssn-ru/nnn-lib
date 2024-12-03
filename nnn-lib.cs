using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace nnnlib
{
    public string configPath = "C:\\Users\\stud\\Desktop\\1.txt";
    
    public bool startProcess(string applicationPath, string arguments = "", bool createWindow = true)
    {
        try
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = applicationPath,
                Arguments = arguments,
                UseShellExecute = false,
                CreateNoWindow = !createWindow
            };
            using (Process process = Process.Start(startInfo)) { process.WaitForExit(); }
            return true;
        }
        catch (Exception ex) { return false; }
        }
    
    internal class NNNAuth
    {
        public bool login(string email, string password)
        {
            string[] data = File.ReadAllText(configPath).Split("-");
            for (int i = 0; i < data.Length; i++)
            {
                string[] user = data[i].Split("|");
                if (email == user[0] && password == user[1]) { return true; }
            }
            return false;
        }
        public bool register(string email, string password)
        {
            StreamWriter file = new StreamWriter(configPath, true);
            file.Write("\0000|\0000-" + email + "|" + password);
            file.Close();
            return true;
        }
    }
}
