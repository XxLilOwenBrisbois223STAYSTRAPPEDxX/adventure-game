namespace adventure_game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.optionButton1 = new System.Windows.Forms.Button();
            this.optionButton2 = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // optionButton1
            // 
            this.optionButton1.Location = new System.Drawing.Point(93, 370);
            this.optionButton1.Name = "optionButton1";
            this.optionButton1.Size = new System.Drawing.Size(123, 67);
            this.optionButton1.TabIndex = 0;
            this.optionButton1.Text = " ";
            this.optionButton1.UseVisualStyleBackColor = true;
            this.optionButton1.Click += new System.EventHandler(this.optionButton1_Click);
            // 
            // optionButton2
            // 
            this.optionButton2.Location = new System.Drawing.Point(675, 370);
            this.optionButton2.Name = "optionButton2";
            this.optionButton2.Size = new System.Drawing.Size(142, 67);
            this.optionButton2.TabIndex = 1;
            this.optionButton2.Text = " ";
            this.optionButton2.UseVisualStyleBackColor = true;
            this.optionButton2.Click += new System.EventHandler(this.optionButton2_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(37, 44);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(16, 16);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "...";
            // 
            // option1Label
            // 
            this.option1Label.AutoSize = true;
            this.option1Label.Location = new System.Drawing.Point(126, 395);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(44, 16);
            this.option1Label.TabIndex = 3;
            this.option1Label.Text = "label1";
            // 
            // option2Label
            // 
            this.option2Label.AutoSize = true;
            this.option2Label.Location = new System.Drawing.Point(726, 395);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(44, 16);
            this.option2Label.TabIndex = 4;
            this.option2Label.Text = "label1";
            this.option2Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 496);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.optionButton2);
            this.Controls.Add(this.optionButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button optionButton1;
        private System.Windows.Forms.Button optionButton2;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
    }
}

