namespace GitExample
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
            this.englishButton = new System.Windows.Forms.Button();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.germanButton = new System.Windows.Forms.Button();
            this.frenchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // englishButton
            // 
            this.englishButton.Location = new System.Drawing.Point(85, 64);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(75, 23);
            this.englishButton.TabIndex = 0;
            this.englishButton.Text = "English";
            this.englishButton.UseVisualStyleBackColor = true;
            this.englishButton.Click += new System.EventHandler(this.englishButton_Click);
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLabel.Location = new System.Drawing.Point(72, 30);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(106, 20);
            this.greetingLabel.TabIndex = 1;
            this.greetingLabel.Text = "Hello World!";
            this.greetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // germanButton
            // 
            this.germanButton.Location = new System.Drawing.Point(85, 93);
            this.germanButton.Name = "germanButton";
            this.germanButton.Size = new System.Drawing.Size(75, 23);
            this.germanButton.TabIndex = 2;
            this.germanButton.Text = "German";
            this.germanButton.UseVisualStyleBackColor = true;
            this.germanButton.Click += new System.EventHandler(this.germanButton_Click);
            // 
            // frenchButton
            // 
            this.frenchButton.Location = new System.Drawing.Point(85, 122);
            this.frenchButton.Name = "frenchButton";
            this.frenchButton.Size = new System.Drawing.Size(75, 23);
            this.frenchButton.TabIndex = 3;
            this.frenchButton.Text = "French";
            this.frenchButton.UseVisualStyleBackColor = true;
            this.frenchButton.Click += new System.EventHandler(this.frenchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.frenchButton);
            this.Controls.Add(this.germanButton);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.englishButton);
            this.Name = "Form1";
            this.Text = "International Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Button germanButton;
        private System.Windows.Forms.Button frenchButton;
    }
}

