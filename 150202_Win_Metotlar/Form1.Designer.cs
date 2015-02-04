namespace _150202_Win_Metotlar
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli designer değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        ///Designer desteği için gerekli metottur; bu metodun
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dakika = new System.Windows.Forms.Label();
            this.saniye = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = ":";
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.saat.Location = new System.Drawing.Point(2, 122);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(70, 51);
            this.saat.TabIndex = 1;
            this.saat.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(176, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 51);
            this.label2.TabIndex = 0;
            this.label2.Text = ":";
            // 
            // dakika
            // 
            this.dakika.AutoSize = true;
            this.dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dakika.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dakika.Location = new System.Drawing.Point(106, 122);
            this.dakika.Name = "dakika";
            this.dakika.Size = new System.Drawing.Size(70, 51);
            this.dakika.TabIndex = 1;
            this.dakika.Text = "00";
            // 
            // saniye
            // 
            this.saniye.AutoSize = true;
            this.saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saniye.Location = new System.Drawing.Point(210, 122);
            this.saniye.Name = "saniye";
            this.saniye.Size = new System.Drawing.Size(70, 51);
            this.saniye.TabIndex = 1;
            this.saniye.Text = "00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "BAŞLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(13, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 52);
            this.label5.TabIndex = 3;
            this.label5.Text = "OZKRONOMETRE";
            // 
            // timer1
            // 
            this.timer1.Interval = 3600000;
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 268);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saniye);
            this.Controls.Add(this.dakika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "OzKronometre Şubat 2015";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dakika;
        private System.Windows.Forms.Label saniye;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

