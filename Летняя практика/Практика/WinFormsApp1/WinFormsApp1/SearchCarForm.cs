using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SearchCarForm : Form
    {
        private List<Car> cars; // Список машин

        public SearchCarForm(List<Car> cars)
        {
            InitializeComponent();
            this.cars = cars; // Инициализация списка машин
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Проверка, введена ли хотя бы одна характеристика
            if (string.IsNullOrEmpty(txtCarNumber.Text) &&
                string.IsNullOrEmpty(txtYear.Text) &&
                string.IsNullOrEmpty(txtPrice.Text) &&
                string.IsNullOrEmpty(txtQuantity.Text) &&
                string.IsNullOrEmpty(txtBrand.Text) &&
                string.IsNullOrEmpty(txtCountry.Text) &&
                (!radioNew.Checked && !radioUsed.Checked)) // выбор нового или б/у
            {
                MessageBox.Show("Для работы поисковика необходимо ввести как минимум одну характеристику.");
                return;
            }

            // Логика поиска
            var query = cars.AsQueryable();

            // Поиск по порядковому номеру
            if (int.TryParse(txtCarNumber.Text, out int carNumber))
            {
                if (radioCarNumberGreaterThan.Checked)
                    query = query.Where(c => c.CarNumber > carNumber);
                else if (radioCarNumberLessThan.Checked)
                    query = query.Where(c => c.CarNumber < carNumber);
                else if (radioCarNumberEqual.Checked)
                    query = query.Where(c => c.CarNumber == carNumber);
            }

            // Поиск по году
            if (int.TryParse(txtYear.Text, out int year))
            {
                if (radioYearGreaterThan.Checked)
                    query = query.Where(c => c.Year > year);
                else if (radioYearLessThan.Checked)
                    query = query.Where(c => c.Year < year);
                else if (radioYearEqual.Checked)
                    query = query.Where(c => c.Year == year);
            }

            // Поиск по цене
            if (float.TryParse(txtPrice.Text, out float price))
            {
                if (radioPriceGreaterThan.Checked)
                    query = query.Where(c => c.Price > price);
                else if (radioPriceLessThan.Checked)
                    query = query.Where(c => c.Price < price);
                else if (radioPriceEqual.Checked)
                    query = query.Where(c => c.Price == price);
            }

            // Поиск по количеству
            if (int.TryParse(txtQuantity.Text, out int quantity))
            {
                if (radioQuantityGreaterThan.Checked)
                    query = query.Where(c => c.Quantity > quantity);
                else if (radioQuantityLessThan.Checked)
                    query = query.Where(c => c.Quantity < quantity);
                else if (radioQuantityEqual.Checked)
                    query = query.Where(c => c.Quantity == quantity);
            }

            // Поиск по марке
            if (!string.IsNullOrEmpty(txtBrand.Text))
            {
                query = query.Where(c => c.Brand.Contains(txtBrand.Text, StringComparison.OrdinalIgnoreCase));
            }

            // Поиск по стране
            if (!string.IsNullOrEmpty(txtCountry.Text))
            {
                query = query.Where(c => c.Country.Contains(txtCountry.Text, StringComparison.OrdinalIgnoreCase));
            }

            // Поиск по новому или б/у
            if (radioNew.Checked) // Если выбрано "Новое"
            {
                query = query.Where(c => c.NewOrUsed == 1); 
            }
            else if (radioUsed.Checked) // Если выбрано "Б/У"
            {
                query = query.Where(c => c.NewOrUsed == 0); 
            }

            // Отображение результатов в DataGridView
            Car_Search.DataSource = query.ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchCarForm_Load(object sender, EventArgs e) { }
        private void radioPriceLessThan_CheckedChanged(object sender, EventArgs e) { }
        private void groupBox5_Enter(object sender, EventArgs e) { }
        private void radioCarNumberGreaterThan_CheckedChanged(object sender, EventArgs e) { }
    }

    public class Car // Класс для представления машины
    {
        public int CarNumber { get; set; } // Порядковый номер
        public string Brand { get; set; } = string.Empty; 
        public string Country { get; set; } = string.Empty; 
        public int Year { get; set; }
        public int NewOrUsed { get; set; } // 1 - новое, 0 - б/у
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
}
