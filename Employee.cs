using System;
namespace COCDesignPattern
{
    public abstract class Employee : IEmployee
    {
        protected IEmployee Approver;
        public virtual void AuthorizedLeaves(int leavesCount)
        {

        } 
    }
}