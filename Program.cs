using System;

namespace ImageEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create image.
            //Image newImage = Image.FromFile(args[0]);
            Console.WriteLine("Image Editor is starting");
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a image file");
            }
            else
            {
                string argument = args[0];
                Console.WriteLine("Argument is: " + argument);
            }
        }
    }
}
