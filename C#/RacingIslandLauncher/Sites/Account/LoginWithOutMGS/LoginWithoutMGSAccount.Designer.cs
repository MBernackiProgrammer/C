
namespace Racing_Island_Lancher.Sites.Account.LoginWithOutMGS
{
    partial class LoginWithoutMGSAccount
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
            this.B_Twich = new System.Windows.Forms.Button();
            this.B_Facebook = new System.Windows.Forms.Button();
            this.B_Gmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Twich
            // 
            this.B_Twich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Twich.Location = new System.Drawing.Point(330, 214);
            this.B_Twich.Name = "B_Twich";
            this.B_Twich.Size = new System.Drawing.Size(140, 23);
            this.B_Twich.TabIndex = 1;
            this.B_Twich.Text = "By Twich";
            this.B_Twich.UseVisualStyleBackColor = true;
            this.B_Twich.Click += new System.EventHandler(this.B_Twich_Click);
            // 
            // B_Facebook
            // 
            this.B_Facebook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Facebook.Location = new System.Drawing.Point(330, 185);
            this.B_Facebook.Name = "B_Facebook";
            this.B_Facebook.Size = new System.Drawing.Size(140, 23);
            this.B_Facebook.TabIndex = 2;
            this.B_Facebook.Text = "By Facebook";
            this.B_Facebook.UseVisualStyleBackColor = true;
            // 
            // B_Gmail
            // 
            this.B_Gmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Gmail.Location = new System.Drawing.Point(330, 156);
            this.B_Gmail.Name = "B_Gmail";
            this.B_Gmail.Size = new System.Drawing.Size(140, 23);
            this.B_Gmail.TabIndex = 3;
            this.B_Gmail.Text = "By Gmail";
            this.B_Gmail.UseVisualStyleBackColor = true;
            this.B_Gmail.Click += new System.EventHandler(this.button3_Click);
            // 
            // LoginWithoutMGSAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_Gmail);
            this.Controls.Add(this.B_Facebook);
            this.Controls.Add(this.B_Twich);
            this.Name = "LoginWithoutMGSAccount";
            this.Text = "LoginWithoutMGSAccount";
            this.Load += new System.EventHandler(this.LoginWithoutMGSAccount_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Twich;
        private System.Windows.Forms.Button B_Facebook;
        private System.Windows.Forms.Button B_Gmail;
    }
}