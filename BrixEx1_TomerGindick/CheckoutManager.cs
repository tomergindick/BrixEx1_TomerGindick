using BrixEx1_TomerGindick.Models;
using System.Collections.Generic;
using System.Linq;

namespace BrixEx1_TomerGindick
{
    public class CheckoutManager
    {
        private List<CheckoutStation> Stations { get; set; }
        private ICheckoutQueue CheckoutQueue { get; set; }
        private CustomersAdder CustomersAdder { get; set; }
        private CheckoutWaitMonitor WaitTimeMonitor { get; set; }

        public CheckoutManager(int numOfCheckoutStations)
        {
            CheckoutQueue = new CheckoutQueue();
            CreateCheckoutStations(numOfCheckoutStations);
            CustomersAdder = new CustomersAdder(CheckoutQueue);
            WaitTimeMonitor = new CheckoutWaitMonitor(CheckoutQueue);
        }

        private void CreateCheckoutStations(int numOfCheckoutStations)
        {
            Stations = Enumerable.Range(0, numOfCheckoutStations)
                                 .Select(i => new CheckoutStation(CheckoutQueue))
                                 .ToList();
        }
    }
}
