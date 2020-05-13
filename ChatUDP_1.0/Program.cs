using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatUDP_1._0
{
    static class Program
    {

        /// Ponto de entrada principal para o aplicativo.

        [STAThread]
        static void Main()
        {
            Control.CheckForIllegalCrossThreadCalls = false;// Permite Debugar a Aplicação
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
