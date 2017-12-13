namespace Serpinski
{
    partial class Form1
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
            this.CarpetButton = new System.Windows.Forms.Button();
            this.FractalPictureBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CarpetButton
            // 
            this.CarpetButton.Location = new System.Drawing.Point(22, 11);
            this.CarpetButton.Name = "CarpetButton";
            this.CarpetButton.Size = new System.Drawing.Size(125, 32);
            this.CarpetButton.TabIndex = 1;
            this.CarpetButton.Text = "Построить";
            this.CarpetButton.UseVisualStyleBackColor = true;
            this.CarpetButton.Click += new System.EventHandler(this.CarpetButton_Click);
            // 
            // FractalPictureBox
            // 
            this.FractalPictureBox.Location = new System.Drawing.Point(22, 49);
            this.FractalPictureBox.Name = "FractalPictureBox";
            this.FractalPictureBox.Size = new System.Drawing.Size(550, 550);
            this.FractalPictureBox.TabIndex = 2;
            this.FractalPictureBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FractalPictureBox);
            this.Controls.Add(this.CarpetButton);
            this.Name = "Form1";
            this.Text = "Serpinski";
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CarpetButton;
        private System.Windows.Forms.PictureBox FractalPictureBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

