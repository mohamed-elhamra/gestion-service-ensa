namespace Gestion_Service_ENSA
{
    partial class AffectationModEtud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffectationModEtud));
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.add = new System.Windows.Forms.Button();
            this.module = new System.Windows.Forms.ComboBox();
            this.cne = new System.Windows.Forms.ComboBox();
            this.label = new MetroFramework.Controls.MetroLabel();
            this.mod = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.rechercherButton = new System.Windows.Forms.Button();
            this.cnebox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.add);
            this.metroPanel3.Controls.Add(this.module);
            this.metroPanel3.Controls.Add(this.cne);
            this.metroPanel3.Controls.Add(this.label);
            this.metroPanel3.Controls.Add(this.mod);
            this.metroPanel3.Controls.Add(this.metroLabel11);
            this.metroPanel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 6;
            this.metroPanel3.Location = new System.Drawing.Point(88, 97);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(314, 294);
            this.metroPanel3.TabIndex = 35;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 7;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.DarkTurquoise;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.Location = new System.Drawing.Point(104, 209);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(135, 46);
            this.add.TabIndex = 73;
            this.add.Text = "       AFFECTER";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.affecter_Click);
            // 
            // module
            // 
            this.module.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.module.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.module.FormattingEnabled = true;
            this.module.Location = new System.Drawing.Point(104, 129);
            this.module.Name = "module";
            this.module.Size = new System.Drawing.Size(152, 23);
            this.module.TabIndex = 41;
            this.module.SelectedIndexChanged += new System.EventHandler(this.module_SelectedIndexChanged_1);
            // 
            // cne
            // 
            this.cne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cne.FormattingEnabled = true;
            this.cne.Location = new System.Drawing.Point(104, 74);
            this.cne.Name = "cne";
            this.cne.Size = new System.Drawing.Size(152, 23);
            this.cne.TabIndex = 41;
            this.cne.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(64, 74);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 19);
            this.label.TabIndex = 36;
            this.label.Text = "CNE";
            // 
            // mod
            // 
            this.mod.AutoSize = true;
            this.mod.Location = new System.Drawing.Point(45, 129);
            this.mod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(54, 19);
            this.mod.TabIndex = 34;
            this.mod.Text = "Module";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.ForeColor = System.Drawing.Color.Black;
            this.metroLabel11.Location = new System.Drawing.Point(22, 12);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(264, 25);
            this.metroLabel11.TabIndex = 18;
            this.metroLabel11.Text = "Affecter un Module a un Etudiant";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(60, 99);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(35, 19);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "CNE";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(77, 12);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(174, 25);
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "Rechercher par CNE :";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.rechercherButton);
            this.metroPanel2.Controls.Add(this.cnebox);
            this.metroPanel2.Controls.Add(this.metroLabel9);
            this.metroPanel2.Controls.Add(this.metroLabel8);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 6;
            this.metroPanel2.Location = new System.Drawing.Point(440, 97);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(322, 294);
            this.metroPanel2.TabIndex = 36;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 7;
            // 
            // rechercherButton
            // 
            this.rechercherButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.rechercherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rechercherButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rechercherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercherButton.Image = ((System.Drawing.Image)(resources.GetObject("rechercherButton.Image")));
            this.rechercherButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rechercherButton.Location = new System.Drawing.Point(109, 209);
            this.rechercherButton.Name = "rechercherButton";
            this.rechercherButton.Size = new System.Drawing.Size(135, 46);
            this.rechercherButton.TabIndex = 72;
            this.rechercherButton.Text = "       CHERCHER";
            this.rechercherButton.UseVisualStyleBackColor = false;
            this.rechercherButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // cnebox
            // 
            this.cnebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cnebox.DropDownWidth = 152;
            this.cnebox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnebox.FormattingEnabled = true;
            this.cnebox.IntegralHeight = false;
            this.cnebox.Location = new System.Drawing.Point(109, 97);
            this.cnebox.Name = "cnebox";
            this.cnebox.Size = new System.Drawing.Size(152, 23);
            this.cnebox.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.metroPanel2);
            this.panel1.Controls.Add(this.metroPanel3);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 508);
            this.panel1.TabIndex = 38;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.button1.Location = new System.Drawing.Point(335, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 48);
            this.button1.TabIndex = 75;
            this.button1.Text = "    RETOUR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 71);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // AffectationModEtud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 506);
            this.Controls.Add(this.panel1);
            this.Name = "AffectationModEtud";
            this.Text = "AffectationModEtud";
            this.Load += new System.EventHandler(this.AffectationModEtud_Load);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel label;
        private MetroFramework.Controls.MetroLabel mod;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cnebox;
        private System.Windows.Forms.ComboBox cne;
        private System.Windows.Forms.ComboBox module;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button rechercherButton;
    }
}