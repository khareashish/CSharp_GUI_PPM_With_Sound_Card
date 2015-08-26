namespace Sound
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BEnablePPM = new System.Windows.Forms.Button();
            this.DetectB = new System.Windows.Forms.Button();
            this.EAmplitude = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Up";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Down";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BEnablePPM
            // 
            this.BEnablePPM.Location = new System.Drawing.Point(93, 213);
            this.BEnablePPM.Name = "BEnablePPM";
            this.BEnablePPM.Size = new System.Drawing.Size(75, 23);
            this.BEnablePPM.TabIndex = 2;
            this.BEnablePPM.Text = "Enable ";
            this.BEnablePPM.UseVisualStyleBackColor = true;
            this.BEnablePPM.Click += new System.EventHandler(this.button3_Click);
            // 
            // DetectB
            // 
            this.DetectB.Location = new System.Drawing.Point(47, 170);
            this.DetectB.Name = "DetectB";
            this.DetectB.Size = new System.Drawing.Size(75, 23);
            this.DetectB.TabIndex = 3;
            this.DetectB.Text = "Detect";
            this.DetectB.UseVisualStyleBackColor = true;
            this.DetectB.Click += new System.EventHandler(this.DetectB_Click);
            // 
            // EAmplitude
            // 
            this.EAmplitude.Location = new System.Drawing.Point(150, 173);
            this.EAmplitude.Name = "EAmplitude";
            this.EAmplitude.Size = new System.Drawing.Size(59, 20);
            this.EAmplitude.TabIndex = 4;
            this.EAmplitude.TextChanged += new System.EventHandler(this.EAmplitude_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.EAmplitude);
            this.Controls.Add(this.DetectB);
            this.Controls.Add(this.BEnablePPM);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BEnablePPM;
        private System.Windows.Forms.Button DetectB;
        private System.Windows.Forms.TextBox EAmplitude;
    }
}

