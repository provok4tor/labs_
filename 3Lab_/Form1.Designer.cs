namespace _3Lab_
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
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Deliver = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(16, 326);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(204, 55);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить ";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(16, 387);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(204, 55);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Deliver
            // 
            this.Deliver.Location = new System.Drawing.Point(242, 326);
            this.Deliver.Name = "Deliver";
            this.Deliver.Size = new System.Drawing.Size(204, 55);
            this.Deliver.TabIndex = 3;
            this.Deliver.Text = "Выполниить доставку";
            this.Deliver.UseVisualStyleBackColor = true;
            this.Deliver.Click += new System.EventHandler(this.Deliver_Click);
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(242, 387);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(204, 55);
            this.Data.TabIndex = 4;
            this.Data.Text = "Информация";
            this.Data.UseVisualStyleBackColor = true;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(415, 228);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 460);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Deliver);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Deliver;
        private System.Windows.Forms.Button Data;
        private System.Windows.Forms.ListBox listBox1;
    }
}

