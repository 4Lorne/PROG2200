using System.Collections.Generic;

namespace SchoolTracker
{
    interface IPayee
    {
        void Pay();
    }
    
    public class Payroll
    {

        private List<IPayee> payees = new List<IPayee>();
        public Payroll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
        }
        
        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }
        }
        
    }
}