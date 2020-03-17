using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project___Work__Rest__Pay_Rent
{
    class WorkScenario
    {        
        public int Days { get; set; }
        public int Money { get; set; }
        public int Energy { get; set; }
        public string Message { get; set; }

        public WorkScenario(int days, int money, int energy, string message) 
        {
            Days = days;
            Money = money;
            Energy = energy;
            Message = message;
        }
    }
}
