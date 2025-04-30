namespace TypingTutor
{
    partial class MainForm
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
            this.butStart = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.rdRus = new System.Windows.Forms.RadioButton();
            this.rdEng = new System.Windows.Forms.RadioButton();
            this.numericCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericCount)).BeginInit();
            this.SuspendLayout();
            // 
            // butStart
            // 
            this.butStart.BackColor = System.Drawing.SystemColors.Info;
            this.butStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butStart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butStart.Location = new System.Drawing.Point(12, 12);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(139, 77);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = false;
            this.butStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.butStart_KeyPress);
            this.butStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.butStart_MouseDown);
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(98, 255);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(345, 39);
            this.lblText.TabIndex = 1;
            // 
            // rdRus
            // 
            this.rdRus.AutoSize = true;
            this.rdRus.Checked = true;
            this.rdRus.Location = new System.Drawing.Point(407, 91);
            this.rdRus.Name = "rdRus";
            this.rdRus.Size = new System.Drawing.Size(67, 17);
            this.rdRus.TabIndex = 2;
            this.rdRus.TabStop = true;
            this.rdRus.Text = "Русский";
            this.rdRus.UseVisualStyleBackColor = true;
            // 
            // rdEng
            // 
            this.rdEng.AutoSize = true;
            this.rdEng.Location = new System.Drawing.Point(407, 114);
            this.rdEng.Name = "rdEng";
            this.rdEng.Size = new System.Drawing.Size(57, 17);
            this.rdEng.TabIndex = 3;
            this.rdEng.Text = "Engish";
            this.rdEng.UseVisualStyleBackColor = true;
            // 
            // numericCount
            // 
            this.numericCount.Location = new System.Drawing.Point(407, 65);
            this.numericCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericCount.Name = "numericCount";
            this.numericCount.Size = new System.Drawing.Size(57, 20);
            this.numericCount.TabIndex = 5;
            this.numericCount.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 53);
            this.label1.TabIndex = 6;
            this.label1.Text = "You can change text samples by replacing\r\ncontent in .txt files in application fo" +
    "lder\r\nEnglishText.txt\r\nRussianText.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericCount);
            this.Controls.Add(this.rdEng);
            this.Controls.Add(this.rdRus);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.butStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Touch Typing Tutor";
            ((System.ComponentModel.ISupportInitialize)(this.numericCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.RadioButton rdRus;
        private System.Windows.Forms.RadioButton rdEng;
        private System.Windows.Forms.NumericUpDown numericCount;
        private System.Windows.Forms.Label label1;
    }
}

