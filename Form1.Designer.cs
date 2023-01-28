
namespace projendp
{
    partial class Form1
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelsaniye = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAVitamini = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCVitamini = new System.Windows.Forms.TextBox();
            this.pictureBoxMeyve = new System.Windows.Forms.PictureBox();
            this.radioBtnNarenciye = new System.Windows.Forms.RadioButton();
            this.radioBtnKatiMeyve = new System.Windows.Forms.RadioButton();
            this.txtSivi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPure = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMeyveGram = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTopPure = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTopSivi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTopAVitamini = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTopCVitamini = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btncikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeyve)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBasla.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBasla.Location = new System.Drawing.Point(694, 344);
            this.btnBasla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(115, 33);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelsaniye
            // 
            this.labelsaniye.AutoSize = true;
            this.labelsaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelsaniye.Location = new System.Drawing.Point(812, 393);
            this.labelsaniye.Name = "labelsaniye";
            this.labelsaniye.Size = new System.Drawing.Size(24, 17);
            this.labelsaniye.TabIndex = 5;
            this.labelsaniye.Text = "60";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.Location = new System.Drawing.Point(856, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saniye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "A Vitamini(iu):";
            // 
            // txtAVitamini
            // 
            this.txtAVitamini.Location = new System.Drawing.Point(147, 164);
            this.txtAVitamini.Margin = new System.Windows.Forms.Padding(4);
            this.txtAVitamini.Name = "txtAVitamini";
            this.txtAVitamini.ReadOnly = true;
            this.txtAVitamini.Size = new System.Drawing.Size(132, 22);
            this.txtAVitamini.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "C Vitamini(mg):";
            // 
            // txtCVitamini
            // 
            this.txtCVitamini.Location = new System.Drawing.Point(147, 194);
            this.txtCVitamini.Margin = new System.Windows.Forms.Padding(4);
            this.txtCVitamini.Name = "txtCVitamini";
            this.txtCVitamini.ReadOnly = true;
            this.txtCVitamini.Size = new System.Drawing.Size(132, 22);
            this.txtCVitamini.TabIndex = 10;
            // 
            // pictureBoxMeyve
            // 
            this.pictureBoxMeyve.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMeyve.Location = new System.Drawing.Point(742, 28);
            this.pictureBoxMeyve.Name = "pictureBoxMeyve";
            this.pictureBoxMeyve.Size = new System.Drawing.Size(188, 130);
            this.pictureBoxMeyve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMeyve.TabIndex = 11;
            this.pictureBoxMeyve.TabStop = false;
            // 
            // radioBtnNarenciye
            // 
            this.radioBtnNarenciye.AutoSize = true;
            this.radioBtnNarenciye.Location = new System.Drawing.Point(52, 28);
            this.radioBtnNarenciye.Name = "radioBtnNarenciye";
            this.radioBtnNarenciye.Size = new System.Drawing.Size(150, 21);
            this.radioBtnNarenciye.TabIndex = 12;
            this.radioBtnNarenciye.Text = "Narenciye Sıkacağı";
            this.radioBtnNarenciye.UseVisualStyleBackColor = true;
            this.radioBtnNarenciye.CheckedChanged += new System.EventHandler(this.radioBtnNarenciye_CheckedChanged);
            // 
            // radioBtnKatiMeyve
            // 
            this.radioBtnKatiMeyve.AutoSize = true;
            this.radioBtnKatiMeyve.Location = new System.Drawing.Point(52, 55);
            this.radioBtnKatiMeyve.Name = "radioBtnKatiMeyve";
            this.radioBtnKatiMeyve.Size = new System.Drawing.Size(155, 21);
            this.radioBtnKatiMeyve.TabIndex = 13;
            this.radioBtnKatiMeyve.Text = "Katı Meyve Sıkacağı";
            this.radioBtnKatiMeyve.UseVisualStyleBackColor = true;
            this.radioBtnKatiMeyve.CheckedChanged += new System.EventHandler(this.radioBtnKatiMeyve_CheckedChanged);
            // 
            // txtSivi
            // 
            this.txtSivi.Location = new System.Drawing.Point(147, 223);
            this.txtSivi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSivi.Name = "txtSivi";
            this.txtSivi.ReadOnly = true;
            this.txtSivi.Size = new System.Drawing.Size(132, 22);
            this.txtSivi.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sıvı Miktarı:";
            // 
            // txtPure
            // 
            this.txtPure.Location = new System.Drawing.Point(147, 253);
            this.txtPure.Margin = new System.Windows.Forms.Padding(4);
            this.txtPure.Name = "txtPure";
            this.txtPure.ReadOnly = true;
            this.txtPure.Size = new System.Drawing.Size(132, 22);
            this.txtPure.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Püre Miktarı:";
            // 
            // txtMeyveGram
            // 
            this.txtMeyveGram.Location = new System.Drawing.Point(147, 136);
            this.txtMeyveGram.Margin = new System.Windows.Forms.Padding(4);
            this.txtMeyveGram.Name = "txtMeyveGram";
            this.txtMeyveGram.ReadOnly = true;
            this.txtMeyveGram.Size = new System.Drawing.Size(132, 22);
            this.txtMeyveGram.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Meyve Ağırlığı(gr):";
            // 
            // txtTopPure
            // 
            this.txtTopPure.Location = new System.Drawing.Point(147, 316);
            this.txtTopPure.Margin = new System.Windows.Forms.Padding(4);
            this.txtTopPure.Name = "txtTopPure";
            this.txtTopPure.ReadOnly = true;
            this.txtTopPure.Size = new System.Drawing.Size(132, 22);
            this.txtTopPure.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Toplam Püre:";
            // 
            // txtTopSivi
            // 
            this.txtTopSivi.Location = new System.Drawing.Point(147, 286);
            this.txtTopSivi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTopSivi.Name = "txtTopSivi";
            this.txtTopSivi.ReadOnly = true;
            this.txtTopSivi.Size = new System.Drawing.Size(132, 22);
            this.txtTopSivi.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Toplam Sıvı:";
            // 
            // txtTopAVitamini
            // 
            this.txtTopAVitamini.Location = new System.Drawing.Point(147, 349);
            this.txtTopAVitamini.Margin = new System.Windows.Forms.Padding(4);
            this.txtTopAVitamini.Name = "txtTopAVitamini";
            this.txtTopAVitamini.ReadOnly = true;
            this.txtTopAVitamini.Size = new System.Drawing.Size(132, 22);
            this.txtTopAVitamini.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Top. A Vitamini(iu):";
            // 
            // txtTopCVitamini
            // 
            this.txtTopCVitamini.Location = new System.Drawing.Point(147, 388);
            this.txtTopCVitamini.Margin = new System.Windows.Forms.Padding(4);
            this.txtTopCVitamini.Name = "txtTopCVitamini";
            this.txtTopCVitamini.ReadOnly = true;
            this.txtTopCVitamini.Size = new System.Drawing.Size(132, 22);
            this.txtTopCVitamini.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Top. C Vitamini(mg):";
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Blue;
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncikis.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btncikis.Location = new System.Drawing.Point(815, 344);
            this.btncikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(115, 33);
            this.btncikis.TabIndex = 28;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 508);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.txtTopCVitamini);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTopAVitamini);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTopPure);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTopSivi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMeyveGram);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSivi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBtnKatiMeyve);
            this.Controls.Add(this.radioBtnNarenciye);
            this.Controls.Add(this.pictureBoxMeyve);
            this.Controls.Add(this.txtCVitamini);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAVitamini);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelsaniye);
            this.Controls.Add(this.btnBasla);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMeyve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelsaniye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAVitamini;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCVitamini;
        private System.Windows.Forms.PictureBox pictureBoxMeyve;
        private System.Windows.Forms.RadioButton radioBtnNarenciye;
        private System.Windows.Forms.RadioButton radioBtnKatiMeyve;
        private System.Windows.Forms.TextBox txtSivi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMeyveGram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTopPure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTopSivi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTopAVitamini;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTopCVitamini;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btncikis;
    }
}

