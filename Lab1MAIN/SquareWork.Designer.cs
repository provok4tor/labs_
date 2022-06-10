namespace Lab1MAIN
{
    partial class SquareWork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SetColour = new System.Windows.Forms.Button();
            this.Turn = new System.Windows.Forms.Button();
            this.Decrease = new System.Windows.Forms.Button();
            this.Increase = new System.Windows.Forms.Button();
            this.SetScale = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Colour = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Y4 = new System.Windows.Forms.TextBox();
            this.X4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Y3 = new System.Windows.Forms.TextBox();
            this.X3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.X1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetColour
            // 
            this.SetColour.Location = new System.Drawing.Point(560, 339);
            this.SetColour.Name = "SetColour";
            this.SetColour.Size = new System.Drawing.Size(221, 57);
            this.SetColour.TabIndex = 21;
            this.SetColour.Text = "Изменить цвет квадрата";
            this.SetColour.UseVisualStyleBackColor = true;
            this.SetColour.Click += new System.EventHandler(this.SetColour_Click);
            // 
            // Turn
            // 
            this.Turn.Location = new System.Drawing.Point(560, 264);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(221, 57);
            this.Turn.TabIndex = 20;
            this.Turn.Text = "Повернуть квадрат";
            this.Turn.UseVisualStyleBackColor = true;
            this.Turn.Click += new System.EventHandler(this.Turn_Click);
            // 
            // Decrease
            // 
            this.Decrease.Location = new System.Drawing.Point(560, 189);
            this.Decrease.Name = "Decrease";
            this.Decrease.Size = new System.Drawing.Size(221, 57);
            this.Decrease.TabIndex = 19;
            this.Decrease.Text = "\"Сжать\" квадрат";
            this.Decrease.UseVisualStyleBackColor = true;
            this.Decrease.Click += new System.EventHandler(this.Decrease_Click);
            // 
            // Increase
            // 
            this.Increase.Location = new System.Drawing.Point(560, 117);
            this.Increase.Name = "Increase";
            this.Increase.Size = new System.Drawing.Size(221, 57);
            this.Increase.TabIndex = 18;
            this.Increase.Text = "\"Растянуть\" квадрат";
            this.Increase.UseVisualStyleBackColor = true;
            this.Increase.Click += new System.EventHandler(this.Increase_Click);
            // 
            // SetScale
            // 
            this.SetScale.Location = new System.Drawing.Point(560, 49);
            this.SetScale.Name = "SetScale";
            this.SetScale.Size = new System.Drawing.Size(221, 57);
            this.SetScale.TabIndex = 17;
            this.SetScale.Text = "Задать размеры квадрата";
            this.SetScale.UseVisualStyleBackColor = true;
            this.SetScale.Click += new System.EventHandler(this.SetScale_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Цвет";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Colour
            // 
            this.Colour.Location = new System.Drawing.Point(97, 391);
            this.Colour.Name = "Colour";
            this.Colour.ReadOnly = true;
            this.Colour.Size = new System.Drawing.Size(100, 22);
            this.Colour.TabIndex = 15;
            this.Colour.TextChanged += new System.EventHandler(this.Colour_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Y4);
            this.groupBox4.Controls.Add(this.X4);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(282, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 170);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вершина 4";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // Y4
            // 
            this.Y4.Location = new System.Drawing.Point(33, 96);
            this.Y4.Name = "Y4";
            this.Y4.ReadOnly = true;
            this.Y4.Size = new System.Drawing.Size(100, 22);
            this.Y4.TabIndex = 8;
            // 
            // X4
            // 
            this.X4.Location = new System.Drawing.Point(33, 51);
            this.X4.Name = "X4";
            this.X4.ReadOnly = true;
            this.X4.Size = new System.Drawing.Size(100, 22);
            this.X4.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "X:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Y2);
            this.groupBox3.Controls.Add(this.X2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(282, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 170);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вершина 2";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(33, 97);
            this.Y2.Name = "Y2";
            this.Y2.ReadOnly = true;
            this.Y2.Size = new System.Drawing.Size(100, 22);
            this.Y2.TabIndex = 4;
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(33, 49);
            this.X2.Name = "X2";
            this.X2.ReadOnly = true;
            this.X2.Size = new System.Drawing.Size(100, 22);
            this.X2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Y3);
            this.groupBox2.Controls.Add(this.X3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(20, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 170);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вершина 3";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Y3
            // 
            this.Y3.Location = new System.Drawing.Point(33, 96);
            this.Y3.Name = "Y3";
            this.Y3.ReadOnly = true;
            this.Y3.Size = new System.Drawing.Size(100, 22);
            this.Y3.TabIndex = 6;
            // 
            // X3
            // 
            this.X3.Location = new System.Drawing.Point(33, 53);
            this.X3.Name = "X3";
            this.X3.ReadOnly = true;
            this.X3.Size = new System.Drawing.Size(100, 22);
            this.X3.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "X:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Y1);
            this.groupBox1.Controls.Add(this.X1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 170);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вершина 1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(33, 95);
            this.Y1.Name = "Y1";
            this.Y1.ReadOnly = true;
            this.Y1.Size = new System.Drawing.Size(100, 22);
            this.Y1.TabIndex = 3;
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(33, 49);
            this.X1.Name = "X1";
            this.X1.ReadOnly = true;
            this.X1.Size = new System.Drawing.Size(100, 22);
            this.X1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // SquareWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetColour);
            this.Controls.Add(this.Turn);
            this.Controls.Add(this.Decrease);
            this.Controls.Add(this.Increase);
            this.Controls.Add(this.SetScale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Colour);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SquareWork";
            this.Text = "SquareWork";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetColour;
        private System.Windows.Forms.Button Turn;
        private System.Windows.Forms.Button Decrease;
        private System.Windows.Forms.Button Increase;
        private System.Windows.Forms.Button SetScale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Colour;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Y4;
        private System.Windows.Forms.TextBox X4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Y3;
        private System.Windows.Forms.TextBox X3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}