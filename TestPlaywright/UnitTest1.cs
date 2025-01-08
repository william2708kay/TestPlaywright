using System.Text.RegularExpressions;  
using System.Threading.Tasks;  
using Microsoft.Playwright;  
using Microsoft.Playwright.NUnit;  
using NUnit.Framework;  

namespace PlaywrightTests;  

[Parallelizable(ParallelScope.Self)]  
[TestFixture]  
public class ExampleTest : PageTest  
{  
    [Test]  
    public async Task HasTitle()  
    {  
        // Ve a la página de Playwright.  
        await Page.GotoAsync("https://playwright.dev");  
        
        // Verifica que el título contenga "Playwright".  
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));  
    }  
    //prueba 2
    [Test]  
    public async Task GetStartedLink()  
    {  
        // Ve a la página de Playwright.  
        await Page.GotoAsync("https://playwright.dev");  
        
        // Clic en el enlace "Get started".  
        await Page.GetByRole(AriaRole.Link, new() { Name = "Get started" }).ClickAsync();  
        
        // Espera que el encabezado "Installation" sea visible.  
        await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Installation" })).ToBeVisibleAsync();  
    }   
}