namespace TulentyTracker.Views
{
    partial class Permission_DetailView
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
            this.AddPermissionButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PermissionName_Control = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PermissionId_Control = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddPermissionButton
            // 
            this.AddPermissionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddPermissionButton.Location = new System.Drawing.Point(98, 80);
            this.AddPermissionButton.Name = "AddPermissionButton";
            this.AddPermissionButton.Size = new System.Drawing.Size(82, 25);
            this.AddPermissionButton.TabIndex = 6;
            this.AddPermissionButton.Text = "Cancel";
            this.AddPermissionButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Name";
            // 
            // PermissionName_Control
            // 
            this.PermissionName_Control.Location = new System.Drawing.Point(52, 40);
            this.PermissionName_Control.Name = "PermissionName_Control";
            this.PermissionName_Control.Size = new System.Drawing.Size(128, 23);
            this.PermissionName_Control.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(8, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Id";
            // 
            // PermissionId_Control
            // 
            this.PermissionId_Control.Enabled = false;
            this.PermissionId_Control.Location = new System.Drawing.Point(52, 11);
            this.PermissionId_Control.Name = "PermissionId_Control";
            this.PermissionId_Control.Size = new System.Drawing.Size(128, 23);
            this.PermissionId_Control.TabIndex = 18;
            // 
            // Permission_DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 119);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PermissionId_Control);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddPermissionButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PermissionName_Control);
            this.MaximumSize = new System.Drawing.Size(208, 158);
            this.MinimumSize = new System.Drawing.Size(208, 158);
            this.Name = "Permission_DetailView";
            this.Text = "Permission_DetailView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddPermissionButton;
        private Label label7;
        public TextBox PermissionName_Control;
        private Button button1;
        private Label label4;
        public TextBox PermissionId_Control;
    }
}