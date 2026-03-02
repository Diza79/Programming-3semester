namespace CarManagementApp 
{
    partial class Menu
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(36, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 40);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Добавление";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(36, 130);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(136, 40);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Изменение";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(36, 176);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(136, 40);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Поиск";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(35, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Удаление";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(35, 268);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 40);
            btnExit.TabIndex = 5;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(36, 36);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 6;
            label1.Text = "Выберите действие:";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(217, 334);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnAdd;
        private Button btnEdit;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnExit;
        private Label label1;
    }
}
