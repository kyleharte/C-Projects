using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class FlagDay : Event
    {
        int noOfBoxes { get; set; }
        int[] arrayBoxAmount;

        public FlagDay(int noOfBoxes,
            int EventNo, DateTime eventd, String branchname, int Starttime, int EndTime) : base(EventNo, eventd, branchname, Starttime, EndTime)
        {
            this.noOfBoxes = noOfBoxes;
            arrayBoxAmount = arrayBoxAmount[noOfBoxes];
        }
    
        public int FlagDayIncome(){
            total = 0;                
            for(int i = 0; i < arrayBoxAmount.Length; i++){
                total += arrayBoxAmount[i];

            }
            return total;
        }
    }
}
