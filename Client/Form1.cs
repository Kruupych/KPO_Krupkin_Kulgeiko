using System.Configuration;
using System.Management;
using RailwayTransport;
using RailwayTransport.Controller.Network;
namespace Client
{
    public partial class Form1 : Form
    {
        public string mode;
        public string time;
        public Dictionary<string, Train> Trains;
        public Dictionary<string, IWagon> Wagons;
        public Dictionary<string, IWagon> WagonsOnStation;
        bool isArrived;
        Train currentTrain;
        StationClient client;
        public Form1()
        {
            InitializeComponent();
            client = new StationClient("195.2.80.2");
            Form2 authorization = new Form2(client);
            mode = "null";
            authorization.ShowDialog(this);
            client.OnAvailableTrainsUpdated += Client_OnAvailableTrainsUpdated;
            timer2.Start();
            Trains = new Dictionary<string, Train>();
            Wagons = new Dictionary<string, IWagon>();
            WagonsOnStation = new Dictionary<string, IWagon>();
            client.RequestAvailableTrains();
            radioWagon.Checked = true;
            radioInfoWagon.Checked = true;
            isArrived = false;
        }

        private void Client_OnAvailableTrainsUpdated(object sender, AvailableTrainsUpdateEventArgs e)
        {

            regenerateTrains(e.Trains);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "null":
                    {
                        this.Close();
                        return;
                    }
                default:
                    {
                        this.labelName.Text = mode;
                        break;
                    }
            }
        }


        private void onUpdateFreeWagon()
        {
            if (comboFreeWagons.Items != null && comboFreeWagons.Items.Count != 0)
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
                    if (comboWagons.Items == null || comboWagons.Items.Count == 0 || !isArrived)
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
                WagonsOnStation.Add($"����� {WagonsOnStation.Count + 1}", wagon);
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
            currentTrain = Trains[comboTrains.SelectedItem.ToString()];
            List<IWagon> updatedWagons = new List<IWagon>();
            updatedWagons.AddRange(currentTrain.Wagons);
            int i = 1;
            for (; i <= updatedWagons.Count; i++)
            {
                Wagons.Add("����� " + i, updatedWagons[i - 1]);
            }
        }
        private void regenerateFreeWagons()
        {
            comboFreeWagons.Items.Clear();
            comboFreeWagons.Items.AddRange(WagonsOnStation.Keys.ToArray());
            onUpdateFreeWagon();
        }
        private void regenerateTrains(List<Train> updatedTrains)
        {
            Trains.Clear();
            int trainCount = updatedTrains.Count;
            for (int i = 1; i <= trainCount; i++)
            {
                Trains.Add(updatedTrains[i - 1].Name, updatedTrains[i - 1]);   //�������� ����� �������

            }
            comboTrains.Invoke(() =>
            {
                comboTrains.Items.Clear();
                comboTrains.Items.AddRange(Trains.Keys.ToArray());
            });

        }
        private void refreshTrainBeforeSending()
        {
            if (currentTrain != null)
            {
                currentTrain.Wagons.Clear();
                currentTrain.AddWagons(Wagons.Values);
            }
        }

        private void comboTrains_Click(object sender, EventArgs e)
        {
            refreshTrainBeforeSending();//�������� ��� �������
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
                if (comboWagons.Items == null || comboWagons.Items.Count == 0 || !isArrived)
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
                MessageBox.Show(comboWagons.SelectedItem.ToString() + " ����������.");
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
                MessageBox.Show(comboFreeWagons.SelectedItem.ToString() + " ����������.");
            }


        }

        private void buttonGetTrain_Click(object sender, EventArgs e)
        {
            isArrived = true;
            client.TrainArrived(currentTrain);
            labelTrainOnStationADD.Visible = true;
            labelTrainName.Text = currentTrain.Name;
            //��������� ����������� ��������� ������
            //����� ����������� ��� ���������
        }

        private void buttonSendTrain_Click(object sender, EventArgs e)
        {
            refreshTrainBeforeSending();
            client.TrainDeparted(currentTrain);
            isArrived = false;
            labelTrainOnStationADD.Visible = false;
            labelTrainName.Text = "";
            //����� �������������� �� ����������
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeNow.Text = TimeOnly.FromDateTime(DateTime.Now).ToLongTimeString();
            time = TimeOnly.FromDateTime(DateTime.Now).ToLongTimeString();
        }



        private void buttonUnlink_Click(object sender, EventArgs e)
        {
            if (comboWagons.Items == null || comboWagons.Items.Count == 0 || !isArrived)
            {
                return;
            }
            IWagon crw;
            crw = Wagons[comboWagons.SelectedItem.ToString()];
            Wagons.Remove(comboWagons.SelectedItem.ToString());
            comboWagons.Items.Remove(comboWagons.SelectedItem);

            WagonsOnStation.Add($"����� {WagonsOnStation.Count + 1}", crw);
            string myKey = WagonsOnStation.FirstOrDefault(x => x.Value == crw).Key;
            comboFreeWagons.Items.Add(myKey);
            regenerateFreeWagons();
            onUpdateWagon();

        }

        private void buttonLink_Click(object sender, EventArgs e)
        {
            if (comboFreeWagons.Items == null || comboFreeWagons.Items.Count == 0 || !isArrived)
            {
                return;
            }
            try
            {
                IWagon crw;
                int index;
                crw = WagonsOnStation[comboFreeWagons.SelectedItem.ToString()];
                WagonsOnStation.Remove(comboFreeWagons.SelectedItem.ToString());  //��������� ��� ������� ������������� ������
                comboFreeWagons.Items.Remove(comboFreeWagons.SelectedItem);

                index = int.Parse(Wagons.Last().Key.Split(" ")[1]) + 1;
                Wagons.Add($"����� {index}", crw);
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
            if (comboFreeWagons.Items == null || comboFreeWagons.Items.Count == 0)
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
                if (comboWagons.Items == null || comboWagons.Items.Count == 0 || !isArrived)
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string processName = "Client.exe";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Process WHERE Name='" + processName + "'");
            ManagementObjectCollection processList = searcher.Get();

            // �������� �� ������ ��������� � ��������� ��
            foreach (ManagementObject obj in processList)
            {
                obj.InvokeMethod("Terminate", null);
            }
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
