using System;

namespace COCDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many leaves do you need?");
            string leavesCount = Console.ReadLine();
            HeadOfDept hd = new HeadOfDept();            
            HRManager hm = new HRManager(hd);
            DirectManager dm = new DirectManager(hm);

            dm.AuthorizedLeaves(Int32.Parse(leavesCount));
        }
    }    
}
