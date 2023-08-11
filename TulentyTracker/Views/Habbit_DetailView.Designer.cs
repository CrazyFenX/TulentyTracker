namespace TulentyTracker.Views
{
    partial class Habbit_DetailView
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
            this.label3 = new System.Windows.Forms.Label();
            this.HabbitDescription_Control = new System.Windows.Forms.TextBox();
            this.AddHabitButton = new System.Windows.Forms.Button();
            this.HabbitCategory_Control = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HabbitName_Control = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.HabbitId_Control = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HabbitCategoryId_Control = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Desc";
            // 
            // HabbitDescription_Control
            // 
            this.HabbitDescription_Control.Location = new System.Drawing.Point(56, 70);
            this.HabbitDescription_Control.Name = "HabbitDescription_Control";
            this.HabbitDescription_Control.Size = new System.Drawing.Size(112, 23);
            this.HabbitDescription_Control.TabIndex = 9;
            // 
            // AddHabitButton
            // 
            this.AddHabitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddHabitButton.Location = new System.Drawing.Point(97, 181);
            this.AddHabitButton.Name = "AddHabitButton";
            this.AddHabitButton.Size = new System.Drawing.Size(71, 23);
            this.AddHabitButton.TabIndex = 11;
            this.AddHabitButton.Text = "Cancel";
            this.AddHabitButton.UseVisualStyleBackColor = true;
            // 
            // HabbitCategory_Control
            // 
            this.HabbitCategory_Control.FormattingEnabled = true;
            this.HabbitCategory_Control.Location = new System.Drawing.Point(56, 128);
            this.HabbitCategory_Control.Name = "HabbitCategory_Control";
            this.HabbitCategory_Control.Size = new System.Drawing.Size(112, 23);
            this.HabbitCategory_Control.TabIndex = 10;
            this.HabbitCategory_Control.SelectedValueChanged += new System.EventHandler(this.HabbitCategory_Control_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Categ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // HabbitName_Control
            // 
            this.HabbitName_Control.Location = new System.Drawing.Point(56, 41);
            this.HabbitName_Control.Name = "HabbitName_Control";
            this.HabbitName_Control.Size = new System.Drawing.Size(112, 23);
            this.HabbitName_Control.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Id";
            // 
            // HabbitId_Control
            // 
            this.HabbitId_Control.Enabled = false;
            this.HabbitId_Control.Location = new System.Drawing.Point(56, 12);
            this.HabbitId_Control.Name = "HabbitId_Control";
            this.HabbitId_Control.Size = new System.Drawing.Size(112, 23);
            this.HabbitId_Control.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "CategId";
            // 
            // HabbitCategoryId_Control
            // 
            this.HabbitCategoryId_Control.Location = new System.Drawing.Point(56, 99);
            this.HabbitCategoryId_Control.Name = "HabbitCategoryId_Control";
            this.HabbitCategoryId_Control.Size = new System.Drawing.Size(112, 23);
            this.HabbitCategoryId_Control.TabIndex = 18;
            // 
            // Habbit_DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 217);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HabbitCategoryId_Control);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HabbitId_Control);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HabbitDescription_Control);
            this.Controls.Add(this.AddHabitButton);
            this.Controls.Add(this.HabbitCategory_Control);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HabbitName_Control);
            this.MinimumSize = new System.Drawing.Size(200, 217);
            this.Name = "Habbit_DetailView";
            this.Text = "Habbit_DetailView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        public TextBox HabbitDescription_Control;
        private Button AddHabitButton;
        public ComboBox HabbitCategory_Control;
        private Label label2;
        private Label label1;
        public TextBox HabbitName_Control;
        private Button button1;
        private Label label4;
        public TextBox HabbitId_Control;
        private Label label5;
        public TextBox HabbitCategoryId_Control;
    }
}