namespace WinFormsApp1
{
    partial class DeleteCarForm
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
            comboBoxDel = new ComboBox();
            label7 = new Label();
            btnCancel = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // comboBoxDel
            // 
            comboBoxDel.FormattingEnabled = true;
            comboBoxDel.Location = new Point(12, 33);
            comboBoxDel.Name = "comboBoxDel";
            comboBoxDel.Size = new Size(415, 23);
            comboBoxDel.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(200, 21);
            label7.TabIndex = 59;
            label7.Text = "Номер машины по списку:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(352, 100);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 64;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 84);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 39);
            btnDelete.TabIndex = 65;
            btnDelete.Text = "Удалить машину";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // DeleteCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 135);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(label7);
            Controls.Add(comboBoxDel);
            Name = "DeleteCarForm";
            Text = "Удаление машины";
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code

        private ComboBox comboBoxDel;
        private Label label7;
        private Button btnCancel;
        private Button btnDelete;

        #endregion
    }
}
