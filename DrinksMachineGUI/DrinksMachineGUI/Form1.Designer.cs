
namespace DrinksMachineGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCoke = new System.Windows.Forms.Button();
            this.btnSprite = new System.Windows.Forms.Button();
            this.btnFanta = new System.Windows.Forms.Button();
            this.btnOasis = new System.Windows.Forms.Button();
            this.btnWater = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drinks machine simulator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please select your drink";
            // 
            // btnCoke
            // 
            this.btnCoke.Location = new System.Drawing.Point(117, 100);
            this.btnCoke.Name = "btnCoke";
            this.btnCoke.Size = new System.Drawing.Size(75, 23);
            this.btnCoke.TabIndex = 2;
            this.btnCoke.Text = "Coke";
            this.btnCoke.UseVisualStyleBackColor = true;
            this.btnCoke.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSprite
            // 
            this.btnSprite.Location = new System.Drawing.Point(117, 260);
            this.btnSprite.Name = "btnSprite";
            this.btnSprite.Size = new System.Drawing.Size(75, 23);
            this.btnSprite.TabIndex = 3;
            this.btnSprite.Text = "Sprite";
            this.btnSprite.UseVisualStyleBackColor = true;
            this.btnSprite.Click += new System.EventHandler(this.btnSprite_Click);
            // 
            // btnFanta
            // 
            this.btnFanta.Location = new System.Drawing.Point(117, 141);
            this.btnFanta.Name = "btnFanta";
            this.btnFanta.Size = new System.Drawing.Size(75, 23);
            this.btnFanta.TabIndex = 4;
            this.btnFanta.Text = "Fanta";
            this.btnFanta.UseVisualStyleBackColor = true;
            this.btnFanta.Click += new System.EventHandler(this.btnFanta_Click);
            // 
            // btnOasis
            // 
            this.btnOasis.Location = new System.Drawing.Point(117, 218);
            this.btnOasis.Name = "btnOasis";
            this.btnOasis.Size = new System.Drawing.Size(75, 23);
            this.btnOasis.TabIndex = 5;
            this.btnOasis.Text = "Oasis";
            this.btnOasis.UseVisualStyleBackColor = true;
            this.btnOasis.Click += new System.EventHandler(this.btnOasis_Click);
            // 
            // btnWater
            // 
            this.btnWater.Location = new System.Drawing.Point(117, 180);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(75, 23);
            this.btnWater.TabIndex = 6;
            this.btnWater.Text = "Water";
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.button5_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::DrinksMachineGUI.Properties.Resources.Water;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(322, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 304);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnWater);
            this.Controls.Add(this.btnOasis);
            this.Controls.Add(this.btnFanta);
            this.Controls.Add(this.btnSprite);
            this.Controls.Add(this.btnCoke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCoke;
        private System.Windows.Forms.Button btnSprite;
        private System.Windows.Forms.Button btnFanta;
        private System.Windows.Forms.Button btnOasis;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

