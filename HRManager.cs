using System;
namespace COCDesignPattern
{
    public class  HRManager : Employee
    {
        public HRManager(IEmployee emp)
        {
            this.Approver = emp;
        }

        public override void AuthorizedLeaves(int leavesCount)
        {
            if(leavesCount > 5)
            {                
                Console.WriteLine("Leaves has to be approved by Head of Department");
                this.Approver.AuthorizedLeaves(leavesCount);
            }
            else
            {
                Console.WriteLine("Leaves approved by HR Manager");
            }
        }
    }
}