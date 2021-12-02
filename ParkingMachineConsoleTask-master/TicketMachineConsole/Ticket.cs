using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingMachineConsole
{
    public class Ticket
    {
        private DateTime purchaseTime;
        private readonly int costPerHour;
        private readonly int price;

        /// <summary>
        /// A ticket. Cannot be changed once created.
        /// </summary>
        /// <param name="price">The amount of money payed for the ticket. A hole number.</param>
        /// <param name="costPerHour">The cost per hour to park. A hole number.</param>
        public Ticket(int p, int c)
        {
            costPerHour = c;
            price = p;
        }
        /// <summary>
        /// Property to read cost per hour.
        /// </summary>
        public int CostPerHour
        {
            get
            {
                return costPerHour;
            }
        }


         public int Price
        {
            get
            {
                return price;
            }
        }



        public DateTime PurchaseTime
        {
            get
            {
                return purchaseTime;
            }
        }
        public TimeSpan GetParkingTimeSpan()
        {
            int antalDagar = price / (costPerHour * 24);
            int rest = price % (costPerHour * 24);
            int antalTimmar = rest / costPerHour;
            int timmarRest = rest % costPerHour;
            int antalMinuter = timmarRest * 60 / costPerHour;
            int minuterRest = timmarRest * 60 % costPerHour;
            TimeSpan timeSpan = new TimeSpan(days: antalDagar, hours: antalTimmar, minutes: antalMinuter, seconds: 0);
            return timeSpan;
        }


        public DateTime GetValidTo()
        {
            DateTime date = DateTime.Now;
            TimeSpan time = GetParkingTimeSpan();
            date = date.Add(time);
            return date;
        }

        public string ToString()
        {
            DateTime date = GetValidTo();
            TimeSpan time = GetParkingTimeSpan();
            return ("Parking ticket valid for:" + 
            Environment.NewLine + time.Days + " days" + 
            Environment.NewLine + time.Hours + " hours" + 
            Environment.NewLine + time.Minutes + " minutes" + Environment.NewLine + Environment.NewLine + "Valid to: " + date);
        }



    }
}
