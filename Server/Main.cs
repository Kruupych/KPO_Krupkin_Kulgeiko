using MaterialSkin;
using MaterialSkin.Controls;
using RailwayTransport;
using RailwayTransport.Controller;
using RailwayTransport.Model.Wagons;
using RailwayTransport.Model;
using RailwayTransport.View;
using System.Collections.Concurrent;
using System.Diagnostics;
using RailwayTransport.Controller.Network;

namespace Server
{
    public partial class Main : MaterialForm
    {
        private MaterialSkinManager _skinManager;
        private List<Train> _trainsInPath;
        private Dictionary<string, Train> _trainsAtStations;
        private Depo _depo;
        private DepoServer _depoServer;
        private Dictionary<string, string> _clientsAuthData;
        private DepoController _depoController;

        protected override bool ScaleChildren => false;

        public Main()
        {
            InitializeComponent();
            InitMaterialSkin();
            InitCargoTypeComboBox();

            _clientsAuthData = new() { { "minsk", "123" }, { "gomel", "234" }, { "bobruisk", "345" } };

            _depoController = new DepoController();
            _depo = _depoController.CreateDepo(100);

            _trainsInPath = new List<Train>();

            _trainsAtStations = new Dictionary<string, Train>();
            lvTrainsOutOfDepo.Groups.Add("path", "В пути");

            foreach (var station in _clientsAuthData)
            {
                _trainsAtStations.Add(station.Key, null);
                lvTrainsOutOfDepo.Groups.Add(station.Key, "ст. " + station.Key.Substring(0, 1).ToUpper() + station.Key.Substring(1, station.Key.Length - 1));
            }

            lbTrainsInDepo.Items.Clear();
            lvTrainsOutOfDepo.Items.Clear();

            _depoServer = new DepoServer();
            _depoServer.OnMessageRecieved += _depoServer_OnMessageRecieved;
            _depoServer.Start();
        }

        private void _depoServer_OnMessageRecieved(object sender, DepoMessageEventArgs e)
        {
            if (e.Message.StartsWith(Commands.TRAIN_IN))
            {
                string msgWithoutCommand = e.Message.Substring(Commands.TRAIN_IN.Length);
                var parts = msgWithoutCommand.Split(';');
                string station = parts[0];
                string trainName = parts[1];

                var train = _trainsInPath.FirstOrDefault((tr) => tr.Name == trainName);
                _trainsInPath.Remove(train);
                _trainsAtStations[station] = train;

                lvTrainsOutOfDepo.Items[train.Name].Group = lvTrainsOutOfDepo.Groups[station];
                lvTrainsOutOfDepo.Update();

                LogEvent($"Поезд \"{trainName}\" прибыл на станцию {station}");
                _depoServer.BroadcastTrains(_trainsInPath);
            }
            else if (e.Message.StartsWith(Commands.TRAIN_OUT))
            {
                string msgWithoutCommand = e.Message.Substring(Commands.TRAIN_OUT.Length);
                var parts = msgWithoutCommand.Split(';');
                string station = parts[0];
                string trainJson = parts[1];
                Train train = RailwaySerializer.DeserializeTrain(trainJson);

                _trainsAtStations[station] = null;
                _trainsInPath.Add(train);
                lvTrainsOutOfDepo.Items[train.Name].Group = lvTrainsOutOfDepo.Groups["path"];
                lvTrainsOutOfDepo.Update();

                LogEvent($"Поезд \"{train.Name}\" убыл из станции {station}");
                _depoServer.BroadcastTrains(_trainsInPath);
            }
            else if (e.Message.StartsWith(Commands.AUTH_REQUEST))
            {
                string msgWithoutCommand = e.Message.Substring(Commands.AUTH_REQUEST.Length);
                var parts = msgWithoutCommand.Split(';');

                string station = parts[0];
                string password = parts[1];

                LogEvent($"Запрос на вход: {station} - {password}");

                if (!_clientsAuthData.ContainsKey(station))
                {
                    _depoServer.SendAuthAnswer(false, e.Client);
                    return;
                }

                _depoServer.SendAuthAnswer(_clientsAuthData[station] == password, e.Client);
            }
            else if (e.Message.StartsWith(Commands.GET_AVAILABLE_TRAINS))
            {
                _depoServer.SendTrains(_trainsInPath, e.Client);   
            }
        }

        private void LogEvent(string message)
        {
            tbLogs.Text += $"\r\n[{DateTime.Now}] {message}";
        }

        private void InitMaterialSkin()
        {
            _skinManager = MaterialSkinManager.Instance;
            _skinManager.AddFormToManage(this);
            _skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void InitCargoTypeComboBox()
        {
            foreach (var item in Enum.GetValues<CargoWagon.Resource>())
            {
                cbCargoType.Items.Add(item.GetDescription());
            }

            cbCargoType.SelectedIndex = 0;
        }

        private void btAddTrain_Click(object sender, EventArgs e)
        {
            cardTrainConstruction.Visible = true;
        }

        private void btCreateTrain_Click(object sender, EventArgs e)
        {
            string name;
            double power;
            int wagonsAmount, loadPercentage;

            try
            {
                name = tbTrainName.Text;

                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception();
                }

                power = double.Parse(tbTrainPower.Text);
                wagonsAmount = int.Parse(tbWagonsCount.Text);
                loadPercentage = sliderWagonsFillness.Value;
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show("Ошибка ввода");
                return;
            }

            bool isPassenger = switchIsPassengerTrain.Checked;

            Train train;

            if (isPassenger)
            {
                train = _depoController.CreateTrain(name, wagonsAmount, power, loadPercentage);
            }
            else
            {
                CargoWagon.Resource resource = (CargoWagon.Resource)cbCargoType.SelectedIndex;

                train = _depoController.CreateTrain(name, wagonsAmount, power, loadPercentage, resource);
            }

            _depo.AddTrain(train);
            lbTrainsInDepo.AddItem(train.Name);
            cardTrainConstruction.Visible = false;

            switchIsPassengerTrain.Checked = false;
            tbTrainPower.Clear();
            tbWagonsCount.Clear();
            sliderWagonsFillness.Value = 50;
            tbTrainName.Clear();
        }

        private void switchRandomConstructor_CheckedChanged(object sender, EventArgs e)
        {
            btGenerateTrainParams.Enabled = switchRandomConstructor.Checked;
        }

        private void btGenerateTrainParams_Click(object sender, EventArgs e)
        {
            var randomTrain = _depoController.CreateTrain();

            bool isPassenger = switchIsPassengerTrain.Checked = randomTrain.GetWagonByIndex(0).IsPassenger;
            tbWagonsCount.Text = randomTrain.Wagons.Count.ToString();

            if (!isPassenger)
            {
                cbCargoType.SelectedIndex = (int)(((CargoWagon)(randomTrain.GetWagonByIndex(0))).ResourceType);
            }

            sliderWagonsFillness.Value = randomTrain.GetWagonByIndex(0).LoadPercentage;

            tbTrainPower.Text = randomTrain.Locomotive.Power.ToString();
        }

        private void switchIsPassengerTrain_CheckedChanged(object sender, EventArgs e)
        {
            cbCargoType.Enabled = !switchIsPassengerTrain.Checked;
        }

        private void lbTrainsInDepo_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            btSendTrain.Enabled = btDeleteTrain.Enabled = true;
            ShowTrainInfo(tbConstructPanelTrainInfo, _depo[lbTrainsInDepo.SelectedIndex]);
        }

        private void ShowTrainInfo(MaterialMultiLineTextBox2 textBox, Train train)
        {
            textBox.Clear();
            textBox.Text = TrainInfoView.GetTrainInfo(train);
        }

        private void btDeleteTrain_Click(object sender, EventArgs e)
        {
            RemoveTrainFromDepo(lbTrainsInDepo.SelectedIndex);
        }

        private void btSendTrain_Click(object sender, EventArgs e)
        {
            _trainsInPath.Add(_depo[lbTrainsInDepo.SelectedIndex]);
            lvTrainsOutOfDepo.Items.Add(new ListViewItem(_depo[lbTrainsInDepo.SelectedIndex].Name, _depo[lbTrainsInDepo.SelectedIndex].Name, lvTrainsOutOfDepo.Groups["path"]));
            LogEvent($"Поезд \"{_depo[lbTrainsInDepo.SelectedIndex].Name}\" убыл с депо");
            RemoveTrainFromDepo(lbTrainsInDepo.SelectedIndex);
            _depoServer.BroadcastTrains(_trainsInPath);
        }

        private void RemoveTrainFromDepo(int index)
        {
            _depo.Trains.Remove(_depo[index]);
            lbTrainsInDepo.Items.Remove(lbTrainsInDepo.Items[index]);
            tbConstructPanelTrainInfo.Clear();
            btSendTrain.Enabled = btDeleteTrain.Enabled = false;
        }

        private void lvTrainsOutOfDepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("indexCanged");
            if (lvTrainsOutOfDepo.SelectedItems.Count == 0)
            {
                return;
            }

            Debug.WriteLine("index: " + lvTrainsOutOfDepo.SelectedItems[0].Index);

            Train trainToShow;

            if (lvTrainsOutOfDepo.SelectedItems[0].Group.Name == "path")
            {
                trainToShow = _trainsInPath.FirstOrDefault((train) => train.Name == lvTrainsOutOfDepo.SelectedItems[0].Text);
            }
            else
            {
                trainToShow = _trainsAtStations[lvTrainsOutOfDepo.SelectedItems[0].Group.Name];
            }

            ShowTrainInfo(tbMainPanelTrainInfo, trainToShow);
        }
    }
}