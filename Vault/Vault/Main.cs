using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Vault
{
    public partial class Main : Form
    {
        //Rounded Corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Main()
        {
            InitializeComponent();
            //Rounded Corners
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void Main_Load(object sender, EventArgs e)
        {
            View_Passwords();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void View_Passwords()
        {
            DataDb dataDb = new DataDb();
            DataTable dt = dataDb.Select_data();
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                string name = dt.Rows[index]["name"].ToString();
               
                dgv_password.Rows.Add(" ",name);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
