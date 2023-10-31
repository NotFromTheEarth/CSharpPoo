using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using Tigrao.ContentContext;
using Tigrao.NotificationContext;
using Tigrao.SharedContext;
using Tigrao.SubscriptionContext;

Console.WriteLine("Hello, Welcome!");

var articles = new List<Article>();
articles.Add(new Article("Programação Orientada a Objetos", "orientacao-objetos"));
articles.Add(new Article("Programação Estruturada", "programacao-estruturada"));

Console.WriteLine("Lista de artigos:");
foreach(var article in articles)
{
    Console.WriteLine($"Id:{article.Id}");
    Console.WriteLine($"Title:{article.Title}");
    Console.WriteLine($"Url:{article.Url}");
    Console.WriteLine();
}

var courses = new List<Course>();
var courseOop = new Course("Introdução POO", "introducao-poo"); 
var courseCSharp = new Course("Introdução C#", "introducao-csharp");
var courseVariables =  new Course("Variables C#", "variables-csharp");

courses.Add(courseOop);
courses.Add(courseCSharp);
courses.Add(courseVariables);

Console.WriteLine("Lista de cursos:");
foreach(var course in courses)
{
    Console.WriteLine($"Id:{course.Id}");
    Console.WriteLine($"Title:{course.Title}");
    Console.WriteLine($"Url:{course.Url}");
    Console.WriteLine();
}

var careers = new List<Career>();
var careerDotnet = new Career("Especialista .Net", "especialista-dotnet");
var careerItem = new CareerItem(1, "Comece por aqui", "Coisa legal", null);
var careerItem3 = new CareerItem(3, "Interesting", "Aaaaaaa", courseCSharp);
var careerItem2 = new CareerItem(2, "Continue", "Coisa bacana", courseVariables);

careerDotnet.Courses.Add(careerItem2);
careerDotnet.Courses.Add(careerItem3);
careerDotnet.Courses.Add(careerItem);
careers.Add(careerDotnet);

foreach(var career in careers)
{
    Console.WriteLine(career.Title);

    foreach(var item in career.Courses.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course?.Title);

        foreach(var notification in item.Notifications)
        {
            Console.WriteLine($"{notification.Property} - {notification.Message}");
        }
    }
}

var payPalSubscription = new PayPalSubscription();
var student = new Student();
student.CreateSubscription(payPalSubscription);