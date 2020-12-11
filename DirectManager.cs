using System;

namespace COCDesignPattern
{
    public class  DirectManager : Employee
    {
        public DirectManager(IEmployee emp)
        {
            this.Approver = emp;
        }

        public override void AuthorizedLeaves(int leavesCount)
        {
            if(leavesCount > 2)
            {
                Console.WriteLine("Leaves has to be approved by HR");
                this.Approver.AuthorizedLeaves(leavesCount);                
            }
            else
            {
                Console.WriteLine("Leaves approved by Manager");
            }
        }

    }
}
