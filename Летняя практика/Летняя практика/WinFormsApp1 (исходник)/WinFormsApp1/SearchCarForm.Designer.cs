namespace WinFormsApp1
{
    partial class SearchCarForm
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
            btnSearch = new Button();
            txtCarNumber = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtBrand = new TextBox();
            txtCountry = new TextBox();
            txtYear = new TextBox();
            radioYearGreaterThan = new RadioButton();
            radioYearLessThan = new RadioButton();
            radioYearEqual = new RadioButton();
            radioPriceLessThan = new RadioButton();
            radioPriceEqual = new RadioButton();
            radioQuantityGreaterThan = new RadioButton();
            radioQuantityLessThan = new RadioButton();
            radioQuantityEqual = new RadioButton();
            radioPriceGreaterThan = new RadioButton();
            Car_Search = new DataGridView();
            label8 = new Label();
            btnCancel = new Button();
            radioCarNumberEqual = new RadioButton();
            radioCarNumberGreaterThan = new RadioButton();
            radioCarNumberLessThan = new RadioButton();
            radioUsed = new RadioButton();
            radioNew = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)Car_Search).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 402);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(168, 35);
            btnSearch.TabIndex = 45;
            btnSearch.Text = "Найти машину";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtCarNumber
            // 
            txtCarNumber.Location = new Point(215, 57);
            txtCarNumber.Name = "txtCarNumber";
            txtCarNumber.Size = new Size(138, 23);
            txtCarNumber.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 60);
            label7.Name = "label7";
            label7.Size = new Size(158, 15);
            label7.TabIndex = 43;
            label7.Text = "Номер машины по списку:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 287);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 42;
            label6.Text = "Количество:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 247);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 41;
            label5.Text = "Цена:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 212);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 40;
            label4.Text = "Новое или б/у:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 179);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 39;
            label3.Text = "Год:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 150);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 38;
            label2.Text = "Страна:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 121);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 37;
            label1.Text = "Марка:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(215, 284);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(138, 23);
            txtQuantity.TabIndex = 36;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(215, 244);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(138, 23);
            txtPrice.TabIndex = 34;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(215, 118);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(138, 23);
            txtBrand.TabIndex = 33;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(215, 147);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(138, 23);
            txtCountry.TabIndex = 32;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(215, 176);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(138, 23);
            txtYear.TabIndex = 31;
            // 
            // radioYearGreaterThan
            // 
            radioYearGreaterThan.AutoSize = true;
            radioYearGreaterThan.Location = new Point(4, 11);
            radioYearGreaterThan.Name = "radioYearGreaterThan";
            radioYearGreaterThan.Size = new Size(33, 19);
            radioYearGreaterThan.TabIndex = 46;
            radioYearGreaterThan.TabStop = true;
            radioYearGreaterThan.Text = ">";
            radioYearGreaterThan.UseVisualStyleBackColor = true;
            // 
            // radioYearLessThan
            // 
            radioYearLessThan.AutoSize = true;
            radioYearLessThan.Location = new Point(43, 11);
            radioYearLessThan.Name = "radioYearLessThan";
            radioYearLessThan.Size = new Size(33, 19);
            radioYearLessThan.TabIndex = 47;
            radioYearLessThan.TabStop = true;
            radioYearLessThan.Text = "<";
            radioYearLessThan.UseVisualStyleBackColor = true;
            // 
            // radioYearEqual
            // 
            radioYearEqual.AutoSize = true;
            radioYearEqual.Location = new Point(83, 11);
            radioYearEqual.Name = "radioYearEqual";
            radioYearEqual.Size = new Size(33, 19);
            radioYearEqual.TabIndex = 48;
            radioYearEqual.TabStop = true;
            radioYearEqual.Text = "=";
            radioYearEqual.UseVisualStyleBackColor = true;
            // 
            // radioPriceLessThan
            // 
            radioPriceLessThan.AutoSize = true;
            radioPriceLessThan.Location = new Point(45, 11);
            radioPriceLessThan.Name = "radioPriceLessThan";
            radioPriceLessThan.Size = new Size(33, 19);
            radioPriceLessThan.TabIndex = 50;
            radioPriceLessThan.TabStop = true;
            radioPriceLessThan.Text = "<";
            radioPriceLessThan.UseVisualStyleBackColor = true;
            radioPriceLessThan.CheckedChanged += radioPriceLessThan_CheckedChanged;
            // 
            // radioPriceEqual
            // 
            radioPriceEqual.AutoSize = true;
            radioPriceEqual.Location = new Point(84, 11);
            radioPriceEqual.Name = "radioPriceEqual";
            radioPriceEqual.Size = new Size(33, 19);
            radioPriceEqual.TabIndex = 51;
            radioPriceEqual.TabStop = true;
            radioPriceEqual.Text = "=";
            radioPriceEqual.UseVisualStyleBackColor = true;
            // 
            // radioQuantityGreaterThan
            // 
            radioQuantityGreaterThan.AutoSize = true;
            radioQuantityGreaterThan.Location = new Point(7, 8);
            radioQuantityGreaterThan.Name = "radioQuantityGreaterThan";
            radioQuantityGreaterThan.Size = new Size(33, 19);
            radioQuantityGreaterThan.TabIndex = 52;
            radioQuantityGreaterThan.TabStop = true;
            radioQuantityGreaterThan.Text = ">";
            radioQuantityGreaterThan.UseVisualStyleBackColor = true;
            // 
            // radioQuantityLessThan
            // 
            radioQuantityLessThan.AutoSize = true;
            radioQuantityLessThan.Location = new Point(46, 8);
            radioQuantityLessThan.Name = "radioQuantityLessThan";
            radioQuantityLessThan.Size = new Size(33, 19);
            radioQuantityLessThan.TabIndex = 53;
            radioQuantityLessThan.TabStop = true;
            radioQuantityLessThan.Text = "<";
            radioQuantityLessThan.UseVisualStyleBackColor = true;
            // 
            // radioQuantityEqual
            // 
            radioQuantityEqual.AutoSize = true;
            radioQuantityEqual.Location = new Point(85, 8);
            radioQuantityEqual.Name = "radioQuantityEqual";
            radioQuantityEqual.Size = new Size(33, 19);
            radioQuantityEqual.TabIndex = 54;
            radioQuantityEqual.TabStop = true;
            radioQuantityEqual.Text = "=";
            radioQuantityEqual.UseVisualStyleBackColor = true;
            // 
            // radioPriceGreaterThan
            // 
            radioPriceGreaterThan.AutoSize = true;
            radioPriceGreaterThan.Location = new Point(6, 11);
            radioPriceGreaterThan.Name = "radioPriceGreaterThan";
            radioPriceGreaterThan.Size = new Size(33, 19);
            radioPriceGreaterThan.TabIndex = 55;
            radioPriceGreaterThan.TabStop = true;
            radioPriceGreaterThan.Text = ">";
            radioPriceGreaterThan.UseVisualStyleBackColor = true;
            // 
            // Car_Search
            // 
            Car_Search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Car_Search.Location = new Point(368, 41);
            Car_Search.Name = "Car_Search";
            Car_Search.Size = new Size(767, 396);
            Car_Search.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(368, 17);
            label8.Name = "label8";
            label8.Size = new Size(188, 21);
            label8.TabIndex = 57;
            label8.Text = "Искомая(ые) машина(ы):";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(278, 414);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 58;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // radioCarNumberEqual
            // 
            radioCarNumberEqual.AutoSize = true;
            radioCarNumberEqual.Location = new Point(79, 14);
            radioCarNumberEqual.Name = "radioCarNumberEqual";
            radioCarNumberEqual.Size = new Size(33, 19);
            radioCarNumberEqual.TabIndex = 59;
            radioCarNumberEqual.TabStop = true;
            radioCarNumberEqual.Text = "=";
            radioCarNumberEqual.UseVisualStyleBackColor = true;
            // 
            // radioCarNumberGreaterThan
            // 
            radioCarNumberGreaterThan.AutoSize = true;
            radioCarNumberGreaterThan.Location = new Point(4, 14);
            radioCarNumberGreaterThan.Name = "radioCarNumberGreaterThan";
            radioCarNumberGreaterThan.Size = new Size(33, 19);
            radioCarNumberGreaterThan.TabIndex = 60;
            radioCarNumberGreaterThan.TabStop = true;
            radioCarNumberGreaterThan.Text = ">";
            radioCarNumberGreaterThan.UseVisualStyleBackColor = true;
            radioCarNumberGreaterThan.CheckedChanged += radioCarNumberGreaterThan_CheckedChanged;
            // 
            // radioCarNumberLessThan
            // 
            radioCarNumberLessThan.AutoSize = true;
            radioCarNumberLessThan.Location = new Point(43, 14);
            radioCarNumberLessThan.Name = "radioCarNumberLessThan";
            radioCarNumberLessThan.Size = new Size(33, 19);
            radioCarNumberLessThan.TabIndex = 61;
            radioCarNumberLessThan.TabStop = true;
            radioCarNumberLessThan.Text = "<";
            radioCarNumberLessThan.UseVisualStyleBackColor = true;
            // 
            // radioUsed
            // 
            radioUsed.AutoSize = true;
            radioUsed.Location = new Point(93, 14);
            radioUsed.Name = "radioUsed";
            radioUsed.Size = new Size(43, 19);
            radioUsed.TabIndex = 62;
            radioUsed.TabStop = true;
            radioUsed.Text = "Б/у";
            radioUsed.UseVisualStyleBackColor = true;
            // 
            // radioNew
            // 
            radioNew.AutoSize = true;
            radioNew.Location = new Point(4, 14);
            radioNew.Name = "radioNew";
            radioNew.Size = new Size(60, 19);
            radioNew.TabIndex = 63;
            radioNew.TabStop = true;
            radioNew.Text = "Новое";
            radioNew.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioPriceGreaterThan);
            groupBox1.Controls.Add(radioPriceEqual);
            groupBox1.Controls.Add(radioPriceLessThan);
            groupBox1.Location = new Point(91, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(118, 38);
            groupBox1.TabIndex = 64;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioQuantityEqual);
            groupBox2.Controls.Add(radioQuantityGreaterThan);
            groupBox2.Controls.Add(radioQuantityLessThan);
            groupBox2.Location = new Point(91, 279);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(118, 33);
            groupBox2.TabIndex = 65;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioYearEqual);
            groupBox3.Controls.Add(radioYearLessThan);
            groupBox3.Controls.Add(radioYearGreaterThan);
            groupBox3.Location = new Point(91, 166);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(117, 36);
            groupBox3.TabIndex = 66;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioCarNumberLessThan);
            groupBox4.Controls.Add(radioCarNumberGreaterThan);
            groupBox4.Controls.Add(radioCarNumberEqual);
            groupBox4.Location = new Point(91, 78);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(118, 39);
            groupBox4.TabIndex = 67;
            groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Transparent;
            groupBox5.Controls.Add(radioUsed);
            groupBox5.Controls.Add(radioNew);
            groupBox5.Location = new Point(211, 198);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(142, 40);
            groupBox5.TabIndex = 68;
            groupBox5.TabStop = false;
            groupBox5.Enter += groupBox5_Enter;
            // 
            // SearchCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 449);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(btnCancel);
            Controls.Add(label8);
            Controls.Add(Car_Search);
            Controls.Add(btnSearch);
            Controls.Add(txtCarNumber);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtBrand);
            Controls.Add(txtCountry);
            Controls.Add(txtYear);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Name = "SearchCarForm";
            Text = "Поиск";
            Load += SearchCarForm_Load;
            ((System.ComponentModel.ISupportInitialize)Car_Search).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #region Windows Form Designer generated code

        // (Остальные переменные и методы)

        #endregion

        private Button btnSearch;
        private TextBox txtCarNumber;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtBrand;
        private TextBox txtCountry;
        private TextBox txtYear;
        private RadioButton radioYearGreaterThan;
        private RadioButton radioYearLessThan;
        private RadioButton radioYearEqual;
        private RadioButton radioPriceLessThan;
        private RadioButton radioPriceEqual;
        private RadioButton radioQuantityGreaterThan;
        private RadioButton radioQuantityLessThan;
        private RadioButton radioQuantityEqual;
        private RadioButton radioPriceGreaterThan;
        private DataGridView Car_Search;
        private Label label8;
        private Button btnCancel;
        private RadioButton radioCarNumberEqual;
        private RadioButton radioCarNumberGreaterThan;
        private RadioButton radioCarNumberLessThan;
        private RadioButton radioUsed;
        private RadioButton radioNew;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
    }
}
