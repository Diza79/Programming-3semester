using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DeleteCarForm : Form
    {
        private List<Car> cars; // Список машин, переданный из Menu

        public DeleteCarForm(List<Car> cars)
        {
            InitializeComponent();
            this.cars = cars;

            // Заполнение ComboBox информацией о машинах
            UpdateComboBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли машина
            if (comboBoxDel.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите машину для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получаем индекс выбранной машины
            int selectedIndex = comboBoxDel.SelectedIndex;

            // Удаляем машину из списка
            cars.RemoveAt(selectedIndex);
            MessageBox.Show("Машина успешно удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Обновляем порядковые номера и ComboBox
            UpdateCarNumbers();
            UpdateComboBox();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) // Оставляем имя обработчика без изменений
        {
            this.Close(); // Закрываем форму
        }

        private void UpdateCarNumbers()
        {
            // Обновляем порядковые номера машин
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].CarNumber = i + 1; // Присваиваем новый номер
            }
        }

        private void UpdateComboBox()
        {
            comboBoxDel.Items.Clear();
            foreach (var car in cars)
            {
                // Формируем строку с полной информацией о машине
                string condition = car.NewOrUsed == 0 ? "Б/у" : "Новая"; // 1 - новая, 0 - б/у
                string displayText = $"№{car.CarNumber} - {car.Brand}, {car.Country}, {car.Year}, {condition}, {car.Price} руб., {car.Quantity} шт.";
                comboBoxDel.Items.Add(displayText);
            }
        }
    }
}
