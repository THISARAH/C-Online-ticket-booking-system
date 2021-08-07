namespace team_final_project
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.bc1 = new System.Windows.Forms.Button();
            this.bc2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bc1
            // 
            this.bc1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc1.Location = new System.Drawing.Point(22, 65);
            this.bc1.Name = "bc1";
            this.bc1.Size = new System.Drawing.Size(316, 69);
            this.bc1.TabIndex = 0;
            this.bc1.Text = "Manage Customer Details";
            this.bc1.UseVisualStyleBackColor = true;
            this.bc1.Click += new System.EventHandler(this.bc1_Click);
            // 
            // bc2
            // 
            this.bc2.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bc2.Location = new System.Drawing.Point(22, 175);
            this.bc2.Name = "bc2";
            this.bc2.Size = new System.Drawing.Size(316, 74);
            this.bc2.TabIndex = 1;
            this.bc2.Text = "Select Music Show";
            this.bc2.UseVisualStyleBackColor = true;
            this.bc2.Click += new System.EventHandler(this.bc2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(485, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(632, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bc2);
            this.Controls.Add(this.bc1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bc1;
        private System.Windows.Forms.Button bc2;
        private System.Windows.Forms.Button button1;
    }
}