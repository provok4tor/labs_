namespace Lab4.Main
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
            this.startMethodButton = new System.Windows.Forms.Button();
            this.inputParametersButton = new System.Windows.Forms.Button();
            this.ParametersListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PropertiesListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createObjectButton = new System.Windows.Forms.Button();
            this.selectMethodComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startMethodButton
            // 
            this.startMethodButton.Enabled = false;
            this.startMethodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startMethodButton.Location = new System.Drawing.Point(344, 396);
            this.startMethodButton.Margin = new System.Windows.Forms.Padding(4);
            this.startMethodButton.Name = "startMethodButton";
            this.startMethodButton.Size = new System.Drawing.Size(140, 54);
            this.startMethodButton.TabIndex = 21;
            this.startMethodButton.Text = "Выполнить метод";
            this.startMethodButton.UseVisualStyleBackColor = true;
            this.startMethodButton.Click += new System.EventHandler(this.startMethodButton_Click);
            // 
            // inputParametersButton
            // 
            this.inputParametersButton.Enabled = false;
            this.inputParametersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputParametersButton.Location = new System.Drawing.Point(177, 396);
            this.inputParametersButton.Margin = new System.Windows.Forms.Padding(4);
            this.inputParametersButton.Name = "inputParametersButton";
            this.inputParametersButton.Size = new System.Drawing.Size(159, 54);
            this.inputParametersButton.TabIndex = 20;
            this.inputParametersButton.Text = "Ввести параметры";
            this.inputParametersButton.UseVisualStyleBackColor = true;
            this.inputParametersButton.Click += new System.EventHandler(this.inputParametersButton_Click);
            // 
            // ParametersListBox
            // 
            this.ParametersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParametersListBox.FormattingEnabled = true;
            this.ParametersListBox.ItemHeight = 16;
            this.ParametersListBox.Location = new System.Drawing.Point(13, 304);
            this.ParametersListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ParametersListBox.Name = "ParametersListBox";
            this.ParametersListBox.Size = new System.Drawing.Size(471, 84);
            this.ParametersListBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Параметры метода";
            // 
            // PropertiesListBox
            // 
            this.PropertiesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PropertiesListBox.FormattingEnabled = true;
            this.PropertiesListBox.ItemHeight = 16;
            this.PropertiesListBox.Location = new System.Drawing.Point(13, 67);
            this.PropertiesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.PropertiesListBox.Name = "PropertiesListBox";
            this.PropertiesListBox.Size = new System.Drawing.Size(471, 212);
            this.PropertiesListBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Свойста объекта";
            // 
            // createObjectButton
            // 
            this.createObjectButton.Enabled = false;
            this.createObjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createObjectButton.Location = new System.Drawing.Point(13, 396);
            this.createObjectButton.Margin = new System.Windows.Forms.Padding(4);
            this.createObjectButton.Name = "createObjectButton";
            this.createObjectButton.Size = new System.Drawing.Size(156, 54);
            this.createObjectButton.TabIndex = 15;
            this.createObjectButton.Text = "Создать объект класса";
            this.createObjectButton.UseVisualStyleBackColor = true;
            this.createObjectButton.Click += new System.EventHandler(this.createObjectButton_Click);
            // 
            // selectMethodComboBox
            // 
            this.selectMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectMethodComboBox.Enabled = false;
            this.selectMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectMethodComboBox.FormattingEnabled = true;
            this.selectMethodComboBox.Location = new System.Drawing.Point(247, 4);
            this.selectMethodComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectMethodComboBox.Name = "selectMethodComboBox";
            this.selectMethodComboBox.Size = new System.Drawing.Size(237, 24);
            this.selectMethodComboBox.TabIndex = 14;
            this.selectMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.selectMethodComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(189, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Метод";
            // 
            // selectTypeComboBox
            // 
            this.selectTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectTypeComboBox.FormattingEnabled = true;
            this.selectTypeComboBox.Location = new System.Drawing.Point(69, 4);
            this.selectTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectTypeComboBox.Name = "selectTypeComboBox";
            this.selectTypeComboBox.Size = new System.Drawing.Size(112, 24);
            this.selectTypeComboBox.TabIndex = 12;
            this.selectTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.selectTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Класс";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 459);
            this.Controls.Add(this.startMethodButton);
            this.Controls.Add(this.inputParametersButton);
            this.Controls.Add(this.ParametersListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PropertiesListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createObjectButton);
            this.Controls.Add(this.selectMethodComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectTypeComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startMethodButton;
        private System.Windows.Forms.Button inputParametersButton;
        private System.Windows.Forms.ListBox ParametersListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox PropertiesListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createObjectButton;
        private System.Windows.Forms.ComboBox selectMethodComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectTypeComboBox;
        private System.Windows.Forms.Label label1;
    }
}

