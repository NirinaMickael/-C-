namespace CSharp.People
{
    public class Student
    {
        public int Id { get; set; }
        public List<int> Note { get; set; } = new List<int>();
        public string? Name { get; set; }
    }
    public class Prof
    {
        public List<Student> students { get; set; } = new List<Student>();
        public void Moyenne()
        {
            foreach (var item in this.students)
            {
                var taille = item.Note.Count;
                if (taille < 1)
                {
                    Console.WriteLine("this student don't have a mark");
                }
                else
                {
                    double sum = 0;
                    for (int i = 0; i < taille; i++)
                    {
                        var el = item.Note[i];
                        sum += el;
                    }
                    Console.WriteLine("{0} had an average of {1}", item.Name, sum / taille);
                }
            }
        }
    }
}