using DemoDI.Models;
using DemoDI.Services;
using DemoDI.Services.BonjourServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace DemoDI.Controllers;

public class HomeController : Controller
{
    private readonly ConnectionStringConfig _connectionStringConfig1;

    public HomeController(IOptions<ConnectionStringConfig> connectionStringConfig1)
    {
        _connectionStringConfig1 = connectionStringConfig1.Value;
    }

    public IActionResult Index(
        [FromServices] IBonjourService bonjourService,
        [FromServices] ICacheBigService cacheServiceBig,
        [FromServices] ICacheSmallService cacheServiceSmall)
    {
        ////  camelCase            PascalCase
        //var bonjourService = new BonjourService();

        var test = _connectionStringConfig1;

        var bonjour = bonjourService.DireBonjour("Nieze");

        var keyFromBig = cacheServiceBig.Get("Key1");

        var keyFromSmall = cacheServiceSmall.Get("Key1");

        return View();
    }

    #region To hide
    //public IActionResult Privacy([FromKeyedServices("small")] ICacheService cache)
    //{
    //    return View();
    //}

    //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //public IActionResult Error()
    //{
    //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //}
    #endregion
}
