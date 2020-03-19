using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using Abc.MvcWebUI.Entity;
using Abc.MvcWebUI.Identity;
using Abc.MvcWebUI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace Abc.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        DataContext dbContext = new DataContext();
        private UserManager<ApplicationUser> userManager;
        private RoleManager<ApplicationRole> roleManager;

        public AccountController()
        {
            var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            userManager = new UserManager<ApplicationUser>(userStore);


            var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());
            roleManager = new RoleManager<ApplicationRole>(roleStore); ;
        }

        [Authorize]
        public ActionResult Index()
        {
            var userName = User.Identity.Name;
            var orders = dbContext.Orders.Where(i => i.UserName == userName).Select(i => new UserOrderModel()
            {
                Id = i.Id,
                OrderNumber = i.OrderNumber,
                OrderDate = i.OrderDate,
                OrderState = i.OrderState,
                Total = i.Total

            }).OrderByDescending(i => i.OrderDate).ToList();
            return View(orders);
        }

        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        // POST: Account
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                //Kayıt İşlemleri
                ApplicationUser user = new ApplicationUser();
                user.Name = model.Name;
                user.Surname = model.Surname;
                user.Email = model.Email;
                user.UserName = model.UserName;

                var result = userManager.Create(user, model.Password);

                if (result.Succeeded)
                {
                    //kullanıcı oluştu ve kullanıcıyı bir role ata
                    if (roleManager.RoleExists("user"))
                    {
                        userManager.AddToRole(user.Id, "user");//kullanıcıyı bir role atıyoruz
                    }

                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("RegisterUserError", "Kullanıcı Oluşturma İşlemi Başarısız Oldu !");
                }
            }

            return View();
        }
        [Authorize]
        public ActionResult Details(int id)
        {
            var entity = dbContext.Orders.Where(i => i.Id == id)
                .Select(i => new OrderDetailsModel()
                {
                    OrderId = i.Id,
                    OrderNumber = i.OrderNumber,
                    Total = i.Total,
                    OrderDate = i.OrderDate,
                    OrderState = i.OrderState,
                    AdresBasligi = i.AdresBasligi,
                    Adres = i.Adres,
                    Sehir = i.Sehir,
                    Semt = i.Semt,
                    Mahalle = i.Mahalle,
                    PostaKodu = i.PostaKodu,
                    OrderLines = i.OrderLines.Select(a => new OrderLineModel()
                    {
                        ProductId = a.ProductId,
                        ProductName = a.Product.Name.Length>50?a.Product.Name.Substring(0,47):a.Product.Name,
                        Image = a.Product.Image,
                        Quantity = a.Quantity,
                        Price = a.Price,

                    }).ToList()//ordera ait olan 

                }).FirstOrDefault();
            return View(entity);
        }

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        // POST: Account
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                //Giriş(login) İşlemleri

                var user = userManager.Find(model.UserName, model.Password);
                if (user != null)
                {
                    //var olan kullanıcıyı sisteme dahil et
                    //applicationcookie oluşturup bunu sisteme bırak.
                    var authManager = HttpContext.GetOwinContext().Authentication;

                    var identityclaism = userManager.CreateIdentity(user, "ApplicationCookie");
                    var authProperties = new AuthenticationProperties();
                    authProperties.IsPersistent = model.RememberMe;//kalıcı bir cookie mi olacak
                                                                   //yoksa belirli bir zaman sonra silinecek mi
                    authManager.SignIn(authProperties, identityclaism);//sisteme dahil ediyoruz

                    if (!String.IsNullOrEmpty(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("LoginUserError", "Böyle bir kullanıcı yok !");
                }

            }

            return View(model);
        }
        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();


            return RedirectToAction("Index", "Home");
        }

    }
}