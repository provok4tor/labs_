namespace _3Lab_
{
    partial class InputForm
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DurationBox = new System.Windows.Forms.TextBox();
            this.CapacityBox = new System.Windows.Forms.TextBox();
            this.DeliverBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(152, 4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 22);
            this.NameBox.TabIndex = 0;
            // 
            // DurationBox
            // 
            this.DurationBox.Location = new System.Drawing.Point(152, 32);
            this.DurationBox.Name = "DurationBox";
            this.DurationBox.Size = new System.Drawing.Size(100, 22);
            this.DurationBox.TabIndex = 1;
            // 
            // CapacityBox
            // 
            this.CapacityBox.Location = new System.Drawing.Point(152, 65);
            this.CapacityBox.Name = "CapacityBox";
            this.CapacityBox.Size = new System.Drawing.Size(100, 22);
            this.CapacityBox.TabIndex = 2;
            // 
            // DeliverBox
            // 
            this.DeliverBox.Location = new System.Drawing.Point(152, 100);
            this.DeliverBox.Name = "DeliverBox";
            this.DeliverBox.Size = new System.Drawing.Size(100, 22);
            this.DeliverBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Срок службы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Грузоподъёмность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Число доставок";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(6, 128);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(246, 34);
            this.OK.TabIndex = 8;
            this.OK.Text = "Добавить";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 170);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeliverBox);
            this.Controls.Add(this.CapacityBox);
            this.Controls.Add(this.DurationBox);
            this.Controls.Add(this.NameBox);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox DurationBox;
        private System.Windows.Forms.TextBox CapacityBox;
        private System.Windows.Forms.TextBox DeliverBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button OK;
    }
}