using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    abstract class Event
    {
        int eventNo { get; set; }
        DateTime eventDate { get; set; }
        String branchName { get; set; }
        int startTime { get; set; }
        int endTime { get; set; }

        public Event(int EventNo, DateTime eventd, String branchname, int Starttime, int EndTime)
        {
            eventNo = EventNo;
            eventDate = eventd;
            branchName = branchname;
            startTime = Starttime;
            endTime = EndTime;
        }

        protected Event()
        {
        }

        public virtual String toString()
        {
            return String.Format("EventNo : {0}" +
                " \n Event Date: {1} " +
                "\n Branch Name: {2} " +
                "\n Start Time: {3} " +
                "\n End Time: {4}"
                , eventNo, eventDate, branchName, startTime, endTime);
        }
    }
}
