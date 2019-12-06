using System;

namespace composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder fo1 = new Folder("pasta1");
            File f1 = new File("a.txt", 32);
            File f2 = new File("b.txt", 23);
            f2.mIsModified = true;             

            Folder fo2 = new Folder("subpasta");
            File f3 = new File("c.txt", 132);
            File f4 = new File("d.txt", 323);

            Folder fo3 = new Folder("subsubpasta1");
            File f5 = new File("e.txt", 12);           

            Folder fo4 = new Folder("subsubpasta2");

            fo1
                .AddContent(f1)
                .AddContent(f2)
                .AddContent(fo2);

            fo2
                .AddContent(f3)
                .AddContent(f4)
                .AddContent(fo3)
                .AddContent(fo4);

            fo3
                .AddContent(f5);

            Console.WriteLine(">>> TEST - SIZE");
            Console.WriteLine($"FO1 - Size = {fo1.GetSize()}");
            Console.WriteLine($"FO2 - Size = {fo2.GetSize()}");
            Console.WriteLine($"FO3 - Size = {fo3.GetSize()}");
            Console.WriteLine($"FO4 - Size = {fo4.GetSize()}");
            Console.WriteLine("<<< TEST - SIZE");

            Console.WriteLine();

            Console.WriteLine(">>> TEST - MODIFIED");
            Console.WriteLine($"FO1 - Modified = {fo1.IsModified()}");
            Console.WriteLine($"FO2 - Modified = {fo2.IsModified()}");
            Console.WriteLine($"FO3 - Modified = {fo3.IsModified()}");
            Console.WriteLine($"FO4 - Modified = {fo4.IsModified()}");
            Console.WriteLine("<<< TEST - MODIFIED");
        }
    }
}
