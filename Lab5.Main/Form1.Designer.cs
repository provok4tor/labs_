namespace Lab5.Main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBuyerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.addBuyerToolStripMenuItem,
            this.addSellerToolStripMenuItem,
            this.addPointToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1654, 36);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip2";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(88, 32);
            this.startToolStripMenuItem.Text = "Запуск";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // addBuyerToolStripMenuItem
            // 
            this.addBuyerToolStripMenuItem.Enabled = false;
            this.addBuyerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addBuyerToolStripMenuItem.Name = "addBuyerToolStripMenuItem";
            this.addBuyerToolStripMenuItem.Size = new System.Drawing.Size(225, 32);
            this.addBuyerToolStripMenuItem.Text = "Добавить покупателя";
            this.addBuyerToolStripMenuItem.Click += new System.EventHandler(this.addBuyerToolStripMenuItem_Click);
            // 
            // addSellerToolStripMenuItem
            // 
            this.addSellerToolStripMenuItem.Enabled = false;
            this.addSellerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addSellerToolStripMenuItem.Name = "addSellerToolStripMenuItem";
            this.addSellerToolStripMenuItem.Size = new System.Drawing.Size(210, 32);
            this.addSellerToolStripMenuItem.Text = "Добавить продавца";
            this.addSellerToolStripMenuItem.Click += new System.EventHandler(this.addSellerToolStripMenuItem_Click);
            // 
            // addPointToolStripMenuItem
            // 
            this.addPointToolStripMenuItem.Enabled = false;
            this.addPointToolStripMenuItem.Name = "addPointToolStripMenuItem";
            this.addPointToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
            this.addPointToolStripMenuItem.Text = "Добавить точку продажи";
            this.addPointToolStripMenuItem.Click += new System.EventHandler(this.addPointToolStripMenuItem_Click);
            // 
            // notificationTextBox
            // 
            this.notificationTextBox.Location = new System.Drawing.Point(0, 39);
            this.notificationTextBox.Multiline = true;
            this.notificationTextBox.Name = "notificationTextBox";
            this.notificationTextBox.Size = new System.Drawing.Size(341, 676);
            this.notificationTextBox.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(347, 39);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1123, 676);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 716);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.notificationTextBox);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBuyerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPointToolStripMenuItem;
        private System.Windows.Forms.TextBox notificationTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

