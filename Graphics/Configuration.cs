using Graphics.Series.Builders;

namespace Graphics;

public static class Configuration
{
    public static Dictionary<string, ISeriesBuilder> SeriesBuilders = new()
    {
        { RandomSeriesName, new RandomSeriesBuilder() },
        { CustomSeriesName, new CustomSeriesBuilder() },
        { SinSeriesName, new SinSeriesBuilder() }
    };

    public static Dictionary<string, string> Checkboxes = new()
    {
        { "SinSeriesCheckBox", SinSeriesName },
        { "CustomSeriesCheckBox", CustomSeriesName },
        { "RandomSeriesCheckBox", RandomSeriesName }
    };

    public const string SinSeriesName = "sin";

    public const string CustomSeriesName = "custom";

    public const string RandomSeriesName = "random";
}