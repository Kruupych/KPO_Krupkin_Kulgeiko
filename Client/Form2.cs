using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form2 : Form
    {
        Authorization auth;
        public Form2()
        {
            InitializeComponent();
            auth = new Authorization();
        }

        private void buttonEntGuest_Click(object sender, EventArgs e)
        {
            string mode = auth.authorize();
            ((Form1)this.Owner).mode = mode;
            this.Close();
        }

        private void buttonEnt_Click(object sender, EventArgs e)
        {           
            string mode = auth.authorize(this.textLogin.Text,this.textPassword.Text);
            if (mode != "false")
            {
                ((Form1)this.Owner).mode = mode;
                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте правильность данных!");
            }           
        }
    }
}
