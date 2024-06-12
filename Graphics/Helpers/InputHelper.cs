namespace Graphics.Helpers;

public static class InputHelper
{
    public static bool ParseInput(string input, string fieldName, out double result)
    {
        var isValid = double.TryParse(input, out result);

        if (string.IsNullOrWhiteSpace(input))
            MessageBox.Show($@"Field {fieldName} cannot be empty");
        else if (!isValid) 
            MessageBox.Show($@"Field {fieldName} has invalid input");

        return isValid;
    }
}