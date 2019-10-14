using System;
using System.Configuration;

namespace BrixEx1_TomerGindick
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var numOfCheckoutStations = GetConfiguredNumOfCheckoutStations();
                var checkoutManager = new CheckoutManager(numOfCheckoutStations);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured: {ex.Message}");
            }
            finally
            {
                Console.ReadKey();
            }
        }

        private static int GetConfiguredNumOfCheckoutStations()
        {
            var configValue = ConfigurationManager.AppSettings.Get("numOfCheckoutStations");
            int returnValue;
            if (!int.TryParse(configValue, out returnValue))
            {
                throw new ConfigurationErrorsException("Missing configuration value number of checkout stations.");
            }
            return returnValue;
        }
    }
}
