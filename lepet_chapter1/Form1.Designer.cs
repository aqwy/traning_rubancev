namespace palindroms_chapter1
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
            this.components = new System.ComponentModel.Container();
            this.lstRes = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveRes = new System.Windows.Forms.Button();
            this.btnDictLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRes
            // 
            this.lstRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstRes.FormattingEnabled = true;
            this.lstRes.ItemHeight = 16;
            this.lstRes.Location = new System.Drawing.Point(-2, 79);
            this.lstRes.Name = "lstRes";
            this.lstRes.Size = new System.Drawing.Size(310, 356);
            this.lstRes.TabIndex = 0;
            // 
            // btnClose
            // 
            
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(236, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 72);
            this.btnClose.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            
            this.btnClear.Location = new System.Drawing.Point(158, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 72);
            this.btnClear.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnClear, "Clear Discrition");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveRes
            // 
            this.btnSaveRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveRes.Cursor = System.Windows.Forms.Cursors.Hand;
            
            this.btnSaveRes.Location = new System.Drawing.Point(80, 3);
            this.btnSaveRes.Name = "btnSaveRes";
            this.btnSaveRes.Size = new System.Drawing.Size(72, 72);
            this.btnSaveRes.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSaveRes, "Save discriptions");
            this.btnSaveRes.UseVisualStyleBackColor = true;
            this.btnSaveRes.Click += new System.EventHandler(this.btnSaveRes_Click);
            // 
            // btnDictLoad
            // 
            
            this.btnDictLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDictLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDictLoad.Location = new System.Drawing.Point(2, 3);
            this.btnDictLoad.Name = "btnDictLoad";
            this.btnDictLoad.Size = new System.Drawing.Size(72, 72);
            this.btnDictLoad.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnDictLoad, "Load Discription");
            this.btnDictLoad.UseVisualStyleBackColor = true;
            this.btnDictLoad.Click += new System.EventHandler(this.btnDictLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 448);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveRes);
            this.Controls.Add(this.btnDictLoad);
            this.Controls.Add(this.lstRes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palindroms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstRes;
        private System.Windows.Forms.Button btnDictLoad;
        private System.Windows.Forms.Button btnSaveRes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

