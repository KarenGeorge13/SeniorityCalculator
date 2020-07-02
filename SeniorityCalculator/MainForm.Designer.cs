namespace SeniorityCalculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.additionalPanel = new System.Windows.Forms.Panel();
            this.parentalLeaveComboBox = new System.Windows.Forms.ComboBox();
            this.regularMilitaryComboBox = new System.Windows.Forms.ComboBox();
            this.parentalLeaveLabel = new System.Windows.Forms.Label();
            this.militaryLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dismissalDateLabel = new System.Windows.Forms.Label();
            this.recruitmentDateLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addNewPeriodButton = new System.Windows.Forms.ToolStripButton();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculatedResult = new System.Windows.Forms.Label();
            this.additionalPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // additionalPanel
            // 
            this.additionalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.additionalPanel.Controls.Add(this.parentalLeaveComboBox);
            this.additionalPanel.Controls.Add(this.regularMilitaryComboBox);
            this.additionalPanel.Controls.Add(this.parentalLeaveLabel);
            this.additionalPanel.Controls.Add(this.militaryLabel);
            this.additionalPanel.Location = new System.Drawing.Point(10, 267);
            this.additionalPanel.Name = "additionalPanel";
            this.additionalPanel.Size = new System.Drawing.Size(514, 100);
            this.additionalPanel.TabIndex = 0;
            // 
            // parentalLeaveComboBox
            // 
            this.parentalLeaveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parentalLeaveComboBox.DropDownWidth = 275;
            this.parentalLeaveComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentalLeaveComboBox.FormattingEnabled = true;
            this.parentalLeaveComboBox.Items.AddRange(new object[] {
            "Нет",
            "Да, за 1 ребенком",
            "Да, за 2 детьми, в разное время",
            "Да, за 3 и более детьми, в разное время"});
            this.parentalLeaveComboBox.Location = new System.Drawing.Point(368, 58);
            this.parentalLeaveComboBox.Name = "parentalLeaveComboBox";
            this.parentalLeaveComboBox.Size = new System.Drawing.Size(121, 27);
            this.parentalLeaveComboBox.TabIndex = 3;
            // 
            // regularMilitaryComboBox
            // 
            this.regularMilitaryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regularMilitaryComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regularMilitaryComboBox.FormattingEnabled = true;
            this.regularMilitaryComboBox.Items.AddRange(new object[] {
            "Нет",
            "Да, 1 год",
            "Да, 1.5 года",
            "Да, 2 года"});
            this.regularMilitaryComboBox.Location = new System.Drawing.Point(368, 13);
            this.regularMilitaryComboBox.Name = "regularMilitaryComboBox";
            this.regularMilitaryComboBox.Size = new System.Drawing.Size(121, 27);
            this.regularMilitaryComboBox.TabIndex = 2;
            // 
            // parentalLeaveLabel
            // 
            this.parentalLeaveLabel.AutoSize = true;
            this.parentalLeaveLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentalLeaveLabel.Location = new System.Drawing.Point(14, 61);
            this.parentalLeaveLabel.Name = "parentalLeaveLabel";
            this.parentalLeaveLabel.Size = new System.Drawing.Size(332, 19);
            this.parentalLeaveLabel.TabIndex = 1;
            this.parentalLeaveLabel.Text = "Вы находились в отпуске по уходу за ребенком?";
            // 
            // militaryLabel
            // 
            this.militaryLabel.AutoSize = true;
            this.militaryLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.militaryLabel.Location = new System.Drawing.Point(14, 16);
            this.militaryLabel.Name = "militaryLabel";
            this.militaryLabel.Size = new System.Drawing.Size(318, 19);
            this.militaryLabel.TabIndex = 0;
            this.militaryLabel.Text = "Вы проходили воинскую службу по призыву?";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.dismissalDateLabel);
            this.mainPanel.Controls.Add(this.recruitmentDateLabel);
            this.mainPanel.Location = new System.Drawing.Point(10, 31);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(514, 225);
            this.mainPanel.TabIndex = 1;
            // 
            // dismissalDateLabel
            // 
            this.dismissalDateLabel.AutoSize = true;
            this.dismissalDateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dismissalDateLabel.Location = new System.Drawing.Point(235, 14);
            this.dismissalDateLabel.Name = "dismissalDateLabel";
            this.dismissalDateLabel.Size = new System.Drawing.Size(134, 19);
            this.dismissalDateLabel.TabIndex = 2;
            this.dismissalDateLabel.Text = "Дата увольнения";
            // 
            // recruitmentDateLabel
            // 
            this.recruitmentDateLabel.AutoSize = true;
            this.recruitmentDateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recruitmentDateLabel.Location = new System.Drawing.Point(32, 14);
            this.recruitmentDateLabel.Name = "recruitmentDateLabel";
            this.recruitmentDateLabel.Size = new System.Drawing.Size(174, 19);
            this.recruitmentDateLabel.TabIndex = 1;
            this.recruitmentDateLabel.Text = "Дата приема на работу";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPeriodButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(536, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addNewPeriodButton
            // 
            this.addNewPeriodButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addNewPeriodButton.Image = ((System.Drawing.Image)(resources.GetObject("addNewPeriodButton.Image")));
            this.addNewPeriodButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNewPeriodButton.Name = "addNewPeriodButton";
            this.addNewPeriodButton.Size = new System.Drawing.Size(150, 22);
            this.addNewPeriodButton.Text = "Добавить период работы";
            this.addNewPeriodButton.Click += new System.EventHandler(this.addNewPeriodButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(404, 373);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 35);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Сбросить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(10, 373);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 35);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(23, 433);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(245, 31);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Ваш трудовой стаж:";
            // 
            // calculatedResult
            // 
            this.calculatedResult.AutoSize = true;
            this.calculatedResult.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatedResult.Location = new System.Drawing.Point(275, 433);
            this.calculatedResult.Name = "calculatedResult";
            this.calculatedResult.Size = new System.Drawing.Size(0, 31);
            this.calculatedResult.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 496);
            this.Controls.Add(this.calculatedResult);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.additionalPanel);
            this.Name = "MainForm";
            this.Text = "Калькулятор трудового стажа";
            this.additionalPanel.ResumeLayout(false);
            this.additionalPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel additionalPanel;
        private System.Windows.Forms.ComboBox parentalLeaveComboBox;
        private System.Windows.Forms.ComboBox regularMilitaryComboBox;
        private System.Windows.Forms.Label parentalLeaveLabel;
        private System.Windows.Forms.Label militaryLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label dismissalDateLabel;
        private System.Windows.Forms.Label recruitmentDateLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addNewPeriodButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label calculatedResult;
    }
}

