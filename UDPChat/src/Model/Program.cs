using System;
using System.Windows.Forms;

namespace UDPChat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool single = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (single) SingleComp();
            else NotSingleComp();
        }
        private static void SingleComp()
        {
            var View = new View.PortEnter();
            var Model = new ModelChat();
            
            Application.Run(View);
        }
        private static void NotSingleComp()
        {
            var View = new View.UserLogin();
            var Model = new ModelChat();
            Model.Localport = Model.Remoteport = 8888;
            var Presentor = new Presentor.PresentorUserLogin(View, Model);
            var _ = new MyProcess.FindProcces();
            if (_.ProcessHaveCopy("UDPChat"))
            {
                MessageBox.Show("Данное приложение уже запущено на вашем компьютере", "Error");
                Environment.Exit(0);
            }
            Application.Run(View);
        }
    }
}
