namespace Graphics.Forms
{
    partial class RandomNumberRangeForm
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
            this.StartRandomRangeInput = new System.Windows.Forms.TextBox();
            this.EndRandomRangeInput = new System.Windows.Forms.TextBox();
            this.RandomNumberStartRangeLabel = new System.Windows.Forms.Label();
            this.RandomNumberEndRangeLabel = new System.Windows.Forms.Label();
            this.SetRandomRangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartRandomRangeInput
            // 
            this.StartRandomRangeInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StartRandomRangeInput.Location = new System.Drawing.Point(118, 50);
            this.StartRandomRangeInput.Name = "StartRandomRangeInput";
            this.StartRandomRangeInput.Size = new System.Drawing.Size(125, 27);
            this.StartRandomRangeInput.TabIndex = 0;
            // 
            // EndRandomRangeInput
            // 
            this.EndRandomRangeInput.Location = new System.Drawing.Point(118, 127);
            this.EndRandomRangeInput.Name = "EndRandomRangeInput";
            this.EndRandomRangeInput.Size = new System.Drawing.Size(125, 27);
            this.EndRandomRangeInput.TabIndex = 1;
            // 
            // RandomNumberStartRangeLabel
            // 
            this.RandomNumberStartRangeLabel.AutoSize = true;
            this.RandomNumberStartRangeLabel.Location = new System.Drawing.Point(25, 57);
            this.RandomNumberStartRangeLabel.Name = "RandomNumberStartRangeLabel";
            this.RandomNumberStartRangeLabel.Size = new System.Drawing.Size(82, 20);
            this.RandomNumberStartRangeLabel.TabIndex = 2;
            this.RandomNumberStartRangeLabel.Text = "Start range";
            // 
            // RandomNumberEndRangeLabel
            // 
            this.RandomNumberEndRangeLabel.AutoSize = true;
            this.RandomNumberEndRangeLabel.Location = new System.Drawing.Point(25, 130);
            this.RandomNumberEndRangeLabel.Name = "RandomNumberEndRangeLabel";
            this.RandomNumberEndRangeLabel.Size = new System.Drawing.Size(76, 20);
            this.RandomNumberEndRangeLabel.TabIndex = 3;
            this.RandomNumberEndRangeLabel.Text = "End range";
            // 
            // SetRandomRangeButton
            // 
            this.SetRandomRangeButton.Location = new System.Drawing.Point(149, 199);
            this.SetRandomRangeButton.Name = "SetRandomRangeButton";
            this.SetRandomRangeButton.Size = new System.Drawing.Size(94, 29);
            this.SetRandomRangeButton.TabIndex = 4;
            this.SetRandomRangeButton.Text = "Apply";
            this.SetRandomRangeButton.UseVisualStyleBackColor = true;
            this.SetRandomRangeButton.Click += new System.EventHandler(this.SetRandomRangeButton_Click);
            // 
            // RandomNumberRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 251);
            this.Controls.Add(this.SetRandomRangeButton);
            this.Controls.Add(this.RandomNumberEndRangeLabel);
            this.Controls.Add(this.RandomNumberStartRangeLabel);
            this.Controls.Add(this.EndRandomRangeInput);
            this.Controls.Add(this.StartRandomRangeInput);
            this.Name = "RandomNumberRangeForm";
            this.Text = "Random Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox StartRandomRangeInput;
        private TextBox EndRandomRangeInput;
        private Label RandomNumberStartRangeLabel;
        private Label RandomNumberEndRangeLabel;
        private Button SetRandomRangeButton;
    }
}