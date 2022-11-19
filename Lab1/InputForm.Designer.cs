
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
            this.components = new System.ComponentModel.Container();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SelectFigureGroupBox.SuspendLayout();
            this.SphereGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectFigureGroupBox
            // 
            this.SelectFigureGroupBox.Controls.Add(this.SphereRadioButton);
            this.SelectFigureGroupBox.Controls.Add(this.PyramidRadioButton);
            this.SelectFigureGroupBox.Controls.Add(this.ParallelepipedRadioButton);
            this.SelectFigureGroupBox.Controls.Add(this.SphereGroupBox);
            this.SelectFigureGroupBox.Location = new System.Drawing.Point(50, 55);
            this.SelectFigureGroupBox.Name = "SelectFigureGroupBox";
            this.SelectFigureGroupBox.Size = new System.Drawing.Size(200, 148);
            this.SelectFigureGroupBox.TabIndex = 0;
            this.SelectFigureGroupBox.TabStop = false;
            this.SelectFigureGroupBox.Text = "Select figure";
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
            // 
            // PyramidRadioButton
            // 
            this.PyramidRadioButton.AutoSize = true;
            this.PyramidRadioButton.Location = new System.Drawing.Point(7, 60);
            this.PyramidRadioButton.Name = "PyramidRadioButton";
            this.PyramidRadioButton.Size = new System.Drawing.Size(80, 21);
            this.PyramidRadioButton.TabIndex = 1;
            this.PyramidRadioButton.Text = "Pyramid";
            this.PyramidRadioButton.UseVisualStyleBackColor = true;
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
            this.OkButton.Location = new System.Drawing.Point(57, 274);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 28);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(150, 274);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 28);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddRandomFigureButton
            // 
            this.AddRandomFigureButton.Location = new System.Drawing.Point(57, 222);
            this.AddRandomFigureButton.Name = "AddRandomFigureButton";
            this.AddRandomFigureButton.Size = new System.Drawing.Size(168, 28);
            this.AddRandomFigureButton.TabIndex = 8;
            this.AddRandomFigureButton.Text = "Add random figure";
            this.AddRandomFigureButton.UseVisualStyleBackColor = true;
            this.AddRandomFigureButton.Visible = false;
            this.AddRandomFigureButton.Click += new System.EventHandler(this.AddRandomFigureButton_Click);
            // 
            // pyramidUserControl
            // 
            this.pyramidUserControl.Location = new System.Drawing.Point(421, 30);
            this.pyramidUserControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pyramidUserControl.Name = "pyramidUserControl";
            this.pyramidUserControl.Size = new System.Drawing.Size(340, 341);
            this.pyramidUserControl.TabIndex = 5;
            // 
            // parallelepipedUserControl
            // 
            this.parallelepipedUserControl.Location = new System.Drawing.Point(421, 30);
            this.parallelepipedUserControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.parallelepipedUserControl.Name = "parallelepipedUserControl";
            this.parallelepipedUserControl.Size = new System.Drawing.Size(334, 303);
            this.parallelepipedUserControl.TabIndex = 4;
            // 
            // sphereUserControl
            // 
            this.sphereUserControl.Location = new System.Drawing.Point(421, 37);
            this.sphereUserControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sphereUserControl.Name = "sphereUserControl";
            this.sphereUserControl.Size = new System.Drawing.Size(303, 166);
            this.sphereUserControl.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 318);
            this.Controls.Add(this.AddRandomFigureButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.pyramidUserControl);
            this.Controls.Add(this.parallelepipedUserControl);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SelectFigureGroupBox);
            this.Controls.Add(this.sphereUserControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputForm";
            this.SelectFigureGroupBox.ResumeLayout(false);
            this.SelectFigureGroupBox.PerformLayout();
            this.SphereGroupBox.ResumeLayout(false);
            this.SphereGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
#if DEBUG
        private System.Windows.Forms.Button AddRandomFigureButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
#endif
    }
}