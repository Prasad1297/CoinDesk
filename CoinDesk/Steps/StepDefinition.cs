using CoinDesk.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestingAskMeAnything.Base;

namespace CoinDesk.Steps
{
    [Binding]
    public class StepDefinition : br
    {
        BitcoinPage bitcoin;
        [Given(@"User is on ""([^""]*)"" page")]
        public void GivenUserIsOnPage(string p0)
        {
            bitcoin = new BitcoinPage(driver);
            driver.Navigate().GoToUrl(p0);
        }

        [When(@"when user gives ""([^""]*)"" as input")]
        public void WhenWhenUserGivesAsInput(string p0)
        {
            string text = p0;
            int x = ((bitcoin.BitcoinChart().Size.Width) / 2) - bitcoin.BitcoinChart().Size.Width;
            string date;
            
            
            for (int i = 0; i < bitcoin.BitcoinChart().Size.Width; i++)
            {
                Actions action = new Actions(driver);
                action.MoveToElement(bitcoin.BitcoinChart()).MoveByOffset(x + i, 0).Perform();
                
                date = bitcoin.Date().Text;
                
                if (text == date)
                {
                    Console.WriteLine(date);
                    break;
                }
            }
        }

        [Then(@"Bitcoin price at that time should be displayed")]
        public void ThenBitcoinPriceAtThatTimeShouldBeDisplayed()
        {
            Console.WriteLine(bitcoin.BitcoinPrice().Text);
            
            driver.Close();
            driver.Quit();
        }

    }
}
