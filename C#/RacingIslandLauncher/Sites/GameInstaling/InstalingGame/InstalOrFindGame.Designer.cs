
namespace Racing_Island_Lancher.Sites.GameInstaling.InstalingGame
{
    partial class InstalOrFindGame
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
            this.B_Download = new System.Windows.Forms.Button();
            this.B_FindGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_Download
            // 
            this.B_Download.Location = new System.Drawing.Point(167, 204);
            this.B_Download.Name = "B_Download";
            this.B_Download.Size = new System.Drawing.Size(75, 23);
            this.B_Download.TabIndex = 0;
            this.B_Download.Text = "Download";
            this.B_Download.UseVisualStyleBackColor = true;
            // 
            // B_FindGame
            // 
            this.B_FindGame.Location = new System.Drawing.Point(249, 204);
            this.B_FindGame.Name = "B_FindGame";
            this.B_FindGame.Size = new System.Drawing.Size(75, 23);
            this.B_FindGame.TabIndex = 1;
            this.B_FindGame.Text = "Find";
            this.B_FindGame.UseVisualStyleBackColor = true;
            this.B_FindGame.Click += new System.EventHandler(this.B_FindGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "We didn\'t found in our files, please download game or fint it.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // InstalOrFindGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_FindGame);
            this.Controls.Add(this.B_Download);
            this.Name = "InstalOrFindGame";
            this.Text = "InstalOrFindGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Download;
        private System.Windows.Forms.Button B_FindGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
    }
}