﻿namespace Graphics.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guidelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RangeGroupBox = new System.Windows.Forms.GroupBox();
            this.StepInput = new System.Windows.Forms.TextBox();
            this.StepLabel = new System.Windows.Forms.Label();
            this.EndRangeLabel = new System.Windows.Forms.Label();
            this.StartRangeLabel = new System.Windows.Forms.Label();
            this.EndRangeInput = new System.Windows.Forms.TextBox();
            this.StartRangeInput = new System.Windows.Forms.TextBox();
            this.VisualizationGroupBox = new System.Windows.Forms.GroupBox();
            this.RandomRangeLabel = new System.Windows.Forms.Label();
            this.ChartTypeLabel = new System.Windows.Forms.Label();
            this.ChartTypeComboBox = new System.Windows.Forms.ComboBox();
            this.RandomSeriesCheckBox = new System.Windows.Forms.CheckBox();
            this.CustomSeriesCheckBox = new System.Windows.Forms.CheckBox();
            this.SinSeriesCheckBox = new System.Windows.Forms.CheckBox();
            this.TransformationGroupBox = new System.Windows.Forms.GroupBox();
            this.TransformButton = new System.Windows.Forms.Button();
            this.CoefficientLabel = new System.Windows.Forms.Label();
            this.AxisComboBox = new System.Windows.Forms.ComboBox();
            this.AxisLabel = new System.Windows.Forms.Label();
            this.CoefficientInput = new System.Windows.Forms.TextBox();
            this.BuildButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ChartBox = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            this.RangeGroupBox.SuspendLayout();
            this.VisualizationGroupBox.SuspendLayout();
            this.TransformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(949, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.guidelineToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // guidelineToolStripMenuItem
            // 
            this.guidelineToolStripMenuItem.Name = "guidelineToolStripMenuItem";
            this.guidelineToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.guidelineToolStripMenuItem.Text = "Instructions";
            // 
            // RangeGroupBox
            // 
            this.RangeGroupBox.Controls.Add(this.StepInput);
            this.RangeGroupBox.Controls.Add(this.StepLabel);
            this.RangeGroupBox.Controls.Add(this.EndRangeLabel);
            this.RangeGroupBox.Controls.Add(this.StartRangeLabel);
            this.RangeGroupBox.Controls.Add(this.EndRangeInput);
            this.RangeGroupBox.Controls.Add(this.StartRangeInput);
            this.RangeGroupBox.Location = new System.Drawing.Point(672, 36);
            this.RangeGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RangeGroupBox.Name = "RangeGroupBox";
            this.RangeGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RangeGroupBox.Size = new System.Drawing.Size(263, 163);
            this.RangeGroupBox.TabIndex = 1;
            this.RangeGroupBox.TabStop = false;
            this.RangeGroupBox.Text = "Range";
            // 
            // StepInput
            // 
            this.StepInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StepInput.Location = new System.Drawing.Point(107, 113);
            this.StepInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StepInput.Name = "StepInput";
            this.StepInput.Size = new System.Drawing.Size(114, 27);
            this.StepInput.TabIndex = 5;
            // 
            // StepLabel
            // 
            this.StepLabel.AutoSize = true;
            this.StepLabel.Location = new System.Drawing.Point(77, 117);
            this.StepLabel.Name = "StepLabel";
            this.StepLabel.Size = new System.Drawing.Size(20, 20);
            this.StepLabel.TabIndex = 4;
            this.StepLabel.Text = "H";
            // 
            // EndRangeLabel
            // 
            this.EndRangeLabel.AutoSize = true;
            this.EndRangeLabel.Location = new System.Drawing.Point(77, 72);
            this.EndRangeLabel.Name = "EndRangeLabel";
            this.EndRangeLabel.Size = new System.Drawing.Size(18, 20);
            this.EndRangeLabel.TabIndex = 3;
            this.EndRangeLabel.Text = "B";
            // 
            // StartRangeLabel
            // 
            this.StartRangeLabel.AutoSize = true;
            this.StartRangeLabel.Location = new System.Drawing.Point(77, 33);
            this.StartRangeLabel.Name = "StartRangeLabel";
            this.StartRangeLabel.Size = new System.Drawing.Size(19, 20);
            this.StartRangeLabel.TabIndex = 2;
            this.StartRangeLabel.Text = "A";
            // 
            // EndRangeInput
            // 
            this.EndRangeInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EndRangeInput.Location = new System.Drawing.Point(107, 68);
            this.EndRangeInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EndRangeInput.Name = "EndRangeInput";
            this.EndRangeInput.Size = new System.Drawing.Size(114, 27);
            this.EndRangeInput.TabIndex = 1;
            // 
            // StartRangeInput
            // 
            this.StartRangeInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StartRangeInput.Location = new System.Drawing.Point(107, 29);
            this.StartRangeInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartRangeInput.Name = "StartRangeInput";
            this.StartRangeInput.Size = new System.Drawing.Size(114, 27);
            this.StartRangeInput.TabIndex = 0;
            // 
            // VisualizationGroupBox
            // 
            this.VisualizationGroupBox.Controls.Add(this.RandomRangeLabel);
            this.VisualizationGroupBox.Controls.Add(this.ChartTypeLabel);
            this.VisualizationGroupBox.Controls.Add(this.ChartTypeComboBox);
            this.VisualizationGroupBox.Controls.Add(this.RandomSeriesCheckBox);
            this.VisualizationGroupBox.Controls.Add(this.CustomSeriesCheckBox);
            this.VisualizationGroupBox.Controls.Add(this.SinSeriesCheckBox);
            this.VisualizationGroupBox.Location = new System.Drawing.Point(672, 207);
            this.VisualizationGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VisualizationGroupBox.Name = "VisualizationGroupBox";
            this.VisualizationGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VisualizationGroupBox.Size = new System.Drawing.Size(263, 185);
            this.VisualizationGroupBox.TabIndex = 2;
            this.VisualizationGroupBox.TabStop = false;
            this.VisualizationGroupBox.Text = "Visualization";
            // 
            // RandomRangeLabel
            // 
            this.RandomRangeLabel.AutoSize = true;
            this.RandomRangeLabel.Location = new System.Drawing.Point(158, 97);
            this.RandomRangeLabel.Name = "RandomRangeLabel";
            this.RandomRangeLabel.Size = new System.Drawing.Size(0, 20);
            this.RandomRangeLabel.TabIndex = 4;
            // 
            // ChartTypeLabel
            // 
            this.ChartTypeLabel.AutoSize = true;
            this.ChartTypeLabel.Location = new System.Drawing.Point(30, 133);
            this.ChartTypeLabel.Name = "ChartTypeLabel";
            this.ChartTypeLabel.Size = new System.Drawing.Size(77, 20);
            this.ChartTypeLabel.TabIndex = 3;
            this.ChartTypeLabel.Text = "Chart type";
            // 
            // ChartTypeComboBox
            // 
            this.ChartTypeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChartTypeComboBox.FormattingEnabled = true;
            this.ChartTypeComboBox.Items.AddRange(new object[] {
            "Dot",
            "Diagram",
            "Spline"});
            this.ChartTypeComboBox.Location = new System.Drawing.Point(107, 129);
            this.ChartTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChartTypeComboBox.Name = "ChartTypeComboBox";
            this.ChartTypeComboBox.Size = new System.Drawing.Size(114, 28);
            this.ChartTypeComboBox.TabIndex = 0;
            // 
            // RandomSeriesCheckBox
            // 
            this.RandomSeriesCheckBox.AutoSize = true;
            this.RandomSeriesCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomSeriesCheckBox.Location = new System.Drawing.Point(7, 96);
            this.RandomSeriesCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RandomSeriesCheckBox.Name = "RandomSeriesCheckBox";
            this.RandomSeriesCheckBox.Size = new System.Drawing.Size(87, 24);
            this.RandomSeriesCheckBox.TabIndex = 2;
            this.RandomSeriesCheckBox.Text = "Random";
            this.RandomSeriesCheckBox.UseVisualStyleBackColor = true;
            this.RandomSeriesCheckBox.CheckedChanged += new System.EventHandler(this.RandomSeriesCheckBox_CheckedChanged);
            // 
            // CustomSeriesCheckBox
            // 
            this.CustomSeriesCheckBox.AutoSize = true;
            this.CustomSeriesCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomSeriesCheckBox.Location = new System.Drawing.Point(7, 63);
            this.CustomSeriesCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomSeriesCheckBox.Name = "CustomSeriesCheckBox";
            this.CustomSeriesCheckBox.Size = new System.Drawing.Size(125, 24);
            this.CustomSeriesCheckBox.TabIndex = 1;
            this.CustomSeriesCheckBox.Text = "y = x (custom)";
            this.CustomSeriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // SinSeriesCheckBox
            // 
            this.SinSeriesCheckBox.AutoSize = true;
            this.SinSeriesCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SinSeriesCheckBox.Location = new System.Drawing.Point(7, 29);
            this.SinSeriesCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SinSeriesCheckBox.Name = "SinSeriesCheckBox";
            this.SinSeriesCheckBox.Size = new System.Drawing.Size(159, 24);
            this.SinSeriesCheckBox.TabIndex = 0;
            this.SinSeriesCheckBox.Text = "y = sin (x) (general)";
            this.SinSeriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // TransformationGroupBox
            // 
            this.TransformationGroupBox.Controls.Add(this.TransformButton);
            this.TransformationGroupBox.Controls.Add(this.CoefficientLabel);
            this.TransformationGroupBox.Controls.Add(this.AxisComboBox);
            this.TransformationGroupBox.Controls.Add(this.AxisLabel);
            this.TransformationGroupBox.Controls.Add(this.CoefficientInput);
            this.TransformationGroupBox.Location = new System.Drawing.Point(672, 400);
            this.TransformationGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TransformationGroupBox.Name = "TransformationGroupBox";
            this.TransformationGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TransformationGroupBox.Size = new System.Drawing.Size(263, 180);
            this.TransformationGroupBox.TabIndex = 3;
            this.TransformationGroupBox.TabStop = false;
            this.TransformationGroupBox.Text = "Transformation";
            // 
            // TransformButton
            // 
            this.TransformButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransformButton.Location = new System.Drawing.Point(107, 141);
            this.TransformButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TransformButton.Name = "TransformButton";
            this.TransformButton.Size = new System.Drawing.Size(114, 31);
            this.TransformButton.TabIndex = 4;
            this.TransformButton.Text = "Apply";
            this.TransformButton.UseVisualStyleBackColor = true;
            // 
            // CoefficientLabel
            // 
            this.CoefficientLabel.AutoSize = true;
            this.CoefficientLabel.Location = new System.Drawing.Point(22, 76);
            this.CoefficientLabel.Name = "CoefficientLabel";
            this.CoefficientLabel.Size = new System.Drawing.Size(81, 20);
            this.CoefficientLabel.TabIndex = 3;
            this.CoefficientLabel.Text = "Coefficient";
            // 
            // AxisComboBox
            // 
            this.AxisComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AxisComboBox.FormattingEnabled = true;
            this.AxisComboBox.Items.AddRange(new object[] {
            "Axis X",
            "Axis Y"});
            this.AxisComboBox.Location = new System.Drawing.Point(107, 35);
            this.AxisComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AxisComboBox.Name = "AxisComboBox";
            this.AxisComboBox.Size = new System.Drawing.Size(114, 28);
            this.AxisComboBox.TabIndex = 2;
            // 
            // AxisLabel
            // 
            this.AxisLabel.AutoSize = true;
            this.AxisLabel.Location = new System.Drawing.Point(67, 39);
            this.AxisLabel.Name = "AxisLabel";
            this.AxisLabel.Size = new System.Drawing.Size(36, 20);
            this.AxisLabel.TabIndex = 1;
            this.AxisLabel.Text = "Axis";
            // 
            // CoefficientInput
            // 
            this.CoefficientInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CoefficientInput.Location = new System.Drawing.Point(107, 73);
            this.CoefficientInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CoefficientInput.Name = "CoefficientInput";
            this.CoefficientInput.Size = new System.Drawing.Size(114, 27);
            this.CoefficientInput.TabIndex = 0;
            // 
            // BuildButton
            // 
            this.BuildButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuildButton.Location = new System.Drawing.Point(749, 619);
            this.BuildButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(86, 31);
            this.BuildButton.TabIndex = 4;
            this.BuildButton.Text = "Build";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Location = new System.Drawing.Point(841, 619);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(94, 31);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ChartBox
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartBox.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartBox.Legends.Add(legend1);
            this.ChartBox.Location = new System.Drawing.Point(14, 36);
            this.ChartBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChartBox.Name = "ChartBox";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "sin";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "custom";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "random";
            this.ChartBox.Series.Add(series1);
            this.ChartBox.Series.Add(series2);
            this.ChartBox.Series.Add(series3);
            this.ChartBox.Size = new System.Drawing.Size(651, 613);
            this.ChartBox.TabIndex = 6;
            this.ChartBox.Text = "Chart";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 665);
            this.Controls.Add(this.ChartBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.TransformationGroupBox);
            this.Controls.Add(this.VisualizationGroupBox);
            this.Controls.Add(this.RangeGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Chart example";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.RangeGroupBox.ResumeLayout(false);
            this.RangeGroupBox.PerformLayout();
            this.VisualizationGroupBox.ResumeLayout(false);
            this.VisualizationGroupBox.PerformLayout();
            this.TransformationGroupBox.ResumeLayout(false);
            this.TransformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private GroupBox RangeGroupBox;
        private GroupBox VisualizationGroupBox;
        private GroupBox TransformationGroupBox;
        private Button BuildButton;
        private Button ResetButton;
        private Label EndRangeLabel;
        private Label StartRangeLabel;
        private TextBox EndRangeInput;
        private TextBox StartRangeInput;
        private CheckBox RandomSeriesCheckBox;
        private CheckBox CustomSeriesCheckBox;
        private CheckBox SinSeriesCheckBox;
        private ComboBox ChartTypeComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBox;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem guidelineToolStripMenuItem;
        private TextBox StepInput;
        private Label StepLabel;
        private Label ChartTypeLabel;
        private Button TransformButton;
        private Label CoefficientLabel;
        private ComboBox AxisComboBox;
        private Label AxisLabel;
        private TextBox CoefficientInput;
        private Label RandomRangeLabel;
    }
}