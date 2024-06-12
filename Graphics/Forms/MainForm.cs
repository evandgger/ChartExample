using System.Globalization;
using Graphics.Helpers;

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

            var isStartRangeValid = InputHelper.ParseInput(startRangeInput, StartRangeLabel.Text, out var startRange);
            var isEndRangeValid = InputHelper.ParseInput(endRangeInput, EndRangeLabel.Text, out var endRange);
            var isStepValid = InputHelper.ParseInput(stepInput, StepLabel.Text, out var step);

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
            ClearSeries();

            var activeSeries = GetActiveSeries(VisualizationGroupBox);

            var xPoints = CalculateXPoints(startRange, endRange, step);

            foreach (var seriesName in activeSeries)
            {
                var series = ChartBox.Series[seriesName];

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

        private void RandomSeriesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomSeriesCheckBox.Checked)
            {
                var randomNumberForm = new RandomNumberRangeForm();

                randomNumberForm.FormClosed += (o, args) =>
                {
                    RandomStartRange = randomNumberForm.StartRange;
                    RandomEndRange = randomNumberForm.EndRange;
                };

                randomNumberForm.ShowDialog();
            }
            
            else
            {
                RandomStartRange = null;
                RandomEndRange = null;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearSeries();
        }

        private void ClearSeries()
        {
            var series = ChartBox.Series;

            foreach (var item in series)
            {
                item.Points.Clear();
            }
        }
    }
}