namespace Racing_Island_Lancher.Sites.MainPage
{
    partial class LauncherMainPage
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
            this.L_Welcome = new System.Windows.Forms.Label();
            this.B_LogOut = new System.Windows.Forms.Button();
            this.B_PlayGame = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.directory = new System.Windows.Forms.Label();
            this.B_UpDates = new System.Windows.Forms.Button();
            this.B_Community = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_Welcome
            // 
            this.L_Welcome.AutoSize = true;
            this.L_Welcome.Location = new System.Drawing.Point(13, 13);
            this.L_Welcome.Name = "L_Welcome";
            this.L_Welcome.Size = new System.Drawing.Size(85, 13);
            this.L_Welcome.TabIndex = 0;
            this.L_Welcome.Text = "Welcome back, ";
            // 
            // B_LogOut
            // 
            this.B_LogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.B_LogOut.Location = new System.Drawing.Point(16, 415);
            this.B_LogOut.Name = "B_LogOut";
            this.B_LogOut.Size = new System.Drawing.Size(75, 23);
            this.B_LogOut.TabIndex = 1;
            this.B_LogOut.Text = "Logout";
            this.B_LogOut.UseVisualStyleBackColor = true;
            this.B_LogOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // B_PlayGame
            // 
            this.B_PlayGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_PlayGame.Location = new System.Drawing.Point(713, 12);
            this.B_PlayGame.Name = "B_PlayGame";
            this.B_PlayGame.Size = new System.Drawing.Size(75, 23);
            this.B_PlayGame.TabIndex = 2;
            this.B_PlayGame.Text = "Play game";
            this.B_PlayGame.UseVisualStyleBackColor = true;
            this.B_PlayGame.Click += new System.EventHandler(this.B_PlayGame_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // directory
            // 
            this.directory.AutoSize = true;
            this.directory.Location = new System.Drawing.Point(649, 21);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(35, 13);
            this.directory.TabIndex = 3;
            this.directory.Text = "label1";
            // 
            // B_UpDates
            // 
            this.B_UpDates.Location = new System.Drawing.Point(16, 29);
            this.B_UpDates.Name = "B_UpDates";
            this.B_UpDates.Size = new System.Drawing.Size(75, 23);
            this.B_UpDates.TabIndex = 4;
            this.B_UpDates.Text = "Updates";
            this.B_UpDates.UseVisualStyleBackColor = true;
            // 
            // B_Community
            // 
            this.B_Community.Location = new System.Drawing.Point(16, 58);
            this.B_Community.Name = "B_Community";
            this.B_Community.Size = new System.Drawing.Size(75, 23);
            this.B_Community.TabIndex = 5;
            this.B_Community.Text = "Community";
            this.B_Community.UseVisualStyleBackColor = true;
            // 
            // LauncherMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_Community);
            this.Controls.Add(this.B_UpDates);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.B_PlayGame);
            this.Controls.Add(this.B_LogOut);
            this.Controls.Add(this.L_Welcome);
            this.Name = "LauncherMainPage";
            this.Text = "LauncherMainPage";
            this.Load += new System.EventHandler(this.LauncherMainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Welcome;
        private System.Windows.Forms.Button B_LogOut;
        private System.Windows.Forms.Button B_PlayGame;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label directory;
        private System.Windows.Forms.Button B_UpDates;
        private System.Windows.Forms.Button B_Community;
    }
}