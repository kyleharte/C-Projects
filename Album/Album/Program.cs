using System;

namespace Album
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    // Album class
    /*
     * Atributes
     * stockNo int
     * artistName string
     * albumName string
     * price double
     * qtyInStock int
     */
    class Album
    {
        int stockNo;
        string artistName;
        string albumName;
        double price;
        int qtyInStock;

        // Construct blank
        public Album()
        {
            this.stockNo = 0;
            this.artistName = "";
            this.albumName = "";
            this.price = 0.00;
            this.qtyInStock = 0;
        }

        //Overloaded Constructor
        public Album (int stockNo, string artistName, string albumName, double price, int qtyInStock)
        {
            this.stockNo = stockNo;
            this.artistName = artistName;
            this.albumName = albumName;
            this.price = price;
            this.qtyInStock = qtyInStock;
        }

        
    }
}
