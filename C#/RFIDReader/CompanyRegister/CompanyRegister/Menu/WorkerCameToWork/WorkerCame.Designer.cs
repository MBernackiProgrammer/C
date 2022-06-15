
namespace CompanyRegister.Menu.WorkerCameToWork
{
    partial class WorkerCame
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
            this.L_Name = new System.Windows.Forms.Label();
            this.L_Surname = new System.Windows.Forms.Label();
            this.L_PhoneNumber = new System.Windows.Forms.Label();
            this.L_RoomNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Location = new System.Drawing.Point(0, 0);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(46, 17);
            this.L_Name.TabIndex = 0;
            this.L_Name.Text = "label1";
            // 
            // L_Surname
            // 
            this.L_Surname.AutoSize = true;
            this.L_Surname.Location = new System.Drawing.Point(3, 21);
            this.L_Surname.Name = "L_Surname";
            this.L_Surname.Size = new System.Drawing.Size(46, 17);
            this.L_Surname.TabIndex = 1;
            this.L_Surname.Text = "label1";
            // 
            // L_PhoneNumber
            // 
            this.L_PhoneNumber.AutoSize = true;
            this.L_PhoneNumber.Location = new System.Drawing.Point(3, 42);
            this.L_PhoneNumber.Name = "L_PhoneNumber";
            this.L_PhoneNumber.Size = new System.Drawing.Size(46, 17);
            this.L_PhoneNumber.TabIndex = 2;
            this.L_PhoneNumber.Text = "label1";
            // 
            // L_RoomNumber
            // 
            this.L_RoomNumber.AutoSize = true;
            this.L_RoomNumber.Location = new System.Drawing.Point(3, 63);
            this.L_RoomNumber.Name = "L_RoomNumber";
            this.L_RoomNumber.Size = new System.Drawing.Size(46, 17);
            this.L_RoomNumber.TabIndex = 3;
            this.L_RoomNumber.Text = "label1";
            // 
            // WorkerCame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.L_RoomNumber);
            this.Controls.Add(this.L_PhoneNumber);
            this.Controls.Add(this.L_Surname);
            this.Controls.Add(this.L_Name);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WorkerCame";
            this.Text = "WorkerCame";
            this.Load += new System.EventHandler(this.WorkerCame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.Label L_Surname;
        private System.Windows.Forms.Label L_PhoneNumber;
        private System.Windows.Forms.Label L_RoomNumber;
    }
}