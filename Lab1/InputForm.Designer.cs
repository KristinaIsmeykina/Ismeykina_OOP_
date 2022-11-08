
namespace View
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
            this.SelectFigureGroupBox = new System.Windows.Forms.GroupBox();
            this.SphereRadioButton = new System.Windows.Forms.RadioButton();
            this.PyramidRadioButton = new System.Windows.Forms.RadioButton();
            this.ParallelepipedRadioButton = new System.Windows.Forms.RadioButton();
            this.SphereGroupBox = new System.Windows.Forms.GroupBox();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddRandomFigureButton = new System.Windows.Forms.Button();
            this.pyramidUserControl = new View.PyramidUserControl();
            this.parallelepipedUserControl = new View.ParallelepipedUserControl();
            this.sphereUserControl = new View.SphereUserControl();
            this.SelectFigureGroupBox.SuspendLayout();
            this.SphereGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectFigureGroupBox
            // 
            this.SelectFigureGroupBox.Controls.Add(this.SphereRadioButton);
            this.SelectFigureGroupBox.Controls.Add(this.PyramidRadioButton);
            this.SelectFigureGroupBox.Controls.Add(this.ParallelepipedRadioButton);
            this.SelectFigureGroupBox.Controls.Add(this.SphereGroupBox);
            this.SelectFigureGroupBox.Location = new System.Drawing.Point(56, 69);
            this.SelectFigureGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectFigureGroupBox.Name = "SelectFigureGroupBox";
            this.SelectFigureGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectFigureGroupBox.Size = new System.Drawing.Size(225, 185);
            this.SelectFigureGroupBox.TabIndex = 0;
            this.SelectFigureGroupBox.TabStop = false;
            this.SelectFigureGroupBox.Text = "Select figure";
            // 
            // SphereRadioButton
            // 
            this.SphereRadioButton.AutoSize = true;
            this.SphereRadioButton.Location = new System.Drawing.Point(8, 112);
            this.SphereRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SphereRadioButton.Name = "SphereRadioButton";
            this.SphereRadioButton.Size = new System.Drawing.Size(86, 24);
            this.SphereRadioButton.TabIndex = 2;
            this.SphereRadioButton.Text = "Sphere";
            this.SphereRadioButton.UseVisualStyleBackColor = true;
            // 
            // PyramidRadioButton
            // 
            this.PyramidRadioButton.AutoSize = true;
            this.PyramidRadioButton.Location = new System.Drawing.Point(8, 75);
            this.PyramidRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PyramidRadioButton.Name = "PyramidRadioButton";
            this.PyramidRadioButton.Size = new System.Drawing.Size(90, 24);
            this.PyramidRadioButton.TabIndex = 1;
            this.PyramidRadioButton.Text = "Pyramid";
            this.PyramidRadioButton.UseVisualStyleBackColor = true;
            // 
            // ParallelepipedRadioButton
            // 
            this.ParallelepipedRadioButton.AutoSize = true;
            this.ParallelepipedRadioButton.Checked = true;
            this.ParallelepipedRadioButton.Location = new System.Drawing.Point(8, 40);
            this.ParallelepipedRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ParallelepipedRadioButton.Name = "ParallelepipedRadioButton";
            this.ParallelepipedRadioButton.Size = new System.Drawing.Size(133, 24);
            this.ParallelepipedRadioButton.TabIndex = 0;
            this.ParallelepipedRadioButton.TabStop = true;
            this.ParallelepipedRadioButton.Text = "Parallelepiped";
            this.ParallelepipedRadioButton.UseVisualStyleBackColor = true;
            // 
            // SphereGroupBox
            // 
            this.SphereGroupBox.Controls.Add(this.RadiusLabel);
            this.SphereGroupBox.Controls.Add(this.RadiusTextBox);
            this.SphereGroupBox.Location = new System.Drawing.Point(218, 132);
            this.SphereGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SphereGroupBox.Name = "SphereGroupBox";
            this.SphereGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SphereGroupBox.Size = new System.Drawing.Size(366, 369);
            this.SphereGroupBox.TabIndex = 4;
            this.SphereGroupBox.TabStop = false;
            this.SphereGroupBox.Text = "Parameters";
            this.SphereGroupBox.Visible = false;
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(19, 46);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(59, 20);
            this.RadiusLabel.TabIndex = 1;
            this.RadiusLabel.Text = "Radius";
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(106, 46);
            this.RadiusTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(112, 26);
            this.RadiusTextBox.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(79, 429);
            this.OkButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(84, 35);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(183, 429);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(84, 35);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddRandomFigureButton
            // 
            this.AddRandomFigureButton.Location = new System.Drawing.Point(79, 362);
            this.AddRandomFigureButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddRandomFigureButton.Name = "AddRandomFigureButton";
            this.AddRandomFigureButton.Size = new System.Drawing.Size(189, 35);
            this.AddRandomFigureButton.TabIndex = 8;
            this.AddRandomFigureButton.Text = "Add random figure";
            this.AddRandomFigureButton.UseVisualStyleBackColor = true;
            this.AddRandomFigureButton.Click += new System.EventHandler(this.AddRandomFigureButton_Click);
            // 
            // pyramidUserControl
            // 
            this.pyramidUserControl.Location = new System.Drawing.Point(474, 38);
            this.pyramidUserControl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pyramidUserControl.Name = "pyramidUserControl";
            this.pyramidUserControl.Size = new System.Drawing.Size(382, 426);
            this.pyramidUserControl.TabIndex = 5;
            // 
            // parallelepipedUserControl
            // 
            this.parallelepipedUserControl.Location = new System.Drawing.Point(474, 38);
            this.parallelepipedUserControl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.parallelepipedUserControl.Name = "parallelepipedUserControl";
            this.parallelepipedUserControl.Size = new System.Drawing.Size(376, 379);
            this.parallelepipedUserControl.TabIndex = 4;
            // 
            // sphereUserControl
            // 
            this.sphereUserControl.Location = new System.Drawing.Point(474, 46);
            this.sphereUserControl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.sphereUserControl.Name = "sphereUserControl";
            this.sphereUserControl.Size = new System.Drawing.Size(341, 208);
            this.sphereUserControl.TabIndex = 6;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 839);
            this.Controls.Add(this.AddRandomFigureButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.pyramidUserControl);
            this.Controls.Add(this.parallelepipedUserControl);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SelectFigureGroupBox);
            this.Controls.Add(this.sphereUserControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.SelectFigureGroupBox.ResumeLayout(false);
            this.SelectFigureGroupBox.PerformLayout();
            this.SphereGroupBox.ResumeLayout(false);
            this.SphereGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectFigureGroupBox;
        private System.Windows.Forms.RadioButton SphereRadioButton;
        private System.Windows.Forms.RadioButton PyramidRadioButton;
        private System.Windows.Forms.RadioButton ParallelepipedRadioButton;
        private System.Windows.Forms.Button OkButton;
        //private System.Windows.Forms.Button CancelButton;
        private SphereUserControl SphereUserControl1;
        private System.Windows.Forms.GroupBox SphereGroupBox;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private ParallelepipedUserControl parallelepipedUserControl;
        private PyramidUserControl pyramidUserControl;
        private SphereUserControl sphereUserControl;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddRandomFigureButton;
    }
}