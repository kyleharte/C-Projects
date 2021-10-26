using System;

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Accomodation[] array = new Accomodation[3];
            array[0] = new Business(0, "135 ", "", "FSAD321", 135.3, 1.3, 1, 300, 'R');
            array[1] = new Flat(100.1, 1, "160", "", "POST103", 135000, 132.4, 12, "Flat", 2, 1);
            array[2] = new Housing(2, "161", "", "POST104", 154322, 10, 1, "F", 2, 20);
            foreach(Accomodation acc in array)
            {
                Console.Write(acc.toString() + "\n" + "Income " + acc.incomeYear() + "\n --------------- \n");

            }



        }
    }
    abstract class Accomodation
    {
        // Auto proterty short hand noation for long getter and setter
        /*
      * Will Return
      * private int _accomodationNo;
      * public int accomdationNo{
      * get { return this._accomodationNo;}
      * set { this._accomodationNo = value;}
      * }
      */
        // Simple getter and setters for all the class variables
        public int accomodationNo { get; set; }
        public String address1 { get; set; }
        public String address2 { get; set; }
        public String postcode { get; set; }
        public double valulation { get; set; }
        public double rent { get; set; }
        public int noRentPaymentsPerYear { get; set; }
        /*
         * Name; Accomodation
         * Params; class variables
         * Function; to initalise all variables in the base class
         */
        public Accomodation(int accomodationno, String address1, String address2, string postcode,
            double valuation, double rent, int norentpaymentsperyear)
        {
            this.accomodationNo = accomodationno;
            this.address1 = address1;
            this.address2 = address2;
            this.postcode = postcode;
            this.valulation = valuation;
            this.rent = rent;
            this.noRentPaymentsPerYear = norentpaymentsperyear;
        }
        public String toString()
        {
            String s = "AccomdationNo: {0} " +
                "\n Address 1: {1} " +
                "\n Address2: {2} " +
                "\n Postcode: {3} " +
                "\n Valuation: {4} " +
                "\n Rent: {5} " +
                "\n Number of Rent Payments per Year: {6} " +
                "\n Unit Type: {7}" +
                "\n Income: {8}";
            return String.Format(s, this.accomodationNo,
                this.address1, this.address2, this.postcode,
                this.valulation, this.rent, this.noRentPaymentsPerYear,
                this.GetType(), this.incomeYear());
        }

        /*
         * Income Year Method
         * Returns rent * no rent payments
         */
        public virtual double incomeYear()
        {
            return this.rent * this.noRentPaymentsPerYear;
        }


    }
    class Housing : Accomodation
    {
        public String type { get; set; }
        public int noBedrooms { get; set; }
        public int noCarParkingSites { get; set; }
        public Housing(int accomodationno, String address1, String address2, string postcode,
            double valuation, double rent, int norentpaymentsperyear,
            String type, int nobedroms, int nocarparkingsites) :
            base(accomodationno, address1, address2, postcode, valuation, rent, norentpaymentsperyear)
        {
            this.type = type;
            this.noBedrooms = nobedroms;
            this.noCarParkingSites = nocarparkingsites;
        }
    }

    class Flat : Housing
    {
        // Flat specfic variables inc getter and setter
        double maintanceCharge { get; set; }

        // Flat Constructor that calls base constructors
        public Flat(double maintanceCharge, int accomodationno, String address1, String address2, string postcode,
            double valuation, double rent, int norentpaymentsperyear,
            String type, int nobedroms, int nocarparkingsites) :
            base(accomodationno, address1, address2, postcode, valuation,
                rent, norentpaymentsperyear, type, nobedroms, nocarparkingsites)
        {
            this.maintanceCharge = maintanceCharge;
        }
        public override double incomeYear()
        {
            Console.WriteLine("LOG");
            return maintanceCharge + (rent * noRentPaymentsPerYear);
        }
    }

    class Business : Accomodation
    {
        // Business specific variables inc get and set
        int size { get; set; }
        char retailOrOffice { get; set; }

        // Business constructor
        public Business(int accomodationno, String address1, String address2, string postcode,
            double valuation, double rent, int norentpaymentsperyear,
            int size, char retailOrOffice) :
            base(accomodationno, address1, address2, postcode, valuation, rent, norentpaymentsperyear)
        {
            this.size = size;
            this.retailOrOffice = retailOrOffice;
        }
    }
}

