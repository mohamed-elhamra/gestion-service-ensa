namespace Gestion_Service_ENSA
{
    partial class AdminScolAbsence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScolAbsence));
            this.etud = new MetroFramework.Controls.MetroComboBox();
            this.modules = new MetroFramework.Controls.MetroComboBox();
            this.pr = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.absence = new MetroFramework.Controls.MetroComboBox();
            this.metroButton2 = new System.Windows.Forms.Button();
            this.metroButton5 = new System.Windows.Forms.Button();
            this.metroButton4 = new System.Windows.Forms.Button();
            this.metroLabel6 = new System.Windows.Forms.Label();
            this.metroLabel5 = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.metroLabel4 = new System.Windows.Forms.Label();
            this.justi = new System.Windows.Forms.TextBox();
            this.fin = new MetroFramework.Controls.MetroTextBox();
            this.debut = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.C = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.metroLabel3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // etud
            // 
            this.etud.FormattingEnabled = true;
            this.etud.ItemHeight = 23;
            this.etud.Location = new System.Drawing.Point(310, 224);
            this.etud.Name = "etud";
            this.etud.Size = new System.Drawing.Size(209, 29);
            this.etud.TabIndex = 25;
            this.etud.SelectedIndexChanged += new System.EventHandler(this.etud_SelectedIndexChanged);
            // 
            // modules
            // 
            this.modules.FormattingEnabled = true;
            this.modules.ItemHeight = 23;
            this.modules.Location = new System.Drawing.Point(310, 165);
            this.modules.Name = "modules";
            this.modules.Size = new System.Drawing.Size(209, 29);
            this.modules.TabIndex = 24;
            this.modules.SelectedIndexChanged += new System.EventHandler(this.modules_SelectedIndexChanged);
            // 
            // pr
            // 
            this.pr.FormattingEnabled = true;
            this.pr.ItemHeight = 23;
            this.pr.Location = new System.Drawing.Point(310, 109);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(209, 29);
            this.pr.TabIndex = 27;
            this.pr.SelectedIndexChanged += new System.EventHandler(this.pr_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.groupBox1.Controls.Add(this.absence);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.metroButton5);
            this.groupBox1.Controls.Add(this.metroButton4);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.passlabel);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.justi);
            this.groupBox1.Controls.Add(this.fin);
            this.groupBox1.Controls.Add(this.debut);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Turquoise;
            this.groupBox1.Location = new System.Drawing.Point(188, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 370);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ABSENCE";
            // 
            // absence
            // 
            this.absence.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.absence.FormattingEnabled = true;
            this.absence.ItemHeight = 23;
            this.absence.Location = new System.Drawing.Point(122, 63);
            this.absence.Name = "absence";
            this.absence.Size = new System.Drawing.Size(199, 29);
            this.absence.TabIndex = 32;
            this.absence.Theme = MetroFramework.MetroThemeStyle.Light;
            this.absence.SelectedIndexChanged += new System.EventHandler(this.absence_SelectedIndexChanged);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.metroButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroButton2.ForeColor = System.Drawing.Color.Black;
            this.metroButton2.Image = ((System.Drawing.Image)(resources.GetObject("metroButton2.Image")));
            this.metroButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroButton2.Location = new System.Drawing.Point(13, 294);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(125, 50);
            this.metroButton2.TabIndex = 78;
            this.metroButton2.Text = "    RESET";
            this.metroButton2.UseVisualStyleBackColor = false;
            this.metroButton2.Click += new System.EventHandler(this.button3_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.metroButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.metroButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroButton5.ForeColor = System.Drawing.Color.Black;
            this.metroButton5.Image = ((System.Drawing.Image)(resources.GetObject("metroButton5.Image")));
            this.metroButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroButton5.Location = new System.Drawing.Point(144, 294);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(130, 50);
            this.metroButton5.TabIndex = 78;
            this.metroButton5.Text = "      AJOUTER";
            this.metroButton5.UseVisualStyleBackColor = false;
            this.metroButton5.Click += new System.EventHandler(this.button4_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.metroButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.metroButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroButton4.ForeColor = System.Drawing.Color.Black;
            this.metroButton4.Image = ((System.Drawing.Image)(resources.GetObject("metroButton4.Image")));
            this.metroButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroButton4.Location = new System.Drawing.Point(277, 294);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(126, 50);
            this.metroButton4.TabIndex = 78;
            this.metroButton4.Text = "      MODIFIER";
            this.metroButton4.UseVisualStyleBackColor = false;
            this.metroButton4.Click += new System.EventHandler(this.button5_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel6.Location = new System.Drawing.Point(24, 190);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(97, 17);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Justification";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel5.Location = new System.Drawing.Point(51, 147);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 17);
            this.metroLabel5.TabIndex = 34;
            this.metroLabel5.Text = "Date Fin";
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passlabel.Location = new System.Drawing.Point(29, 111);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(89, 17);
            this.passlabel.TabIndex = 29;
            this.passlabel.Text = "Date Debut";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel4.Location = new System.Drawing.Point(47, 69);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 17);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Absence";
            // 
            // justi
            // 
            this.justi.Location = new System.Drawing.Point(123, 188);
            this.justi.Multiline = true;
            this.justi.Name = "justi";
            this.justi.Size = new System.Drawing.Size(199, 81);
            this.justi.TabIndex = 17;
            // 
            // fin
            // 
            this.fin.Location = new System.Drawing.Point(122, 145);
            this.fin.Name = "fin";
            this.fin.Size = new System.Drawing.Size(200, 23);
            this.fin.TabIndex = 15;
            // 
            // debut
            // 
            this.debut.Location = new System.Drawing.Point(123, 109);
            this.debut.Name = "debut";
            this.debut.Size = new System.Drawing.Size(200, 23);
            this.debut.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.C);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 702);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.MediumTurquoise;
            this.C.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.C.Image = ((System.Drawing.Image)(resources.GetObject("C.Image")));
            this.C.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.C.Location = new System.Drawing.Point(3, 642);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(150, 48);
            this.C.TabIndex = 77;
            this.C.Text = "    RETOUR";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(86, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 33);
            this.label1.TabIndex = 30;
            this.label1.Text = "Scolarité";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 78);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(247, 171);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 17);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Module";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(237, 230);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 17);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Etudiant";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel3.Location = new System.Drawing.Point(211, 115);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 17);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Professseur";
            // 
            // AdminScolAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 697);
            this.Controls.Add(this.pr);
            this.Controls.Add(this.etud);
            this.Controls.Add(this.modules);
            this.Controls.Add(this.panel1);
            this.Name = "AdminScolAbsence";
            this.Text = "AdminScolAbsence";
            this.Load += new System.EventHandler(this.AdminScolAbsence_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox etud;
        private MetroFramework.Controls.MetroComboBox modules;
        private MetroFramework.Controls.MetroComboBox pr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox justi;
        private MetroFramework.Controls.MetroTextBox fin;
        private MetroFramework.Controls.MetroTextBox debut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.Label metroLabel4;
        private System.Windows.Forms.Label metroLabel3;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.Label metroLabel6;
        private System.Windows.Forms.Label metroLabel5;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button metroButton4;
        private System.Windows.Forms.Button metroButton5;
        private System.Windows.Forms.Button metroButton2;
        private MetroFramework.Controls.MetroComboBox absence;
    }
}