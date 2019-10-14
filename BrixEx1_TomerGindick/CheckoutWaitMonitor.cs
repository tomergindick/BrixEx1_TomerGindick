using System.Threading;
using System.Threading.Tasks;

namespace BrixEx1_TomerGindick
{
    public class CheckoutWaitMonitor
    {
        public CheckoutWaitMonitor(ICheckoutQueue checkoutQueue)
        {
            Task.Factory.StartNew(() => RunAsync(checkoutQueue));
        }

        private async Task RunAsync(ICheckoutQueue checkoutQueue)
        {
            while (true)
            {
                System.Console.WriteLine($"{checkoutQueue.NumOfWaitingCustomers} customers in line");
                await Task.Delay(1000);
            }
        }
    }
}