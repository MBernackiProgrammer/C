namespace Racing_Island_Lancher.Sites.Account.Login
{
    partial class LoginTo
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
            this.Login = new System.Windows.Forms.TextBox();
            this.B_CreateAccount = new System.Windows.Forms.Button();
            this.B_Quite = new System.Windows.Forms.Button();
            this.Passworld = new System.Windows.Forms.TextBox();
            this.B_Login = new System.Windows.Forms.Button();
            this.B_LoginWitoutMGSAccount = new System.Windows.Forms.Button();
            this.B_FullScreen = new System.Windows.Forms.Button();
            this.B_Minimalize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AccessibleDescription = "";
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.Location = new System.Drawing.Point(304, 155);
            this.Login.Name = "Login";
            this.Login.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Login.Size = new System.Drawing.Size(183, 20);
            this.Login.TabIndex = 0;
            this.Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // B_CreateAccount
            // 
            this.B_CreateAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_CreateAccount.Location = new System.Drawing.Point(304, 253);
            this.B_CreateAccount.Name = "B_CreateAccount";
            this.B_CreateAccount.Size = new System.Drawing.Size(91, 25);
            this.B_CreateAccount.TabIndex = 1;
            this.B_CreateAccount.Text = "Create account";
            this.B_CreateAccount.UseVisualStyleBackColor = true;
            this.B_CreateAccount.Click += new System.EventHandler(this.B_CreateAccount_Click);
            // 
            // B_Quite
            // 
            this.B_Quite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Quite.Location = new System.Drawing.Point(713, 12);
            this.B_Quite.Name = "B_Quite";
            this.B_Quite.Size = new System.Drawing.Size(75, 23);
            this.B_Quite.TabIndex = 2;
            this.B_Quite.Text = "Quite";
            this.B_Quite.UseVisualStyleBackColor = true;
            this.B_Quite.Click += new System.EventHandler(this.B_Quite_Click);
            // 
            // Passworld
            // 
            this.Passworld.AccessibleDescription = "";
            this.Passworld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Passworld.Location = new System.Drawing.Point(304, 200);
            this.Passworld.Name = "Passworld";
            this.Passworld.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Passworld.Size = new System.Drawing.Size(183, 20);
            this.Passworld.TabIndex = 3;
            this.Passworld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // B_Login
            // 
            this.B_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Login.Location = new System.Drawing.Point(396, 253);
            this.B_Login.Name = "B_Login";
            this.B_Login.Size = new System.Drawing.Size(91, 25);
            this.B_Login.TabIndex = 4;
            this.B_Login.Text = "Login";
            this.B_Login.UseVisualStyleBackColor = true;
            this.B_Login.Click += new System.EventHandler(this.B_Login_Click);
            // 
            // B_LoginWitoutMGSAccount
            // 
            this.B_LoginWitoutMGSAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_LoginWitoutMGSAccount.Location = new System.Drawing.Point(304, 226);
            this.B_LoginWitoutMGSAccount.Name = "B_LoginWitoutMGSAccount";
            this.B_LoginWitoutMGSAccount.Size = new System.Drawing.Size(183, 25);
            this.B_LoginWitoutMGSAccount.TabIndex = 5;
            this.B_LoginWitoutMGSAccount.Text = "Login witout MGS Account";
            this.B_LoginWitoutMGSAccount.UseVisualStyleBackColor = true;
            this.B_LoginWitoutMGSAccount.Click += new System.EventHandler(this.B_LoginWitoutMGSAccount_Click);
            // 
            // B_FullScreen
            // 
            this.B_FullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_FullScreen.Location = new System.Drawing.Point(632, 12);
            this.B_FullScreen.Name = "B_FullScreen";
            this.B_FullScreen.Size = new System.Drawing.Size(75, 23);
            this.B_FullScreen.TabIndex = 6;
            this.B_FullScreen.Text = "Full screen";
            this.B_FullScreen.UseVisualStyleBackColor = true;
            this.B_FullScreen.Click += new System.EventHandler(this.B_FullScreen_Click);
            // 
            // B_Minimalize
            // 
            this.B_Minimalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Minimalize.Location = new System.Drawing.Point(551, 12);
            this.B_Minimalize.Name = "B_Minimalize";
            this.B_Minimalize.Size = new System.Drawing.Size(75, 23);
            this.B_Minimalize.TabIndex = 7;
            this.B_Minimalize.Text = "Minimalize";
            this.B_Minimalize.UseVisualStyleBackColor = true;
            this.B_Minimalize.Click += new System.EventHandler(this.B_Minimalize_Click);
            // 
            // LoginTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_Minimalize);
            this.Controls.Add(this.B_FullScreen);
            this.Controls.Add(this.B_LoginWitoutMGSAccount);
            this.Controls.Add(this.B_Login);
            this.Controls.Add(this.Passworld);
            this.Controls.Add(this.B_Quite);
            this.Controls.Add(this.B_CreateAccount);
            this.Controls.Add(this.Login);
            this.Name = "LoginTo";
            this.Text = "LoginTo";
            this.Load += new System.EventHandler(this.LoginTo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Button B_CreateAccount;
        private System.Windows.Forms.Button B_Quite;
        private System.Windows.Forms.TextBox Passworld;
        private System.Windows.Forms.Button B_Login;
        private System.Windows.Forms.Button B_LoginWitoutMGSAccount;
        private System.Windows.Forms.Button B_FullScreen;
        private System.Windows.Forms.Button B_Minimalize;
    }
}