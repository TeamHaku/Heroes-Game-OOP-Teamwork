namespace Game
{
    partial class CastleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CastleView));
            this.Unit1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.u1minus = new System.Windows.Forms.Button();
            this.u1plus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Unit1
            // 
            this.Unit1.Image = ((System.Drawing.Image)(resources.GetObject("Unit1.Image")));
            this.Unit1.Location = new System.Drawing.Point(12, 134);
            this.Unit1.Name = "Unit1";
            this.Unit1.Size = new System.Drawing.Size(58, 51);
            this.Unit1.TabIndex = 0;
            this.Unit1.UseVisualStyleBackColor = true;
            this.Unit1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 1;
            // 
            // u1minus
            // 
            this.u1minus.Image = ((System.Drawing.Image)(resources.GetObject("u1minus.Image")));
            this.u1minus.Location = new System.Drawing.Point(76, 144);
            this.u1minus.Name = "u1minus";
            this.u1minus.Size = new System.Drawing.Size(38, 30);
            this.u1minus.TabIndex = 2;
            this.u1minus.UseVisualStyleBackColor = true;
            // 
            // u1plus
            // 
            this.u1plus.Image = ((System.Drawing.Image)(resources.GetObject("u1plus.Image")));
            this.u1plus.Location = new System.Drawing.Point(243, 144);
            this.u1plus.Name = "u1plus";
            this.u1plus.Size = new System.Drawing.Size(38, 30);
            this.u1plus.TabIndex = 3;
            this.u1plus.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(76, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(97, 36);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "1200";
            // 
            // CastleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.u1plus);
            this.Controls.Add(this.u1minus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Unit1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CastleView";
            this.Load += new System.EventHandler(this.CastleView_Load);
            this.Click += new System.EventHandler(this.CastleView_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Unit1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button u1minus;
        private System.Windows.Forms.Button u1plus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}