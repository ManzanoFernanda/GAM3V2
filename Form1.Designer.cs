namespace GAM3
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.circularButton4 = new GAM3.CircularButton();
            this.circularButton5 = new GAM3.CircularButton();
            this.circularButton6 = new GAM3.CircularButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // circularButton4
            // 
            this.circularButton4.AllowDrop = true;
            this.circularButton4.BackgroundImage = global::GAM3.Properties.Resources.btpanda;
            this.circularButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton4.FlatAppearance.BorderSize = 0;
            this.circularButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton4.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton4.ForeColor = System.Drawing.Color.White;
            this.circularButton4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.circularButton4.Location = new System.Drawing.Point(269, 279);
            this.circularButton4.Margin = new System.Windows.Forms.Padding(1);
            this.circularButton4.Name = "circularButton4";
            this.circularButton4.Size = new System.Drawing.Size(150, 150);
            this.circularButton4.TabIndex = 0;
            this.circularButton4.Text = "JUGAR";
            this.circularButton4.UseVisualStyleBackColor = true;
            this.circularButton4.Click += new System.EventHandler(this.CircularButton4_Click);
            // 
            // circularButton5
            // 
            this.circularButton5.BackgroundImage = global::GAM3.Properties.Resources.bt1;
            this.circularButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton5.FlatAppearance.BorderSize = 0;
            this.circularButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton5.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.circularButton5.Location = new System.Drawing.Point(25, 281);
            this.circularButton5.Margin = new System.Windows.Forms.Padding(0);
            this.circularButton5.Name = "circularButton5";
            this.circularButton5.Size = new System.Drawing.Size(150, 150);
            this.circularButton5.TabIndex = 1;
            this.circularButton5.Text = "PUNTOS";
            this.circularButton5.UseVisualStyleBackColor = true;
            this.circularButton5.Click += new System.EventHandler(this.CircularButton5_Click);
            // 
            // circularButton6
            // 
            this.circularButton6.BackgroundImage = global::GAM3.Properties.Resources.btpardo;
            this.circularButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton6.FlatAppearance.BorderSize = 0;
            this.circularButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton6.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.circularButton6.Location = new System.Drawing.Point(518, 281);
            this.circularButton6.Margin = new System.Windows.Forms.Padding(1);
            this.circularButton6.Name = "circularButton6";
            this.circularButton6.Size = new System.Drawing.Size(150, 150);
            this.circularButton6.TabIndex = 2;
            this.circularButton6.Text = "SALIR";
            this.circularButton6.UseVisualStyleBackColor = true;
            this.circularButton6.Click += new System.EventHandler(this.CircularButton6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::GAM3.Properties.Resources.AAAABc9dWyJLLdJUZ0jT6n8fOedFXPDhvx8lXDhfOQxwTxgrLIvUP7BTgjcefxqPaI9QCoX6lYRzbsY4y_VrlTTkucedcR9p_BLtohfX;
            this.pictureBox1.Location = new System.Drawing.Point(210, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GAM3.Properties.Resources.ea24747361f8dbc210e03374866d2e48;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.circularButton6);
            this.Controls.Add(this.circularButton5);
            this.Controls.Add(this.circularButton4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Name = "Form1";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public CircularButton circularButton4;
        public CircularButton circularButton5;
        public CircularButton circularButton6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}