using RailwayTransport.Controller.Network;
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
        StationClient client;
        Authorization auth;
        public StationClient GetClient()
        {
            return client;
        }
        public Form2(StationClient client)
        {
            InitializeComponent();
            auth = new Authorization();
            this.client = client;
            connect();
        }
        private void connect()
        {
            try
            {
                this.client.Connect();
            }
            catch (Exception)
            {

                throw; //make
            }
        }

        private void buttonEntGuest_Click(object sender, EventArgs e)
        {
            string mode = auth.authorize();
            ((Form1)this.Owner).mode = mode;
            this.Close();
        }

        private async void buttonEnt_Click(object sender, EventArgs e)
        {
            bool success = await client.TryAuth(this.textLogin.Text.ToLower(), this.textPassword.Text);
            if (!success)
            {
                MessageBox.Show("Проверьте правильность данных!");
            }
            else
            {
                string mode = this.textLogin.Text.ToLower();
                ((Form1)this.Owner).mode = mode;
                this.Close();
            }
            //string mode = auth.authorize(this.textLogin.Text,this.textPassword.Text);
            //if (mode != "false")
            //{
            //    ((Form1)this.Owner).mode = mode;
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Проверьте правильность данных!");
            //}           
        }
    }
}
