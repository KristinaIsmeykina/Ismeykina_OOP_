
namespace View
{
    partial class PyramidUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.AngleOfSidesTextBox = new System.Windows.Forms.TextBox();
            this.AngleLabel = new System.Windows.Forms.Label();
            this.SecondSideTextBox = new System.Windows.Forms.TextBox();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.FirstSideTextBox = new System.Windows.Forms.TextBox();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.NumberOfCornersComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumberOfCornersComboBox);
            this.groupBox2.Controls.Add(this.NumberLabel);
            this.groupBox2.Controls.Add(this.AngleOfSidesTextBox);
            this.groupBox2.Controls.Add(this.AngleLabel);
            this.groupBox2.Controls.Add(this.SecondSideTextBox);
            this.groupBox2.Controls.Add(this.SecondLabel);
            this.groupBox2.Controls.Add(this.FirstSideTextBox);
            this.groupBox2.Controls.Add(this.FirstLabel);
            this.groupBox2.Controls.Add(this.HeightTextBox);
            this.groupBox2.Controls.Add(this.HeightLabel);
            this.groupBox2.Location = new System.Drawing.Point(18, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 253);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(22, 213);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(126, 17);
            this.NumberLabel.TabIndex = 8;
            this.NumberLabel.Text = "Number of corners";
            // 
            // AngleOfSidesTextBox
            // 
            this.AngleOfSidesTextBox.Location = new System.Drawing.Point(167, 167);
            this.AngleOfSidesTextBox.Name = "AngleOfSidesTextBox";
            this.AngleOfSidesTextBox.Size = new System.Drawing.Size(120, 22);
            this.AngleOfSidesTextBox.TabIndex = 7;
            // 
            // AngleLabel
            // 
            this.AngleLabel.AutoSize = true;
            this.AngleLabel.Location = new System.Drawing.Point(22, 167);
            this.AngleLabel.Name = "AngleLabel";
            this.AngleLabel.Size = new System.Drawing.Size(97, 17);
            this.AngleLabel.TabIndex = 6;
            this.AngleLabel.Text = "Angle of sides";
            // 
            // SecondSideTextBox
            // 
            this.SecondSideTextBox.Location = new System.Drawing.Point(167, 119);
            this.SecondSideTextBox.Name = "SecondSideTextBox";
            this.SecondSideTextBox.Size = new System.Drawing.Size(120, 22);
            this.SecondSideTextBox.TabIndex = 5;
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Location = new System.Drawing.Point(22, 124);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(139, 17);
            this.SecondLabel.TabIndex = 4;
            this.SecondLabel.Text = "Second side\'s length";
            // 
            // FirstSideTextBox
            // 
            this.FirstSideTextBox.Location = new System.Drawing.Point(167, 78);
            this.FirstSideTextBox.Name = "FirstSideTextBox";
            this.FirstSideTextBox.Size = new System.Drawing.Size(120, 22);
            this.FirstSideTextBox.TabIndex = 3;
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.Location = new System.Drawing.Point(22, 83);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(118, 17);
            this.FirstLabel.TabIndex = 2;
            this.FirstLabel.Text = "First side\'s length";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(167, 34);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(120, 22);
            this.HeightTextBox.TabIndex = 1;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(22, 34);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(49, 17);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "Height";
            // 
            // NumberOfCornersComboBox
            // 
            this.NumberOfCornersComboBox.FormattingEnabled = true;
            this.NumberOfCornersComboBox.Items.AddRange(new object[] {
            "2",
            "3"});
            this.NumberOfCornersComboBox.Location = new System.Drawing.Point(167, 213);
            this.NumberOfCornersComboBox.Name = "NumberOfCornersComboBox";
            this.NumberOfCornersComboBox.Size = new System.Drawing.Size(121, 24);
            this.NumberOfCornersComboBox.TabIndex = 9;
            // 
            // PyramidUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "PyramidUserControl";
            this.Size = new System.Drawing.Size(340, 341);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox AngleOfSidesTextBox;
        private System.Windows.Forms.Label AngleLabel;
        private System.Windows.Forms.TextBox SecondSideTextBox;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.TextBox FirstSideTextBox;
        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.ComboBox NumberOfCornersComboBox;
    }
}
