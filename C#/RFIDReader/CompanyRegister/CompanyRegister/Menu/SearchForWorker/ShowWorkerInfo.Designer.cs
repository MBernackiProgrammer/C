
namespace CompanyRegister.Menu.SearchForWorker
{
    partial class ShowWorkerInfo
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
            this.L_RoomNumber = new System.Windows.Forms.Label();
            this.L_PhoneNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_WorkerInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GB_WorkerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Location = new System.Drawing.Point(122, 18);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(45, 17);
            this.L_Name.TabIndex = 0;
            this.L_Name.Text = "Name";
            // 
            // L_Surname
            // 
            this.L_Surname.AutoSize = true;
            this.L_Surname.Location = new System.Drawing.Point(122, 39);
            this.L_Surname.Name = "L_Surname";
            this.L_Surname.Size = new System.Drawing.Size(65, 17);
            this.L_Surname.TabIndex = 1;
            this.L_Surname.Text = "Surname";
            // 
            // L_RoomNumber
            // 
            this.L_RoomNumber.AutoSize = true;
            this.L_RoomNumber.Location = new System.Drawing.Point(122, 77);
            this.L_RoomNumber.Name = "L_RoomNumber";
            this.L_RoomNumber.Size = new System.Drawing.Size(97, 17);
            this.L_RoomNumber.TabIndex = 2;
            this.L_RoomNumber.Text = "Room number";
            // 
            // L_PhoneNumber
            // 
            this.L_PhoneNumber.AutoSize = true;
            this.L_PhoneNumber.Location = new System.Drawing.Point(122, 60);
            this.L_PhoneNumber.Name = "L_PhoneNumber";
            this.L_PhoneNumber.Size = new System.Drawing.Size(101, 17);
            this.L_PhoneNumber.TabIndex = 3;
            this.L_PhoneNumber.Text = "Phone number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imię :";
            // 
            // GB_WorkerInfo
            // 
            this.GB_WorkerInfo.Controls.Add(this.label4);
            this.GB_WorkerInfo.Controls.Add(this.L_RoomNumber);
            this.GB_WorkerInfo.Controls.Add(this.L_PhoneNumber);
            this.GB_WorkerInfo.Controls.Add(this.label3);
            this.GB_WorkerInfo.Controls.Add(this.L_Name);
            this.GB_WorkerInfo.Controls.Add(this.label2);
            this.GB_WorkerInfo.Controls.Add(this.label1);
            this.GB_WorkerInfo.Controls.Add(this.L_Surname);
            this.GB_WorkerInfo.Location = new System.Drawing.Point(12, 12);
            this.GB_WorkerInfo.Name = "GB_WorkerInfo";
            this.GB_WorkerInfo.Size = new System.Drawing.Size(286, 144);
            this.GB_WorkerInfo.TabIndex = 5;
            this.GB_WorkerInfo.TabStop = false;
            this.GB_WorkerInfo.Text = "Dane pracownika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwisko :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numer telefonu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numer pokoju :";
            // 
            // ShowWorkerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 170);
            this.Controls.Add(this.GB_WorkerInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowWorkerInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Dane pracownika";
            this.Load += new System.EventHandler(this.ShowWorkerInfo_Load);
            this.GB_WorkerInfo.ResumeLayout(false);
            this.GB_WorkerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.Label L_Surname;
        private System.Windows.Forms.Label L_RoomNumber;
        private System.Windows.Forms.Label L_PhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_WorkerInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}