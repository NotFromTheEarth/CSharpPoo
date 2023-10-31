using System.Collections.Generic;
using System.Reflection;
namespace Tigrao.ContentContext;

public class Course : Content
{
    public Course(string title, string url)
        :base (title, url) 
    {
        Modules = new List<Module>();
    }
    
    public string Tag { get; set; }
    public List<Module> Modules { get; set; }
}
