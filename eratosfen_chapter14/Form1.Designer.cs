namespace eratosfen_chapter14
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.udNumber = new System.Windows.Forms.NumericUpDown();
            this.udNumber2 = new System.Windows.Forms.NumericUpDown();
            this.btnPrime = new System.Windows.Forms.Button();
            this.btnLst = new System.Windows.Forms.Button();
            this.lstBoxChetverki = new System.Windows.Forms.ListBox();
            this.btnPerfectNums = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 368);
            this.listBox1.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(281, 381);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "resheto ";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // udNumber
            // 
            this.udNumber.Location = new System.Drawing.Point(302, 233);
            this.udNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udNumber.Name = "udNumber";
            this.udNumber.Size = new System.Drawing.Size(120, 20);
            this.udNumber.TabIndex = 2;
            // 
            // udNumber2
            // 
            this.udNumber2.Location = new System.Drawing.Point(302, 270);
            this.udNumber2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udNumber2.Name = "udNumber2";
            this.udNumber2.Size = new System.Drawing.Size(120, 20);
            this.udNumber2.TabIndex = 3;
            // 
            // btnPrime
            // 
            this.btnPrime.Location = new System.Drawing.Point(281, 336);
            this.btnPrime.Name = "btnPrime";
            this.btnPrime.Size = new System.Drawing.Size(115, 23);
            this.btnPrime.TabIndex = 4;
            this.btnPrime.Text = "V promejutke s..do";
            this.btnPrime.UseVisualStyleBackColor = true;
            this.btnPrime.Click += new System.EventHandler(this.btnPrime_Click);
            // 
            // btnLst
            // 
            this.btnLst.Location = new System.Drawing.Point(408, 381);
            this.btnLst.Name = "btnLst";
            this.btnLst.Size = new System.Drawing.Size(75, 23);
            this.btnLst.TabIndex = 5;
            this.btnLst.Text = "primeList";
            this.btnLst.UseVisualStyleBackColor = true;
            this.btnLst.Click += new System.EventHandler(this.btnLst_Click);
            // 
            // lstBoxChetverki
            // 
            this.lstBoxChetverki.FormattingEnabled = true;
            this.lstBoxChetverki.Location = new System.Drawing.Point(281, 12);
            this.lstBoxChetverki.Name = "lstBoxChetverki";
            this.lstBoxChetverki.Size = new System.Drawing.Size(171, 199);
            this.lstBoxChetverki.TabIndex = 6;
            // 
            // btnPerfectNums
            // 
            this.btnPerfectNums.Location = new System.Drawing.Point(507, 336);
            this.btnPerfectNums.Name = "btnPerfectNums";
            this.btnPerfectNums.Size = new System.Drawing.Size(100, 23);
            this.btnPerfectNums.TabIndex = 7;
            this.btnPerfectNums.Text = "perefect nums";
            this.btnPerfectNums.UseVisualStyleBackColor = true;
            this.btnPerfectNums.Click += new System.EventHandler(this.btnPerfectNums_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPerfectNums);
            this.Controls.Add(this.lstBoxChetverki);
            this.Controls.Add(this.btnLst);
            this.Controls.Add(this.btnPrime);
            this.Controls.Add(this.udNumber2);
            this.Controls.Add(this.udNumber);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.udNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNumber2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.NumericUpDown udNumber;
        private System.Windows.Forms.NumericUpDown udNumber2;
        private System.Windows.Forms.Button btnPrime;
        private System.Windows.Forms.Button btnLst;
        private System.Windows.Forms.ListBox lstBoxChetverki;
        private System.Windows.Forms.Button btnPerfectNums;
    }
}

