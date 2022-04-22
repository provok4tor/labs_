namespace Lab2_
{
    partial class Third
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
            this.OK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeText = new System.Windows.Forms.TextBox();
            this.StudentText = new System.Windows.Forms.TextBox();
            this.DiscipText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(22, 190);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(164, 30);
            this.OK.TabIndex = 17;
            this.OK.Text = "Добавить";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Время сдачи(ч.)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Число студентов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Дисциплина";
            // 
            // TimeText
            // 
            this.TimeText.Location = new System.Drawing.Point(22, 148);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(164, 22);
            this.TimeText.TabIndex = 11;
            // 
            // StudentText
            // 
            this.StudentText.Location = new System.Drawing.Point(22, 88);
            this.StudentText.Name = "StudentText";
            this.StudentText.Size = new System.Drawing.Size(164, 22);
            this.StudentText.TabIndex = 10;
            // 
            // DiscipText
            // 
            this.DiscipText.Location = new System.Drawing.Point(22, 29);
            this.DiscipText.Name = "DiscipText";
            this.DiscipText.Size = new System.Drawing.Size(164, 22);
            this.DiscipText.TabIndex = 9;
            // 
            // Third
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 233);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.StudentText);
            this.Controls.Add(this.DiscipText);
            this.Name = "Third";
            this.Text = "Third";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TimeText;
        private System.Windows.Forms.TextBox StudentText;
        private System.Windows.Forms.TextBox DiscipText;
    }
}