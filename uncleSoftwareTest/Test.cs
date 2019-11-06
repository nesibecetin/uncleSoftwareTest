using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace uncleSoftwareTest
{
    [TestFixture]
    public class Test
    {
        IWebDriver driver = new FirefoxDriver(); // tarayıcımızı driver nesnesine atadık
        [Test]
        public void siteninAcilmesi()
        {
            // TODO: Add your test code here
            driver.Navigate().GoToUrl("http://unclesoftware.com/"); // tarayıcımızın gitmesi gerektiği sitenin urlsini verdik 
            Assert.Pass("sitenin açılması passing test");
        }
        [Test]
        //kullanıcı giriş testi
        public void login()
        {
            driver.Navigate().GoToUrl("http://unclesoftware.com/");// tarayıcımızın gitmesi gerektiği site

            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[2]/a")).Click();
            System.Threading.Thread.Sleep(2000);
            //burada xpath kullandık xpath tarayıcı da xml verilerine ulaşmak için kullanılır burada ana sayfa menüsünde giriş yap butonuna tıklanıyor
            driver.FindElement(By.Name("emailorname")).SendKeys("kubila56n7145211748a@gmail.com"); // burada kullanıcı adı veya eposta ile giriş için bilgiler gönderiliyor textboxa
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Name("password")).SendKeys("Mehmetcan48"); // burada kullanıcı şifresi gönderilyor textboxa
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[3]/a")).Click(); // burada ise giriş yapma butonuna tıklanıyor
            Assert.Pass("passing test");
        }
        [Test]
        public void bireyselKayitOlma()
        {
            driver.Navigate().GoToUrl("http://unclesoftware.com/");
           
            // TODO: Add your test code here
            driver.FindElement(By.XPath("/ html / body / div[1] / div / div[1] / ul / li[1] / a")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("name")).SendKeys("Kubilay Ürün");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("mail")).SendKeys("kubila56n7145211748w@gmail.com");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("password")).SendKeys("Mehmetcan48");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[3]/a")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("nick")).SendKeys("abc");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("phone")).SendKeys("5327134736");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[2]/a")).Click();
            Assert.Pass("kayit olma passing test");
        }

        

       
       

       

        
    }
}
