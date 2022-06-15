
namespace CompanyRegister.Menu
{
    partial class MenuGL
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
            this.B_Search = new System.Windows.Forms.Button();
            this.B_ShowAllWorkers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.B_SearchWorkerByIDCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Search
            // 
            this.B_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Search.Location = new System.Drawing.Point(13, 13);
            this.B_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B_Search.Name = "B_Search";
            this.B_Search.Size = new System.Drawing.Size(264, 28);
            this.B_Search.TabIndex = 0;
            this.B_Search.Text = "Szukaj nowych bryloków";
            this.B_Search.UseVisualStyleBackColor = true;
            this.B_Search.Click += new System.EventHandler(this.B_Search_Click);
            // 
            // B_ShowAllWorkers
            // 
            this.B_ShowAllWorkers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_ShowAllWorkers.Location = new System.Drawing.Point(13, 49);
            this.B_ShowAllWorkers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.B_ShowAllWorkers.Name = "B_ShowAllWorkers";
            this.B_ShowAllWorkers.Size = new System.Drawing.Size(264, 28);
            this.B_ShowAllWorkers.TabIndex = 1;
            this.B_ShowAllWorkers.Text = "Wyświetl wszystkich pracowników";
            this.B_ShowAllWorkers.UseVisualStyleBackColor = true;
            this.B_ShowAllWorkers.Click += new System.EventHandler(this.B_ShowAllWorkers_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(13, 85);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Wyszukaj pracownika po ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // B_SearchWorkerByIDCard
            // 
            this.B_SearchWorkerByIDCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_SearchWorkerByIDCard.Location = new System.Drawing.Point(13, 121);
            this.B_SearchWorkerByIDCard.Margin = new System.Windows.Forms.Padding(4);
            this.B_SearchWorkerByIDCard.Name = "B_SearchWorkerByIDCard";
            this.B_SearchWorkerByIDCard.Size = new System.Drawing.Size(264, 54);
            this.B_SearchWorkerByIDCard.TabIndex = 3;
            this.B_SearchWorkerByIDCard.Text = "Wyszukaj pracownika po odczytu z karty";
            this.B_SearchWorkerByIDCard.UseVisualStyleBackColor = true;
            // 
            // MenuGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(298, 188);
            this.Controls.Add(this.B_SearchWorkerByIDCard);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.B_ShowAllWorkers);
            this.Controls.Add(this.B_Search);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuGL";
            this.Text = "MenuGL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Search;
        private System.Windows.Forms.Button B_ShowAllWorkers;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button B_SearchWorkerByIDCard;
    }
}