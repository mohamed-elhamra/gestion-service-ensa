namespace Gestion_Service_ENSA
{
    partial class Prof
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prof));
            this.debut = new MetroFramework.Controls.MetroTextBox();
            this.modules = new MetroFramework.Controls.MetroComboBox();
            this.cc = new MetroFramework.Controls.MetroTextBox();
            this.etud = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.justi = new System.Windows.Forms.TextBox();
            this.fin = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateexam = new MetroFramework.Controls.MetroTextBox();
            this.note = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.metroButton1 = new System.Windows.Forms.Button();
            this.metroButton2 = new System.Windows.Forms.Button();
            this.metroButton5 = new System.Windows.Forms.Button();
            this.metroButton4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // debut
            // 
            this.debut.Location = new System.Drawing.Point(107, 40);
            this.debut.Name = "debut";
            this.debut.Size = new System.Drawing.Size(200, 23);
            this.debut.TabIndex = 11;
            // 
            // modules
            // 
            this.modules.FormattingEnabled = true;
            this.modules.ItemHeight = 23;
            this.modules.Location = new System.Drawing.Point(326, 160);
            this.modules.Name = "modules";
            this.modules.Size = new System.Drawing.Size(209, 29);
            this.modules.TabIndex = 18;
            this.modules.SelectedIndexChanged += new System.EventHandler(this.modules_SelectedIndexChanged);
            // 
            // cc
            // 
            this.cc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.cc.Enabled = false;
            this.cc.Location = new System.Drawing.Point(250, 94);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(68, 23);
            this.cc.TabIndex = 19;
            // 
            // etud
            // 
            this.etud.FormattingEnabled = true;
            this.etud.ItemHeight = 23;
            this.etud.Location = new System.Drawing.Point(326, 219);
            this.etud.Name = "etud";
            this.etud.Size = new System.Drawing.Size(209, 29);
            this.etud.TabIndex = 21;
            this.etud.SelectedIndexChanged += new System.EventHandler(this.etud_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.groupBox1.Controls.Add(this.metroButton5);
            this.groupBox1.Controls.Add(this.metroButton4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.justi);
            this.groupBox1.Controls.Add(this.fin);
            this.groupBox1.Controls.Add(this.debut);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Location = new System.Drawing.Point(441, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 294);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ABSENCE";
            // 
            // justi
            // 
            this.justi.Location = new System.Drawing.Point(108, 120);
            this.justi.Multiline = true;
            this.justi.Name = "justi";
            this.justi.Size = new System.Drawing.Size(199, 81);
            this.justi.TabIndex = 17;
            // 
            // fin
            // 
            this.fin.Location = new System.Drawing.Point(107, 78);
            this.fin.Name = "fin";
            this.fin.Size = new System.Drawing.Size(200, 23);
            this.fin.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.groupBox2.Controls.Add(this.metroButton1);
            this.groupBox2.Controls.Add(this.metroButton2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateexam);
            this.groupBox2.Controls.Add(this.note);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox2.Location = new System.Drawing.Point(29, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 294);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EXAMEN";
            // 
            // dateexam
            // 
            this.dateexam.Location = new System.Drawing.Point(139, 87);
            this.dateexam.Name = "dateexam";
            this.dateexam.Size = new System.Drawing.Size(199, 23);
            this.dateexam.TabIndex = 32;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(139, 49);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(199, 23);
            this.note.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(-6, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 674);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Justification";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Date Fin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Date Debut";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(22, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Date d\'examen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(93, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Note";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(267, 167);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 17);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Module";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(257, 226);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 17);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "Etudiant";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(172, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Votre CIN";
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
            this.metroButton1.Location = new System.Drawing.Point(50, 226);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(130, 50);
            this.metroButton1.TabIndex = 79;
            this.metroButton1.Text = "      AJOUTER";
            this.metroButton1.UseVisualStyleBackColor = false;
            this.metroButton1.Click += new System.EventHandler(this.button1_Click);
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
            this.metroButton2.Location = new System.Drawing.Point(212, 226);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(126, 50);
            this.metroButton2.TabIndex = 80;
            this.metroButton2.Text = "      MODIFIER";
            this.metroButton2.UseVisualStyleBackColor = false;
            this.metroButton2.Click += new System.EventHandler(this.button2_Click);
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
            this.metroButton5.Location = new System.Drawing.Point(57, 227);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(130, 50);
            this.metroButton5.TabIndex = 81;
            this.metroButton5.Text = "      AJOUTER";
            this.metroButton5.UseVisualStyleBackColor = false;
            this.metroButton5.Click += new System.EventHandler(this.button3_Click);
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
            this.metroButton4.Location = new System.Drawing.Point(223, 227);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(126, 50);
            this.metroButton4.TabIndex = 82;
            this.metroButton4.Text = "      MODIFIER";
            this.metroButton4.UseVisualStyleBackColor = false;
            this.metroButton4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(370, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 53);
            this.button1.TabIndex = 55;
            this.button1.Text = "    RETOUR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 68);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(81, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 33);
            this.label7.TabIndex = 59;
            this.label7.Text = "Service Professeur";
            // 
            // Prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 669);
            this.Controls.Add(this.etud);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.modules);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Prof";
            this.Text = "Prof";
            this.Load += new System.EventHandler(this.Prof_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox debut;
        private MetroFramework.Controls.MetroComboBox modules;
        private MetroFramework.Controls.MetroTextBox cc;
        private MetroFramework.Controls.MetroComboBox etud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox justi;
        private MetroFramework.Controls.MetroTextBox fin;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox dateexam;
        private MetroFramework.Controls.MetroTextBox note;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button metroButton1;
        private System.Windows.Forms.Button metroButton2;
        private System.Windows.Forms.Button metroButton5;
        private System.Windows.Forms.Button metroButton4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}