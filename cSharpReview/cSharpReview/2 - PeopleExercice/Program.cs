//Exercício sobre acesso de atributos de classes
namespace cSharpReview
{
    internal class ProgramPeople
    {
        static void Main1(string[] args)
        {
            People p1 = new People();
            People p2 = new People();

            Console.WriteLine("Enter name and age for people 1");
            p1.Name = Console.ReadLine();
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name and age for people 2");
            p2.Name = Console.ReadLine();
            p2.Age = int.Parse(Console.ReadLine());

            if (p1.Age > p2.Age)
                Console.WriteLine(p1.Name);
            else if (p1.Age < p2.Age)
                Console.WriteLine(p2.Name);
            else Console.WriteLine("Same age");
        }
    }
}
