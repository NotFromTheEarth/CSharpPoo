using Tigrao.ContentContext.Enums;

namespace Tigrao.ContentContext;

public class Lecture : SharedContext.Base
{
    public int Order { get; set; }
    public string Title { get; set; }
    public int DurationInMinutes { get; set; }
    public EContentLevel ContentLevel { get; set; }
}