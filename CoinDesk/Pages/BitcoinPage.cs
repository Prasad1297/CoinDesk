using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinDesk.Pages
{
    public class BitcoinPage
    {
        public IWebDriver driver;

        public BitcoinPage(IWebDriver redriver)
        {
            driver = redriver;
            PageFactory.InitElements(redriver, this);
        }

        [FindsBy(How = How.XPath, Using = ("((//*[name()='svg' and @class='highcharts-root'])[1] //*[name()='rect'])[4]"))]
        IWebElement bitcoinChart;

        [FindsBy(How = How.XPath, Using = ("//span[@class='date']"))]
        IWebElement date;

        [FindsBy(How = How.XPath, Using = ("//span[@class='price']"))]
        IWebElement price;

        public IWebElement BitcoinChart()
        {
           return bitcoinChart;
        }

        public IWebElement Date()
        { 
            return date;
        }

        public IWebElement BitcoinPrice()
        { 
            return price;
        }
    }
}