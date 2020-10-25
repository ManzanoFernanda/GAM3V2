namespace GAM3
{
    partial class Form1000
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
            this.circularButton1 = new GAM3.CircularButton();
            this.circularButton3 = new GAM3.CircularButton();
            this.SuspendLayout();
            // 
            // circularButton1
            // 
            this.circularButton1.BackgroundImage = global::GAM3.Properties.Resources.bt1;
            this.circularButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton1.Location = new System.Drawing.Point(159, 204);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(75, 23);
            this.circularButton1.TabIndex = 0;
            this.circularButton1.Text = "circularButton1";
            this.circularButton1.UseVisualStyleBackColor = true;
            // 
            // circularButton3
            // 
            this.circularButton3.Location = new System.Drawing.Point(553, 204);
            this.circularButton3.Name = "circularButton3";
            this.circularButton3.Size = new System.Drawing.Size(75, 23);
            this.circularButton3.TabIndex = 2;
            this.circularButton3.Text = "circularButton3";
            this.circularButton3.UseVisualStyleBackColor = true;
            // 
            // Form1000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GAM3.Properties.Resources.ea24747361f8dbc210e03374866d2e48;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.circularButton3);
            this.Controls.Add(this.circularButton1);
            this.Name = "Form1000";
            this.Text = "Form1000";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularButton circularButton1;
        private CircularButton circularButton3;
    }
}