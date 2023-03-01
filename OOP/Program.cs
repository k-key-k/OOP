namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                people[i] = new Person();
                people[i].Read();
            }
            for (int i = 0; i < people.Length;i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine(people[i].Name);
                Console.WriteLine(people[i].Surname);
                Console.WriteLine(people[i].Age(people[i].BDay));
                Console.WriteLine(people[i].Sex);
            }
        }
    }
}