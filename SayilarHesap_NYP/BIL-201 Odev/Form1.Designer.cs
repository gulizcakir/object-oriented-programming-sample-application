
namespace BIL_201_Odev
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
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.gbGirisBilgileri = new System.Windows.Forms.GroupBox();
            this.mtbBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.mtbBitis = new System.Windows.Forms.MaskedTextBox();
            this.lblBitis = new System.Windows.Forms.Label();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.tcSonuc = new System.Windows.Forms.TabControl();
            this.tpTekSayilar = new System.Windows.Forms.TabPage();
            this.tpCiftSayilar = new System.Windows.Forms.TabPage();
            this.tpAsalSayilar = new System.Windows.Forms.TabPage();
            this.tpMukemmelSay = new System.Windows.Forms.TabPage();
            this.lvTekSayilar = new System.Windows.Forms.ListView();
            this.lvCiftSayilar = new System.Windows.Forms.ListView();
            this.lvAsalSayilar = new System.Windows.Forms.ListView();
            this.lvMukemmelSay = new System.Windows.Forms.ListView();
            this.nıUyari = new System.Windows.Forms.NotifyIcon(this.components);
            this.gbGirisBilgileri.SuspendLayout();
            this.tcSonuc.SuspendLayout();
            this.tpTekSayilar.SuspendLayout();
            this.tpCiftSayilar.SuspendLayout();
            this.tpAsalSayilar.SuspendLayout();
            this.tpMukemmelSay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangic.Location = new System.Drawing.Point(35, 98);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(159, 25);
            this.lblBaslangic.TabIndex = 0;
            this.lblBaslangic.Text = "Başlangıç Değeri";
            // 
            // gbGirisBilgileri
            // 
            this.gbGirisBilgileri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbGirisBilgileri.Controls.Add(this.btnCalistir);
            this.gbGirisBilgileri.Controls.Add(this.mtbBitis);
            this.gbGirisBilgileri.Controls.Add(this.lblBitis);
            this.gbGirisBilgileri.Controls.Add(this.mtbBaslangic);
            this.gbGirisBilgileri.Controls.Add(this.lblBaslangic);
            this.gbGirisBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbGirisBilgileri.Location = new System.Drawing.Point(30, 24);
            this.gbGirisBilgileri.Name = "gbGirisBilgileri";
            this.gbGirisBilgileri.Size = new System.Drawing.Size(908, 220);
            this.gbGirisBilgileri.TabIndex = 1;
            this.gbGirisBilgileri.TabStop = false;
            this.gbGirisBilgileri.Text = "Giriş Bilgileri";
            // 
            // mtbBaslangic
            // 
            this.mtbBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbBaslangic.Location = new System.Drawing.Point(200, 98);
            this.mtbBaslangic.Mask = "10000";
            this.mtbBaslangic.Name = "mtbBaslangic";
            this.mtbBaslangic.Size = new System.Drawing.Size(100, 30);
            this.mtbBaslangic.TabIndex = 1;
            this.mtbBaslangic.ValidatingType = typeof(int);
            // 
            // mtbBitis
            // 
            this.mtbBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbBitis.Location = new System.Drawing.Point(543, 100);
            this.mtbBitis.Mask = "00000";
            this.mtbBitis.Name = "mtbBitis";
            this.mtbBitis.Size = new System.Drawing.Size(100, 30);
            this.mtbBitis.TabIndex = 3;
            this.mtbBitis.ValidatingType = typeof(int);
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitis.Location = new System.Drawing.Point(427, 103);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(110, 25);
            this.lblBitis.TabIndex = 2;
            this.lblBitis.Text = "Bitiş Değeri";
            // 
            // btnCalistir
            // 
            this.btnCalistir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalistir.Location = new System.Drawing.Point(722, 98);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(144, 44);
            this.btnCalistir.TabIndex = 4;
            this.btnCalistir.Text = "Çalıştır!";
            this.btnCalistir.UseVisualStyleBackColor = false;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // tcSonuc
            // 
            this.tcSonuc.Controls.Add(this.tpTekSayilar);
            this.tcSonuc.Controls.Add(this.tpCiftSayilar);
            this.tcSonuc.Controls.Add(this.tpAsalSayilar);
            this.tcSonuc.Controls.Add(this.tpMukemmelSay);
            this.tcSonuc.Location = new System.Drawing.Point(30, 251);
            this.tcSonuc.Name = "tcSonuc";
            this.tcSonuc.SelectedIndex = 0;
            this.tcSonuc.Size = new System.Drawing.Size(908, 262);
            this.tcSonuc.TabIndex = 2;
            // 
            // tpTekSayilar
            // 
            this.tpTekSayilar.Controls.Add(this.lvTekSayilar);
            this.tpTekSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tpTekSayilar.Location = new System.Drawing.Point(4, 29);
            this.tpTekSayilar.Name = "tpTekSayilar";
            this.tpTekSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tpTekSayilar.Size = new System.Drawing.Size(900, 229);
            this.tpTekSayilar.TabIndex = 0;
            this.tpTekSayilar.Text = "Tek Sayılar";
            this.tpTekSayilar.UseVisualStyleBackColor = true;
            // 
            // tpCiftSayilar
            // 
            this.tpCiftSayilar.Controls.Add(this.lvCiftSayilar);
            this.tpCiftSayilar.Location = new System.Drawing.Point(4, 29);
            this.tpCiftSayilar.Name = "tpCiftSayilar";
            this.tpCiftSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tpCiftSayilar.Size = new System.Drawing.Size(900, 229);
            this.tpCiftSayilar.TabIndex = 1;
            this.tpCiftSayilar.Text = "Çift Sayılar";
            this.tpCiftSayilar.UseVisualStyleBackColor = true;
            // 
            // tpAsalSayilar
            // 
            this.tpAsalSayilar.Controls.Add(this.lvAsalSayilar);
            this.tpAsalSayilar.Location = new System.Drawing.Point(4, 29);
            this.tpAsalSayilar.Name = "tpAsalSayilar";
            this.tpAsalSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAsalSayilar.Size = new System.Drawing.Size(900, 229);
            this.tpAsalSayilar.TabIndex = 2;
            this.tpAsalSayilar.Text = "Asal Sayılar";
            this.tpAsalSayilar.UseVisualStyleBackColor = true;
            // 
            // tpMukemmelSay
            // 
            this.tpMukemmelSay.Controls.Add(this.lvMukemmelSay);
            this.tpMukemmelSay.Location = new System.Drawing.Point(4, 29);
            this.tpMukemmelSay.Name = "tpMukemmelSay";
            this.tpMukemmelSay.Padding = new System.Windows.Forms.Padding(3);
            this.tpMukemmelSay.Size = new System.Drawing.Size(900, 229);
            this.tpMukemmelSay.TabIndex = 3;
            this.tpMukemmelSay.Text = "Mükemmel Sayılar";
            this.tpMukemmelSay.UseVisualStyleBackColor = true;
            // 
            // lvTekSayilar
            // 
            this.lvTekSayilar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvTekSayilar.HideSelection = false;
            this.lvTekSayilar.Location = new System.Drawing.Point(6, 6);
            this.lvTekSayilar.Name = "lvTekSayilar";
            this.lvTekSayilar.Size = new System.Drawing.Size(888, 217);
            this.lvTekSayilar.TabIndex = 0;
            this.lvTekSayilar.UseCompatibleStateImageBehavior = false;
            this.lvTekSayilar.View = System.Windows.Forms.View.List;
            // 
            // lvCiftSayilar
            // 
            this.lvCiftSayilar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvCiftSayilar.HideSelection = false;
            this.lvCiftSayilar.Location = new System.Drawing.Point(6, 6);
            this.lvCiftSayilar.Name = "lvCiftSayilar";
            this.lvCiftSayilar.Size = new System.Drawing.Size(888, 217);
            this.lvCiftSayilar.TabIndex = 1;
            this.lvCiftSayilar.UseCompatibleStateImageBehavior = false;
            this.lvCiftSayilar.View = System.Windows.Forms.View.List;
            // 
            // lvAsalSayilar
            // 
            this.lvAsalSayilar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvAsalSayilar.HideSelection = false;
            this.lvAsalSayilar.Location = new System.Drawing.Point(6, 6);
            this.lvAsalSayilar.Name = "lvAsalSayilar";
            this.lvAsalSayilar.Size = new System.Drawing.Size(888, 217);
            this.lvAsalSayilar.TabIndex = 1;
            this.lvAsalSayilar.UseCompatibleStateImageBehavior = false;
            this.lvAsalSayilar.View = System.Windows.Forms.View.List;
            // 
            // lvMukemmelSay
            // 
            this.lvMukemmelSay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvMukemmelSay.HideSelection = false;
            this.lvMukemmelSay.Location = new System.Drawing.Point(6, 6);
            this.lvMukemmelSay.Name = "lvMukemmelSay";
            this.lvMukemmelSay.Size = new System.Drawing.Size(888, 217);
            this.lvMukemmelSay.TabIndex = 1;
            this.lvMukemmelSay.UseCompatibleStateImageBehavior = false;
            this.lvMukemmelSay.View = System.Windows.Forms.View.List;
            // 
            // nıUyari
            // 
            this.nıUyari.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nıUyari.Text = "notifyIcon1";
            this.nıUyari.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 525);
            this.Controls.Add(this.tcSonuc);
            this.Controls.Add(this.gbGirisBilgileri);
            this.Name = "Form1";
            this.Text = "HESAPLA";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.gbGirisBilgileri.ResumeLayout(false);
            this.gbGirisBilgileri.PerformLayout();
            this.tcSonuc.ResumeLayout(false);
            this.tpTekSayilar.ResumeLayout(false);
            this.tpCiftSayilar.ResumeLayout(false);
            this.tpAsalSayilar.ResumeLayout(false);
            this.tpMukemmelSay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.GroupBox gbGirisBilgileri;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.MaskedTextBox mtbBitis;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.MaskedTextBox mtbBaslangic;
        private System.Windows.Forms.TabControl tcSonuc;
        private System.Windows.Forms.TabPage tpTekSayilar;
        private System.Windows.Forms.ListView lvTekSayilar;
        private System.Windows.Forms.TabPage tpCiftSayilar;
        private System.Windows.Forms.ListView lvCiftSayilar;
        private System.Windows.Forms.TabPage tpAsalSayilar;
        private System.Windows.Forms.ListView lvAsalSayilar;
        private System.Windows.Forms.TabPage tpMukemmelSay;
        private System.Windows.Forms.ListView lvMukemmelSay;
        private System.Windows.Forms.NotifyIcon nıUyari;
    }
}

