namespace GardenReporter_Steve
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCharges = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(160, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(390, 246);
            this.listBox1.TabIndex = 5;
            // 
            // btnCharges
            // 
            this.btnCharges.Location = new System.Drawing.Point(373, 12);
            this.btnCharges.Name = "btnCharges";
            this.btnCharges.Size = new System.Drawing.Size(177, 62);
            this.btnCharges.TabIndex = 4;
            this.btnCharges.Text = "Charges Report";
            this.btnCharges.UseVisualStyleBackColor = true;
            this.btnCharges.Click += new System.EventHandler(this.btnCharges_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(151, 12);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(177, 62);
            this.btnArea.TabIndex = 3;
            this.btnArea.Text = "Area Report";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 373);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCharges);
            this.Controls.Add(this.btnArea);
            this.Name = "Form1";
            this.Text = "Form1";
          
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCharges;
        private System.Windows.Forms.Button btnArea;
    }
}

