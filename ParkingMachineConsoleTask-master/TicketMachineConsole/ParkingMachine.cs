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

        public ParkingMachine()
        {
            total = 0;
            currentTotal = 0;
            costPerHour = 20;
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


        public int Cancel()
        {
            int tal = currentTotal;
            currentTotal = 0;
            return tal;

        }

        public string BuyTicket()
        {
            Total = Total + currentTotal;
            int antalDagar = currentTotal / (costPerHour * 24);
            int rest = currentTotal % (costPerHour * 24);
            int antalTimmar = rest / costPerHour;
            int timmarRest = rest % costPerHour;
            int antalMinuter = timmarRest * 60 / costPerHour;
            int minuterRest = timmarRest *  60 % costPerHour;
            currentTotal = 0;
            return ("Parking Ticket valid for:" + Environment.NewLine + antalDagar + " days" + Environment.NewLine + antalTimmar + " Hours" + Environment.NewLine + antalMinuter + "Minutes");



        }
    }
}
