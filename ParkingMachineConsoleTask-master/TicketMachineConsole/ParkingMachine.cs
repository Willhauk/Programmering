using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingMachineConsole
{
    /// <summary>
    /// An object of the class ParkingMachine represents a parking machine.
    /// 
    /// Insert money first. 
    /// 
    /// Then buy a ticket or select cancel to refund.
    /// </summary>
    public class ParkingMachine
    {
        // There is two places to save money.
        // Total in the machine, from all finnished purchases.
        private int total;

        // Total for the current customer.
        private int currentTotal;

        // Cost to park.
        private int costPerHour;
        

        public ParkingMachine(int c)
        {
            total = 0;
            currentTotal = 0;
            costPerHour = c;
            
        }

        public int CurrentTotal
        {
            get
            {
                return currentTotal;
            }
        }
        public int Total { get; set; }

        public int InsertMoney(int m)
        {
            if (m > 0)
            {
                currentTotal = m + currentTotal;
            }
            return currentTotal;

        }

        public int CostPerHour
        {
            get
            {
                return costPerHour;
            }
        }


        public int Cancel()
        {
            int tal = currentTotal;
            currentTotal = 0;
            return tal;

        }

        public Ticket BuyTicket()
        {
            Total = Total + currentTotal;
            DateTime date = GetValidTo();
            TimeSpan time = GetParkingTimeSpan();
            int total2 = currentTotal;
            currentTotal = 0;
            //  return ("Parking ticket valid for:" + 
            //    Environment.NewLine + time.Days + " days" + 
            //  Environment.NewLine + time.Hours + " hours" + 
            //Environment.NewLine + time.Minutes + " minutes" + Environment.NewLine + Environment.NewLine + "Valid to: " + date);
            return new Ticket(total2, costPerHour);
        }
       
        
        
        public DateTime GetValidTo()
        {
            DateTime date = DateTime.Now;
            TimeSpan time = GetParkingTimeSpan();
            date = date.Add(time);
            return date;
        }

        public TimeSpan GetParkingTimeSpan()
        {
            int antalDagar = currentTotal / (costPerHour * 24);
            int rest = currentTotal % (costPerHour * 24);
            int antalTimmar = rest / costPerHour;
            int timmarRest = rest % costPerHour;
            int antalMinuter = timmarRest * 60 / costPerHour;
            int minuterRest = timmarRest * 60 % costPerHour;
            TimeSpan timeSpan = new TimeSpan(days: antalDagar, hours: antalTimmar, minutes: antalMinuter, seconds: 0);
            return timeSpan;
        }
    }
}
