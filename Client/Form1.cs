using System.Configuration;
using RailwayTransport;
namespace Client
{
    public partial class Form1 : Form
    {
        public string mode;
        public Dictionary<string, Train> Trains;
        public Dictionary<string, IWagon> Wagons;
        public List<IWagon> freeWagons; // свободные вагоны, после включения в состав поезда удаляются из списка
        network connection;
        public Form1()
        {
            InitializeComponent();
            Form2 authorization = new Form2();
            mode = "null";
            authorization.ShowDialog(this);
            timer1.Start();
            connection = new network();
            Trains = new Dictionary<string, Train>();
            Wagons = new Dictionary<string, IWagon>();
            freeWagons= new List<IWagon>();
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
            regenerateTrains();
            
        }

        private void butttonAddW_Click(object sender, EventArgs e)
        {
            Form3 loadingWagon = new Form3();
            loadingWagon.ShowDialog(this);
        }

        private void regenerateWagons()
        {
            if (comboTrains.SelectedText == "")
            {
                return;
            }
            Wagons.Clear();
            Train current = Trains[comboTrains.SelectedText];
            List<IWagon> updatedWagons = new List<IWagon>();
            updatedWagons.AddRange(current.Wagons);
            int i = 1;
            for (;i<= updatedWagons.Count;i++)
            {
                Wagons.Add("Вагон " + i, updatedWagons[i - 1]);
            }
            for (int j=0; i <= freeWagons.Count; i++,j++)
            {
                Wagons.Add("Вагон " + i, freeWagons[j]);
            }
        }
        private void regenerateTrains()
        {
            Trains.Clear();
            List<Train> updatedTrains = new List<Train>();
            updatedTrains.AddRange(connection.getTrainsList());
            int trainCount = updatedTrains.Count;
            for (int i = 1; i <= trainCount; i++)
            {
                Trains.Add("Поезд " + i, updatedTrains[i - 1]);
               
            }
            comboTrains.Items.Clear();
            comboTrains.Items.AddRange(Trains.Keys.ToArray());
        }

        private void comboTrains_Click(object sender, EventArgs e)
        {
            regenerateWagons();
            comboWagons.Items.Clear();
            comboWagons.Items.AddRange(Wagons.Keys.ToArray());
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
