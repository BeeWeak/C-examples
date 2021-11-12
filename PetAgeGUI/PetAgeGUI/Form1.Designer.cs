
namespace PetAgeGUI
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
            this.txtAgeInYears = new System.Windows.Forms.TextBox();
            this.txtAgeInDogYears = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDogAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAgeInYears
            // 
            this.txtAgeInYears.Location = new System.Drawing.Point(154, 121);
            this.txtAgeInYears.Name = "txtAgeInYears";
            this.txtAgeInYears.Size = new System.Drawing.Size(100, 20);
            this.txtAgeInYears.TabIndex = 0;
            // 
            // txtAgeInDogYears
            // 
            this.txtAgeInDogYears.Location = new System.Drawing.Point(154, 222);
            this.txtAgeInDogYears.Name = "txtAgeInDogYears";
            this.txtAgeInDogYears.Size = new System.Drawing.Size(100, 20);
            this.txtAgeInDogYears.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(164, 164);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(24, 124);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(100, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age in human years";
            // 
            // lblDogAge
            // 
            this.lblDogAge.AutoSize = true;
            this.lblDogAge.Location = new System.Drawing.Point(24, 211);
            this.lblDogAge.Name = "lblDogAge";
            this.lblDogAge.Size = new System.Drawing.Size(88, 13);
            this.lblDogAge.TabIndex = 4;
            this.lblDogAge.Text = "Age in Dog years";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 368);
            this.Controls.Add(this.lblDogAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtAgeInDogYears);
            this.Controls.Add(this.txtAgeInYears);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAgeInYears;
        private System.Windows.Forms.TextBox txtAgeInDogYears;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblDogAge;
    }
}

