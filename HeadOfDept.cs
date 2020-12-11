using System;
namespace COCDesignPattern
{
    public class  HeadOfDept : Employee
    {
        public override void AuthorizedLeaves(int leavesCount)
        {            
            Console.WriteLine("Leaves approved by Head of Department");
        }        
    }
}