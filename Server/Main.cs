using MaterialSkin;
using MaterialSkin.Controls;
using RailwayTransport;
using RailwayTransport.Controller;
using RailwayTransport.Model.Wagons;
using RailwayTransport.Model;
using RailwayTransport.View;
using System.Collections.Concurrent;

namespace Server
{
    public partial class Main : MaterialForm
    {
        private MaterialSkinManager _skinManager;
        private ConcurrentDictionary<string, Train> _trainsOutOfDepo;
        private Depo _depo;
        private DepoController _depoController;

        protected override bool ScaleChildren => false;

        public Main()
        {
            InitializeComponent();
            InitMaterialSkin();
            InitCargoTypeComboBox();

            _depoController = new DepoController();
            _depo = _depoController.CreateDepo(100);

            _trainsOutOfDepo = new ConcurrentDictionary<string, Train>();

            lbTrainsInDepo.Items.Clear();
            lvTrainsOutOfDepo.Items.Clear();
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



            cardTrainConstruction.Visible = false;
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
    }
}