namespace ZadanieRekrutacyjneITC
{
    partial class MainView
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
            this.sBClients = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // sBClients
            // 
            this.sBClients.Location = new System.Drawing.Point(12, 12);
            this.sBClients.Name = "sBClients";
            this.sBClients.Size = new System.Drawing.Size(221, 54);
            this.sBClients.TabIndex = 0;
            this.sBClients.Text = "Klienci";
            this.sBClients.Click += new System.EventHandler(this.sBClients_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(239, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(221, 54);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Dokumenty";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 91);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.sBClients);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sBClients;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

