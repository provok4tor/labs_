namespace Lab1MAIN
{
    partial class CreateSquare
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
            this.button1 = new System.Windows.Forms.Button();
            this.VertexY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VertexX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CenterY = new System.Windows.Forms.TextBox();
            this.CenterX = new System.Windows.Forms.TextBox();
            this.ColourTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 47);
            this.button1.TabIndex = 21;
            this.button1.Text = "Работать с этим квадратом";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VertexY
            // 
            this.VertexY.Location = new System.Drawing.Point(477, 81);
            this.VertexY.Name = "VertexY";
            this.VertexY.Size = new System.Drawing.Size(149, 22);
            this.VertexY.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Y:";
            // 
            // VertexX
            // 
            this.VertexX.Location = new System.Drawing.Point(308, 81);
            this.VertexX.Name = "VertexX";
            this.VertexX.Size = new System.Drawing.Size(136, 22);
            this.VertexX.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Координаты любой вершины квадрата   Х:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Координаты центра квадрата                 Х:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Цвет квадрата";
            // 
            // CenterY
            // 
            this.CenterY.Location = new System.Drawing.Point(477, 46);
            this.CenterY.Name = "CenterY";
            this.CenterY.Size = new System.Drawing.Size(149, 22);
            this.CenterY.TabIndex = 13;
            // 
            // CenterX
            // 
            this.CenterX.Location = new System.Drawing.Point(308, 46);
            this.CenterX.Name = "CenterX";
            this.CenterX.Size = new System.Drawing.Size(136, 22);
            this.CenterX.TabIndex = 12;
            // 
            // ColourTXT
            // 
            this.ColourTXT.Location = new System.Drawing.Point(124, 9);
            this.ColourTXT.Name = "ColourTXT";
            this.ColourTXT.Size = new System.Drawing.Size(136, 22);
            this.ColourTXT.TabIndex = 11;
            // 
            // CreateSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VertexY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VertexX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CenterY);
            this.Controls.Add(this.CenterX);
            this.Controls.Add(this.ColourTXT);
            this.Name = "CreateSquare";
            this.Text = "Create";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox VertexY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VertexX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CenterY;
        private System.Windows.Forms.TextBox CenterX;
        private System.Windows.Forms.TextBox ColourTXT;
    }
}

