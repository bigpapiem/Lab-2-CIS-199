
namespace Lab2
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
            this.EnterMealPrice = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.Tip15 = new System.Windows.Forms.Label();
            this.Tip18 = new System.Windows.Forms.Label();
            this.Tip20 = new System.Windows.Forms.Label();
            this.TIPRATE1 = new System.Windows.Forms.Label();
            this.TIPRATE2 = new System.Windows.Forms.Label();
            this.TIPRATE3 = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterMealPrice
            // 
            this.EnterMealPrice.AutoSize = true;
            this.EnterMealPrice.Location = new System.Drawing.Point(37, 28);
            this.EnterMealPrice.Name = "EnterMealPrice";
            this.EnterMealPrice.Size = new System.Drawing.Size(131, 17);
            this.EnterMealPrice.TabIndex = 0;
            this.EnterMealPrice.Text = "Enter price of meal:";
            this.EnterMealPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(279, 28);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 22);
            this.Price.TabIndex = 1;
            // 
            // Tip15
            // 
            this.Tip15.AutoSize = true;
            this.Tip15.Location = new System.Drawing.Point(121, 70);
            this.Tip15.Name = "Tip15";
            this.Tip15.Size = new System.Drawing.Size(36, 17);
            this.Tip15.TabIndex = 2;
            this.Tip15.Text = "15%";
            // 
            // Tip18
            // 
            this.Tip18.AutoSize = true;
            this.Tip18.Location = new System.Drawing.Point(121, 117);
            this.Tip18.Name = "Tip18";
            this.Tip18.Size = new System.Drawing.Size(36, 17);
            this.Tip18.TabIndex = 3;
            this.Tip18.Text = "18%";
            // 
            // Tip20
            // 
            this.Tip20.AutoSize = true;
            this.Tip20.Location = new System.Drawing.Point(121, 166);
            this.Tip20.Name = "Tip20";
            this.Tip20.Size = new System.Drawing.Size(36, 17);
            this.Tip20.TabIndex = 4;
            this.Tip20.Text = "20%";
            // 
            // TIPRATE1
            // 
            this.TIPRATE1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TIPRATE1.Location = new System.Drawing.Point(279, 70);
            this.TIPRATE1.Name = "TIPRATE1";
            this.TIPRATE1.Size = new System.Drawing.Size(100, 23);
            this.TIPRATE1.TabIndex = 5;
            // 
            // TIPRATE2
            // 
            this.TIPRATE2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TIPRATE2.Location = new System.Drawing.Point(279, 116);
            this.TIPRATE2.Name = "TIPRATE2";
            this.TIPRATE2.Size = new System.Drawing.Size(100, 23);
            this.TIPRATE2.TabIndex = 6;
            // 
            // TIPRATE3
            // 
            this.TIPRATE3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TIPRATE3.Location = new System.Drawing.Point(279, 166);
            this.TIPRATE3.Name = "TIPRATE3";
            this.TIPRATE3.Size = new System.Drawing.Size(100, 23);
            this.TIPRATE3.TabIndex = 7;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(153, 241);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(119, 28);
            this.calcBtn.TabIndex = 8;
            this.calcBtn.Text = "Calculate Tip";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 319);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.TIPRATE3);
            this.Controls.Add(this.TIPRATE2);
            this.Controls.Add(this.TIPRATE1);
            this.Controls.Add(this.Tip20);
            this.Controls.Add(this.Tip18);
            this.Controls.Add(this.Tip15);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.EnterMealPrice);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterMealPrice;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label Tip15;
        private System.Windows.Forms.Label Tip18;
        private System.Windows.Forms.Label Tip20;
        private System.Windows.Forms.Label TIPRATE1;
        private System.Windows.Forms.Label TIPRATE2;
        private System.Windows.Forms.Label TIPRATE3;
        private System.Windows.Forms.Button calcBtn;
    }
}


