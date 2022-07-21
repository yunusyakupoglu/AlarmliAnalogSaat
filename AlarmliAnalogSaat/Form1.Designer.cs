
namespace AlarmliAnalogSaat
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxKadran = new System.Windows.Forms.PictureBox();
            this.pictureBoxMili = new System.Windows.Forms.PictureBox();
            this.pictureBoxSaniye = new System.Windows.Forms.PictureBox();
            this.pictureBoxYelkovan = new System.Windows.Forms.PictureBox();
            this.pictureBoxAkrep = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAlarmDurdur = new System.Windows.Forms.Button();
            this.btnAlarmErtele = new System.Windows.Forms.Button();
            this.btnAlarmKur = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.lblGuncelZaman = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.txtAlarmZamani = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKadran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMili)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaniye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYelkovan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAkrep)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1258, 714);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxKadran);
            this.groupBox1.Controls.Add(this.pictureBoxMili);
            this.groupBox1.Controls.Add(this.pictureBoxSaniye);
            this.groupBox1.Controls.Add(this.pictureBoxYelkovan);
            this.groupBox1.Controls.Add(this.pictureBoxAkrep);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 708);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SAAT";
            // 
            // pictureBoxKadran
            // 
            this.pictureBoxKadran.Image = global::AlarmliAnalogSaat.Properties.Resources.kadran;
            this.pictureBoxKadran.Location = new System.Drawing.Point(64, 108);
            this.pictureBoxKadran.Name = "pictureBoxKadran";
            this.pictureBoxKadran.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxKadran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKadran.TabIndex = 0;
            this.pictureBoxKadran.TabStop = false;
            // 
            // pictureBoxMili
            // 
            this.pictureBoxMili.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMili.Image = global::AlarmliAnalogSaat.Properties.Resources.mili;
            this.pictureBoxMili.Location = new System.Drawing.Point(6, 468);
            this.pictureBoxMili.Name = "pictureBoxMili";
            this.pictureBoxMili.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxMili.TabIndex = 4;
            this.pictureBoxMili.TabStop = false;
            // 
            // pictureBoxSaniye
            // 
            this.pictureBoxSaniye.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSaniye.Image = global::AlarmliAnalogSaat.Properties.Resources.saniye;
            this.pictureBoxSaniye.Location = new System.Drawing.Point(6, 348);
            this.pictureBoxSaniye.Name = "pictureBoxSaniye";
            this.pictureBoxSaniye.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxSaniye.TabIndex = 3;
            this.pictureBoxSaniye.TabStop = false;
            // 
            // pictureBoxYelkovan
            // 
            this.pictureBoxYelkovan.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxYelkovan.Image = global::AlarmliAnalogSaat.Properties.Resources.yelkovan;
            this.pictureBoxYelkovan.Location = new System.Drawing.Point(6, 255);
            this.pictureBoxYelkovan.Name = "pictureBoxYelkovan";
            this.pictureBoxYelkovan.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxYelkovan.TabIndex = 2;
            this.pictureBoxYelkovan.TabStop = false;
            // 
            // pictureBoxAkrep
            // 
            this.pictureBoxAkrep.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAkrep.Image = global::AlarmliAnalogSaat.Properties.Resources.akrep;
            this.pictureBoxAkrep.Location = new System.Drawing.Point(6, 131);
            this.pictureBoxAkrep.Name = "pictureBoxAkrep";
            this.pictureBoxAkrep.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxAkrep.TabIndex = 1;
            this.pictureBoxAkrep.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(632, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 708);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ALARM";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(617, 682);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btnAlarmDurdur, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAlarmErtele, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAlarmKur, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 548);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(611, 131);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnAlarmDurdur
            // 
            this.btnAlarmDurdur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlarmDurdur.Location = new System.Drawing.Point(409, 3);
            this.btnAlarmDurdur.Name = "btnAlarmDurdur";
            this.btnAlarmDurdur.Size = new System.Drawing.Size(199, 125);
            this.btnAlarmDurdur.TabIndex = 2;
            this.btnAlarmDurdur.Text = "Durdur";
            this.btnAlarmDurdur.UseVisualStyleBackColor = true;
            this.btnAlarmDurdur.Click += new System.EventHandler(this.btnAlarmDurdur_Click);
            // 
            // btnAlarmErtele
            // 
            this.btnAlarmErtele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlarmErtele.Location = new System.Drawing.Point(206, 3);
            this.btnAlarmErtele.Name = "btnAlarmErtele";
            this.btnAlarmErtele.Size = new System.Drawing.Size(197, 125);
            this.btnAlarmErtele.TabIndex = 1;
            this.btnAlarmErtele.Text = "Ertele";
            this.btnAlarmErtele.UseVisualStyleBackColor = true;
            this.btnAlarmErtele.Click += new System.EventHandler(this.btnAlarmErtele_Click);
            // 
            // btnAlarmKur
            // 
            this.btnAlarmKur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlarmKur.Location = new System.Drawing.Point(3, 3);
            this.btnAlarmKur.Name = "btnAlarmKur";
            this.btnAlarmKur.Size = new System.Drawing.Size(197, 125);
            this.btnAlarmKur.TabIndex = 0;
            this.btnAlarmKur.Text = "Kur";
            this.btnAlarmKur.UseVisualStyleBackColor = true;
            this.btnAlarmKur.Click += new System.EventHandler(this.btnAlarmKur_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lblBilgi, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblGuncelZaman, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(611, 539);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBilgi.Location = new System.Drawing.Point(3, 322);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(605, 217);
            this.lblBilgi.TabIndex = 2;
            this.lblBilgi.Text = "label3";
            this.lblBilgi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGuncelZaman
            // 
            this.lblGuncelZaman.AutoSize = true;
            this.lblGuncelZaman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGuncelZaman.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGuncelZaman.Location = new System.Drawing.Point(3, 0);
            this.lblGuncelZaman.Name = "lblGuncelZaman";
            this.lblGuncelZaman.Size = new System.Drawing.Size(605, 215);
            this.lblGuncelZaman.TabIndex = 0;
            this.lblGuncelZaman.Text = "label1";
            this.lblGuncelZaman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.txtAlarmZamani, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 218);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(605, 101);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerSaat
            // 
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // txtAlarmZamani
            // 
            this.txtAlarmZamani.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAlarmZamani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAlarmZamani.Location = new System.Drawing.Point(3, 36);
            this.txtAlarmZamani.Mask = "00:00:00";
            this.txtAlarmZamani.Name = "txtAlarmZamani";
            this.txtAlarmZamani.Size = new System.Drawing.Size(599, 27);
            this.txtAlarmZamani.TabIndex = 0;
            this.txtAlarmZamani.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAlarmZamani.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 714);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKadran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMili)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaniye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYelkovan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAkrep)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAlarmDurdur;
        private System.Windows.Forms.Button btnAlarmErtele;
        private System.Windows.Forms.Button btnAlarmKur;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label lblGuncelZaman;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBoxMili;
        private System.Windows.Forms.PictureBox pictureBoxSaniye;
        private System.Windows.Forms.PictureBox pictureBoxYelkovan;
        private System.Windows.Forms.PictureBox pictureBoxAkrep;
        private System.Windows.Forms.PictureBox pictureBoxKadran;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.MaskedTextBox txtAlarmZamani;
    }
}

