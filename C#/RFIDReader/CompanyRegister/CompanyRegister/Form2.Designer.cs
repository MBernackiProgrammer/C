
namespace CompanyRegister
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.B_Yes = new System.Windows.Forms.Button();
            this.B_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wykryto nowy brylok / kartę, czy chesz ją dodać do bazy danych.";
            // 
            // B_Yes
            // 
            this.B_Yes.Location = new System.Drawing.Point(363, 299);
            this.B_Yes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B_Yes.Name = "B_Yes";
            this.B_Yes.Size = new System.Drawing.Size(100, 28);
            this.B_Yes.TabIndex = 2;
            this.B_Yes.Text = "Tak";
            this.B_Yes.UseVisualStyleBackColor = true;
            // 
            // B_No
            // 
            this.B_No.Location = new System.Drawing.Point(471, 299);
            this.B_No.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B_No.Name = "B_No";
            this.B_No.Size = new System.Drawing.Size(100, 28);
            this.B_No.TabIndex = 3;
            this.B_No.Text = "Nie";
            this.B_No.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.B_No);
            this.Controls.Add(this.B_Yes);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Yes;
        private System.Windows.Forms.Button B_No;
    }
}