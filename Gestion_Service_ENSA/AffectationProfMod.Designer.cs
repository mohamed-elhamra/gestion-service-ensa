namespace Gestion_Service_ENSA
{
    partial class AffectationProfMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffectationProfMod));
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.affecter = new System.Windows.Forms.Button();
            this.dateText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.professeur = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.module = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroButton2 = new System.Windows.Forms.Button();
            this.cin = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.affecter);
            this.metroPanel3.Controls.Add(this.dateText);
            this.metroPanel3.Controls.Add(this.metroLabel15);
            this.metroPanel3.Controls.Add(this.professeur);
            this.metroPanel3.Controls.Add(this.metroLabel10);
            this.metroPanel3.Controls.Add(this.module);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.metroLabel11);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 6;
            this.metroPanel3.Location = new System.Drawing.Point(76, 90);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(311, 333);
            this.metroPanel3.TabIndex = 35;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 7;
            this.metroPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel3_Paint);
            // 
            // affecter
            // 
            this.affecter.BackColor = System.Drawing.Color.DarkTurquoise;
            this.affecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.affecter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.affecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affecter.Image = ((System.Drawing.Image)(resources.GetObject("affecter.Image")));
            this.affecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.affecter.Location = new System.Drawing.Point(97, 250);
            this.affecter.Name = "affecter";
            this.affecter.Size = new System.Drawing.Size(135, 46);
            this.affecter.TabIndex = 72;
            this.affecter.Text = "       AFFECTER";
            this.affecter.UseVisualStyleBackColor = false;
            this.affecter.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(144, 192);
            this.dateText.Margin = new System.Windows.Forms.Padding(2);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(129, 26);
            this.dateText.TabIndex = 40;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(29, 199);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(111, 19);
            this.metroLabel15.TabIndex = 39;
            this.metroLabel15.Text = "date d\'affectation";
            // 
            // professeur
            // 
            this.professeur.FormattingEnabled = true;
            this.professeur.ItemHeight = 23;
            this.professeur.Location = new System.Drawing.Point(145, 91);
            this.professeur.Margin = new System.Windows.Forms.Padding(2);
            this.professeur.Name = "professeur";
            this.professeur.Size = new System.Drawing.Size(128, 29);
            this.professeur.TabIndex = 37;
            this.professeur.SelectedIndexChanged += new System.EventHandler(this.professeur_SelectedIndexChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(29, 100);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(70, 19);
            this.metroLabel10.TabIndex = 36;
            this.metroLabel10.Text = "Professeur";
            // 
            // module
            // 
            this.module.FormattingEnabled = true;
            this.module.ItemHeight = 23;
            this.module.Location = new System.Drawing.Point(144, 143);
            this.module.Margin = new System.Windows.Forms.Padding(2);
            this.module.Name = "module";
            this.module.Size = new System.Drawing.Size(128, 29);
            this.module.TabIndex = 35;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(29, 152);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 34;
            this.metroLabel3.Text = "Module";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(38, 11);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(216, 19);
            this.metroLabel11.TabIndex = 18;
            this.metroLabel11.Text = "Affecter un module a un professeur";
            // 
            // metroPanel4
            // 
            this.metroPanel4.AutoSize = true;
            this.metroPanel4.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.metroButton2);
            this.metroPanel4.Controls.Add(this.cin);
            this.metroPanel4.Controls.Add(this.metroLabel13);
            this.metroPanel4.Controls.Add(this.metroLabel14);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 6;
            this.metroPanel4.Location = new System.Drawing.Point(445, 90);
            this.metroPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(333, 333);
            this.metroPanel4.TabIndex = 37;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 7;
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.metroButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroButton2.Image = ((System.Drawing.Image)(resources.GetObject("metroButton2.Image")));
            this.metroButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroButton2.Location = new System.Drawing.Point(117, 250);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(135, 46);
            this.metroButton2.TabIndex = 71;
            this.metroButton2.Text = "       CHERCHER";
            this.metroButton2.UseVisualStyleBackColor = false;
            this.metroButton2.Click += new System.EventHandler(this.button6_Click);
            // 
            // cin
            // 
            this.cin.FormattingEnabled = true;
            this.cin.ItemHeight = 23;
            this.cin.Location = new System.Drawing.Point(108, 137);
            this.cin.Margin = new System.Windows.Forms.Padding(2);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(177, 29);
            this.cin.TabIndex = 20;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(54, 10);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(171, 19);
            this.metroLabel13.TabIndex = 18;
            this.metroLabel13.Text = "Recherche module par prof";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(26, 143);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(70, 19);
            this.metroLabel14.TabIndex = 16;
            this.metroLabel14.Text = "Professeur";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 563);
            this.panel1.TabIndex = 39;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 72);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(345, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 48);
            this.button1.TabIndex = 76;
            this.button1.Text = "    RETOUR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AffectationProfMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 561);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.panel1);
            this.Name = "AffectationProfMod";
            this.Text = "AffectationProfMod";
            this.Load += new System.EventHandler(this.AffectationProfMod_Load);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTextBox dateText;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroComboBox professeur;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox module;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroComboBox cin;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button metroButton2;
        private System.Windows.Forms.Button affecter;
    }
}