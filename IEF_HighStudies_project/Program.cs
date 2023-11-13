using MyDataset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEF_HighStudies_project
{
    static class Program
    {
        private static IEFHSDBdataset ds;
        private static int u_id = 0;
        private static bool admin = false;

        public static bool Administrator
        {
            get { return Program.admin; }
            set { Program.admin = value; }
        }
        public static IEFHSDBdataset GetDataset
        {
            get
            {
                if (Program.ds == null)
                    Program.ds = new IEFHSDBdataset();
                return Program.ds;
            }
        }
        public static int User_ID
        {
            get { return Program.u_id; }
            set { Program.u_id = value; }
        }
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInForm());
        }
    }
}
