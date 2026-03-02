namespace WinFormsApp1
{
    partial class EditCarForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBoxCar = new ComboBox();
            textBoxMark = new TextBox();
            textBoxCountry = new TextBox();
            textBoxYear = new TextBox();
            textBoxPrice = new TextBox();
            textBoxQuantity = new TextBox();
            radioButtonNew = new RadioButton();
            radioButtonBY = new RadioButton();
            btnChangeCar = new Button();
            btnCancel = new Button();
            labelCar = new Label();
            labelMark = new Label();
            labelCountry = new Label();
            labelYear = new Label();
            labelPrice = new Label();
            labelQuantity = new Label();
            labelCondition = new Label();
            SuspendLayout();
            // 
            // comboBoxCar
            // 
            comboBoxCar.FormattingEnabled = true;
            comboBoxCar.Location = new Point(12, 28);
            comboBoxCar.Name = "comboBoxCar";
            comboBoxCar.Size = new Size(362, 23);
            comboBoxCar.TabIndex = 0;
            // 
            // textBoxMark
            // 
            textBoxMark.Location = new Point(126, 79);
            textBoxMark.Name = "textBoxMark";
            textBoxMark.Size = new Size(248, 23);
            textBoxMark.TabIndex = 2;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(126, 108);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(248, 23);
            textBoxCountry.TabIndex = 3;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(126, 137);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(248, 23);
            textBoxYear.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(126, 166);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(248, 23);
            textBoxPrice.TabIndex = 5;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(126, 196);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(248, 23);
            textBoxQuantity.TabIndex = 6;
            // 
            // radioButtonNew
            // 
            radioButtonNew.AutoSize = true;
            radioButtonNew.Location = new Point(126, 249);
            radioButtonNew.Name = "radioButtonNew";
            radioButtonNew.Size = new Size(59, 19);
            radioButtonNew.TabIndex = 7;
            radioButtonNew.TabStop = true;
            radioButtonNew.Text = "Новая";
            radioButtonNew.UseVisualStyleBackColor = true;
            // 
            // radioButtonBY
            // 
            radioButtonBY.AutoSize = true;
            radioButtonBY.Location = new Point(331, 249);
            radioButtonBY.Name = "radioButtonBY";
            radioButtonBY.Size = new Size(43, 19);
            radioButtonBY.TabIndex = 8;
            radioButtonBY.TabStop = true;
            radioButtonBY.Text = "Б/у";
            radioButtonBY.UseVisualStyleBackColor = true;
            // 
            // btnChangeCar
            // 
            btnChangeCar.Location = new Point(12, 287);
            btnChangeCar.Name = "btnChangeCar";
            btnChangeCar.Size = new Size(75, 23);
            btnChangeCar.TabIndex = 9;
            btnChangeCar.Text = "Изменить";
            btnChangeCar.UseVisualStyleBackColor = true;
            btnChangeCar.Click += btnChangeCar_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(299, 287);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // labelCar
            // 
            labelCar.AutoSize = true;
            labelCar.Location = new Point(12, 9);
            labelCar.Name = "labelCar";
            labelCar.Size = new Size(224, 15);
            labelCar.TabIndex = 11;
            labelCar.Text = "Здесь вы можете посмотреть машины.";
            // 
            // labelMark
            // 
            labelMark.AutoSize = true;
            labelMark.Location = new Point(12, 82);
            labelMark.Name = "labelMark";
            labelMark.Size = new Size(46, 15);
            labelMark.TabIndex = 12;
            labelMark.Text = "Марка:";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(12, 111);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(49, 15);
            labelCountry.TabIndex = 13;
            labelCountry.Text = "Страна:";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(12, 140);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(29, 15);
            labelYear.TabIndex = 14;
            labelYear.Text = "Год:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(12, 169);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(38, 15);
            labelPrice.TabIndex = 15;
            labelPrice.Text = "Цена:";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(12, 199);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(75, 15);
            labelQuantity.TabIndex = 16;
            labelQuantity.Text = "Количество:";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(12, 249);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(69, 15);
            labelCondition.TabIndex = 17;
            labelCondition.Text = "Состояние:";
            // 
            // EditCarForm
            // 
            ClientSize = new Size(386, 322);
            Controls.Add(labelCondition);
            Controls.Add(labelQuantity);
            Controls.Add(labelPrice);
            Controls.Add(labelYear);
            Controls.Add(labelCountry);
            Controls.Add(labelMark);
            Controls.Add(labelCar);
            Controls.Add(btnCancel);
            Controls.Add(btnChangeCar);
            Controls.Add(radioButtonBY);
            Controls.Add(radioButtonNew);
            Controls.Add(textBoxQuantity);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxMark);
            Controls.Add(comboBoxCar);
            Name = "EditCarForm";
            Text = "Редактировать машину";
            Load += EditCarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxCar;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.RadioButton radioButtonNew;
        private System.Windows.Forms.RadioButton radioButtonBY;
        private System.Windows.Forms.Button btnChangeCar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelCondition;
    }
}
