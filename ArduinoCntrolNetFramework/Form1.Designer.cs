namespace ArduinoCntrolNetFramework
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
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
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ledOn1 = new System.Windows.Forms.Button();
            this.ledOff1 = new System.Windows.Forms.Button();
            this.ledOff2 = new System.Windows.Forms.Button();
            this.ledOn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // ledOn1
            // 
            this.ledOn1.Location = new System.Drawing.Point(237, 153);
            this.ledOn1.Name = "ledOn1";
            this.ledOn1.Size = new System.Drawing.Size(113, 48);
            this.ledOn1.TabIndex = 0;
            this.ledOn1.Text = "Aç";
            this.ledOn1.UseVisualStyleBackColor = true;
            this.ledOn1.Click += new System.EventHandler(this.ledOn1_Click);
            // 
            // ledOff1
            // 
            this.ledOff1.Location = new System.Drawing.Point(237, 207);
            this.ledOff1.Name = "ledOff1";
            this.ledOff1.Size = new System.Drawing.Size(113, 48);
            this.ledOff1.TabIndex = 1;
            this.ledOff1.Text = "Kapat";
            this.ledOff1.UseVisualStyleBackColor = true;
            this.ledOff1.Click += new System.EventHandler(this.ledOff1_Click);
            // 
            // ledOff2
            // 
            this.ledOff2.Location = new System.Drawing.Point(356, 207);
            this.ledOff2.Name = "ledOff2";
            this.ledOff2.Size = new System.Drawing.Size(113, 48);
            this.ledOff2.TabIndex = 3;
            this.ledOff2.Text = "Kapat";
            this.ledOff2.UseVisualStyleBackColor = true;
            this.ledOff2.Click += new System.EventHandler(this.ledOff2_Click);
            // 
            // ledOn2
            // 
            this.ledOn2.Location = new System.Drawing.Point(356, 153);
            this.ledOn2.Name = "ledOn2";
            this.ledOn2.Size = new System.Drawing.Size(113, 48);
            this.ledOn2.TabIndex = 2;
            this.ledOn2.Text = "Aç";
            this.ledOn2.UseVisualStyleBackColor = true;
            this.ledOn2.Click += new System.EventHandler(this.ledOn2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Led 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Led 2";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ledOff2);
            this.Controls.Add(this.ledOn2);
            this.Controls.Add(this.ledOff1);
            this.Controls.Add(this.ledOn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ledOn1;
        private System.Windows.Forms.Button ledOff1;
        private System.Windows.Forms.Button ledOff2;
        private System.Windows.Forms.Button ledOn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

