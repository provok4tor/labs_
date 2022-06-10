namespace Lab3.Main
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
            this.OK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeliverBox = new System.Windows.Forms.TextBox();
            this.CapacityBox = new System.Windows.Forms.TextBox();
            this.DurationBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(56, 131);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(266, 34);
            this.OK.TabIndex = 17;
            this.OK.Text = "Добавить";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Число доставок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Грузоподъёмность (т.)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Срок службы (полных лет)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название";
            // 
            // DeliverBox
            // 
            this.DeliverBox.Location = new System.Drawing.Point(222, 103);
            this.DeliverBox.Name = "DeliverBox";
            this.DeliverBox.Size = new System.Drawing.Size(100, 22);
            this.DeliverBox.TabIndex = 12;
            // 
            // CapacityBox
            // 
            this.CapacityBox.Location = new System.Drawing.Point(222, 68);
            this.CapacityBox.Name = "CapacityBox";
            this.CapacityBox.Size = new System.Drawing.Size(100, 22);
            this.CapacityBox.TabIndex = 11;
            // 
            // DurationBox
            // 
            this.DurationBox.Location = new System.Drawing.Point(222, 35);
            this.DurationBox.Name = "DurationBox";
            this.DurationBox.Size = new System.Drawing.Size(100, 22);
            this.DurationBox.TabIndex = 10;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(222, 7);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 22);
            this.NameBox.TabIndex = 9;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 177);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeliverBox;
        private System.Windows.Forms.TextBox CapacityBox;
        private System.Windows.Forms.TextBox DurationBox;
        private System.Windows.Forms.TextBox NameBox;
    }
}