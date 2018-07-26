using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vault
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Users users = new Users();

        private void lbl_CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_MinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            users.Username = txt_Username.Text;
            users.Password = txt_Password.Text;

            if(users.Select_User(txt_Username.Text, txt_Password.Text).Rows.Count!=0)
                {
                this.Hide();
                Main main = new Main();
                main.Show();
               
            }
            else
            {
                MessageBox.Show("Incorrect username or passwords");
            }

        }
        
    }
}
