namespace Lab3.Main
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Data = new System.Windows.Forms.Button();
            this.Deliver = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(430, 292);
            this.listBox1.TabIndex = 10;
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(238, 387);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(204, 55);
            this.Data.TabIndex = 9;
            this.Data.Text = "Информация";
            this.Data.UseVisualStyleBackColor = true;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // Deliver
            // 
            this.Deliver.Location = new System.Drawing.Point(238, 326);
            this.Deliver.Name = "Deliver";
            this.Deliver.Size = new System.Drawing.Size(204, 55);
            this.Deliver.TabIndex = 8;
            this.Deliver.Text = "Выполниить доставку";
            this.Deliver.UseVisualStyleBackColor = true;
            this.Deliver.Click += new System.EventHandler(this.Deliver_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(12, 387);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(204, 55);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 326);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(204, 55);
            this.Add.TabIndex = 6;
            this.Add.Text = "Добавить ";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Deliver);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Data;
        private System.Windows.Forms.Button Deliver;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
    }
}

