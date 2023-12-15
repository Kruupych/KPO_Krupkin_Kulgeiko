using System.Configuration;
using RailwayTransport;
namespace Client
{
    public partial class Form1 : Form
    {
        public string mode;
        public Dictionary<string, Train> Trains;
        public Dictionary<string, IWagon> Wagons;
        public Dictionary<string, IWagon> WagonsOnStation;
        //public List<IWagon> freeWagons; // свободные вагоны, после включения в состав поезда удаляются из списка
        Network connection;
        public Form1()
        {
            InitializeComponent();
            Form2 authorization = new Form2();
            mode = "null";
            authorization.ShowDialog(this);
            timer1.Start();
            timer2.Start();
            connection = new Network();
            Trains = new Dictionary<string, Train>();
            Wagons = new Dictionary<string, IWagon>();
            WagonsOnStation = new Dictionary<string, IWagon>();
            //freeWagons = new List<IWagon>();
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
            regenerateTrains();
            regenerateFreeWagons();    
        }

        private void butttonAddW_Click(object sender, EventArgs e)
        {
            Form3 loadingWagon;
            if (sender == this.buttonLoadW)
            {
                CargoWagon cw;
                PassengerWagon pw;
                if (Wagons[comboWagons.SelectedItem.ToString()].IsPassenger == false)
                {
                    cw = new CargoWagon((CargoWagon)Wagons[comboWagons.SelectedItem.ToString()]);
                    //Wagons[comboWagons.SelectedItem.ToString()] = cw;
                    loadingWagon = new Form3(cw);
                }
                else
                {
                    pw = new PassengerWagon((PassengerWagon)Wagons[comboWagons.SelectedItem.ToString()]);
                    //Wagons[comboWagons.SelectedItem.ToString()] = pw;
                    loadingWagon = new Form3(pw);
                }
                loadingWagon.ShowDialog(this);
                IWagon wagon = loadingWagon.getCurrentWagon();
                Wagons[comboWagons.SelectedItem.ToString()] = wagon;
            }
            else
            {
                loadingWagon = new Form3();
                loadingWagon.ShowDialog(this);
                IWagon wagon = loadingWagon.getCurrentWagon();
                WagonsOnStation.Add($"Вагон {WagonsOnStation.Count + 1}", wagon);
                string myKey = WagonsOnStation.FirstOrDefault(x => x.Value == wagon).Key;
                comboFreeWagons.Items.Add(myKey);
            }


        }

        private void regenerateWagons()
        {
            if (comboTrains.SelectedText == "")
            {
                return;
            }
            Wagons.Clear();
            Train current = Trains[comboTrains.SelectedItem.ToString()];
            List<IWagon> updatedWagons = new List<IWagon>();
            updatedWagons.AddRange(current.Wagons);
            int i = 1;
            for (; i <= updatedWagons.Count; i++)
            {
                Wagons.Add("Вагон " + i, updatedWagons[i - 1]);
            }
            //for (int j = 0; i <= freeWagons.Count; i++, j++)
            //{
            //    Wagons.Add("Вагон " + i, freeWagons[j]);
            //}
        }
        private void regenerateFreeWagons()
        {
            comboFreeWagons.Items.Clear();
            comboFreeWagons.Items.AddRange(WagonsOnStation.Keys.ToArray());
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

        private void buttonClearW_Click(object sender, EventArgs e)
        {
            regenerateWagons();
            CargoWagon cw;
            PassengerWagon pw;
            if (Wagons[comboWagons.SelectedItem.ToString()].IsPassenger == false)
            {
                cw = new CargoWagon((CargoWagon)Wagons[comboWagons.SelectedItem.ToString()]);
                textMain.Text += cw.ResourceType.ToString();
                cw.Unload();
                Wagons[comboWagons.SelectedItem.ToString()] = cw;
            }
            else
            {
                pw = new PassengerWagon((PassengerWagon)Wagons[comboWagons.SelectedItem.ToString()]);
                textMain.Text += pw.PassengersCount.ToString();
                pw.Unload();
                Wagons[comboWagons.SelectedItem.ToString()] = pw;
            }

        }

        private void buttonGetTrain_Click(object sender, EventArgs e)
        {

        }

        private void buttonSendTrain_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeNow.Text = DateTime.Now.TimeOfDay.ToString();
        }

        private void comboFreeWagons_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wagonInfo = WagonsOnStation[comboFreeWagons.SelectedItem.ToString()].IsPassenger ? "Количестов пассажиров" + ((PassengerWagon)WagonsOnStation[comboFreeWagons.SelectedItem.ToString()]).PassengersCount.ToString() : ((CargoWagon)WagonsOnStation[comboFreeWagons.SelectedItem.ToString()]).ResourceType.ToString();
            textMain.Text += " " + wagonInfo;
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
