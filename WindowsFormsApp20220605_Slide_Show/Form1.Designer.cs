
namespace WindowsFormsApp20220605_Slide_Show
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Start1 = new System.Windows.Forms.Button();
            this.Stop2 = new System.Windows.Forms.Button();
            this.Preview3 = new System.Windows.Forms.Button();
            this.Open4 = new System.Windows.Forms.Button();
            this.Next5 = new System.Windows.Forms.Button();
            this.labelcounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(709, 185);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Start1
            // 
            this.Start1.Location = new System.Drawing.Point(152, 227);
            this.Start1.Name = "Start1";
            this.Start1.Size = new System.Drawing.Size(75, 23);
            this.Start1.TabIndex = 1;
            this.Start1.Text = "Start";
            this.Start1.UseVisualStyleBackColor = true;
            this.Start1.Click += new System.EventHandler(this.Start1_Click);
            // 
            // Stop2
            // 
            this.Stop2.Location = new System.Drawing.Point(505, 226);
            this.Stop2.Name = "Stop2";
            this.Stop2.Size = new System.Drawing.Size(75, 23);
            this.Stop2.TabIndex = 2;
            this.Stop2.Text = "Stop";
            this.Stop2.UseVisualStyleBackColor = true;
            this.Stop2.Click += new System.EventHandler(this.Stop2_Click);
            // 
            // Preview3
            // 
            this.Preview3.Location = new System.Drawing.Point(38, 268);
            this.Preview3.Name = "Preview3";
            this.Preview3.Size = new System.Drawing.Size(75, 23);
            this.Preview3.TabIndex = 3;
            this.Preview3.Text = "Prev";
            this.Preview3.UseVisualStyleBackColor = true;
            this.Preview3.Click += new System.EventHandler(this.Preview3_Click);
            // 
            // Open4
            // 
            this.Open4.Location = new System.Drawing.Point(339, 268);
            this.Open4.Name = "Open4";
            this.Open4.Size = new System.Drawing.Size(75, 23);
            this.Open4.TabIndex = 4;
            this.Open4.Text = "Open";
            this.Open4.UseVisualStyleBackColor = true;
            this.Open4.Click += new System.EventHandler(this.Open4_Click);
            // 
            // Next5
            // 
            this.Next5.Location = new System.Drawing.Point(646, 268);
            this.Next5.Name = "Next5";
            this.Next5.Size = new System.Drawing.Size(75, 23);
            this.Next5.TabIndex = 5;
            this.Next5.Text = "Next";
            this.Next5.UseVisualStyleBackColor = true;
            this.Next5.Click += new System.EventHandler(this.Next5_Click);
            // 
            // labelcounter
            // 
            this.labelcounter.AutoSize = true;
            this.labelcounter.Location = new System.Drawing.Point(679, 214);
            this.labelcounter.Name = "labelcounter";
            this.labelcounter.Size = new System.Drawing.Size(39, 15);
            this.labelcounter.TabIndex = 6;
            this.labelcounter.Text = "Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 326);
            this.Controls.Add(this.labelcounter);
            this.Controls.Add(this.Next5);
            this.Controls.Add(this.Open4);
            this.Controls.Add(this.Preview3);
            this.Controls.Add(this.Stop2);
            this.Controls.Add(this.Start1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Start1;
        private System.Windows.Forms.Button Stop2;
        private System.Windows.Forms.Button Preview3;
        private System.Windows.Forms.Button Open4;
        private System.Windows.Forms.Button Next5;
        private System.Windows.Forms.Label labelcounter;
    }
}

