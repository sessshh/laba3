namespace laba3
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
            this.btnHello = new System.Windows.Forms.Button();
            this.btnВыйти = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(15, 122);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(375, 23);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello!";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnВыйти
            // 
            this.btnВыйти.Location = new System.Drawing.Point(15, 167);
            this.btnВыйти.Name = "btnВыйти";
            this.btnВыйти.Size = new System.Drawing.Size(375, 23);
            this.btnВыйти.TabIndex = 1;
            this.btnВыйти.Text = "Выйти";
            this.btnВыйти.UseVisualStyleBackColor = true;
            this.btnВыйти.Click += new System.EventHandler(this.btnВыйти_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(151, 75);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(239, 22);
            this.tbName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите свое имя";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnВыйти);
            this.Controls.Add(this.btnHello);
            this.Name = "Form1";
            this.Text = "Знакомство";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnВыйти;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
    }
}

