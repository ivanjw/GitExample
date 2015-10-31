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
            this.SuspendLayout();
            // 
            // englishButton
            // 
            this.englishButton.Location = new System.Drawing.Point(62, 73);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(75, 23);
            this.englishButton.TabIndex = 0;
            this.englishButton.Text = "English";
            this.englishButton.UseVisualStyleBackColor = true;
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Location = new System.Drawing.Point(72, 30);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(65, 13);
            this.greetingLabel.TabIndex = 1;
            this.greetingLabel.Text = "Hello World!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.englishButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Label greetingLabel;
    }
}

