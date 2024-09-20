using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TestProject1;

public class CommonActions 
{
    IWebDriver driver = new ChromeDriver();
	public void WaitForControlExist(IWebDriver Control)
	{
		WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
		wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(Control));
	}

    public void IsElementVisible(IWebDriver Control)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(Control));
    }

    public void AlertIsPresent()
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
    }


}
