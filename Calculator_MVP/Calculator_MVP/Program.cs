using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_MVP
{
    static class Program
    {
    
        [STAThread]
        static void Main()
        {
      

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Model model = new Model();
            View1 view1 = new View1();
            Presenter p = new Presenter(model, view1);
            Application.Run(view1);
        }
    }
}
