using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MediaOrganizer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainView view = new MainView();
            MainController controller = new MainController(view.Model);

            Application.Run(controller.Model.View);
        }
    }
}
