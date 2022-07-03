namespace Lab5.Main
{
    partial class SelectSellerType
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
            this.agreeButton = new System.Windows.Forms.Button();
            this.selectSellerComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agreeButton
            // 
            this.agreeButton.Enabled = false;
            this.agreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.agreeButton.Location = new System.Drawing.Point(13, 82);
            this.agreeButton.Margin = new System.Windows.Forms.Padding(4);
            this.agreeButton.Name = "agreeButton";
            this.agreeButton.Size = new System.Drawing.Size(161, 41);
            this.agreeButton.TabIndex = 5;
            this.agreeButton.Text = "Выбрать";
            this.agreeButton.UseVisualStyleBackColor = true;
            this.agreeButton.Click += new System.EventHandler(this.agreeButton_Click);
            // 
            // selectSellerComboBox
            // 
            this.selectSellerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectSellerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectSellerComboBox.FormattingEnabled = true;
            this.selectSellerComboBox.Location = new System.Drawing.Point(13, 41);
            this.selectSellerComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectSellerComboBox.Name = "selectSellerComboBox";
            this.selectSellerComboBox.Size = new System.Drawing.Size(236, 33);
            this.selectSellerComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберете тип продавца";
            // 
            // SelectSellerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 138);
            this.Controls.Add(this.agreeButton);
            this.Controls.Add(this.selectSellerComboBox);
            this.Controls.Add(this.label1);
            this.Name = "SelectSellerType";
            this.Text = "SelectSellerType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agreeButton;
        private System.Windows.Forms.ComboBox selectSellerComboBox;
        private System.Windows.Forms.Label label1;
    }
}