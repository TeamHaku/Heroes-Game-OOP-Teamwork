namespace TestForm
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
            this.pictureBoxUnit = new System.Windows.Forms.PictureBox();
            this.unit1 = new System.Windows.Forms.TextBox();
            this.u1minus = new System.Windows.Forms.Button();
            this.u1plus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.goldBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUnit
            // 
            this.pictureBoxUnit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUnit.Image")));
            this.pictureBoxUnit.Location = new System.Drawing.Point(12, 134);
            this.pictureBoxUnit.Name = "pictureBoxUnit";
            this.pictureBoxUnit.Size = new System.Drawing.Size(44, 40);
            this.pictureBoxUnit.TabIndex = 0;
            this.pictureBoxUnit.TabStop = false;
            // 
            // unit1
            // 
            this.unit1.Location = new System.Drawing.Point(120, 150);
            this.unit1.Name = "unit1";
            this.unit1.ReadOnly = true;
            this.unit1.Size = new System.Drawing.Size(117, 20);
            this.unit1.TabIndex = 1;
            // 
            // u1minus
            // 
            this.u1minus.Image = ((System.Drawing.Image)(resources.GetObject("u1minus.Image")));
            this.u1minus.Location = new System.Drawing.Point(76, 144);
            this.u1minus.Name = "u1minus";
            this.u1minus.Size = new System.Drawing.Size(38, 30);
            this.u1minus.TabIndex = 2;
            this.u1minus.UseVisualStyleBackColor = true;
            this.u1minus.Click += new System.EventHandler(this.u1minus_Click);
            // 
            // u1plus
            // 
            this.u1plus.Image = ((System.Drawing.Image)(resources.GetObject("u1plus.Image")));
            this.u1plus.Location = new System.Drawing.Point(243, 144);
            this.u1plus.Name = "u1plus";
            this.u1plus.Size = new System.Drawing.Size(38, 30);
            this.u1plus.TabIndex = 3;
            this.u1plus.UseVisualStyleBackColor = true;
            this.u1plus.Click += new System.EventHandler(this.u1plus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestForm.Properties.Resources.gold;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // goldBox
            // 
            this.goldBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goldBox.Location = new System.Drawing.Point(76, 12);
            this.goldBox.Name = "goldBox";
            this.goldBox.ReadOnly = true;
            this.goldBox.Size = new System.Drawing.Size(97, 36);
            this.goldBox.TabIndex = 5;
            this.goldBox.Text = "";
            // 
            // CastleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.goldBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.u1plus);
            this.Controls.Add(this.u1minus);
            this.Controls.Add(this.unit1);
            this.Controls.Add(this.pictureBoxUnit);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CastleView";
            this.ShowIcon = false;
            this.Text = "Castle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUnit;
        private System.Windows.Forms.TextBox unit1;
        private System.Windows.Forms.Button u1minus;
        private System.Windows.Forms.Button u1plus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox goldBox;
    }
}