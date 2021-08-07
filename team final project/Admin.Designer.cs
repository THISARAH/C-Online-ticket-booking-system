namespace team_final_project
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.ba1 = new System.Windows.Forms.Button();
            this.ba2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ba1
            // 
            this.ba1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba1.Location = new System.Drawing.Point(77, 68);
            this.ba1.Name = "ba1";
            this.ba1.Size = new System.Drawing.Size(272, 86);
            this.ba1.TabIndex = 0;
            this.ba1.Text = "Manage Employee Details";
            this.ba1.UseVisualStyleBackColor = true;
            this.ba1.Click += new System.EventHandler(this.ba1_Click);
            // 
            // ba2
            // 
            this.ba2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ba2.Location = new System.Drawing.Point(77, 215);
            this.ba2.Name = "ba2";
            this.ba2.Size = new System.Drawing.Size(272, 85);
            this.ba2.TabIndex = 1;
            this.ba2.Text = "Ticket Details Report";
            this.ba2.UseVisualStyleBackColor = true;
            this.ba2.Click += new System.EventHandler(this.ba2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(639, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ba2);
            this.Controls.Add(this.ba1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ba1;
        private System.Windows.Forms.Button ba2;
        private System.Windows.Forms.Button button1;
    }
}