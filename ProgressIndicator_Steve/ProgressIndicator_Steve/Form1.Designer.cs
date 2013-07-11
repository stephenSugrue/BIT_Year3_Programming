namespace ProgressIndicator_Steve
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
            this.rdoSpinBox = new System.Windows.Forms.RadioButton();
            this.rdoTrackBar = new System.Windows.Forms.RadioButton();
            this.rdoProgressBar = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoSpinBox
            // 
            this.rdoSpinBox.AutoSize = true;
            this.rdoSpinBox.Location = new System.Drawing.Point(61, 75);
            this.rdoSpinBox.Name = "rdoSpinBox";
            this.rdoSpinBox.Size = new System.Drawing.Size(67, 17);
            this.rdoSpinBox.TabIndex = 0;
            this.rdoSpinBox.TabStop = true;
            this.rdoSpinBox.Text = "Spin Box";
            this.rdoSpinBox.UseVisualStyleBackColor = true;
            // 
            // rdoTrackBar
            // 
            this.rdoTrackBar.AutoSize = true;
            this.rdoTrackBar.Location = new System.Drawing.Point(61, 141);
            this.rdoTrackBar.Name = "rdoTrackBar";
            this.rdoTrackBar.Size = new System.Drawing.Size(72, 17);
            this.rdoTrackBar.TabIndex = 1;
            this.rdoTrackBar.TabStop = true;
            this.rdoTrackBar.Text = "Track Bar";
            this.rdoTrackBar.UseVisualStyleBackColor = true;
            // 
            // rdoProgressBar
            // 
            this.rdoProgressBar.AutoSize = true;
            this.rdoProgressBar.Location = new System.Drawing.Point(61, 111);
            this.rdoProgressBar.Name = "rdoProgressBar";
            this.rdoProgressBar.Size = new System.Drawing.Size(85, 17);
            this.rdoProgressBar.TabIndex = 2;
            this.rdoProgressBar.TabStop = true;
            this.rdoProgressBar.Text = "Progress Bar";
            this.rdoProgressBar.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(353, 105);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(299, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(350, 141);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(307, 45);
            this.trackBar1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(353, 72);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(299, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.rdoProgressBar);
            this.Controls.Add(this.rdoTrackBar);
            this.Controls.Add(this.rdoSpinBox);
            this.Name = "Form1";
            this.Text = "Feedback bars";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoSpinBox;
        private System.Windows.Forms.RadioButton rdoTrackBar;
        private System.Windows.Forms.RadioButton rdoProgressBar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}

