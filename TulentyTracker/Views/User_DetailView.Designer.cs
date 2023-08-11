namespace TulentyTracker.Views
{
    partial class User_DetailView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserBirthDate_Control = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UserCountry_Control = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UserSurname_Control = new System.Windows.Forms.TextBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.UserPermission_Control = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.UserName_Control = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserId_Control = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserPermissionId_Control = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserBirthDate_Control
            // 
            this.UserBirthDate_Control.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UserBirthDate_Control.Location = new System.Drawing.Point(85, 126);
            this.UserBirthDate_Control.Name = "UserBirthDate_Control";
            this.UserBirthDate_Control.Size = new System.Drawing.Size(112, 23);
            this.UserBirthDate_Control.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Birth Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Country";
            // 
            // UserCountry_Control
            // 
            this.UserCountry_Control.Location = new System.Drawing.Point(85, 97);
            this.UserCountry_Control.Name = "UserCountry_Control";
            this.UserCountry_Control.Size = new System.Drawing.Size(112, 23);
            this.UserCountry_Control.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Surname";
            // 
            // UserSurname_Control
            // 
            this.UserSurname_Control.Location = new System.Drawing.Point(85, 68);
            this.UserSurname_Control.Name = "UserSurname_Control";
            this.UserSurname_Control.Size = new System.Drawing.Size(112, 23);
            this.UserSurname_Control.TabIndex = 14;
            // 
            // AddUserButton
            // 
            this.AddUserButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddUserButton.Location = new System.Drawing.Point(14, 223);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(86, 26);
            this.AddUserButton.TabIndex = 17;
            this.AddUserButton.Text = "OK";
            this.AddUserButton.UseVisualStyleBackColor = true;
            // 
            // UserPermission_Control
            // 
            this.UserPermission_Control.FormattingEnabled = true;
            this.UserPermission_Control.Location = new System.Drawing.Point(85, 184);
            this.UserPermission_Control.Name = "UserPermission_Control";
            this.UserPermission_Control.Size = new System.Drawing.Size(112, 23);
            this.UserPermission_Control.TabIndex = 16;
            this.UserPermission_Control.SelectedValueChanged += new System.EventHandler(this.UserPermission_Control_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Permission";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Name";
            // 
            // UserName_Control
            // 
            this.UserName_Control.Location = new System.Drawing.Point(85, 39);
            this.UserName_Control.Name = "UserName_Control";
            this.UserName_Control.Size = new System.Drawing.Size(112, 23);
            this.UserName_Control.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(111, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Id";
            // 
            // UserId_Control
            // 
            this.UserId_Control.Enabled = false;
            this.UserId_Control.Location = new System.Drawing.Point(85, 12);
            this.UserId_Control.Name = "UserId_Control";
            this.UserId_Control.Size = new System.Drawing.Size(112, 23);
            this.UserId_Control.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "PermId";
            // 
            // UserPermissionId_Control
            // 
            this.UserPermissionId_Control.Enabled = false;
            this.UserPermissionId_Control.Location = new System.Drawing.Point(85, 155);
            this.UserPermissionId_Control.Name = "UserPermissionId_Control";
            this.UserPermissionId_Control.Size = new System.Drawing.Size(112, 23);
            this.UserPermissionId_Control.TabIndex = 27;
            this.UserPermissionId_Control.TextChanged += new System.EventHandler(this.UserPermissionId_Control_TextChanged);
            // 
            // User_DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserPermissionId_Control);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserId_Control);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserBirthDate_Control);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.UserCountry_Control);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UserSurname_Control);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.UserPermission_Control);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.UserName_Control);
            this.MaximumSize = new System.Drawing.Size(234, 303);
            this.MinimumSize = new System.Drawing.Size(234, 303);
            this.Name = "User_DetailView";
            this.Text = "User_DetailView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DateTimePicker UserBirth_Control;
        private Label label4;
        private Label label9;
        public TextBox UserCountry_Control;
        private Label label10;
        public TextBox UserSurename_Control;
        private Button AddUserButton;
        public ComboBox UserPermission_Control;
        private Label label11;
        private Label label12;
        public TextBox UserName_Control;
        private Button button1;
        public TextBox UserSurname_Control;
        public DateTimePicker UserBirthDate_Control;
        private Label label1;
        private Label label2;
        public TextBox UserPermissionId_Control;
        public TextBox UserId_Control;
    }
}