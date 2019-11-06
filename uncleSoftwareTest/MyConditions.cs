using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uncleSoftwareTest
{
    public class MyConditions
    {
        public static Func<IWebDriver, bool> ElementIsVisible(IWebElement element)
        {
            return (driver) =>
            {
                try
                {
                    return element.Displayed;
                }
                catch (Exception)
                {
                    // If element is null, stale or if it cannot be located
                    return false;
                }
            };
        }
    }
}
