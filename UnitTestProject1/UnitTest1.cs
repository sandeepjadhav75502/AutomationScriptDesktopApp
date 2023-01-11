using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Diagnostics;
using System.Threading;
using static System.Collections.Specialized.BitVector32;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {     
        [TestMethod]
        [Obsolete]
        public void SysInfoTest()
        {
            Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");
            AppiumOptions appCapabilities = new AppiumOptions();
            WindowsDriver<WindowsElement> SysInfoApp;
            //DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.AddAdditionalCapability("app", @"C:\Windows\System32\msinfo32.exe");
            Uri path = new Uri("http://127.0.0.1:4723");
            SysInfoApp = new WindowsDriver<WindowsElement>(path, appCapabilities);

            SysInfoApp.FindElementByName("Help").Click();
            SysInfoApp.FindElementByName("About System Info...").Click();
        }

        [TestMethod]
        [Obsolete]
        public void CalculatorTest()
        {
            Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

            WindowsDriver<WindowsElement> Calculator;
            AppiumOptions appCapabilities = new AppiumOptions();

            appCapabilities.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            Calculator = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appCapabilities);

            Calculator.FindElementByAccessibilityId("num5Button").Click();
            Calculator.FindElementByAccessibilityId("plusButton").Click();
            Calculator.FindElementByAccessibilityId("num3Button").Click();
            Calculator.FindElementByAccessibilityId("equalButton").Click();
        }
        [TestMethod]
        [Obsolete]
        public void DentalLabTest()
        {
            Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");

            WindowsDriver<WindowsElement> dentalLab;
            AppiumOptions appCapabilities = new AppiumOptions();

            appCapabilities.AddAdditionalCapability("app", "C:\\Users\\Lenovo\\OneDrive\\Documents\\Release\\ClassDantKalaLab.exe");
            appCapabilities.AddAdditionalCapability("fullReset", true);
            dentalLab = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appCapabilities);
            dentalLab.FindElementByAccessibilityId("btnLogin").Click();
            Thread.Sleep(5000);
            dentalLab.FindElementByAccessibilityId("btnNewDrEntry").Click();
            Thread.Sleep(5000);
            dentalLab.FindElementByAccessibilityId("btnClose").Click();
            Thread.Sleep(5000);
            var allWindowHandles = dentalLab.WindowHandles;       
            dentalLab.SwitchTo().Window(allWindowHandles[0]);
            Thread.Sleep(5000);
            dentalLab.FindElementByAccessibilityId("btnYes").Click();
        }
    }
}
