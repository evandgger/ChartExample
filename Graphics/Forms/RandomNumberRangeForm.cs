using Graphics.Helpers;

namespace Graphics.Forms
{
    public partial class RandomNumberRangeForm : Form
    {
        public double StartRange { get; set; }

        public double EndRange { get; set; }

        public RandomNumberRangeForm()
        {
            InitializeComponent();
        }

        private void SetRandomRangeButton_Click(object sender, EventArgs e)
        {
            var startRangeInput = StartRandomRangeInput.Text;
            var endRangeInput = EndRandomRangeInput.Text;

            var isStartRangeValid = InputHelper.ParseInput(startRangeInput, RandomNumberStartRangeLabel.Text, out var startRange);
            var isEndRangeValid = InputHelper.ParseInput(endRangeInput, RandomNumberEndRangeLabel.Text, out var endRange);

            var inputsAreValid = isStartRangeValid && isEndRangeValid;

            if (inputsAreValid)
            {
                StartRange = startRange;
                EndRange = endRange;

                Close();
            }
            else
            {
                MessageBox.Show(@"Inputs are not valid. Please verify");
            }
        }
    }
}
