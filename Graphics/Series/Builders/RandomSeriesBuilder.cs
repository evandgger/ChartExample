using Graphics.Models;

namespace Graphics.Series.Builders;

public class RandomSeriesBuilder : ISeriesBuilder
{
    public List<SeriesPoint> Build(List<double> xPoints, double? startRange = null, double? endRange = null)
    {
        var random = new Random();

        if (startRange == null || endRange == null)
            throw new InvalidOperationException("Unable to build the random series. Set up random numbers range");

        var result = new List<SeriesPoint>();

        foreach (var x in xPoints)
        {
            var y = random.NextDouble() * (endRange.Value - startRange.Value) + startRange.Value;

            var point = new SeriesPoint(x, y);

            result.Add(point);
        }

        return result;
    }
}