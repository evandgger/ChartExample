using Graphics.Models;

namespace Graphics.Series.Builders;

public class SinSeriesBuilder : ISeriesBuilder
{
    public List<SeriesPoint> Build(List<double> xPoints, double? startRange = null, double? endRange = null)
    {
        var result = new List<SeriesPoint>();

        foreach (var x in xPoints)
        {
            var y = Math.Sin(x);

            var point = new SeriesPoint(x, y);

            result.Add(point);
        }

        return result;
    }
}