using ICPasswordGenerator;

namespace ICPasswordGenerator_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            GeneratePassword ic = new();
            ic.DisplayGenerate();
        }
    }
}