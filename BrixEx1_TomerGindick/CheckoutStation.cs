using System;
using System.Threading;
using System.Threading.Tasks;

namespace BrixEx1_TomerGindick
{
    public class CheckoutStation
    {
        public CheckoutStation(ICheckoutQueue checkoutQueue)
        {
            Task.Factory.StartNew(() => RunAsync(checkoutQueue));
        }

        private async Task RunAsync(ICheckoutQueue checkoutQueue)
        {
            Random rand = new Random();

            while (true)
            {
                if (checkoutQueue.GetNextCustomer())
                {
                    var checkoutProcessingTimeSeconds = rand.Next(1, 5);
                    Console.WriteLine($"Checkout processing {checkoutProcessingTimeSeconds} seconds");
                    await Task.Delay(checkoutProcessingTimeSeconds * 1000);
                }
                else
                {
                    await Task.Delay(1000);
                }
            }
        }
    }
}