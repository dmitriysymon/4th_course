namespace WindowsFormsApp3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_textBox = new System.Windows.Forms.TextBox();
            this.r_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serealize_button = new System.Windows.Forms.Button();
            this.deserealize_button = new System.Windows.Forms.Button();
            this.reflec_textbox = new System.Windows.Forms.TextBox();
            this.reflec_button = new System.Windows.Forms.Button();
            this.a_textBox = new System.Windows.Forms.TextBox();
            this.draw_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.b_textBox);
            this.panel1.Controls.Add(this.r_textBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 134);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сторона В";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сторона А";
            // 
            // b_textBox
            // 
            this.b_textBox.Location = new System.Drawing.Point(199, 78);
            this.b_textBox.Name = "b_textBox";
            this.b_textBox.Size = new System.Drawing.Size(100, 20);
            this.b_textBox.TabIndex = 2;
            this.b_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // r_textBox
            // 
            this.r_textBox.Location = new System.Drawing.Point(24, 78);
            this.r_textBox.Name = "r_textBox";
            this.r_textBox.Size = new System.Drawing.Size(100, 20);
            this.r_textBox.TabIndex = 1;
            this.r_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(131, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ромб";
            // 
            // serealize_button
            // 
            this.serealize_button.BackColor = System.Drawing.Color.Chartreuse;
            this.serealize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serealize_button.Location = new System.Drawing.Point(354, 43);
            this.serealize_button.Name = "serealize_button";
            this.serealize_button.Size = new System.Drawing.Size(75, 23);
            this.serealize_button.TabIndex = 5;
            this.serealize_button.Text = "Serialize";
            this.serealize_button.UseVisualStyleBackColor = false;
            this.serealize_button.Click += new System.EventHandler(this.serialize_Click);
            // 
            // deserealize_button
            // 
            this.deserealize_button.BackColor = System.Drawing.Color.Red;
            this.deserealize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deserealize_button.Location = new System.Drawing.Point(354, 108);
            this.deserealize_button.Name = "deserealize_button";
            this.deserealize_button.Size = new System.Drawing.Size(75, 23);
            this.deserealize_button.TabIndex = 6;
            this.deserealize_button.Text = "Deserialize";
            this.deserealize_button.UseVisualStyleBackColor = false;
            this.deserealize_button.Click += new System.EventHandler(this.deserealize_button_Click);
            // 
            // reflec_textbox
            // 
            this.reflec_textbox.Location = new System.Drawing.Point(12, 161);
            this.reflec_textbox.Multiline = true;
            this.reflec_textbox.Name = "reflec_textbox";
            this.reflec_textbox.ReadOnly = true;
            this.reflec_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.reflec_textbox.Size = new System.Drawing.Size(325, 150);
            this.reflec_textbox.TabIndex = 7;
            // 
            // reflec_button
            // 
            this.reflec_button.Location = new System.Drawing.Point(354, 288);
            this.reflec_button.Name = "reflec_button";
            this.reflec_button.Size = new System.Drawing.Size(75, 23);
            this.reflec_button.TabIndex = 8;
            this.reflec_button.Text = "Рефлексія";
            this.reflec_button.UseVisualStyleBackColor = true;
            this.reflec_button.Click += new System.EventHandler(this.reflec_button_Click);
            // 
            // a_textBox
            // 
            this.a_textBox.Location = new System.Drawing.Point(24, 78);
            this.a_textBox.Name = "a_textBox";
            this.a_textBox.Size = new System.Drawing.Size(100, 20);
            this.a_textBox.TabIndex = 1;
            this.a_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // draw_btn
            // 
            this.draw_btn.Location = new System.Drawing.Point(354, 233);
            this.draw_btn.Name = "draw_btn";
            this.draw_btn.Size = new System.Drawing.Size(75, 23);
            this.draw_btn.TabIndex = 9;
            this.draw_btn.Text = "Draw";
            this.draw_btn.UseVisualStyleBackColor = true;
            this.draw_btn.Click += new System.EventHandler(this.draw_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 337);
            this.Controls.Add(this.draw_btn);
            this.Controls.Add(this.reflec_button);
            this.Controls.Add(this.reflec_textbox);
            this.Controls.Add(this.deserealize_button);
            this.Controls.Add(this.serealize_button);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox b_textBox;
        private System.Windows.Forms.TextBox r_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button serealize_button;
        private System.Windows.Forms.Button deserealize_button;
        private System.Windows.Forms.TextBox reflec_textbox;
        private System.Windows.Forms.Button reflec_button;
        private System.Windows.Forms.TextBox a_textBox;
        private System.Windows.Forms.Button draw_btn;
    }
}

