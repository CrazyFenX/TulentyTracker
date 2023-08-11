namespace TulentyTracker.Views
{
    partial class Category_DetailView
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
            this.label6 = new System.Windows.Forms.Label();
            this.CategoryDescription_Control = new System.Windows.Forms.TextBox();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CategoryName_Control = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryId_Control = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Desc";
            // 
            // CategoryDescription_Control
            // 
            this.CategoryDescription_Control.Location = new System.Drawing.Point(58, 76);
            this.CategoryDescription_Control.Name = "CategoryDescription_Control";
            this.CategoryDescription_Control.Size = new System.Drawing.Size(112, 23);
            this.CategoryDescription_Control.TabIndex = 9;
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddCategoryButton.Location = new System.Drawing.Point(14, 114);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(76, 25);
            this.AddCategoryButton.TabIndex = 10;
            this.AddCategoryButton.Text = "Ok";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Name";
            // 
            // CategoryName_Control
            // 
            this.CategoryName_Control.Location = new System.Drawing.Point(58, 47);
            this.CategoryName_Control.Name = "CategoryName_Control";
            this.CategoryName_Control.Size = new System.Drawing.Size(112, 23);
            this.CategoryName_Control.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(96, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id";
            // 
            // CategoryId_Control
            // 
            this.CategoryId_Control.Enabled = false;
            this.CategoryId_Control.Location = new System.Drawing.Point(58, 18);
            this.CategoryId_Control.Name = "CategoryId_Control";
            this.CategoryId_Control.Size = new System.Drawing.Size(112, 23);
            this.CategoryId_Control.TabIndex = 14;
            // 
            // Category_DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 151);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryId_Control);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CategoryDescription_Control);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CategoryName_Control);
            this.MaximumSize = new System.Drawing.Size(207, 190);
            this.MinimumSize = new System.Drawing.Size(207, 190);
            this.Name = "Category_DetailView";
            this.Text = "Category_DetailView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        public TextBox CategoryDescription_Control;
        private Button AddCategoryButton;
        private Label label8;
        public TextBox CategoryName_Control;
        private Button button1;
        private Label label1;
        public TextBox CategoryId_Control;
    }
}