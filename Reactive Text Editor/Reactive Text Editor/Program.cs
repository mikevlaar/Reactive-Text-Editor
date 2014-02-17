using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Reactive_Text_Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 Form = new Form1();
            Application.Run(Form);
        }
    }
}
