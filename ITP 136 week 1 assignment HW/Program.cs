namespace ITP_136_week_1_assignment_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patientName;

            Console.WriteLine("Who is being seen today?");

            patientName = Console.ReadLine();

            Console.WriteLine("Welcome " + patientName);

            Console.ReadKey();
        }
    }
}
