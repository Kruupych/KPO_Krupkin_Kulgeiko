using RailwayTransport;
using RailwayTransport.Controller.Factories;
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
    public partial class Form3 : Form
    {
        private IWagon currentWagon;
        public Form3(IWagon wagon)
        {
            InitializeComponent();
            currentWagon = wagon;
        }
        public Form3()
        {
            InitializeComponent();

        }
        public IWagon getCurrentWagon()
        {
            return currentWagon;
        }
        private void buttonCreateWagon_Click(object sender, EventArgs e)
        {
            RandomWagonFactory rwf = new RandomWagonFactory();
            if (radioPas.Checked)
            {
                currentWagon = rwf.CreatePassengerWagon();
            }
            else
            {
                currentWagon = rwf.CreateCargoWagon();
            }
        }

        private void buttonLoadWagon_Click(object sender, EventArgs e)
        {
            CargoWagon cw;
            PassengerWagon pw;
            if (currentWagon.IsPassenger == false)
            {
                cw = (CargoWagon)currentWagon;
                CargoWagon.Resource resource;
                switch (comboResourceType.SelectedIndex)
                {
                    case 0:
                        resource = CargoWagon.Resource.Nothing;
                        break;
                    case 1:
                        resource = CargoWagon.Resource.Coal;
                        break;
                    case 2:
                        resource = CargoWagon.Resource.Wood;
                        break;
                    case 3:
                        resource = CargoWagon.Resource.AgroCombine;
                        break;
                    case 4:
                        resource = CargoWagon.Resource.Fuel;
                        break;
                    case 5:
                        resource = CargoWagon.Resource.Animals;
                        break;                   
                    default:
                        resource = CargoWagon.Resource.Nothing;
                        break;
                }
                cw.Load(resource,trackCarPer.Value);
                currentWagon = cw;
            }
            else
            {
                pw = (PassengerWagon)currentWagon;
                pw.Load(trackCarPer.Value);
                currentWagon = pw;
            }
            this.Close();
        }

        private void trackCarPer_Scroll(object sender, EventArgs e)
        {
            percentLoad.Text=trackCarPer.Value.ToString();
        }
    }
}
