using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EditCarForm : Form
    {
        private List<Car> cars; // Список машин

        public EditCarForm(List<Car> cars)
        {
            InitializeComponent();
            this.cars = cars; // Сохраняем список машин
        }

        private void EditCarForm_Load(object sender, EventArgs e)
        {
            LoadCarsToComboBox();
        }

        private void LoadCarsToComboBox()
        {
            comboBoxCar.Items.Clear();
            foreach (var car in cars)
            {
                string condition = car.NewOrUsed == 1 ? "Новая" : "Б/у";
                string displayText = $"Car #{car.CarNumber} - {car.Brand}, {car.Country}, {car.Year}, {condition}, {car.Price} руб., {car.Quantity} шт.";
                comboBoxCar.Items.Add(displayText);
            }
        }

        private void btnChangeCar_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            int selectedIndex = comboBoxCar.SelectedIndex;
            if (selectedIndex < 0)
            {
                MessageBox.Show("Пожалуйста, выберите машину для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string brand = textBoxMark.Text;
            string country = textBoxCountry.Text;
            int year = int.Parse(textBoxYear.Text);
            int isNew = radioButtonNew.Checked ? 1 : 0;
            float price = float.Parse(textBoxPrice.Text);
            int quantity = int.Parse(textBoxQuantity.Text);

            // Обновляем данные
            cars[selectedIndex].Brand = brand;
            cars[selectedIndex].Country = country;
            cars[selectedIndex].Year = year;
            cars[selectedIndex].NewOrUsed = isNew;
            cars[selectedIndex].Price = price;
            cars[selectedIndex].Quantity = quantity;

            MessageBox.Show("Данные машины успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCarsToComboBox(); // Обновляем ComboBox
            this.Close();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBoxMark.Text) ||
                string.IsNullOrWhiteSpace(textBoxCountry.Text) ||
                !int.TryParse(textBoxYear.Text, out int year) ||
                year > DateTime.Now.Year ||
                !decimal.TryParse(textBoxPrice.Text, out decimal price) ||
                price < 0 ||
                !int.TryParse(textBoxQuantity.Text, out int quantity) ||
                quantity < 0)
            {
                MessageBox.Show("Пожалуйста, проверьте введенные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
