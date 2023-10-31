using System.Collections.Generic;

namespace Tigrao.ContentContext;

public class Career : Content
{
    public Career(string title, string url)
        : base (title, url)
    {
        Courses = new List<CareerItem>();
    }
    
    public List<CareerItem> Courses { get; set; }
    public int TotalCourses => Courses.Count;
}