
namespace CompanyRegister.Menu.Settings
{
    partial class SettingsCOM
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.B_Save = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.L_WarningMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(320, 153);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // B_Save
            // 
            this.B_Save.Location = new System.Drawing.Point(375, 234);
            this.B_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(100, 28);
            this.B_Save.TabIndex = 1;
            this.B_Save.Text = "Zapisz";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // L_WarningMessage
            // 
            this.L_WarningMessage.AutoSize = true;
            this.L_WarningMessage.Location = new System.Drawing.Point(265, 94);
            this.L_WarningMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_WarningMessage.Name = "L_WarningMessage";
            this.L_WarningMessage.Size = new System.Drawing.Size(254, 17);
            this.L_WarningMessage.TabIndex = 2;
            this.L_WarningMessage.Text = "Nie udało nam się znalesść urządzenia";
            // 
            // SettingsCOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.L_WarningMessage);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SettingsCOM";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button B_Save;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label L_WarningMessage;
    }
}