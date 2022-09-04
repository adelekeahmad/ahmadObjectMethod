// See https://aka.ms/new-console-template for more information
namespace ahmadObjectMethod{
    class program
    {
        static void Main(string[] args)
        {
            ObjectMethod student1 = new ObjectMethod("Ahmad", 700, 6.0);
            ObjectMethod student2 = new ObjectMethod("Timmy", 700, 6.5);
            ObjectMethod student3 = new ObjectMethod("Shanoy", 700, 5.0);
            Console.WriteLine(student3.hasHonours());
            Console.ReadLine();
        }
    }
}