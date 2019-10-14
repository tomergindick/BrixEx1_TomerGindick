using BrixEx1_TomerGindick.Models;

namespace BrixEx1_TomerGindick
{
    public interface ICheckoutQueue
    {
        void AddCustomer(Customer cust);
        bool GetNextCustomer();
        int NumOfWaitingCustomers { get; }
    }
}