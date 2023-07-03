using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;

namespace eShop.Web.Controls
{
    public class ProductExcute : Controller
    {
        Product_DAL product = new Product_DAL();

        [Route("/productinsert")]
        public async Task<IActionResult> Insert([FromQuery] int Productid, [FromQuery] string Brand, [FromQuery] string Name, [FromQuery] double Price,
            [FromQuery] string ImageLink, [FromQuery] string Description)
        {
            product.Insert(Productid, Name, Brand, Price, ImageLink, Description);
            var userClaims = new List<Claim>()
            {
            };

            var userIdentity = new ClaimsIdentity(userClaims, "eShop.CookieAuth");
            var userPrincipal = new ClaimsPrincipal(userIdentity);

            await HttpContext.SignInAsync("eShop.CookieAuth", userPrincipal);
            return Redirect("/productrequire");
        }
    }
}