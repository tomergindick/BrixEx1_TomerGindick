using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrixEx1_TomerGindick.Models
{
    public class CustomersAdder
    {
        public CustomersAdder(ICheckoutQueue checkoutQueue)
        {
            Task.Factory.StartNew(() => RunAsync(checkoutQueue));
        }

        private async Task RunAsync(ICheckoutQueue checkoutQueue)
        {
            while (true)
            {
                checkoutQueue.AddCustomer(new Customer());
                await Task.Delay(1000);
            }
        }
    }
}
