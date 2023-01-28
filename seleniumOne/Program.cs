using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace seleniumOne
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initailize()
        {
            driver.Navigate().GoToUrl("https://flocard.app/");
             //driver.Navigate().GoToUrl("https://flocardstaging.duckdns.org/flocardstaging");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void SDG()//For Impacting SDGs button navigation bar
        {
            IWebElement sdg = driver.FindElement(By.XPath("/html/body/footer/div/div[1]/div[2]/div/div[1]/ul/li[1]/a"));
            sdg.Click();

        }


        [Test]
        public void Integrated()//For Integrated Soltions button navigation bar
        {
            IWebElement integ = driver.FindElement(By.XPath("//*[@id=\'navBar\']/div/ul/li[2]/a"));
            integ.Click();

        }
        [Test]
        public void KownledgeBank()//For Knowledge Bank button navigation bar
        {
            IWebElement kown = driver.FindElement(By.XPath("//*[@id=\'navBar\']/div/ul/li[3]/a"));
            kown.Click();

        }
        [Test]
        public void ContactUs()//For Contact Us button navigation bar
        {
            IWebElement contact = driver.FindElement(By.XPath("//*[@id=\"navBar\"]/div/ul/li[4]/a"));
            contact.Click();

        }
        [Test]
        public void AboutUs()//For About us button navigation bar
        {
            IWebElement about = driver.FindElement(By.XPath("//*[@id=\"navBar\"]/div/ul/li[5]/a"));
            about.Click();

        }
        [Test]
        public void Becomepartner()//For Become a Planter button navigation bar
        {
            IWebElement part = driver.FindElement(By.XPath("//*[@id=\'navBar\']/div/ul/li[6]/a"));
            part.Click();


        }




        [Test]
        public void Linkedln()// clicking the buttons for logging in flocard via linkedin 
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\'content\']/div/div/div/a"));
            element.Click();
            IWebElement linked = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linked.Click();
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            user.SendKeys("ankitkullu7@gmail.com");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            pass.SendKeys("ANkit@123");
            IWebElement sign = driver.FindElement(By.XPath("//*[@id=\"app__container\"]/main/div[2]/form/div[3]/button"));
            sign.Click();

        }

        [Test]
        public void ExchangeSection()// clicking the  exchange codes buttons 
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\'content\']/div/div/div/a"));
            element.Click();
            IWebElement linked = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linked.Click();
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            user.SendKeys("ankitkullu7@gmail.com");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            pass.SendKeys("ANkit@123");
            IWebElement sign = driver.FindElement(By.XPath("//*[@id=\"app__container\"]/main/div[2]/form/div[3]/button"));
            sign.Click();
            IWebElement exc = driver.FindElement(By.XPath("//*[@id=\"exchangemenu\"]/a"));
            exc.Click();
            IWebElement excode = driver.FindElement(By.XPath("//*[@id=\"lnkExchangeCodes\"]"));
            excode.Click();

        }



        [Test]
        public void Contact() //for My contact button
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\'content\']/div/div/div/a"));
            element.Click();
            IWebElement linked = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linked.Click();
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            user.SendKeys("ankitkullu7@gmail.com");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            pass.SendKeys("ANkit@123");
            IWebElement sign = driver.FindElement(By.XPath("//*[@id=\"app__container\"]/main/div[2]/form/div[3]/button"));
            sign.Click();
            IWebElement Mycont = driver.FindElement(By.XPath("//*[@id=\"lnkContacts\"]/span"));
            Mycont.Click();
        }

        [Test]
        public void floId() //for my flocard ID button 
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\'content\']/div/div/div/a"));
            element.Click();
            IWebElement linked = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linked.Click();
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            user.SendKeys("ankitkullu7@gmail.com");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            pass.SendKeys("ANkit@123");
            IWebElement sign = driver.FindElement(By.XPath("//*[@id=\"app__container\"]/main/div[2]/form/div[3]/button"));
            sign.Click();
            IWebElement MyfloId = driver.FindElement(By.XPath("//*[@id=\"lnkAddress\"]/span"));
            MyfloId.Click();
        }

        [Test]
        public void PlanterApp()//for my planters app button
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\'content\']/div/div/div/a"));
            element.Click();
            IWebElement linked = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linked.Click();
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            user.SendKeys("ankitkullu7@gmail.com");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            pass.SendKeys("ANkit@123");
            IWebElement sign = driver.FindElement(By.XPath("//*[@id=\"app__container\"]/main/div[2]/form/div[3]/button"));
            sign.Click();
            IWebElement plantapp = driver.FindElement(By.XPath("//*[@id=\"lnkPlanter\"]"));
            plantapp.Click();
        }

        [Test]
        public void FAQ()//for FAQ button
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\'content\']/div/div/div/a"));
            element.Click();
            IWebElement linked = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linked.Click();
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            user.SendKeys("ankitkullu7@gmail.com");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            pass.SendKeys("ANkit@123");
            IWebElement sign = driver.FindElement(By.XPath("//*[@id=\"app__container\"]/main/div[2]/form/div[3]/button"));
            sign.Click();
            IWebElement faq = driver.FindElement(By.XPath("//*[@id=\"lnkFAQ\"]/span"));
            faq.Click();
        }

        [Test]
        public void flocard()//for flocard policies 
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\'content\']/div/div/div/a"));
            element.Click();
            IWebElement linked = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linked.Click();
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            user.SendKeys("ankitkullu7@gmail.com");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            pass.SendKeys("ANkit@123");
            IWebElement sign = driver.FindElement(By.XPath("//*[@id=\"app__container\"]/main/div[2]/form/div[3]/button"));
            sign.Click();
            IWebElement poli = driver.FindElement(By.XPath("//*[@id=\"lnkPolicies\"]/span"));
            poli.Click();
        }

        [Test]
        public void Support() //for support button
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\'content\']/div/div/div/a"));
            element.Click();
            IWebElement linked = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linked.Click();
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            user.SendKeys("ankitkullu7@gmail.com");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            pass.SendKeys("ANkit@123");
            IWebElement sign = driver.FindElement(By.XPath("//*[@id=\"app__container\"]/main/div[2]/form/div[3]/button"));
            sign.Click();
            IWebElement supp = driver.FindElement(By.XPath("//*[@id=\"lnkSupport\"]/span"));
            supp.Click();
        }


        [Test]
        public void FLowedit()//for flocard editing
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\'content\']/div/div/div/a"));
            element.Click();
            IWebElement linked = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linked.Click();
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            user.SendKeys("ankitkullu7@gmail.com");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            pass.SendKeys("ANkit@123");
            IWebElement sign = driver.FindElement(By.XPath("//*[@id=\"app__container\"]/main/div[2]/form/div[3]/button"));
            sign.Click();
            IWebElement floedit = driver.FindElement(By.XPath("//*[@id=\"editIntro\"]"));
            floedit.Click();
            IWebElement edit = driver.FindElement(By.XPath("//*[@id='connectionsDropdown1']/div/a"));
            edit.Click();
        }
        public void SetDefault()//for set deafault button
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\'content\']/div/div/div/a"));
            element.Click();
            IWebElement linked = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linked.Click();
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            user.SendKeys("ankitkullu7@gmail.com");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            pass.SendKeys("ANkit@123");
            IWebElement sign = driver.FindElement(By.XPath("//*[@id=\"app__container\"]/main/div[2]/form/div[3]/button"));
            sign.Click();
            IWebElement floedit = driver.FindElement(By.XPath("//*[@id=\"editIntro\"]"));
            floedit.Click();
            IWebElement def = driver.FindElement(By.XPath("//*[@id=\"def1\"]"));
            def.Click();
        }
        [Test]
        public void ExchangeCard()//for exchange card  button
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\'content\']/div/div/div/a"));
            element.Click();
            IWebElement linked = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linked.Click();
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            user.SendKeys("ankitkullu7@gmail.com");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            pass.SendKeys("ANkit@123");
            IWebElement sign = driver.FindElement(By.XPath("//*[@id=\"app__container\"]/main/div[2]/form/div[3]/button"));
            sign.Click();
            IWebElement floedit = driver.FindElement(By.XPath("//*[@id=\"editIntro\"]"));
            floedit.Click();
            IWebElement exccard = driver.FindElement(By.XPath("//*[@id=\"connectionsDropdown1\"]/a[2]"));
            exccard.Click();
        }
        [Test]
        public void ShareCard()//for share card  button
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\'content\']/div/div/div/a"));
            element.Click();
            IWebElement linked = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linked.Click();
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            user.SendKeys("ankitkullu7@gmail.com");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            pass.SendKeys("ANkit@123");
            IWebElement sign = driver.FindElement(By.XPath("//*[@id=\"app__container\"]/main/div[2]/form/div[3]/button"));
            sign.Click();
            IWebElement floedit = driver.FindElement(By.XPath("//*[@id=\"editIntro\"]"));
            floedit.Click();
            IWebElement shcard = driver.FindElement(By.XPath("//*[@id=\"connectionsDropdown1\"]/a[3]"));
            shcard.Click();
        }
        [Test]
        public void VersionCard()//for  card version  button
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\'content\']/div/div/div/a"));
            element.Click();
            IWebElement linked = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linked.Click();
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            user.SendKeys("ankitkullu7@gmail.com");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            pass.SendKeys("ANkit@123");
            IWebElement sign = driver.FindElement(By.XPath("//*[@id=\"app__container\"]/main/div[2]/form/div[3]/button"));
            sign.Click();
            IWebElement floedit = driver.FindElement(By.XPath("//*[@id=\"editIntro\"]"));
            floedit.Click();
            IWebElement shcard = driver.FindElement(By.XPath("//*[@id=\"connectionsDropdown1\"]/a[4]"));
            shcard.Click();
        }
        [Test]
        public void AttachOrg()//for  attachto orgnization button
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\'content\']/div/div/div/a"));
            element.Click();
            IWebElement linked = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linked.Click();
            IWebElement user = driver.FindElement(By.XPath("//*[@id=\"username\"]"));
            user.SendKeys("ankitkullu7@gmail.com");
            IWebElement pass = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            pass.SendKeys("ANkit@123");
            IWebElement sign = driver.FindElement(By.XPath("//*[@id=\"app__container\"]/main/div[2]/form/div[3]/button"));
            sign.Click();
            IWebElement floedit = driver.FindElement(By.XPath("//*[@id=\"editIntro\"]"));
            floedit.Click();
            IWebElement shcard = driver.FindElement(By.XPath("//*[@id=\"connectionsDropdown1\"]/a[5]"));
            shcard.Click();
        }
        [Test]
        public void CreateCard() 
        {
            IWebElement getStarted = driver.FindElement(By.XPath("//*[@id=\'logoAndNav\']/nav/div/div[1]/a"));
            getStarted.Click();
            IWebElement linkedIn = driver.FindElement(By.XPath("//*[@id=\'content\']/div[2]/div/div/div/div/form/div/a[2]/span"));
            linkedIn.Click();
            IWebElement emailID = driver.FindElement(By.XPath("//*[@id=\'username\']"));
            emailID.SendKeys("ankitkullu7@gmail.com");
            IWebElement password = driver.FindElement(By.XPath("//*[@id=\'password\']"));
            password.SendKeys("ANkit@123");
            IWebElement signIn = driver.FindElement(By.XPath("//*[@id=\'app__container\']/main/div[2]/form/div[3]/button"));
            signIn.Click();
            IWebElement createCard = driver.FindElement(By.XPath("//*[@id=\'new_card_id\']/div/div[1]/a/img"));
            createCard.Click();
            IWebElement fullName = driver.FindElement(By.XPath("//*[@id=\'txtName\']"));
            fullName.SendKeys("Ankit Kullu ");
            IWebElement position = driver.FindElement(By.XPath("//*[@id=\'txtHeadline\']"));
            position.SendKeys("Intern");
            IWebElement phone = driver.FindElement(By.XPath("//*[@id=\'txtPhone\']"));
            phone.SendKeys("9523347534");
            IWebElement website = driver.FindElement(By.XPath("//*[@id=\'txtWebsite\']"));
            website.SendKeys("www.google.com");
            IWebElement facebookProfile = driver.FindElement(By.XPath("//*[@id=\'txtFacebook\']"));
            facebookProfile.SendKeys("www.facebook.com");
            IWebElement instaProfile = driver.FindElement(By.XPath("//*[@id=\'txtInstagram\']"));
            instaProfile.SendKeys("www.instagram.com");
            IWebElement twitterProfile = driver.FindElement(By.XPath("//*[@id=\'txtTwitter\']"));
            twitterProfile.SendKeys("www.twitter.com");
            IWebElement linkedinProfile = driver.FindElement(By.XPath("//*[@id=\'txtLinkedin\']"));
            linkedinProfile.SendKeys("www.linkedin.com");
            IWebElement tags = driver.FindElement(By.XPath("//*[@id=\'txtLinkedin\']"));
            tags.SendKeys("jobseekers");
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\'content\']/div[1]/section/div/div/div[2]/div/div/form/div[12]/input"));
            createButton.Click();
        }


    }


    }
    

