namespace Inheritance
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createTriangle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toString = new System.Windows.Forms.Button();
            this.draw = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createTriangle
            // 
            this.createTriangle.Location = new System.Drawing.Point(12, 12);
            this.createTriangle.Name = "createTriangle";
            this.createTriangle.Size = new System.Drawing.Size(222, 67);
            this.createTriangle.TabIndex = 0;
            this.createTriangle.Text = "Maak driehoek";
            this.createTriangle.UseVisualStyleBackColor = true;
            this.createTriangle.Click += new System.EventHandler(this.createTriangle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(685, 266);
            this.textBox1.TabIndex = 1;
            // 
            // toString
            // 
            this.toString.Enabled = false;
            this.toString.Location = new System.Drawing.Point(240, 12);
            this.toString.Name = "toString";
            this.toString.Size = new System.Drawing.Size(222, 67);
            this.toString.TabIndex = 2;
            this.toString.Text = "Toon ToString()";
            this.toString.UseVisualStyleBackColor = true;
            this.toString.Click += new System.EventHandler(this.toString_Click);
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(468, 12);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(222, 67);
            this.draw.TabIndex = 3;
            this.draw.Text = "Toon Draw()";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 372);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 283);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 667);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.toString);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.createTriangle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button createTriangle;
        private TextBox textBox1;
        private Button toString;
        private Button draw;
        private PictureBox pictureBox1;
    }
}