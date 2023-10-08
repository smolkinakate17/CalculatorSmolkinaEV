namespace CalculatorSmolkinaEV
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
            this.Prev = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Div = new System.Windows.Forms.Button();
            this.DEL = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Number9 = new System.Windows.Forms.Button();
            this.Number8 = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Number6 = new System.Windows.Forms.Button();
            this.Number5 = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Number3 = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Number7 = new System.Windows.Forms.Button();
            this.Number4 = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.Button();
            this.Comma = new System.Windows.Forms.Button();
            this.Number0 = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Prev
            // 
            this.Prev.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Prev.Location = new System.Drawing.Point(14, 12);
            this.Prev.Multiline = true;
            this.Prev.Name = "Prev";
            this.Prev.ReadOnly = true;
            this.Prev.Size = new System.Drawing.Size(310, 20);
            this.Prev.TabIndex = 5;
            this.Prev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(14, 38);
            this.Result.MaxLength = 10;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(310, 35);
            this.Result.TabIndex = 4;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Div);
            this.panel1.Controls.Add(this.DEL);
            this.panel1.Controls.Add(this.C);
            this.panel1.Controls.Add(this.Mult);
            this.panel1.Controls.Add(this.Number9);
            this.panel1.Controls.Add(this.Number8);
            this.panel1.Controls.Add(this.Minus);
            this.panel1.Controls.Add(this.Number6);
            this.panel1.Controls.Add(this.Number5);
            this.panel1.Controls.Add(this.Plus);
            this.panel1.Controls.Add(this.Number3);
            this.panel1.Controls.Add(this.Number2);
            this.panel1.Controls.Add(this.Equal);
            this.panel1.Controls.Add(this.Number7);
            this.panel1.Controls.Add(this.Number4);
            this.panel1.Controls.Add(this.Number1);
            this.panel1.Controls.Add(this.Comma);
            this.panel1.Controls.Add(this.Number0);
            this.panel1.Controls.Add(this.CE);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Location = new System.Drawing.Point(4, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 211);
            this.panel1.TabIndex = 3;
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.Color.White;
            this.Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Div.Location = new System.Drawing.Point(249, 3);
            this.Div.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(80, 40);
            this.Div.TabIndex = 27;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.Click += new System.EventHandler(this.Oper_Click);
            // 
            // DEL
            // 
            this.DEL.BackColor = System.Drawing.Color.White;
            this.DEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DEL.Location = new System.Drawing.Point(167, 3);
            this.DEL.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.DEL.Name = "DEL";
            this.DEL.Size = new System.Drawing.Size(80, 40);
            this.DEL.TabIndex = 26;
            this.DEL.Text = "DEL";
            this.DEL.UseVisualStyleBackColor = false;
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.White;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C.Location = new System.Drawing.Point(85, 3);
            this.C.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(80, 40);
            this.C.TabIndex = 25;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // Mult
            // 
            this.Mult.BackColor = System.Drawing.Color.White;
            this.Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mult.Location = new System.Drawing.Point(249, 43);
            this.Mult.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(80, 40);
            this.Mult.TabIndex = 24;
            this.Mult.Text = "x";
            this.Mult.UseVisualStyleBackColor = false;
            this.Mult.Click += new System.EventHandler(this.Oper_Click);
            // 
            // Number9
            // 
            this.Number9.BackColor = System.Drawing.Color.White;
            this.Number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number9.Location = new System.Drawing.Point(167, 43);
            this.Number9.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(80, 40);
            this.Number9.TabIndex = 23;
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = false;
            this.Number9.Click += new System.EventHandler(this.NumberClick);
            // 
            // Number8
            // 
            this.Number8.BackColor = System.Drawing.Color.White;
            this.Number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number8.Location = new System.Drawing.Point(85, 43);
            this.Number8.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(80, 40);
            this.Number8.TabIndex = 22;
            this.Number8.Text = "8";
            this.Number8.UseVisualStyleBackColor = false;
            this.Number8.Click += new System.EventHandler(this.NumberClick);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.White;
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minus.Location = new System.Drawing.Point(249, 85);
            this.Minus.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(80, 40);
            this.Minus.TabIndex = 21;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Oper_Click);
            // 
            // Number6
            // 
            this.Number6.BackColor = System.Drawing.Color.White;
            this.Number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number6.Location = new System.Drawing.Point(167, 85);
            this.Number6.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(80, 40);
            this.Number6.TabIndex = 20;
            this.Number6.Text = "6";
            this.Number6.UseVisualStyleBackColor = false;
            this.Number6.Click += new System.EventHandler(this.NumberClick);
            // 
            // Number5
            // 
            this.Number5.BackColor = System.Drawing.Color.White;
            this.Number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number5.Location = new System.Drawing.Point(85, 85);
            this.Number5.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(80, 40);
            this.Number5.TabIndex = 19;
            this.Number5.Text = "5";
            this.Number5.UseVisualStyleBackColor = false;
            this.Number5.Click += new System.EventHandler(this.NumberClick);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.White;
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.Location = new System.Drawing.Point(249, 127);
            this.Plus.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(80, 40);
            this.Plus.TabIndex = 18;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Oper_Click);
            // 
            // Number3
            // 
            this.Number3.BackColor = System.Drawing.Color.White;
            this.Number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number3.Location = new System.Drawing.Point(167, 127);
            this.Number3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(80, 40);
            this.Number3.TabIndex = 17;
            this.Number3.Text = "3";
            this.Number3.UseVisualStyleBackColor = false;
            this.Number3.Click += new System.EventHandler(this.NumberClick);
            // 
            // Number2
            // 
            this.Number2.BackColor = System.Drawing.Color.White;
            this.Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number2.Location = new System.Drawing.Point(85, 127);
            this.Number2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(80, 40);
            this.Number2.TabIndex = 16;
            this.Number2.Text = "2";
            this.Number2.UseVisualStyleBackColor = false;
            this.Number2.Click += new System.EventHandler(this.NumberClick);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.Color.White;
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Equal.Location = new System.Drawing.Point(249, 169);
            this.Equal.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(80, 40);
            this.Equal.TabIndex = 15;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Number7
            // 
            this.Number7.BackColor = System.Drawing.Color.White;
            this.Number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number7.Location = new System.Drawing.Point(3, 43);
            this.Number7.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(80, 40);
            this.Number7.TabIndex = 14;
            this.Number7.Text = "7";
            this.Number7.UseVisualStyleBackColor = false;
            this.Number7.Click += new System.EventHandler(this.NumberClick);
            // 
            // Number4
            // 
            this.Number4.BackColor = System.Drawing.Color.White;
            this.Number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number4.Location = new System.Drawing.Point(3, 85);
            this.Number4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(80, 40);
            this.Number4.TabIndex = 13;
            this.Number4.Text = "4";
            this.Number4.UseVisualStyleBackColor = false;
            this.Number4.Click += new System.EventHandler(this.NumberClick);
            // 
            // Number1
            // 
            this.Number1.BackColor = System.Drawing.Color.White;
            this.Number1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number1.Location = new System.Drawing.Point(3, 127);
            this.Number1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(80, 40);
            this.Number1.TabIndex = 12;
            this.Number1.Text = "1";
            this.Number1.UseVisualStyleBackColor = false;
            this.Number1.Click += new System.EventHandler(this.NumberClick);
            // 
            // Comma
            // 
            this.Comma.BackColor = System.Drawing.Color.White;
            this.Comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Comma.Location = new System.Drawing.Point(167, 169);
            this.Comma.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(80, 40);
            this.Comma.TabIndex = 11;
            this.Comma.Text = ",";
            this.Comma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Comma.UseVisualStyleBackColor = false;
            this.Comma.Click += new System.EventHandler(this.Comma_Click);
            // 
            // Number0
            // 
            this.Number0.BackColor = System.Drawing.Color.White;
            this.Number0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Number0.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Number0.Location = new System.Drawing.Point(85, 169);
            this.Number0.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Number0.Name = "Number0";
            this.Number0.Size = new System.Drawing.Size(80, 40);
            this.Number0.TabIndex = 10;
            this.Number0.Text = "0";
            this.Number0.UseVisualStyleBackColor = false;
            this.Number0.Click += new System.EventHandler(this.NumberClick);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.White;
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CE.Location = new System.Drawing.Point(3, 3);
            this.CE.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(80, 40);
            this.CE.TabIndex = 9;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(228, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(0, 0);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 291);
            this.Controls.Add(this.Prev);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Prev;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button DEL;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Number9;
        private System.Windows.Forms.Button Number8;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Number6;
        private System.Windows.Forms.Button Number5;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Number3;
        private System.Windows.Forms.Button Number2;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Number7;
        private System.Windows.Forms.Button Number4;
        private System.Windows.Forms.Button Number1;
        private System.Windows.Forms.Button Comma;
        private System.Windows.Forms.Button Number0;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button button8;
    }
}

