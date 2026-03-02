using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WinFormsApp1;
using System.Globalization;

namespace CarManagementApp
{
    public partial class Menu : Form
    {
        private List<Car> cars; // Список машин
        private string filePath = "bd_cars.txt"; // Путь к файлу

        public Menu()
        {
            InitializeComponent();
            LoadCars(); // Загрузка данных при инициализации

            this.FormClosing += new FormClosingEventHandler(Menu_FormClosing);
        }

        private void LoadCars()
        {
            cars = LoadCarsFromFile(filePath); // Обновление списка машин
        }

        private List<Car> LoadCarsFromFile(string filePath)
        {
            var carList = new List<Car>();
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Файл с данными не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return carList; // Возвращаем пустой список, если файл не найден
                }

                var lines = File.ReadAllLines(filePath);
                Car? currentCar = null;

                foreach (var line in lines)
                {
                    if (line.StartsWith("Car #"))
                    {
                        if (currentCar != null)
                        {
                            carList.Add(currentCar);
                        }

                        currentCar = new Car();
                        string carNumberString = line.Substring(5).Trim();
                        if (int.TryParse(carNumberString, out int carNumber))
                        {
                            currentCar.CarNumber = carNumber;
                        }
                    }
                    else if (currentCar != null)
                    {
                        if (line.StartsWith("Brand:"))
                        {
                            currentCar.Brand = line.Substring(6).Trim();
                        }
                        else if (line.StartsWith("Country:"))
                        {
                            currentCar.Country = line.Substring(8).Trim();
                        }
                        else if (line.StartsWith("Year:"))
                        {
                            currentCar.Year = int.Parse(line.Substring(5).Trim());
                        }
                        else if (line.StartsWith("New or Used:"))
                        {
                            currentCar.NewOrUsed = int.Parse(line.Substring(12).Trim());
                        }
                        else if (line.StartsWith("Price:"))
                        {
                            currentCar.Price = float.Parse(line.Substring(6).Trim(), CultureInfo.InvariantCulture);
                        }
                        else if (line.StartsWith("Quantity:"))
                        {
                            currentCar.Quantity = int.Parse(line.Substring(9).Trim());
                        }
                    }
                }

                if (currentCar != null)
                {
                    carList.Add(currentCar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
            return carList;
        }

        private void SaveCarsToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var car in cars)
                    {
                        writer.WriteLine($"Car #{car.CarNumber}");
                        writer.WriteLine($"Brand: {car.Brand}");
                        writer.WriteLine($"Country: {car.Country}");
                        writer.WriteLine($"Year: {car.Year}");
                        writer.WriteLine($"New or Used: {car.NewOrUsed}");
                        writer.WriteLine($"Price: {car.Price}");
                        writer.WriteLine($"Quantity: {car.Quantity}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddCarForm(cars);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                SaveCarsToFile(filePath);
                LoadCars(); // Обновление списка машин после добавления
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var editForm = new EditCarForm(cars);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                SaveCarsToFile(filePath);
                LoadCars(); // Обновление списка машин после редактирования
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchCarForm(cars);
            searchForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCar();
        }

        private void DeleteCar()
        {
            // Проверка на наличие машин в базе данных
            if (cars.Count == 0)
            {
                MessageBox.Show("База данных пуста. Невозможно удалить машину.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Выходим из метода, если машин нет
            }

            // Если машины есть, открываем форму удаления
            var deleteForm = new DeleteCarForm(cars);
            if (deleteForm.ShowDialog() == DialogResult.OK) // Проверяем, что форма закрылась с результатом OK
            {
                SaveCarsToFile(filePath); // Сохраняем изменения в файл
                LoadCars(); // Обновление списка машин после удаления
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрытие формы
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCarsToFile(filePath); // Сохранение данных перед закрытием формы
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
