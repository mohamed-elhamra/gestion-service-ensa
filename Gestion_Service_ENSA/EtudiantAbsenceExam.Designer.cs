namespace Gestion_Service_ENSA
{
    partial class EtudiantAbsenceExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EtudiantAbsenceExam));
            this.module = new MetroFramework.Controls.MetroComboBox();
            this.cne = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.noteButton = new System.Windows.Forms.Button();
            this.absenceButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // module
            // 
            this.module.FormattingEnabled = true;
            this.module.ItemHeight = 23;
            this.module.Location = new System.Drawing.Point(220, 203);
            this.module.Margin = new System.Windows.Forms.Padding(2);
            this.module.Name = "module";
            this.module.Size = new System.Drawing.Size(125, 29);
            this.module.TabIndex = 0;
            // 
            // cne
            // 
            this.cne.Location = new System.Drawing.Point(251, 117);
            this.cne.Name = "cne";
            this.cne.ReadOnly = true;
            this.cne.Size = new System.Drawing.Size(95, 20);
            this.cne.TabIndex = 4;
            this.cne.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.noteButton);
            this.panel1.Controls.Add(this.absenceButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cne);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 503);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(279, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(157, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Module";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(165, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Votre CNE";
            // 
            // noteButton
            // 
            this.noteButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.noteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.noteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteButton.ForeColor = System.Drawing.Color.Black;
            this.noteButton.Image = ((System.Drawing.Image)(resources.GetObject("noteButton.Image")));
            this.noteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.noteButton.Location = new System.Drawing.Point(71, 256);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(205, 50);
            this.noteButton.TabIndex = 81;
            this.noteButton.Text = "    Afficher Notes";
            this.noteButton.UseVisualStyleBackColor = false;
            this.noteButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // absenceButton
            // 
            this.absenceButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.absenceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.absenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.absenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absenceButton.ForeColor = System.Drawing.Color.Black;
            this.absenceButton.Image = ((System.Drawing.Image)(resources.GetObject("absenceButton.Image")));
            this.absenceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.absenceButton.Location = new System.Drawing.Point(282, 256);
            this.absenceButton.Name = "absenceButton";
            this.absenceButton.Size = new System.Drawing.Size(199, 50);
            this.absenceButton.TabIndex = 82;
            this.absenceButton.Text = "         Afficher Absences";
            this.absenceButton.UseVisualStyleBackColor = false;
            this.absenceButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(221, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 53);
            this.button1.TabIndex = 83;
            this.button1.Text = "    RETOUR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 85);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(81, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 33);
            this.label7.TabIndex = 85;
            this.label7.Text = "Service Etudiant";
            // 
            // EtudiantAbsenceExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 497);
            this.Controls.Add(this.module);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EtudiantAbsenceExam";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Text = "EtudiantAbsenceExam";
            this.Load += new System.EventHandler(this.EtudiantAbsenceExam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox module;
        private System.Windows.Forms.TextBox cne;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button noteButton;
        private System.Windows.Forms.Button absenceButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}