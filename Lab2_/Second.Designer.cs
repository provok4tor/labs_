namespace Lab2_
{
    partial class Second
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
            this.DiscipText = new System.Windows.Forms.TextBox();
            this.StudentText = new System.Windows.Forms.TextBox();
            this.TimeText = new System.Windows.Forms.TextBox();
            this.TwoText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DiscipText
            // 
            this.DiscipText.Location = new System.Drawing.Point(25, 29);
            this.DiscipText.Name = "DiscipText";
            this.DiscipText.Size = new System.Drawing.Size(164, 22);
            this.DiscipText.TabIndex = 0;
            // 
            // StudentText
            // 
            this.StudentText.Location = new System.Drawing.Point(25, 88);
            this.StudentText.Name = "StudentText";
            this.StudentText.Size = new System.Drawing.Size(164, 22);
            this.StudentText.TabIndex = 1;
            // 
            // TimeText
            // 
            this.TimeText.Location = new System.Drawing.Point(25, 148);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(164, 22);
            this.TimeText.TabIndex = 2;
            // 
            // TwoText
            // 
            this.TwoText.Location = new System.Drawing.Point(25, 207);
            this.TwoText.Name = "TwoText";
            this.TwoText.Size = new System.Drawing.Size(164, 22);
            this.TwoText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дисциплина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Число студентов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время сдачи(ч.)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Процент \"2\"";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(25, 246);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(164, 30);
            this.OK.TabIndex = 8;
            this.OK.Text = "Добавить";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Second
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 295);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TwoText);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.StudentText);
            this.Controls.Add(this.DiscipText);
            this.Name = "Second";
            this.Text = "Second";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DiscipText;
        private System.Windows.Forms.TextBox StudentText;
        private System.Windows.Forms.TextBox TimeText;
        private System.Windows.Forms.TextBox TwoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OK;
    }
}