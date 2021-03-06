namespace AddessBook_V1
{
    partial class Settings
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ClearDataBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BackBtn.FlatAppearance.BorderSize = 2;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(12, 24);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(59, 33);
            this.BackBtn.TabIndex = 33;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Clear Table Data";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ExitBtn.FlatAppearance.BorderSize = 2;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(275, 24);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(59, 33);
            this.ExitBtn.TabIndex = 31;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ClearDataBtn
            // 
            this.ClearDataBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClearDataBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearDataBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearDataBtn.FlatAppearance.BorderSize = 2;
            this.ClearDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearDataBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearDataBtn.Location = new System.Drawing.Point(111, 185);
            this.ClearDataBtn.Name = "ClearDataBtn";
            this.ClearDataBtn.Size = new System.Drawing.Size(119, 33);
            this.ClearDataBtn.TabIndex = 30;
            this.ClearDataBtn.Text = "Clear Data";
            this.ClearDataBtn.UseVisualStyleBackColor = false;
            this.ClearDataBtn.Click += new System.EventHandler(this.ClearDataBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(346, 458);
            this.ControlBox = false;
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearDataBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ClearDataBtn;
    }
}