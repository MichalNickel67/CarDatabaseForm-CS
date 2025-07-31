using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cars1
{
    public partial class Form1 : Form
    {
        List<CarClass> CarList {  get; set; } = new List <CarClass>();
        private System.Windows.Forms.ComboBox subComboBox;

        public Form1()
        {
            InitializeComponent();
            LogoImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void carTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carDatabaseDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.carTableTableAdapter.Fill(this.carDatabaseDataSet.CarTable);
            DataTable brandTable = this.carDatabaseDataSet.CarTable.DefaultView.ToTable(true, "Brand");
            List<string> brandNames = new List<string>();

            foreach (DataRow row in brandTable.Rows)
            {
                brandNames.Add(row["Brand"].ToString());
            }

            brandNames.Sort();

            foreach (string brandName in brandNames)
            {
                SelectCarBrand.Items.Add(brandName);
            }
        }

        private void AddNewCar_Click(object sender, EventArgs e)
        {
            string fuelType = "";
            if (radioButtonPetrol.Checked)
            {
                fuelType = "Petrol";
            }
            else if (radioButtonDiesel.Checked)
            {
                fuelType = "Diesel";
            }
            else if (radioButtonElectric.Checked)
            {
                fuelType = "Electric";
            }
            else
            {
                MessageBox.Show("Please Select a Fuel Type.", "Fuel Type Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(NewBrandTextBox.Text) || string.IsNullOrWhiteSpace(NewModelTextBox.Text) || string.IsNullOrWhiteSpace(NewYearTextBox.Text) || string.IsNullOrWhiteSpace(NewEngineSizeTextBox.Text))
            {
                MessageBox.Show("Please Fill Out All fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(NewYearTextBox.Text, out int year) || !decimal.TryParse(NewEngineSizeTextBox.Text, out decimal engineSize))
            {
                MessageBox.Show("Invalid Year or Engine Size.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CarClass cc = new CarClass(NewBrandTextBox.Text, NewModelTextBox.Text, year, engineSize, fuelType);
            CarList.Add(cc);

            foreach (CarClass car in CarList)
            {
                this.carTableTableAdapter.InsertNewCar(car.Brand, car.Model, car.Year, car.Enginesize, car.Fueltype);
            }
            this.carTableTableAdapter.Fill(this.carDatabaseDataSet.CarTable);

            NewBrandTextBox.Text = "";
            NewModelTextBox.Text = "";
            NewYearTextBox.Text = "";
            NewEngineSizeTextBox.Text = "";

            radioButtonPetrol.Checked = false;
            radioButtonDiesel.Checked = false;
            radioButtonElectric.Checked = false;

            MessageBox.Show("Car Added To Database Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectCarModel.Items.Clear();
            string selectedBrand = SelectCarBrand.SelectedItem.ToString();
            DataRow[] filteredRows = this.carDatabaseDataSet.CarTable.Select("Brand = '" + selectedBrand + "'");

            foreach (DataRow row in filteredRows)
            {
                SelectCarModel.Items.Add(row["Model"].ToString());
            }
        }

        private void SubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedModel = subComboBox.SelectedItem.ToString();
            MessageBox.Show("Selected Model: " + selectedModel);
        }

        private void SelectCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedModel = SelectCarModel.SelectedItem.ToString();
            DataRow[] selectedCarRows = this.carDatabaseDataSet.CarTable.Select("Model = '" + selectedModel + "'");

            if (selectedCarRows.Length > 0)
            {
                string carID = selectedCarRows[0]["Car ID"].ToString();
                string brand = selectedCarRows[0]["Brand"].ToString();
                string year = selectedCarRows[0]["Year"].ToString();
                decimal engineSize = Convert.ToDecimal(selectedCarRows[0]["Engine Size"]);
                string fuelType = selectedCarRows[0]["Fuel Type"].ToString();

                string searchCriteria = brand.ToLower();
                Image brandLogo = null;

                switch (searchCriteria)
                {
                    case "abarth":
                        LogoImage.Image = Properties.Images.AbarthLogo;
                        break;
                    case "acura":
                        LogoImage.Image = Properties.Images.AcuraLogo;
                        break;
                    case "alfa romeo":
                        LogoImage.Image = Properties.Images.AlfaRomeoLogo;
                        break;
                    case "aston martin":
                        LogoImage.Image = Properties.Images.AstonMartinLogo;
                        break;
                    case "audi":
                        LogoImage.Image = Properties.Images.AudiLogo;
                        break;
                    case "alpine":
                        LogoImage.Image = Properties.Images.AlpineLogo;
                        break;
                    case "bentley":
                        LogoImage.Image = Properties.Images.BentleyLogo;
                        break;
                    case "bmw":
                        LogoImage.Image = Properties.Images.BMWLogo;
                        break;
                    case "bugatti":
                        LogoImage.Image = Properties.Images.BugattiLogo;
                        break;
                    case "buick":
                        LogoImage.Image = Properties.Images.BuickLogo;
                        break;
                    case "cadillac":
                        LogoImage.Image = Properties.Images.CadillacLogo;
                        break;
                    case "chevrolet":
                        LogoImage.Image = Properties.Images.ChevroletLogo;
                        break;
                    case "dodge":
                        LogoImage.Image = Properties.Images.DodgeLogo;
                        break;
                    case "ferrari":
                        LogoImage.Image = Properties.Images.FerrariLogo;
                        break;
                    case "fiat":
                        LogoImage.Image = Properties.Images.FiatLogo;
                        break;
                    case "ford":
                        LogoImage.Image = Properties.Images.FordLogo;
                        break;
                    case "honda":
                        LogoImage.Image = Properties.Images.HondaLogo;
                        break;
                    case "hyundai":
                        LogoImage.Image = Properties.Images.HyundaiLogo;
                        break;
                    case "jaguar":
                        LogoImage.Image = Properties.Images.JaguarLogo;
                        break;
                    case "jeep":
                        LogoImage.Image = Properties.Images.JeepLogo;
                        break;
                    case "lamborghini":
                        LogoImage.Image = Properties.Images.LamborghiniLogo;
                        break;
                    case "land rover":
                        LogoImage.Image = Properties.Images.LandRoverLogo;
                        break;
                    case "lexus":
                        LogoImage.Image = Properties.Images.LexusLogo;
                        break;
                    case "maserati":
                        LogoImage.Image = Properties.Images.MaseratiLogo;
                        break;
                    case "mazda":
                        LogoImage.Image = Properties.Images.MazdaLogo;
                        break;
                    case "mercedes":
                        LogoImage.Image = Properties.Images.MercedesLogo;
                        break;
                    case "mini":
                        LogoImage.Image = Properties.Images.MiniLogo;
                        break;
                    case "mitsubishi":
                        LogoImage.Image = Properties.Images.MitsubishiLogo;
                        break;
                    case "nissan":
                        LogoImage.Image = Properties.Images.NissanLogo;
                        break;
                    case "subaru":
                        LogoImage.Image = Properties.Images.SubaruLogo;
                        break;
                    case "toyota":
                        LogoImage.Image = Properties.Images.ToyotaLogo;
                        break;
                    case "volkswagen":
                        LogoImage.Image = Properties.Images.VWLogo;
                        break;
                    case "volvo":
                        LogoImage.Image = Properties.Images.VolvoLogo;
                        break;
                    default:
                        LogoImage.Image = null;
                        break;
                }

                string brandLogoText = (brandLogo != null) ? "[Brand Logo]" : "";

                string message = $"Selected Car Information:\n\n" +
                                 $"Car ID: {carID}\n" +
                                 $"Brand: {brand}\n" +
                                 $"Model: {selectedModel}\n" +
                                 $"Year: {year}\n" +
                                 $"Engine Size: {engineSize}\n" + 
                                 $"Fuel Type: {fuelType}";

                MessageBox.Show(message, "Car Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogoImage.Image = brandLogo;
            }
            else
            {
                MessageBox.Show("Selected Car Information Is Not Available.", "Information Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            string searchCriteria = TextSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchCriteria))
            {
                DataView dv = new DataView(this.carDatabaseDataSet.CarTable);
                dv.RowFilter = $"Brand LIKE '%{searchCriteria}%' OR " +
                               $"Model LIKE '%{searchCriteria}%' OR " +
                               $"CONVERT([Year], 'System.String') LIKE '%{searchCriteria}%' OR " +
                               $"CONVERT([Engine Size], 'System.String') LIKE '%{searchCriteria}%' OR " +
                               $"[Fuel Type] = '{searchCriteria}'";

                if (searchCriteria.Equals("Abarth", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.AbarthLogo;
                }
                else if (searchCriteria.Equals("Acura", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.AcuraLogo;
                }
                else if (searchCriteria.Equals("Alfa Romeo", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.AlfaRomeoLogo;
                }
                else if (searchCriteria.Equals("Aston Martin", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.AstonMartinLogo;
                }
                else if (searchCriteria.Equals("Audi", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.AudiLogo;
                }
                else if (searchCriteria.Equals("Bentley", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.BentleyLogo;
                }
                else if (searchCriteria.Equals("BMW", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.BMWLogo;
                }
                else if (searchCriteria.Equals("Bugatti", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.BugattiLogo;
                }
                else if (searchCriteria.Equals("Buick", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.BuickLogo;
                }
                else if (searchCriteria.Equals("Cadillac", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.CadillacLogo;
                }
                else if (searchCriteria.Equals("Chevrolet", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.ChevroletLogo;
                }
                else if (searchCriteria.Equals("Dodge", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.DodgeLogo;
                }
                else if (searchCriteria.Equals("Ferrari", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.FerrariLogo;
                }
                else if (searchCriteria.Equals("Fiat", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.FiatLogo;
                }
                else if (searchCriteria.Equals("Ford", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.FordLogo;
                }
                else if (searchCriteria.Equals("Honda", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.HondaLogo;
                }
                else if (searchCriteria.Equals("Hyundai", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.HyundaiLogo;
                }
                else if (searchCriteria.Equals("Jaguar", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.JaguarLogo;
                }
                else if (searchCriteria.Equals("Jeep", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.JeepLogo;
                }
                else if (searchCriteria.Equals("Koenigsegg", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.KoenigseggLogo;
                }
                else if (searchCriteria.Equals("Lamborghini", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.LamborghiniLogo;
                }
                else if (searchCriteria.Equals("Lancia", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.LanciaLogo;
                }
                else if (searchCriteria.Equals("Land Rover", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.LandRoverLogo;
                }
                else if (searchCriteria.Equals("Lexus", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.LexusLogo;
                }
                else if (searchCriteria.Equals("Lotus", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.LotusLogo;
                }
                else if (searchCriteria.Equals("Maserati", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.MaseratiLogo;
                }
                else if (searchCriteria.Equals("Mazda", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.MazdaLogo;
                }
                else if (searchCriteria.Equals("McLaren", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.McLarenLogo;
                }
                else if (searchCriteria.Equals("Mercedes", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.MercedesLogo;
                }
                else if (searchCriteria.Equals("MG", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.MGLogo;
                }
                else if (searchCriteria.Equals("Mini", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.MiniLogo;
                }
                else if (searchCriteria.Equals("Mitsubishi", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.MitsubishiLogo;
                }
                else if (searchCriteria.Equals("Morgan", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.MorganLogo;
                }
                else if (searchCriteria.Equals("NIO", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.NIOLogo;
                }
                else if (searchCriteria.Equals("Nissan", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.NissanLogo;
                }
                else if (searchCriteria.Equals("Pagani", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.PaganiLogo;
                }
                else if (searchCriteria.Equals("Peel", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.PeelLogo;
                }
                else if (searchCriteria.Equals("Plymouth", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.PlymouthLogo;
                }
                else if (searchCriteria.Equals("Peugeot", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.PeugeotLogo;
                }
                else if (searchCriteria.Equals("Pontiac", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.PontiacLogo;
                }
                else if (searchCriteria.Equals("Renault", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.RenaultLogo;
                }
                else if (searchCriteria.Equals("Rimac", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.RimacLogo;
                }
                else if (searchCriteria.Equals("Seat", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.SeatLogo;
                }
                else if (searchCriteria.Equals("Skoda", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.SkodaLogo;
                }
                else if (searchCriteria.Equals("Subaru", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.SubaruLogo;
                }
                else if (searchCriteria.Equals("Toyota", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.ToyotaLogo;
                }
                else if (searchCriteria.Equals("Vauxhall", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.VauxhallLogo;
                }
                else if (searchCriteria.Equals("Volvo", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.VolvoLogo;
                }
                else if (searchCriteria.Equals("Volkswagen", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.VWLogo;
                }
                else if (searchCriteria.Equals("Petrol", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.Petrol;
                }
                else if (searchCriteria.Equals("Diesel", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.Diesel;
                }
                else if (searchCriteria.Equals("Electric", StringComparison.OrdinalIgnoreCase))
                {
                    LogoImage.Image = Properties.Images.Electric;
                }
                else
                {
                    LogoImage.Image = null;
                }

                CarTableDataGridView.DataSource = dv;
            }
            else
            {
                LogoImage.Image = null;
                CarTableDataGridView.DataSource = this.carDatabaseDataSet.CarTable;
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();

            registerForm.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogoImage_Click(object sender, EventArgs e)
        {
            LogoImage.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
