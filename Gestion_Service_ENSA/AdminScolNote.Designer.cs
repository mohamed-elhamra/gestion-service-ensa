namespace Gestion_Service_ENSA
{
    partial class AdminScolNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScolNote));
            this.pr = new MetroFramework.Controls.MetroComboBox();
            this.etud = new MetroFramework.Controls.MetroComboBox();
            this.modules = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateexam = new MetroFramework.Controls.MetroTextBox();
            this.note = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.metroLabel3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton4 = new System.Windows.Forms.Button();
            this.metroButton1 = new System.Windows.Forms.Button();
            this.metroButton2 = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pr
            // 
            this.pr.FormattingEnabled = true;
            this.pr.ItemHeight = 23;
            this.pr.Location = new System.Drawing.Point(321, 96);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(209, 29);
            this.pr.TabIndex = 33;
            this.pr.SelectedIndexChanged += new System.EventHandler(this.pr_SelectedIndexChanged);
            // 
            // etud
            // 
            this.etud.FormattingEnabled = true;
            this.etud.ItemHeight = 23;
            this.etud.Location = new System.Drawing.Point(321, 211);
            this.etud.Name = "etud";
            this.etud.Size = new System.Drawing.Size(209, 29);
            this.etud.TabIndex = 31;
            this.etud.SelectedIndexChanged += new System.EventHandler(this.etud_SelectedIndexChanged);
            // 
            // modules
            // 
            this.modules.FormattingEnabled = true;
            this.modules.ItemHeight = 23;
            this.modules.Location = new System.Drawing.Point(321, 152);
            this.modules.Name = "modules";
            this.modules.Size = new System.Drawing.Size(209, 29);
            this.modules.TabIndex = 30;
            this.modules.SelectedIndexChanged += new System.EventHandler(this.modules_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.groupBox1.Controls.Add(this.metroButton4);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateexam);
            this.groupBox1.Controls.Add(this.note);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox1.Location = new System.Drawing.Point(224, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 282);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EXAMEN";
            // 
            // dateexam
            // 
            this.dateexam.Location = new System.Drawing.Point(136, 118);
            this.dateexam.Name = "dateexam";
            this.dateexam.Size = new System.Drawing.Size(199, 23);
            this.dateexam.TabIndex = 32;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(136, 81);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(199, 23);
            this.note.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.C);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 588);
            this.panel1.TabIndex = 35;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(257, 157);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 17);
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Text = "Module";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(247, 216);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 17);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "Etudiant";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel3.Location = new System.Drawing.Point(221, 101);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 17);
            this.metroLabel3.TabIndex = 36;
            this.metroLabel3.Text = "Professseur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(88, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Date d\'examen";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(86, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 33);
            this.label13.TabIndex = 93;
            this.label13.Text = "Scolarité";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 78);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
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
            this.metroButton4.Location = new System.Drawing.Point(8, 211);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(106, 50);
            this.metroButton4.TabIndex = 79;
            this.metroButton4.Text = "    RESET";
            this.metroButton4.UseVisualStyleBackColor = false;
            this.metroButton4.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.metroButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroButton1.ForeColor = System.Drawing.Color.Black;
            this.metroButton1.Image = ((System.Drawing.Image)(resources.GetObject("metroButton1.Image")));
            this.metroButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroButton1.Location = new System.Drawing.Point(126, 211);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(117, 50);
            this.metroButton1.TabIndex = 80;
            this.metroButton1.Text = "      AJOUTER";
            this.metroButton1.UseVisualStyleBackColor = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton5_Click);
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
            this.metroButton2.Location = new System.Drawing.Point(256, 211);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(122, 50);
            this.metroButton2.TabIndex = 81;
            this.metroButton2.Text = "        MODIFIER";
            this.metroButton2.UseVisualStyleBackColor = false;
            this.metroButton2.Click += new System.EventHandler(this.button2_Click);
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
            this.C.Location = new System.Drawing.Point(3, 537);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(150, 48);
            this.C.TabIndex = 94;
            this.C.Text = "    RETOUR";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // AdminScolNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 586);
            this.Controls.Add(this.pr);
            this.Controls.Add(this.etud);
            this.Controls.Add(this.modules);
            this.Controls.Add(this.panel1);
            this.Name = "AdminScolNote";
            this.Text = "AdminScolNote";
            this.Load += new System.EventHandler(this.AdminScolNote_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox pr;
        private MetroFramework.Controls.MetroComboBox etud;
        private MetroFramework.Controls.MetroComboBox modules;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox dateexam;
        private MetroFramework.Controls.MetroTextBox note;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.Label metroLabel3;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button metroButton4;
        private System.Windows.Forms.Button metroButton1;
        private System.Windows.Forms.Button metroButton2;
        private System.Windows.Forms.Button C;
    }
}