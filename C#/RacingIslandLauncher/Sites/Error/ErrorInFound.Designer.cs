
namespace Racing_Island_Lancher.Sites.Error
{
    partial class ErrorInFound
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.B_Localize = new System.Windows.Forms.Button();
            this.L_Sorry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // B_Localize
            // 
            this.B_Localize.Location = new System.Drawing.Point(494, 222);
            this.B_Localize.Name = "B_Localize";
            this.B_Localize.Size = new System.Drawing.Size(75, 23);
            this.B_Localize.TabIndex = 3;
            this.B_Localize.Text = "Localize ";
            this.B_Localize.UseVisualStyleBackColor = true;
            this.B_Localize.Click += new System.EventHandler(this.B_Localize_Click);
            // 
            // L_Sorry
            // 
            this.L_Sorry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Sorry.AutoSize = true;
            this.L_Sorry.Location = new System.Drawing.Point(231, 205);
            this.L_Sorry.Name = "L_Sorry";
            this.L_Sorry.Size = new System.Drawing.Size(339, 13);
            this.L_Sorry.TabIndex = 2;
            this.L_Sorry.Text = "Sorry, but we didn\'t found your game, try to  localizate it on your device";
            // 
            // ErrorInFound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_Localize);
            this.Controls.Add(this.L_Sorry);
            this.Name = "ErrorInFound";
            this.Text = "ErrorInFound";
            this.Load += new System.EventHandler(this.ErrorInFound_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button B_Localize;
        private System.Windows.Forms.Label L_Sorry;
    }
}