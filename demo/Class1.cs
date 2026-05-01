using System.Reflection;

namespace demo
{
    public class Ass_Calling_entry_excuting
    {
        public static void a_c_e_e()
        {
            Console.WriteLine("Tracing ......\nExcuting Assembly.....\nEntry Assembly....\nCalling Assembly ");
            Console.WriteLine($"Excuting Assembly : {Assembly.GetExecutingAssembly()}");
            Console.WriteLine($"Entry Assembly : {Assembly.GetEntryAssembly()}");
            Console.WriteLine($"Calling Assembly : {Assembly.GetCallingAssembly()}");
        }

    }
}
