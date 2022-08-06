using System;
using CSharp.People;
namespace CSharp
{    public class Program
    {
        static void Main(string[] args)
        {
            var Students = new List<Student>{
                new Student{Id=1,Name="Mickael",Note={
                    10,10
                }},
                new Student{Id=1,Name="Mickael",Note={
                    11,10
                }}
            };
            var Prof = new Prof{
                students=Students
            };
            Prof.Moyenne();
        }
        static void Affiche_all_Students (List<Student>_students){
            foreach (var item in _students)
            {
                Console.WriteLine("id : {0} -> name : {1}",item.Id,item.Name);
            }
        }
    }
}