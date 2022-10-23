
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SphereRadioButton = new System.Windows.Forms.RadioButton();
            this.PyramidRadioButton = new System.Windows.Forms.RadioButton();
            this.ParallelepipedRadioButton = new System.Windows.Forms.RadioButton();
            this.SphereGroupBox = new System.Windows.Forms.GroupBox();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.pyramidUserControl = new View.PyramidUserControl();
            this.parallelepipedUserControl = new View.ParallelepipedUserControl();
            this.sphereUserControl = new View.SphereUserControl();
            this.groupBox1.SuspendLayout();
            this.SphereGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SphereRadioButton);
            this.groupBox1.Controls.Add(this.PyramidRadioButton);
            this.groupBox1.Controls.Add(this.ParallelepipedRadioButton);
            this.groupBox1.Controls.Add(this.SphereGroupBox);
            this.groupBox1.Location = new System.Drawing.Point(50, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select figure";
            // 
            // SphereRadioButton
            // 
            this.SphereRadioButton.AutoSize = true;
            this.SphereRadioButton.Location = new System.Drawing.Point(7, 90);
            this.SphereRadioButton.Name = "SphereRadioButton";
            this.SphereRadioButton.Size = new System.Drawing.Size(75, 21);
            this.SphereRadioButton.TabIndex = 2;
            this.SphereRadioButton.Text = "Sphere";
            this.SphereRadioButton.UseVisualStyleBackColor = true;
            this.SphereRadioButton.CheckedChanged += new System.EventHandler(this.SphereRadioButton_CheckedChanged);
            // 
            // PyramidRadioButton
            // 
            this.PyramidRadioButton.AutoSize = true;
            this.PyramidRadioButton.Checked = true;
            this.PyramidRadioButton.Location = new System.Drawing.Point(7, 60);
            this.PyramidRadioButton.Name = "PyramidRadioButton";
            this.PyramidRadioButton.Size = new System.Drawing.Size(80, 21);
            this.PyramidRadioButton.TabIndex = 1;
            this.PyramidRadioButton.TabStop = true;
            this.PyramidRadioButton.Text = "Pyramid";
            this.PyramidRadioButton.UseVisualStyleBackColor = true;
            this.PyramidRadioButton.CheckedChanged += new System.EventHandler(this.PyramidRadioButton_CheckedChanged);
            // 
            // ParallelepipedRadioButton
            // 
            this.ParallelepipedRadioButton.AutoSize = true;
            this.ParallelepipedRadioButton.Location = new System.Drawing.Point(7, 32);
            this.ParallelepipedRadioButton.Name = "ParallelepipedRadioButton";
            this.ParallelepipedRadioButton.Size = new System.Drawing.Size(119, 21);
            this.ParallelepipedRadioButton.TabIndex = 0;
            this.ParallelepipedRadioButton.Text = "Parallelepiped";
            this.ParallelepipedRadioButton.UseVisualStyleBackColor = true;
            this.ParallelepipedRadioButton.CheckedChanged += new System.EventHandler(this.ParallelepipedRadioButton_CheckedChanged);
            // 
            // SphereGroupBox
            // 
            this.SphereGroupBox.Controls.Add(this.RadiusLabel);
            this.SphereGroupBox.Controls.Add(this.RadiusTextBox);
            this.SphereGroupBox.Location = new System.Drawing.Point(194, 106);
            this.SphereGroupBox.Name = "SphereGroupBox";
            this.SphereGroupBox.Size = new System.Drawing.Size(325, 295);
            this.SphereGroupBox.TabIndex = 4;
            this.SphereGroupBox.TabStop = false;
            this.SphereGroupBox.Text = "Parameters";
            this.SphereGroupBox.Visible = false;
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(17, 37);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(52, 17);
            this.RadiusLabel.TabIndex = 1;
            this.RadiusLabel.Text = "Radius";
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(94, 37);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 22);
            this.RadiusTextBox.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(72, 348);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(260, 348);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(92, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // pyramidUserControl
            // 
            this.pyramidUserControl.Location = new System.Drawing.Point(421, 55);
            this.pyramidUserControl.Name = "pyramidUserControl";
            this.pyramidUserControl.Size = new System.Drawing.Size(340, 341);
            this.pyramidUserControl.TabIndex = 5;
            // 
            // parallelepipedUserControl
            // 
            this.parallelepipedUserControl.Location = new System.Drawing.Point(412, 37);
            this.parallelepipedUserControl.Name = "parallelepipedUserControl";
            this.parallelepipedUserControl.Size = new System.Drawing.Size(334, 303);
            this.parallelepipedUserControl.TabIndex = 4;
            // 
            // sphereUserControl
            // 
            this.sphereUserControl.Location = new System.Drawing.Point(421, 37);
            this.sphereUserControl.Name = "sphereUserControl";
            this.sphereUserControl.Size = new System.Drawing.Size(303, 166);
            this.sphereUserControl.TabIndex = 6;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 671);
            this.Controls.Add(this.pyramidUserControl);
            this.Controls.Add(this.parallelepipedUserControl);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sphereUserControl);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SphereGroupBox.ResumeLayout(false);
            this.SphereGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SphereRadioButton;
        private System.Windows.Forms.RadioButton PyramidRadioButton;
        private System.Windows.Forms.RadioButton ParallelepipedRadioButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private SphereUserControl SphereUserControl1;
        private System.Windows.Forms.GroupBox SphereGroupBox;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private ParallelepipedUserControl parallelepipedUserControl;
        private PyramidUserControl pyramidUserControl;
        private SphereUserControl sphereUserControl;
    }
}