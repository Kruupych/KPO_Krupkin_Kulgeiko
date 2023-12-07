using System.Configuration;

namespace Client
{


    public partial class Form1 : Form
    {
        public string mode;
        public Form1()
        {
            InitializeComponent();
            Form2 authorization = new Form2();
            mode = "null";
            authorization.ShowDialog(this);
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "null":
                    {
                        this.labelName.Text = mode;
                        break;
                    }
                default:
                    {
                        this.labelName.Text = mode;
                        break;
                    }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeNow.Text = DateTime.Now.TimeOfDay.ToString();
        }

        private void butttonAddW_Click(object sender, EventArgs e)
        {
            Form3 loadingWagon = new Form3();
            loadingWagon.ShowDialog(this);
        }
    }
    public class Authorization
    {
        public Dictionary<string, string> users = new() { { "minsk", "123" }, { "gomel", "234" }, { "bobruisk", "345" } };
        public List<string> enterMode = new() { "guest", "minsk", "gomel", "bobruisk" };
        public Authorization()
        {

        }
       
        public string authorize(string username, string password)
        {
            string mode = "false";
            if (users.ContainsKey(username) && users[username] == password)
            {
                 mode = username.ToLower();
            }
            return mode;
        }
        public string authorize()
        {                    
            return enterMode[0];
        }
    }
}
