using Graphics.Models;

namespace Graphics.Series.Builders;

public class CustomSeriesBuilder : ISeriesBuilder
{
    public List<SeriesPoint> Build(List<double> xPoints, double? startRange = null, double? endRange = null)
    {
        var result = new List<SeriesPoint>();

        foreach (var x in xPoints)
        {
            var y = Math.Pow(x, 2);

            var point = new SeriesPoint(x, y);

            result.Add(point);
        }

        return result;
    }
}