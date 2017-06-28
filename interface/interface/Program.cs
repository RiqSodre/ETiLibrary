using Interface.Formularios.Sistema;
using System;
using System.Windows.Forms;

namespace Interface
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);

             FrmLogin frmLogin = new FrmLogin();

             if(frmLogin.ShowDialog() == DialogResult.Yes)
             {
                Application.Run(new FrmMenu());
             }
        }
    }
}
