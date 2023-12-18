using System.Configuration;
using RailwayTransport;
namespace Client
{
    public partial class Form1 : Form
    {
        public string mode;
        public string time;
        public Dictionary<string, Train> Trains;
        public Dictionary<string, IWagon> Wagons;
        public Dictionary<string, IWagon> WagonsOnStation;
        Network connection;
        Train currentTrain;
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
            regenerateTrains();
            radioWagon.Checked = true;
            radioInfoWagon.Checked = true;
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
        }
        private void onUpdateFreeWagon()
        {
            if (comboFreeWagons.Items != null  && comboFreeWagons.Items.Count!=0)
            {
                comboFreeWagons.SelectedIndex = 0;
            }
        }
        private void onUpdateWagon()
        {
            if (comboWagons.Items != null && comboWagons.Items.Count != 0)
            {
                comboWagons.SelectedIndex = 0;
            }
        }
        private void butttonAddW_Click(object sender, EventArgs e)
        {
            Form3 loadingWagon;
            if (sender == this.buttonLoadW)
            {
                CargoWagon cw;
                PassengerWagon pw;
                if (radioWagon.Checked)
                {
                    if (comboWagons.Items == null || comboWagons.Items.Count == 0)
                    {
                        return;
                    }
                    if (Wagons[comboWagons.SelectedItem.ToString()].IsPassenger == false)
                    {
                        cw = new CargoWagon((CargoWagon)Wagons[comboWagons.SelectedItem.ToString()]);
                        loadingWagon = new Form3(cw);
                    }
                    else
                    {
                        pw = new PassengerWagon((PassengerWagon)Wagons[comboWagons.SelectedItem.ToString()]);
                        loadingWagon = new Form3(pw);
                    }
                    loadingWagon.ShowDialog(this);
                    IWagon wagon = loadingWagon.getCurrentWagon();
                    Wagons[comboWagons.SelectedItem.ToString()] = wagon;
                }
                else
                {
                    if (comboFreeWagons.Items == null || comboFreeWagons.Items.Count == 0)
                    {
                        return;
                    }
                    if (WagonsOnStation[comboFreeWagons.SelectedItem.ToString()].IsPassenger == false)
                    {
                        cw = new CargoWagon((CargoWagon)WagonsOnStation[comboFreeWagons.SelectedItem.ToString()]);
                        loadingWagon = new Form3(cw);
                    }
                    else
                    {
                        pw = new PassengerWagon((PassengerWagon)WagonsOnStation[comboFreeWagons.SelectedItem.ToString()]);
                        loadingWagon = new Form3(pw);
                    }
                    loadingWagon.ShowDialog(this);
                    IWagon wagon = loadingWagon.getCurrentWagon();
                    WagonsOnStation[comboFreeWagons.SelectedItem.ToString()] = wagon;
                }

            }
            else
            {
                loadingWagon = new Form3();
                loadingWagon.ShowDialog(this);
                IWagon wagon = loadingWagon.getCurrentWagon();
                WagonsOnStation.Add($"Вагон {WagonsOnStation.Count + 1}", wagon);
                string myKey = WagonsOnStation.FirstOrDefault(x => x.Value == wagon).Key;
                comboFreeWagons.Items.Add(myKey);
                regenerateFreeWagons();
            }

            
        }

        private void regenerateWagons()
        {
            if (comboTrains.SelectedItem == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(comboTrains.SelectedItem.ToString()))
            {
                return;
            }
            Wagons.Clear();
            currentTrain= Trains[comboTrains.SelectedItem.ToString()];
            List<IWagon> updatedWagons = new List<IWagon>();
            updatedWagons.AddRange(currentTrain.Wagons);
            int i = 1;
            for (; i <= updatedWagons.Count; i++)
            {
                Wagons.Add("Вагон " + i, updatedWagons[i - 1]);
            }
        }
        private void regenerateFreeWagons()
        {
            comboFreeWagons.Items.Clear();
            comboFreeWagons.Items.AddRange(WagonsOnStation.Keys.ToArray());
            onUpdateFreeWagon();
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
        private void refreshTrainBeforeSending()
        {
            if(currentTrain != null) 
            {                 
                currentTrain.Wagons.Clear();
                currentTrain.AddWagons(Wagons.Values);
            }
        }

        private void comboTrains_Click(object sender, EventArgs e)
        {
            refreshTrainBeforeSending();
            regenerateWagons();
            comboWagons.Items.Clear();
            comboWagons.Items.AddRange(Wagons.Keys.ToArray());
        }

        private void buttonClearW_Click(object sender, EventArgs e)
        {
            regenerateWagons();
            CargoWagon cw;
            PassengerWagon pw;
            if (radioWagon.Checked)
            {
                if (comboWagons.Items == null || comboWagons.Items.Count == 0)
                {
                    return;
                }
                if (Wagons[comboWagons.SelectedItem.ToString()].IsPassenger == false)
                {
                    cw = new CargoWagon((CargoWagon)Wagons[comboWagons.SelectedItem.ToString()]);
                    cw.Unload();
                    Wagons[comboWagons.SelectedItem.ToString()] = cw;
                }
                else
                {
                    pw = new PassengerWagon((PassengerWagon)Wagons[comboWagons.SelectedItem.ToString()]);
                    pw.Unload();
                    Wagons[comboWagons.SelectedItem.ToString()] = pw;
                }
                MessageBox.Show(comboWagons.SelectedItem.ToString() + " освобожден.");
            }
            else
            {
                if (comboFreeWagons.Items == null || comboFreeWagons.Items.Count == 0)
                {
                    return;
                }
                if (WagonsOnStation[comboFreeWagons.SelectedItem.ToString()].IsPassenger == false)
                {
                    cw = new CargoWagon((CargoWagon)WagonsOnStation[comboFreeWagons.SelectedItem.ToString()]);
                    cw.Unload();
                    WagonsOnStation[comboFreeWagons.SelectedItem.ToString()] = cw;
                }
                else
                {
                    pw = new PassengerWagon((PassengerWagon)WagonsOnStation[comboFreeWagons.SelectedItem.ToString()]);
                    pw.Unload();
                    WagonsOnStation[comboFreeWagons.SelectedItem.ToString()] = pw;
                }
                MessageBox.Show(comboFreeWagons.SelectedItem.ToString() + " освобожден.");
            }


        }

        private void buttonGetTrain_Click(object sender, EventArgs e)
        {
            connection.TrainArrived(currentTrain);
            //поезд блокируется для изменения
        }

        private void buttonSendTrain_Click(object sender, EventArgs e)
        {
            refreshTrainBeforeSending();
            connection.SendTrain(currentTrain);
            //поезд осовобождается от блокировки
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeNow.Text = TimeOnly.FromDateTime(DateTime.Now).ToLongTimeString();
            time = TimeOnly.FromDateTime(DateTime.Now).ToLongTimeString();
        }



        private void buttonUnlink_Click(object sender, EventArgs e)
        {
            if (comboWagons.Items == null || comboWagons.Items.Count == 0)
            {
                return;
            }
            IWagon crw;
            crw = Wagons[comboWagons.SelectedItem.ToString()];
            Wagons.Remove(comboWagons.SelectedItem.ToString());
            comboWagons.Items.Remove(comboWagons.SelectedItem);

            WagonsOnStation.Add($"Вагон {WagonsOnStation.Count + 1}", crw);
            string myKey = WagonsOnStation.FirstOrDefault(x => x.Value == crw).Key;
            comboFreeWagons.Items.Add(myKey);
            regenerateFreeWagons();
            onUpdateWagon();
            
        }

        private void buttonLink_Click(object sender, EventArgs e)
        {
            if (comboFreeWagons.Items == null || comboFreeWagons.Items.Count == 0)
            {
                return;
            }
            try
            {
                IWagon crw;
                int index;
                crw = WagonsOnStation[comboFreeWagons.SelectedItem.ToString()];
                WagonsOnStation.Remove(comboFreeWagons.SelectedItem.ToString());
                comboFreeWagons.Items.Remove(comboFreeWagons.SelectedItem);

                index = int.Parse(Wagons.Last().Key.Split(" ")[1]) + 1;
                Wagons.Add($"Вагон {index}", crw);
                string myKey = Wagons.FirstOrDefault(x => x.Value == crw).Key;
                comboWagons.Items.Add(myKey);
                regenerateFreeWagons();
                onUpdateWagon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
             
        }

        private void buttonDelW_Click(object sender, EventArgs e)
        {
            if(comboFreeWagons.Items==null || comboFreeWagons.Items.Count == 0)
            {
                return;
            }
            WagonsOnStation.Remove(comboFreeWagons.SelectedItem.ToString());
            comboFreeWagons.Items.Remove(comboFreeWagons.SelectedItem);
            regenerateFreeWagons();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            if (radioInfoWagon.Checked)
            {
                if (comboWagons.Items == null || comboWagons.Items.Count == 0)
                {
                    return;
                }
                textMain.Text += "\n" + Wagons[comboWagons.SelectedItem.ToString()].ToString();
            }
            else
            {
                if (comboFreeWagons.Items == null || comboFreeWagons.Items.Count == 0)
                {
                    return;
                }
                textMain.Text += "\n" + WagonsOnStation[comboFreeWagons.SelectedItem.ToString()].ToString();
            }
        }

        private void buttonClrScr_Click(object sender, EventArgs e)
        {
            textMain.Clear();
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
