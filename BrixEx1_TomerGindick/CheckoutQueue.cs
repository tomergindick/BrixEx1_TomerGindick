using BrixEx1_TomerGindick.Models;
using System.Collections.Concurrent;

namespace BrixEx1_TomerGindick
{
    public class CheckoutQueue : ICheckoutQueue
    {
        private ConcurrentQueue<Customer> Customers { get; set; }

        public int NumOfWaitingCustomers
        {
            get { return Customers.Count; }
        }

        public CheckoutQueue()
        {
            Customers = new ConcurrentQueue<Customer>();
        }

        public void AddCustomer(Customer cust)
        {
            Customers.Enqueue(cust);
        }

        public bool GetNextCustomer()
        {
            Customer cust;
            return Customers.TryDequeue(out cust);
        }

    }
}