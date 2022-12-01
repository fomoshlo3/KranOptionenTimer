namespace UKranOptionenTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CmdStart = new System.Windows.Forms.Button();
            this.CmdStop = new System.Windows.Forms.Button();
            this.OptKranEin = new System.Windows.Forms.RadioButton();
            this.OptKranAus = new System.Windows.Forms.RadioButton();
            this.OptKranLinks = new System.Windows.Forms.RadioButton();
            this.OptKranRechts = new System.Windows.Forms.RadioButton();
            this.OptAuslegerEin = new System.Windows.Forms.RadioButton();
            this.OptAuslegerAus = new System.Windows.Forms.RadioButton();
            this.OptHakenEin = new System.Windows.Forms.RadioButton();
            this.OptHakenAus = new System.Windows.Forms.RadioButton();
            this.h = new System.Windows.Forms.Panel();
            this.a = new System.Windows.Forms.Panel();
            this.s = new System.Windows.Forms.Panel();
            this.f = new System.Windows.Forms.Panel();
            this.TimKran = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(266, 256);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(50, 23);
            this.CmdStart.TabIndex = 35;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // CmdStop
            // 
            this.CmdStop.Location = new System.Drawing.Point(322, 256);
            this.CmdStop.Name = "CmdStop";
            this.CmdStop.Size = new System.Drawing.Size(50, 23);
            this.CmdStop.TabIndex = 34;
            this.CmdStop.Text = "Stop";
            this.CmdStop.UseVisualStyleBackColor = true;
            this.CmdStop.Click += new System.EventHandler(this.CmdStop_Click);
            // 
            // OptKranEin
            // 
            this.OptKranEin.AutoSize = true;
            this.OptKranEin.Location = new System.Drawing.Point(282, 187);
            this.OptKranEin.Name = "OptKranEin";
            this.OptKranEin.Size = new System.Drawing.Size(68, 19);
            this.OptKranEin.TabIndex = 33;
            this.OptKranEin.Text = "Kran ein";
            this.OptKranEin.UseVisualStyleBackColor = true;
            // 
            // OptKranAus
            // 
            this.OptKranAus.AutoSize = true;
            this.OptKranAus.Location = new System.Drawing.Point(282, 162);
            this.OptKranAus.Name = "OptKranAus";
            this.OptKranAus.Size = new System.Drawing.Size(70, 19);
            this.OptKranAus.TabIndex = 32;
            this.OptKranAus.Text = "Kran aus";
            this.OptKranAus.UseVisualStyleBackColor = true;
            // 
            // OptKranLinks
            // 
            this.OptKranLinks.AutoSize = true;
            this.OptKranLinks.Location = new System.Drawing.Point(282, 137);
            this.OptKranLinks.Name = "OptKranLinks";
            this.OptKranLinks.Size = new System.Drawing.Size(76, 19);
            this.OptKranLinks.TabIndex = 31;
            this.OptKranLinks.Text = "Kran links";
            this.OptKranLinks.UseVisualStyleBackColor = true;
            // 
            // OptKranRechts
            // 
            this.OptKranRechts.AutoSize = true;
            this.OptKranRechts.Location = new System.Drawing.Point(282, 112);
            this.OptKranRechts.Name = "OptKranRechts";
            this.OptKranRechts.Size = new System.Drawing.Size(84, 19);
            this.OptKranRechts.TabIndex = 30;
            this.OptKranRechts.Text = "Kran rechts";
            this.OptKranRechts.UseVisualStyleBackColor = true;
            // 
            // OptAuslegerEin
            // 
            this.OptAuslegerEin.AutoSize = true;
            this.OptAuslegerEin.Location = new System.Drawing.Point(282, 87);
            this.OptAuslegerEin.Name = "OptAuslegerEin";
            this.OptAuslegerEin.Size = new System.Drawing.Size(90, 19);
            this.OptAuslegerEin.TabIndex = 29;
            this.OptAuslegerEin.Text = "Ausleger ein";
            this.OptAuslegerEin.UseVisualStyleBackColor = true;
            // 
            // OptAuslegerAus
            // 
            this.OptAuslegerAus.AutoSize = true;
            this.OptAuslegerAus.Location = new System.Drawing.Point(282, 62);
            this.OptAuslegerAus.Name = "OptAuslegerAus";
            this.OptAuslegerAus.Size = new System.Drawing.Size(92, 19);
            this.OptAuslegerAus.TabIndex = 28;
            this.OptAuslegerAus.Text = "Ausleger aus";
            this.OptAuslegerAus.UseVisualStyleBackColor = true;
            // 
            // OptHakenEin
            // 
            this.OptHakenEin.AutoSize = true;
            this.OptHakenEin.Location = new System.Drawing.Point(282, 37);
            this.OptHakenEin.Name = "OptHakenEin";
            this.OptHakenEin.Size = new System.Drawing.Size(78, 19);
            this.OptHakenEin.TabIndex = 27;
            this.OptHakenEin.Text = "Haken ein";
            this.OptHakenEin.UseVisualStyleBackColor = true;
            // 
            // OptHakenAus
            // 
            this.OptHakenAus.AutoSize = true;
            this.OptHakenAus.Checked = true;
            this.OptHakenAus.Location = new System.Drawing.Point(282, 12);
            this.OptHakenAus.Name = "OptHakenAus";
            this.OptHakenAus.Size = new System.Drawing.Size(80, 19);
            this.OptHakenAus.TabIndex = 26;
            this.OptHakenAus.TabStop = true;
            this.OptHakenAus.Text = "Haken aus";
            this.OptHakenAus.UseVisualStyleBackColor = true;
            // 
            // h
            // 
            this.h.BackColor = System.Drawing.Color.Blue;
            this.h.Location = new System.Drawing.Point(97, 138);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(10, 20);
            this.h.TabIndex = 25;
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Yellow;
            this.a.Location = new System.Drawing.Point(97, 128);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(50, 10);
            this.a.TabIndex = 24;
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.Color.Green;
            this.s.Location = new System.Drawing.Point(147, 128);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(10, 100);
            this.s.TabIndex = 23;
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.Red;
            this.f.Location = new System.Drawing.Point(127, 228);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(50, 10);
            this.f.TabIndex = 22;
            // 
            // TimKran
            // 
            this.TimKran.Interval = 500;
            this.TimKran.Tick += new System.EventHandler(this.TimKran_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.CmdStop);
            this.Controls.Add(this.OptKranEin);
            this.Controls.Add(this.OptKranAus);
            this.Controls.Add(this.OptKranLinks);
            this.Controls.Add(this.OptKranRechts);
            this.Controls.Add(this.OptAuslegerEin);
            this.Controls.Add(this.OptAuslegerAus);
            this.Controls.Add(this.OptHakenEin);
            this.Controls.Add(this.OptHakenAus);
            this.Controls.Add(this.h);
            this.Controls.Add(this.a);
            this.Controls.Add(this.s);
            this.Controls.Add(this.f);
            this.Name = "Form1";
            this.Text = "Kran, Optionen und Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CmdStart;
        private Button CmdStop;
        private RadioButton OptKranEin;
        private RadioButton OptKranAus;
        private RadioButton OptKranLinks;
        private RadioButton OptKranRechts;
        private RadioButton OptAuslegerEin;
        private RadioButton OptAuslegerAus;
        private RadioButton OptHakenEin;
        private RadioButton OptHakenAus;
        private Panel h;
        private Panel a;
        private Panel s;
        private Panel f;
        private System.Windows.Forms.Timer TimKran;
    }
}