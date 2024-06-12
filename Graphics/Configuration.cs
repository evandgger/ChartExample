using Graphics.Series.Builders;

namespace Graphics;

public static class Configuration
{
    public static Dictionary<string, ISeriesBuilder> SeriesBuilders = new()
    {
        { "random", new RandomSeriesBuilder() },
        { "custom", new CustomSeriesBuilder() },
        { "sin", new SinSeriesBuilder() }
    };

    public static Dictionary<string, string> Checkboxes = new()
    {
        { "SinSeriesCheckBox", "sin" },
        { "CustomSeriesCheckBox", "custom" },
        { "RandomSeriesCheckbox", "random" }
    };
}