using System;
using System.Collections.Generic;
using System.Text;
namespace Events
{
    class Hosted : Event
    {
        String description { get; set; }
        String venue { get; set; }
        double venueChargePerPerson { get; set; }
        double ticketCharge { get; set; }
        int noAttended { get; set; }
        double donation { get; set; }

        public Hosted(String Description, String Venue, 
            double VenueChargePerPerson, double TicketCharge,
            int NoAttended, Double Donation,
            int EventNo, DateTime EventDate, String BranchName,
            int StartTime, int EndTime) : base(EventNo, EventDate, BranchName, StartTime, EndTime)
        {
            description = Description;
            venue = Venue;
            venueChargePerPerson = VenueChargePerPerson;
            ticketCharge = TicketCharge;
            noAttended = NoAttended;
            donation = Donation;
        }

        public double HostedIncome()
        {
            // Income is profit on a ticket, multiplied by noAttended plus donations
            // Profit on a ticket is ticketCharge = venueChargePer Person
            return (ticketCharge - venueChargePerPerson) * noAttended + donation;
        }
    }
}
