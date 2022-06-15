
namespace Wyswietlanie
{
    partial class COMError
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
            this.L_ErrorText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_ErrorText
            // 
            this.L_ErrorText.AutoSize = true;
            this.L_ErrorText.Location = new System.Drawing.Point(93, 41);
            this.L_ErrorText.Name = "L_ErrorText";
            this.L_ErrorText.Size = new System.Drawing.Size(160, 17);
            this.L_ErrorText.TabIndex = 0;
            this.L_ErrorText.Text = "Wybierz poprawne COM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // COMError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 124);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.L_ErrorText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "COMError";
            this.ShowInTaskbar = false;
            this.Text = "Błąd";
            this.Load += new System.EventHandler(this.COMError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_ErrorText;
        private System.Windows.Forms.Button button1;
    }
}