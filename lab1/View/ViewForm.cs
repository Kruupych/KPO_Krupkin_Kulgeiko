using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using RailwayTransport.Controller;
using RailwayTransport.View;
using Serilog;
using Log = Serilog.Log;

namespace RailwayTransport.View
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }
        Dictionary<string, Train> trains = new Dictionary<string, Train>();
        Dictionary<string, Depo> depoes = new Dictionary<string, Depo>();

        int countTrains = 0, countDepoes = 0;
        private void buttonAddTrain_Click(object sender, EventArgs e)
        {
            try
            {
                var train0 = TrainCreator.CreateTrain(wagonsCount: int.Parse(text_wagon.Text));

                string name = "Поезд: " + (++countTrains);
                trains.Add(name, train0);
                comboTrains.Items.Add(name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddDepo_Click(object sender, EventArgs e)
        {
            try
            {
                Depo depo = new Depo(int.Parse(text_train.Text));

                string name = "Депо: " + (++countDepoes);
                depoes.Add(name, depo);
                comboDepoes.Items.Add(name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboTrains.Items.Count == 0 || comboDepoes.Items.Count == 0)
                {
                    throw new ArgumentException(nameof(comboDepoes), "Нет поездов или депо");
                }
                if (comboTrains.SelectedItem == null || comboDepoes.SelectedItem == null)
                {
                    throw new ArgumentNullException(nameof(comboDepoes), "Не выбран поезд или депо");
                }
                if (depoes[comboDepoes.SelectedItem.ToString()].Trains.Contains(trains[comboTrains.SelectedItem.ToString()]))
                {
                    throw new ArgumentException(nameof(comboDepoes), "Этот поезд уже есть в депо");
                }
                depoes[comboDepoes.SelectedItem.ToString()].AddTrain(trains[comboTrains.SelectedItem.ToString()]);
            }
            catch (Exception ex)
            {
                Log.Information("\n" + this.buttonAddToDepo.Text + " Ошибка: " + ex.Message );
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboTrains.Items.Count == 0 || comboDepoes.Items.Count == 0)
                {
                    throw new ArgumentException(nameof(comboDepoes));
                }
                if (comboTrains.SelectedItem == null || comboDepoes.SelectedItem == null)
                {
                    throw new ArgumentNullException(nameof(comboDepoes));
                }
                depoes[comboDepoes.SelectedItem.ToString()].RemoveTrain(trains[comboTrains.SelectedItem.ToString()]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCleanScr_Click(object sender, EventArgs e)
        {
            richTextView.Clear();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboTrains.Items.Count == 0 || comboDepoes.Items.Count == 0)
                {
                    throw new ArgumentException(nameof(comboDepoes));
                }
                if (comboTrains.SelectedItem == null || comboDepoes.SelectedItem == null)
                {
                    throw new ArgumentNullException(nameof(comboDepoes));
                }
                switch (comboSortType.SelectedIndex)
                {
                    case 0:
                        richTextView.AppendText("\n\t---До сортировки:---\n");
                        TrainInfoView.ShowDepoInfoWF(depoes[comboDepoes.SelectedItem.ToString()], this.richTextView);
                        break;
                    case 1:
                        richTextView.AppendText("\n\n\t---Сортировка по длине:---\n");
                        TrainInfoView.ShowDepoInfoWF(depoes[comboDepoes.SelectedItem.ToString()].SortByLength(), this.richTextView);
                        break;
                    case 2:
                        richTextView.AppendText("\n\n\t---Сортировка по весу:---\n");
                        TrainInfoView.ShowDepoInfoWF(depoes[comboDepoes.SelectedItem.ToString()].SortByWeight(), this.richTextView);
                        break;
                    case 3:
                        richTextView.AppendText("\n\n\t---Сортировка по скорости:---\n");
                        TrainInfoView.ShowDepoInfoWF(depoes[comboDepoes.SelectedItem.ToString()].SortBySpeed(), this.richTextView);
                        break;
                    default:
                        richTextView.AppendText("\n\tСпособ не выбран\n");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelDepo_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboDepoes.Items.Count == 0)
                {
                    throw new ArgumentException(nameof(comboDepoes));
                }
                if (comboDepoes.SelectedItem == null)
                {
                    throw new ArgumentNullException(nameof(comboDepoes));
                }
                depoes.Remove(comboDepoes.SelectedItem.ToString());
                comboDepoes.Items.RemoveAt(comboDepoes.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelTrain_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboTrains.Items.Count == 0)
                {
                    throw new ArgumentException(nameof(comboTrains));
                }
                if (comboTrains.SelectedItem == null)
                {
                    throw new ArgumentNullException(nameof(comboTrains));
                }
                trains.Remove(comboTrains.SelectedItem.ToString());
                comboTrains.Items.RemoveAt(comboTrains.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<Train> listForView=new List<Train>();
                if (comboTrains.Items.Count == 0 || comboDepoes.Items.Count == 0)
                {
                    throw new ArgumentException(nameof(comboDepoes));
                }
                if (comboTrains.SelectedItem == null || comboDepoes.SelectedItem == null)
                {
                    throw new ArgumentNullException(nameof(comboDepoes));
                }
                switch (comboSearchType.SelectedIndex)
                {
                    case 0:
                        richTextView.AppendText("\n\t---Самый длинный:---\n");
                        TrainInfoView.ShowTrainInfoWF(depoes[comboDepoes.SelectedItem.ToString()].FindTrainByLength(false), this.richTextView);
                        break;
                    case 1:
                        richTextView.AppendText("\n\n\t---Самый короткий:---\n");
                        TrainInfoView.ShowTrainInfoWF(depoes[comboDepoes.SelectedItem.ToString()].FindTrainByLength(true), this.richTextView);
                        break;
                    case 2:
                        richTextView.AppendText("\n\n\t---Самый тяжелый:---\n");
                        TrainInfoView.ShowTrainInfoWF(depoes[comboDepoes.SelectedItem.ToString()].FindTrainByWeight(false), this.richTextView);
                        break;
                    case 3:
                        richTextView.AppendText("\n\n\t---Самый легкий:---\n");
                        TrainInfoView.ShowTrainInfoWF(depoes[comboDepoes.SelectedItem.ToString()].FindTrainByWeight(true), this.richTextView);
                        break;
                    case 4:
                        richTextView.AppendText("\n\n\t---Самый быстрый:---\n");
                        TrainInfoView.ShowTrainInfoWF(depoes[comboDepoes.SelectedItem.ToString()].FindTrainBySpeed(false), this.richTextView);
                        break;
                    case 5:
                        richTextView.AppendText("\n\n\t---Самый медленный:---\n");
                        TrainInfoView.ShowTrainInfoWF(depoes[comboDepoes.SelectedItem.ToString()].FindTrainBySpeed(true), this.richTextView);
                        break;
                    case 6:
                        richTextView.AppendText("\n\n\t---Длиннее чем:---\n");                        
                        listForView.AddRange(depoes[comboDepoes.SelectedItem.ToString()].FindTrainByLength(true, int.Parse(textSearchValue.Text)));
                        foreach (Train train in listForView)
                        {
                            TrainInfoView.ShowTrainInfoWF(train, this.richTextView);
                        }
                        break;
                    case 7:
                        richTextView.AppendText("\n\n\t---Короче чем:---\n");                       
                        listForView.AddRange(depoes[comboDepoes.SelectedItem.ToString()].FindTrainByLength(false, int.Parse(textSearchValue.Text)));
                        foreach (Train train in listForView)
                        {
                            TrainInfoView.ShowTrainInfoWF(train, this.richTextView);
                        }
                        break;
                    case 8:
                        richTextView.AppendText("\n\n\t---Тяжелее чем:---\n");
                        listForView.AddRange(depoes[comboDepoes.SelectedItem.ToString()].FindTrainByWeight(true, int.Parse(textSearchValue.Text)));
                        foreach (Train train in listForView)
                        {
                            TrainInfoView.ShowTrainInfoWF(train, this.richTextView);
                        }
                        break;
                    case 9:
                        richTextView.AppendText("\n\n\t---Легче чем:---\n");
                        listForView.AddRange(depoes[comboDepoes.SelectedItem.ToString()].FindTrainByWeight(false, int.Parse(textSearchValue.Text)));
                        foreach (Train train in listForView)
                        {
                            TrainInfoView.ShowTrainInfoWF(train, this.richTextView);
                        }
                        break;
                    case 10:
                        richTextView.AppendText("\n\n\t---Быстрее чем:---\n");
                        listForView.AddRange(depoes[comboDepoes.SelectedItem.ToString()].FindTrainBySpeed(true, int.Parse(textSearchValue.Text)));
                        foreach (Train train in listForView)
                        {
                            TrainInfoView.ShowTrainInfoWF(train, this.richTextView);
                        }
                        break;
                    case 11:
                        richTextView.AppendText("\n\n\t---Медленнее чем:---\n");
                        listForView.AddRange(depoes[comboDepoes.SelectedItem.ToString()].FindTrainBySpeed(false, int.Parse(textSearchValue.Text)));
                        foreach (Train train in listForView)
                        {
                            TrainInfoView.ShowTrainInfoWF(train, this.richTextView);
                        }
                        break;
                    case 12:
                        richTextView.AppendText("\n\n\t---Поиск поезда:---\n");
                        listForView.AddRange(depoes[comboDepoes.SelectedItem.ToString()].FindAll(p => p == trains[comboTrains.SelectedItem.ToString()]));
                        foreach (Train train in listForView)
                        {
                            TrainInfoView.ShowTrainInfoWF(train, this.richTextView);
                        }
                        break;
                    default:
                        richTextView.AppendText("\n\tСпособ не выбран\n");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
