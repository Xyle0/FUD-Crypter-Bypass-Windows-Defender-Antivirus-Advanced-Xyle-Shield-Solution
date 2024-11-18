using System;
using System.Windows.Forms;

namespace authguard
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public 8()
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (Program.auth_sample.login(username.Text, password.Text))
            {
              
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }

        void OnFormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
