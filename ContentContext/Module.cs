using System.Collections.Generic;
namespace Tigrao.ContentContext;

public class Module : SharedContext.Base
{
    public Module()
    {
        Lectures = new List<Lecture>();
    }
    
    public int Order { get; set; }
    public string Title { get; set; }
    public List<Lecture> Lectures { get; set; }
}