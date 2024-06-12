using System.Globalization;

namespace Graphics.Forms
{
    public partial class MainForm : Form
    {
        public double? RandomStartRange { get; set; }

        public double? RandomEndRange { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            var startRangeInput = StartRangeInput.Text;
            var endRangeInput = EndRangeInput.Text;
            var stepInput = StepInput.Text;

            var isStartRangeValid = ParseInput(startRangeInput, StartRangeLabel.Text, out var startRange);
            var isEndRangeValid = ParseInput(endRangeInput, EndRangeLabel.Text, out var endRange);
            var isStepValid = ParseInput(stepInput, StepLabel.Text, out var step);

            var isConfigurationValid = isStartRangeValid && isEndRangeValid && isStepValid;

            if (!isConfigurationValid)
            {
                MessageBox.Show(@"Unable to build the chart. Please, validate your input");

                return;
            }

            VerifyRange(ref startRange, ref endRange);

            DrawSeries(startRange, endRange, step);
        }

        private void DrawSeries(double startRange, double endRange, double step)
        {
            var activeSeries = GetActiveSeries(VisualizationGroupBox);

            var xPoints = CalculateXPoints(startRange, endRange, step);

            foreach (var seriesName in activeSeries)
            {
                var series = ChartBox.Series[seriesName];

                series.Points.Clear();

                var pointBuilder = Configuration.SeriesBuilders[seriesName];

                var points = pointBuilder.Build(xPoints, RandomStartRange, RandomEndRange);

                foreach (var point in points)
                {
                    series.Points.AddXY(point.X, point.Y);
                }
            }
        }

        private List<double> CalculateXPoints(double startRange, double endRange, double step)
        {
            var result = new List<double>();

            for (var point = startRange; point <= endRange; point += step)
            {
                result.Add(point);
            }
            
            return result;
        }

        private List<string> GetActiveSeries(GroupBox groupBox)
        {
            EnsureSeriesChecked(groupBox);

            var result = new List<string>();

            foreach (var control in groupBox.Controls)
            {
                if (control is CheckBox checkbox)
                {
                    if (checkbox.Checked)
                    {
                        result.Add(Configuration.Checkboxes[checkbox.Name]);
                    }
                }
            }

            return result;
        }

        private void EnsureSeriesChecked(GroupBox groupBox)
        {
            var atLeastOneChecked = false;

            foreach (var control in groupBox.Controls)
            {
                if (control is CheckBox checkbox)
                {
                    if (checkbox.Checked)
                    {
                        atLeastOneChecked = true;

                        break;
                    }
                }
            }

            if (!atLeastOneChecked)
            {
                SinSeriesCheckBox.Checked = true;

                MessageBox.Show(@"There is no selected series. sin(x) was set as default");
            }
        }

        private void VerifyRange(ref double start, ref double end)
        {
            if (start > end)
            {
                (start, end) = (end, start);

                MessageBox.Show(@"Range is reversed");

                StartRangeInput.Text = start.ToString(CultureInfo.InvariantCulture);
                EndRangeInput.Text = end.ToString(CultureInfo.InvariantCulture);
            }
        }

        private static bool ParseInput(string input, string fieldName, out double result)
        {
            var isValid = double.TryParse(input, out result);

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show($@"Field {fieldName} cannot be empty");
            }
            else if (!isValid)
            {
                MessageBox.Show($@"Field {fieldName} has invalid input");
            }

            return isValid;
        }

        private void RandomSeriesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomSeriesCheckBox.Checked)
            {
                // open dialog and collect range details
            }
            
            else
            {
                RandomStartRange = null;
                RandomEndRange = null;
            }
        }
    }
}