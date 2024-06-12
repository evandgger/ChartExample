using Graphics.Models;

namespace Graphics.Series.Builders;

public interface ISeriesBuilder
{
    public List<SeriesPoint> Build(List<double> xPoints, double? startRange = null, double? endRange = null);
}