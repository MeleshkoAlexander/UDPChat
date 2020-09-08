using System.Diagnostics;

namespace MyProcess
{
    public class FindProcces
    {
        public bool ProcessIsRun(string ProcessName)
        {
            Process proc = Process.GetProcessesByName(ProcessName)[0];
            if (proc.HasExited) return true;
            else return false;
        }
        public bool ProcessHaveCopy(string ProcessName)
        {
            int count = 0;
            foreach(Process proc in Process.GetProcesses())
            {
                if (proc.ProcessName == ProcessName) count++;
                if (count > 1) return true;
            }
            return false;
        }
    }
}
