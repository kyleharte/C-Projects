using System;

namespace Events
{
    // June 2017 P 20
    class Program
    {
        static void Main(string[] args)
        {
            Event[] arrayEvent = new Event[300];
            int currentSize = 84;
            
        }
        public double BranchIncome(Event[] arrayEvent, String requiredBranch, int currentSize)
        {
            for(int i = 0; i < currentSize; i++)
            {
                if(arrayEvent[i].branchName == requiredBranch)
                {
                    return arrayEvent[i].hostedIncome();
                }
            }
            return -1;
        }

       


    }
}
