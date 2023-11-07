namespace dotnet_lab3
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
            this.button_draw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_draw
            // 
            this.button_draw.Location = new System.Drawing.Point(630, 58);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(123, 38);
            this.button_draw.TabIndex = 0;
            this.button_draw.Text = "Додати фігуру";
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_draw);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_draw;
    }
}

