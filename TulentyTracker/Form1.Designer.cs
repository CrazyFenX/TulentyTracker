namespace TulentyTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HabbitNametextBox = new System.Windows.Forms.TextBox();
            this.groupBoxHabbit = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HabbitDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AddHabitButton = new System.Windows.Forms.Button();
            this.HabbitCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PerminssionButton = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.NavButtonCategory = new System.Windows.Forms.Button();
            this.NavButtonAdding = new System.Windows.Forms.Button();
            this.NavButtonHabbits = new System.Windows.Forms.Button();
            this.AddingPanel = new System.Windows.Forms.Panel();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.UserBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UserCountryTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UserSurenameTextBox = new System.Windows.Forms.TextBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.UserPermissionComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoryDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.PermissionGroupBox = new System.Windows.Forms.GroupBox();
            this.AddPermissionButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PermissionNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxHabbit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AddingPanel.SuspendLayout();
            this.DataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxCategory.SuspendLayout();
            this.PermissionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HabbitNametextBox
            // 
            this.HabbitNametextBox.Location = new System.Drawing.Point(50, 33);
            this.HabbitNametextBox.Name = "HabbitNametextBox";
            this.HabbitNametextBox.Size = new System.Drawing.Size(112, 23);
            this.HabbitNametextBox.TabIndex = 0;
            // 
            // groupBoxHabbit
            // 
            this.groupBoxHabbit.Controls.Add(this.label3);
            this.groupBoxHabbit.Controls.Add(this.HabbitDescriptionTextBox);
            this.groupBoxHabbit.Controls.Add(this.AddHabitButton);
            this.groupBoxHabbit.Controls.Add(this.HabbitCategoryComboBox);
            this.groupBoxHabbit.Controls.Add(this.label2);
            this.groupBoxHabbit.Controls.Add(this.label1);
            this.groupBoxHabbit.Controls.Add(this.HabbitNametextBox);
            this.groupBoxHabbit.Location = new System.Drawing.Point(6, 12);
            this.groupBoxHabbit.Name = "groupBoxHabbit";
            this.groupBoxHabbit.Size = new System.Drawing.Size(184, 231);
            this.groupBoxHabbit.TabIndex = 1;
            this.groupBoxHabbit.TabStop = false;
            this.groupBoxHabbit.Text = "Habbit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desc";
            // 
            // HabbitDescriptionTextBox
            // 
            this.HabbitDescriptionTextBox.Location = new System.Drawing.Point(50, 62);
            this.HabbitDescriptionTextBox.Name = "HabbitDescriptionTextBox";
            this.HabbitDescriptionTextBox.Size = new System.Drawing.Size(112, 23);
            this.HabbitDescriptionTextBox.TabIndex = 1;
            // 
            // AddHabitButton
            // 
            this.AddHabitButton.Location = new System.Drawing.Point(50, 178);
            this.AddHabitButton.Name = "AddHabitButton";
            this.AddHabitButton.Size = new System.Drawing.Size(112, 34);
            this.AddHabitButton.TabIndex = 3;
            this.AddHabitButton.Text = "Add";
            this.AddHabitButton.UseVisualStyleBackColor = true;
            this.AddHabitButton.Click += new System.EventHandler(this.AddHabitButton_Click);
            // 
            // HabbitCategoryComboBox
            // 
            this.HabbitCategoryComboBox.FormattingEnabled = true;
            this.HabbitCategoryComboBox.Location = new System.Drawing.Point(50, 91);
            this.HabbitCategoryComboBox.Name = "HabbitCategoryComboBox";
            this.HabbitCategoryComboBox.Size = new System.Drawing.Size(112, 23);
            this.HabbitCategoryComboBox.TabIndex = 2;
            this.HabbitCategoryComboBox.Enter += new System.EventHandler(this.HabbitCategoryComboBox_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PerminssionButton);
            this.panel1.Controls.Add(this.UserButton);
            this.panel1.Controls.Add(this.NavButtonCategory);
            this.panel1.Controls.Add(this.NavButtonAdding);
            this.panel1.Controls.Add(this.NavButtonHabbits);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 472);
            this.panel1.TabIndex = 2;
            // 
            // PerminssionButton
            // 
            this.PerminssionButton.Location = new System.Drawing.Point(0, 209);
            this.PerminssionButton.Name = "PerminssionButton";
            this.PerminssionButton.Size = new System.Drawing.Size(159, 34);
            this.PerminssionButton.TabIndex = 4;
            this.PerminssionButton.Text = "Permissions";
            this.PerminssionButton.UseVisualStyleBackColor = true;
            this.PerminssionButton.Click += new System.EventHandler(this.PerminssionButton_Click);
            // 
            // UserButton
            // 
            this.UserButton.Location = new System.Drawing.Point(0, 169);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(159, 34);
            this.UserButton.TabIndex = 3;
            this.UserButton.Text = "Users";
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // NavButtonCategory
            // 
            this.NavButtonCategory.Location = new System.Drawing.Point(0, 129);
            this.NavButtonCategory.Name = "NavButtonCategory";
            this.NavButtonCategory.Size = new System.Drawing.Size(159, 34);
            this.NavButtonCategory.TabIndex = 2;
            this.NavButtonCategory.Text = "Categories";
            this.NavButtonCategory.UseVisualStyleBackColor = true;
            this.NavButtonCategory.Click += new System.EventHandler(this.NavButtonCategory_Click);
            // 
            // NavButtonAdding
            // 
            this.NavButtonAdding.Location = new System.Drawing.Point(0, 34);
            this.NavButtonAdding.Name = "NavButtonAdding";
            this.NavButtonAdding.Size = new System.Drawing.Size(159, 34);
            this.NavButtonAdding.TabIndex = 0;
            this.NavButtonAdding.Text = "Adding";
            this.NavButtonAdding.UseVisualStyleBackColor = true;
            this.NavButtonAdding.Click += new System.EventHandler(this.NavButtonAdding_Click);
            // 
            // NavButtonHabbits
            // 
            this.NavButtonHabbits.Location = new System.Drawing.Point(0, 89);
            this.NavButtonHabbits.Name = "NavButtonHabbits";
            this.NavButtonHabbits.Size = new System.Drawing.Size(159, 34);
            this.NavButtonHabbits.TabIndex = 1;
            this.NavButtonHabbits.Text = "Habbits";
            this.NavButtonHabbits.UseVisualStyleBackColor = true;
            this.NavButtonHabbits.Click += new System.EventHandler(this.NavButtonHabbits_Click);
            // 
            // AddingPanel
            // 
            this.AddingPanel.Controls.Add(this.DataPanel);
            this.AddingPanel.Controls.Add(this.groupBoxUser);
            this.AddingPanel.Controls.Add(this.groupBoxCategory);
            this.AddingPanel.Controls.Add(this.groupBoxHabbit);
            this.AddingPanel.Controls.Add(this.PermissionGroupBox);
            this.AddingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddingPanel.Location = new System.Drawing.Point(162, 0);
            this.AddingPanel.Name = "AddingPanel";
            this.AddingPanel.Size = new System.Drawing.Size(657, 472);
            this.AddingPanel.TabIndex = 3;
            // 
            // DataPanel
            // 
            this.DataPanel.Controls.Add(this.UpdateButton);
            this.DataPanel.Controls.Add(this.DeleteButton);
            this.DataPanel.Controls.Add(this.dataGridView1);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataPanel.Location = new System.Drawing.Point(0, 0);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(657, 472);
            this.DataPanel.TabIndex = 11;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Location = new System.Drawing.Point(381, 426);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(129, 37);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(516, 426);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(129, 37);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(633, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.UserBirthDateTimePicker);
            this.groupBoxUser.Controls.Add(this.label4);
            this.groupBoxUser.Controls.Add(this.label9);
            this.groupBoxUser.Controls.Add(this.UserCountryTextBox);
            this.groupBoxUser.Controls.Add(this.label10);
            this.groupBoxUser.Controls.Add(this.UserSurenameTextBox);
            this.groupBoxUser.Controls.Add(this.AddUserButton);
            this.groupBoxUser.Controls.Add(this.UserPermissionComboBox);
            this.groupBoxUser.Controls.Add(this.label11);
            this.groupBoxUser.Controls.Add(this.label12);
            this.groupBoxUser.Controls.Add(this.UserNameTextBox);
            this.groupBoxUser.Location = new System.Drawing.Point(386, 12);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(207, 231);
            this.groupBoxUser.TabIndex = 10;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            // 
            // UserBirthDateTimePicker
            // 
            this.UserBirthDateTimePicker.Location = new System.Drawing.Point(77, 120);
            this.UserBirthDateTimePicker.Name = "UserBirthDateTimePicker";
            this.UserBirthDateTimePicker.Size = new System.Drawing.Size(112, 23);
            this.UserBirthDateTimePicker.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Country";
            // 
            // UserCountryTextBox
            // 
            this.UserCountryTextBox.Location = new System.Drawing.Point(77, 91);
            this.UserCountryTextBox.Name = "UserCountryTextBox";
            this.UserCountryTextBox.Size = new System.Drawing.Size(112, 23);
            this.UserCountryTextBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Surname";
            // 
            // UserSurenameTextBox
            // 
            this.UserSurenameTextBox.Location = new System.Drawing.Point(77, 62);
            this.UserSurenameTextBox.Name = "UserSurenameTextBox";
            this.UserSurenameTextBox.Size = new System.Drawing.Size(112, 23);
            this.UserSurenameTextBox.TabIndex = 1;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(77, 178);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(112, 34);
            this.AddUserButton.TabIndex = 4;
            this.AddUserButton.Text = "Add";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // UserPermissionComboBox
            // 
            this.UserPermissionComboBox.FormattingEnabled = true;
            this.UserPermissionComboBox.Location = new System.Drawing.Point(77, 149);
            this.UserPermissionComboBox.Name = "UserPermissionComboBox";
            this.UserPermissionComboBox.Size = new System.Drawing.Size(112, 23);
            this.UserPermissionComboBox.TabIndex = 3;
            this.UserPermissionComboBox.Enter += new System.EventHandler(this.UserPermissionComboBox_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Permission";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Name";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(77, 36);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(112, 23);
            this.UserNameTextBox.TabIndex = 0;
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.label6);
            this.groupBoxCategory.Controls.Add(this.CategoryDescriptionTextBox);
            this.groupBoxCategory.Controls.Add(this.AddCategoryButton);
            this.groupBoxCategory.Controls.Add(this.label8);
            this.groupBoxCategory.Controls.Add(this.CategoryNameTextBox);
            this.groupBoxCategory.Location = new System.Drawing.Point(196, 12);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(184, 231);
            this.groupBoxCategory.TabIndex = 10;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Desc";
            // 
            // CategoryDescriptionTextBox
            // 
            this.CategoryDescriptionTextBox.Location = new System.Drawing.Point(50, 62);
            this.CategoryDescriptionTextBox.Name = "CategoryDescriptionTextBox";
            this.CategoryDescriptionTextBox.Size = new System.Drawing.Size(112, 23);
            this.CategoryDescriptionTextBox.TabIndex = 1;
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Location = new System.Drawing.Point(50, 178);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(112, 34);
            this.AddCategoryButton.TabIndex = 2;
            this.AddCategoryButton.Text = "Add";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Name";
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(50, 33);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(112, 23);
            this.CategoryNameTextBox.TabIndex = 0;
            // 
            // PermissionGroupBox
            // 
            this.PermissionGroupBox.Controls.Add(this.AddPermissionButton);
            this.PermissionGroupBox.Controls.Add(this.label7);
            this.PermissionGroupBox.Controls.Add(this.PermissionNameTextBox);
            this.PermissionGroupBox.Location = new System.Drawing.Point(6, 249);
            this.PermissionGroupBox.Name = "PermissionGroupBox";
            this.PermissionGroupBox.Size = new System.Drawing.Size(184, 112);
            this.PermissionGroupBox.TabIndex = 8;
            this.PermissionGroupBox.TabStop = false;
            this.PermissionGroupBox.Text = "Permission";
            // 
            // AddPermissionButton
            // 
            this.AddPermissionButton.Location = new System.Drawing.Point(50, 62);
            this.AddPermissionButton.Name = "AddPermissionButton";
            this.AddPermissionButton.Size = new System.Drawing.Size(112, 34);
            this.AddPermissionButton.TabIndex = 1;
            this.AddPermissionButton.Text = "Add";
            this.AddPermissionButton.UseVisualStyleBackColor = true;
            this.AddPermissionButton.Click += new System.EventHandler(this.AddPermissionButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Name";
            // 
            // PermissionNameTextBox
            // 
            this.PermissionNameTextBox.Location = new System.Drawing.Point(50, 33);
            this.PermissionNameTextBox.Name = "PermissionNameTextBox";
            this.PermissionNameTextBox.Size = new System.Drawing.Size(112, 23);
            this.PermissionNameTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 472);
            this.Controls.Add(this.AddingPanel);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(835, 511);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxHabbit.ResumeLayout(false);
            this.groupBoxHabbit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.AddingPanel.ResumeLayout(false);
            this.DataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxCategory.PerformLayout();
            this.PermissionGroupBox.ResumeLayout(false);
            this.PermissionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox HabbitNametextBox;
        private GroupBox groupBoxHabbit;
        private Label label3;
        private TextBox HabbitDescriptionTextBox;
        private Button AddHabitButton;
        private ComboBox HabbitCategoryComboBox;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel AddingPanel;
        private GroupBox groupBoxUser;
        private Label label9;
        private TextBox UserCountryTextBox;
        private Label label10;
        private TextBox UserSurenameTextBox;
        private Button AddUserButton;
        private ComboBox UserPermissionComboBox;
        private Label label11;
        private Label label12;
        private TextBox UserNameTextBox;
        private GroupBox groupBoxCategory;
        private Label label6;
        private TextBox CategoryDescriptionTextBox;
        private Button AddCategoryButton;
        private Label label8;
        private TextBox CategoryNameTextBox;
        private Button NavButtonAdding;
        private Button NavButtonHabbits;
        private Button UserButton;
        private Button NavButtonCategory;
        private Panel DataPanel;
        private DataGridView dataGridView1;
        private Button PerminssionButton;
        private GroupBox PermissionGroupBox;
        private Button AddPermissionButton;
        private Label label7;
        private TextBox PermissionNameTextBox;
        private Button UpdateButton;
        private Button DeleteButton;
        private DateTimePicker UserBirthDateTimePicker;
        private Label label4;
    }
}