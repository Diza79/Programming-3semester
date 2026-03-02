namespace WinFormsApp1
{
    partial class AddCarForm
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textQuantity = new TextBox();
            textPrice = new TextBox();
            textMarka = new TextBox();
            textStrana = new TextBox();
            textYear = new TextBox();
            btnAdd = new Button(); 
            btnCancel = new Button(); 
            groupBox1 = new GroupBox();
            radbntLoss = new RadioButton();
            rarbtnNew = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();

            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 174);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 27;
            label6.Text = "Количество:";

            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 145);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 26;
            label5.Text = "Цена:";

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 109);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 25;
            label4.Text = "Новая или б/у:";

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 73);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 24;
            label3.Text = "Год:";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 44);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 23;
            label2.Text = "Страна:";

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 22;
            label1.Text = "Марка:";

            // 
            // textQuantity
            // 
            textQuantity.Location = new Point(116, 171);
            textQuantity.Name = "textQuantity";
            textQuantity.Size = new Size(168, 23);
            textQuantity.TabIndex = 21;

            // 
            // textPrice
            // 
            textPrice.Location = new Point(116, 142);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(168, 23);
            textPrice.TabIndex = 19;

            // 
            // textMarka
            // 
            textMarka.Location = new Point(116, 12);
            textMarka.Name = "textMarka";
            textMarka.Size = new Size(168, 23);
            textMarka.TabIndex = 18;

            // 
            // textStrana
            // 
            textStrana.Location = new Point(116, 41);
            textStrana.Name = "textStrana";
            textStrana.Size = new Size(168, 23);
            textStrana.TabIndex = 17;

            // 
            // textYear
            // 
            textYear.Location = new Point(116, 70);
            textYear.Name = "textYear";
            textYear.Size = new Size(168, 23);
            textYear.TabIndex = 16;

            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(9, 210);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 42);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Добавить машину";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click; 

            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(209, 229);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click; 

            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radbntLoss);
            groupBox1.Controls.Add(rarbtnNew);
            groupBox1.Location = new Point(116, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 37);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;

            // 
            // radbntLoss
            // 
            radbntLoss.AutoSize = true;
            radbntLoss.Location = new Point(119, 10);
            radbntLoss.Name = "radbntLoss";
            radbntLoss.Size = new Size(43, 19);
            radbntLoss.TabIndex = 1;
            radbntLoss.TabStop = true;
            radbntLoss.Text = "Б/у";
            radbntLoss.UseVisualStyleBackColor = true;

            // 
            // rarbtnNew
            // 
            rarbtnNew.AutoSize = true;
            rarbtnNew.Location = new Point(6, 10);
            rarbtnNew.Name = "rarbtnNew";
            rarbtnNew.Size = new Size(59, 19);
            rarbtnNew.TabIndex = 0;
            rarbtnNew.TabStop = true;
            rarbtnNew.Text = "Новая";
            rarbtnNew.UseVisualStyleBackColor = true;

            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 264);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textQuantity);
            Controls.Add(textPrice);
            Controls.Add(textMarka);
            Controls.Add(textStrana);
            Controls.Add(textYear);
            Controls.Add(btnAdd); 
            Controls.Add(btnCancel);
            Name = "AddCarForm";
            Text = "Добавление машины";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #region 

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textQuantity;
        private TextBox textPrice;
        private TextBox textMarka;
        private TextBox textStrana;
        private TextBox textYear;
        private Button btnAdd; 
        private Button btnCancel;
        private GroupBox groupBox1;
        private RadioButton radbntLoss;
        private RadioButton rarbtnNew;

        #endregion
    }
}
