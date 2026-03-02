using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddCarForm : Form
    {
        private List<Car> cars; // Список машин, переданный из меню

        public AddCarForm(List<Car> cars)
        {
            InitializeComponent();
            this.cars = cars; // Инициализируем список машин
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Проверка, заполнены ли все поля
            if (string.IsNullOrWhiteSpace(textYear.Text) ||
                string.IsNullOrWhiteSpace(textStrana.Text) ||
                string.IsNullOrWhiteSpace(textMarka.Text) ||
                string.IsNullOrWhiteSpace(textPrice.Text) ||
                string.IsNullOrWhiteSpace(textQuantity.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Переменные для хранения преобразованных значений
            int year;
            float price;
            int quantity;
            int newOrUsed;

            
            if (!int.TryParse(textYear.Text, out year))
            {
                MessageBox.Show("Введите корректный год.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (year < 1885 || year > DateTime.Now.Year) // Проверяем, что год находится в диапазоне 1885 < x < текущий год
            {
                MessageBox.Show($"Год должен быть между 1885 и {DateTime.Now.Year}.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!float.TryParse(textPrice.Text, out price))
            {
                MessageBox.Show("Введите корректную цену.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (!int.TryParse(textQuantity.Text, out quantity))
            {
                MessageBox.Show("Введите корректное количество.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Устанавливаем значение для NewOrUsed в зависимости от выбранной радио-кнопки
            newOrUsed = rarbtnNew.Checked ? 1 : 0;

            // Создаем новую машину
            Car newCar = new Car
            {
                Brand = textMarka.Text,
                Country = textStrana.Text,
                Year = year,
                NewOrUsed = newOrUsed, // Присваиваем 1 или 0
                Price = price, 
                Quantity = quantity
            };

            // Определяем номер для новой машины
            newCar.CarNumber = cars.Count > 0 ? cars[cars.Count - 1].CarNumber + 1 : 1;

            // Добавляем новую машину в список
            cars.Add(newCar);
            MessageBox.Show("Машина успешно добавлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Закрываем форму
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
