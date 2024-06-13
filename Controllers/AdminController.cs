using forex.Models;
using forex.context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;

namespace New_Dashboard.Controllers
{
    public class AdminController : Controller
    {
        readonly TreeDataaccess dbtreeContext = new TreeDataaccess();
        readonly string connectionString = @"Data Source=68.178.203.9;Initial Catalog=KBC40New;User ID=sa;Password=gri12DEB!@;";
        private readonly IWebHostEnvironment webHostEnvironment;

        public AdminController(ILogger<AdminController> logger, IWebHostEnvironment hostEnvironment)
        {
            webHostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult qrcode()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                dashboardmodel dmO = new dashboardmodel();
                directcontext dcO = new directcontext();
                dmO = dcO.admindashboardsee(connectionString);
                return View(dmO);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        public IActionResult requestgreenwallet()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                kyccontext logoc = new kyccontext();
                kycmodellist dmo = new kycmodellist();
                dmo = logoc.activesee(connectionString);
                return View(dmo);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult greenwalletsendSummery()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                kyccontext logoc = new kyccontext();
                kycmodellist dmo = new kycmodellist();
                dmo = logoc.activsend(connectionString);
                return View(dmo);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }


        }

        public IActionResult kbcSummery()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                kyccontext logoc = new kyccontext();
                kycmodellist dmo = new kycmodellist();
                dmo = logoc.activssend(connectionString);
                return View(dmo);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }


        }
        public IActionResult logout()

        {
            HttpContext.Session.SetString("Adminflag", "0");


            return RedirectToAction("login", "home");

        }
        public IActionResult IncomeSummary()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.incomesee(connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
            
        }

        public IActionResult Annualsubscription()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.annual(connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }

        }

        public IActionResult couponwallet()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                couponlist ip = new couponlist();
               
                ip = duct.couponsees(connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult directincome()
        {
            return View();

        }
        public IActionResult levelincome()
        {
            return View();

        }

        public IActionResult profitsharing()
        {
            return View();

        }
        public IActionResult royalty()
        {
            return View();

        }
        public IActionResult community()
        {

            return View();

        }
        public IActionResult rankreward()
        {
            return View();

        }
        public IActionResult bonnanza()
        {
            return View();

        }
        public IActionResult roiCalculate()
        {
            return View();

        }
        public IActionResult royalityadmin()
        {
            ViewBag.mess = TempData["mess"];
            return View();
        }

        [HttpPost]
        public IActionResult royalityadmin(string FromDate, string ToDate)
        {

            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                roicontext rc = new roicontext();
                roimodel ro = new roimodel();
                ro = rc.roisee(FromDate, ToDate, connectionString);
                TempData["mess"] = ro.message;
                ViewBag.mess = ro.message;
                return View(ro);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult incomeprofit()
        {
            return View();

        }
        public IActionResult profileupdate(string uid)
        {

            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                userlistModel ip = new userlistModel();
                ip = duct.userprofilesee(uid, connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        [HttpPost]
        public IActionResult pass(string City, string password, string userid, string name, string email, string mobile,string planename)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                userlistModel ip = new userlistModel();
                ip.name = name;
                ip.emailaddress = email;
                ip.Mobile = mobile;
                ip.password = password;
                ip.userid = userid;
                ip.City = City;
                ip.planename =planename;
                duct.adminupdatepass(ip, connectionString);
                return RedirectToAction("Userlist", "admin");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult greenwallet()
        {
            return View();

        }
        public IActionResult fundtypewallet()
        {
            return View();
        }
            [HttpPost]
            public IActionResult fundtypewallet(string userid, string details, string amount, string date, string inout, string incometype)
            {
                string k = HttpContext.Session.GetString("Adminflag");
                if (k == "1")
                {
                    walletmodel greenModel = new walletmodel();
                    greenModel.userid = userid;
                    greenModel.amount = amount;
                    greenModel.details = details;
                    greenModel.Date = date;
                    greenModel.inout = inout;
                    greenModel.incometype = incometype;
                    greenwalletCon dcO = new greenwalletCon();
                    string a = dcO.incometypewalletin(greenModel, connectionString);
                    ViewBag.tp2 = "Payment Successfully!";
                    return View();

                }
                else
                {
                    return RedirectToAction("adminlogin", "home");
                }
            }
        public IActionResult addfranchise()
        {
            return View();

        }
        [HttpPost]
        public IActionResult addfranchise(string fran, string userid, string date, string refral, string refralp)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
               
               
                greenwalletCon dcO = new greenwalletCon();
                string a = dcO.addfranchise(fran,userid,date,refral,refralp, connectionString);
                ViewBag.tp2 = "Add Successfully ";
                return View();

            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        public IActionResult franchisewallet()
        {
            return View();

        }
        [HttpPost]
        public IActionResult franchisewallet(string userid, string details, string amount, string date, string inout)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                walletmodel greenModel = new walletmodel();
                greenModel.userid = userid;
                greenModel.amount = amount;
                greenModel.details = details;
                greenModel.Date = date;
                greenModel.inout = inout;
                greenwalletCon dcO = new greenwalletCon();
                string a = dcO.franchwalletin(greenModel, connectionString);
                ViewBag.tp2 = "Payment Successfully!";
                return View();

            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult KBCwallet()
        {
            return View();

        }
        [HttpPost]
        public IActionResult KBCwallet(string userid, string details, string amount, string date, string inout)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                walletmodel greenModel = new walletmodel();
                greenModel.userid = userid;
                greenModel.amount = amount;
                greenModel.details = details;
                greenModel.Date = date;
                greenModel.inout = inout;
                greenwalletCon dcO = new greenwalletCon();
                string a = dcO.kbcwalletin(greenModel, connectionString);
                ViewBag.tp2 = "Payment Successfully!";
                return View();

            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }


        public IActionResult ClubReservation(string id)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                string uid = "";
                if (id == null)
                {
                    uid = "NWF100001";
                }
                else
                {
                    uid = id;
                }
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
               
                incoO = dcO.paySeeClub(uid, connectionString);
                ViewBag.data1 = TempData["tp1"];
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult membertomemberkbc()
        {
            return View();

        }
        public IActionResult membertomember()
        {
            return View();

        }
        [HttpPost]
        public IActionResult membertomemberkbc(string userid, string details, string amount, string date, string inout, string byuserid)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                walletmodel greenModel = new walletmodel();
                greenModel.userid = userid;
                greenModel.amount = amount;
                greenModel.details = details;
                greenModel.Date = date;
                greenModel.inout = inout;
                greenModel.byuserid = byuserid;
                greenwalletCon dcO = new greenwalletCon();
                string a = dcO.greenwalletinskbc(greenModel, connectionString);
                ViewBag.tp2 = "Payment Successfully!";
                return View();

            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult membertomember(string userid, string details, string amount, string date, string inout,string byuserid)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                walletmodel greenModel = new walletmodel();
                greenModel.userid = userid;
                greenModel.amount = amount;
                greenModel.details = details;
                greenModel.Date = date;
                greenModel.inout = inout;
                greenModel.byuserid = byuserid;
                greenwalletCon dcO = new greenwalletCon();
                string a = dcO.greenwalletins(greenModel, connectionString);
                ViewBag.tp2 = "Payment Successfully!";
                return View();

            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }


        [HttpPost]
        public IActionResult greenwallet(string userid, string details, string amount, string date, string inout)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                walletmodel greenModel = new walletmodel();
                greenModel.userid = userid;
                greenModel.amount = amount;
                greenModel.details = details;
                greenModel.Date = date;
                greenModel.inout = inout;
                greenwalletCon dcO = new greenwalletCon();
                string a = dcO.greenwalletin(greenModel, connectionString);
                ViewBag.tp2 = "Payment Successfully!";
                return View();

            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }



        public IActionResult charitywallet()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult charitywallet(string userid, string details, string amount, string date, string inout)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                walletmodel greenModel = new walletmodel();
                greenModel.userid = userid;
                greenModel.amount = amount;
                greenModel.details = details;
                greenModel.Date = date;
                greenModel.inout = inout;
                greenwalletCon dcO = new greenwalletCon();
                string a = dcO.charitywalletin(greenModel, connectionString);
                ViewBag.tp2 = "Payment Successfully!";
                return View();

            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult Donationwallet()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        [HttpPost]
        public IActionResult Donationwallet(string userid, string details, string amount, string date, string inout)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                walletmodel greenModel = new walletmodel();
                greenModel.userid = userid;
                greenModel.amount = amount;
                greenModel.details = details;
                greenModel.Date = date;
                greenModel.inout = inout;
                greenwalletCon dcO = new greenwalletCon();
                string a = dcO.donationwalletin(greenModel, connectionString);
                ViewBag.tp2 = "Payment Successfully!";
                return View();

            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }


        public IActionResult charitywalletsendSummery()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                kyccontext logoc = new kyccontext();
                kycmodellist dmo = new kycmodellist();
                dmo = logoc.charitysend(connectionString);
                return View(dmo);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }


        }

        public IActionResult DonationwalletsendSummery()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                kyccontext logoc = new kyccontext();
                kycmodellist dmo = new kycmodellist();
                dmo = logoc.donationsend(connectionString);
                return View(dmo);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }


        }
        public IActionResult crowdwallet()
        {
            return View();

        }

        [HttpPost]
        public IActionResult crowdwallet(string userid, string details, string amount, string date, string inout)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                walletmodel greenModel = new walletmodel();
                greenModel.userid = userid;
                greenModel.amount = amount;
                greenModel.details = details;
                greenModel.Date = date;
                greenModel.inout = inout;
                greenwalletCon dcO = new greenwalletCon();
                string a = dcO.crowdwalletin(greenModel, connectionString);
                ViewBag.tp2 = "Payment Successfully!";
                return View();

            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult kbcid(string uid)
        {
           
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                IncomeWallet dowm = new IncomeWallet();
                greenwalletCon dcO = new greenwalletCon();
                dowm = dcO.kbcwalletsee(uid, connectionString);
                return View(dowm);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }

        }
        public IActionResult greenid()
        {
            string uid = "";
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                IncomeWallet dowm = new IncomeWallet();
                greenwalletCon dcO = new greenwalletCon();
                dowm = dcO.greenwalletsee(uid, connectionString);
                return View(dowm);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }

        }


        [HttpPost]
        public IActionResult greenid(string uid)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                IncomeWallet dowm = new IncomeWallet();
                greenwalletCon dcO = new greenwalletCon();
                dowm = dcO.greenwalletsee(uid, connectionString);
                return View(dowm);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        public IActionResult DirectReferral()
        {
            return View();
        }
        public IActionResult TeamReferral()
        {
            return View();
        }

        public IActionResult DownlineTeam(string uid)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                Downline dowm = new Downline();
                downlinedata dcO = new downlinedata();
               
                dowm = dcO.downlinesee(uid, connectionString);
                return View(dowm);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult passwordchange()
        {
            return View();
        }
        public IActionResult Addfund()
        {
            return View();
        }

        public IActionResult tree()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                treelist tre = new treelist();
                treeContext treeCon = new treeContext();
                string uid = HttpContext.Session.GetString("UserId");
                tre = treeCon.treeSee(uid, connectionString);
                return View(tre);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        public IActionResult fund(string id, string page)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                // string id = "daily";
                ViewBag.page = page;
                ViewBag.id = id;
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.incomeseedate(uid, id, connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("login", "Home");
            }
        }

        public IActionResult banner()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                IncomeWallet d = new IncomeWallet();
                incomewalletContext dcO = new incomewalletContext();
                d = dcO.slideimg(connectionString);
                return View(d);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult banner(string index, IFormFile file)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                string uniqueFileName = null;
                if (file != null)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "upload");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }
                string img = uniqueFileName;

                incomewalletContext dcO = new incomewalletContext();
                dcO.insertimgs(index, img, connectionString);
                return RedirectToAction("banner");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult delimage(string index)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {


                incomewalletContext dcO = new incomewalletContext();
                dcO.delimgs(index, connectionString);
                return RedirectToAction("pop");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult delimagelogin(string index)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {


                incomewalletContext dcO = new incomewalletContext();
                dcO.delimgslogin(index, connectionString);
                return RedirectToAction("poplogin");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult delimagedashboard(string index)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                incomewalletContext dcO = new incomewalletContext();
                dcO.delimgsdashboard(index, connectionString);
                return RedirectToAction("popdashbord");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult PaymentSummery()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                incoO = dcO.adminpaidsee(connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult PaymentSummeryfranchise()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                incoO = dcO.adminpaidseees(connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

       
        public IActionResult userlist()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                ip = duct.userlistsee(connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
       public IActionResult userlist2()
       
       {
           string k = HttpContext.Session.GetString("Adminflag");
           if (k == "1")
           {
               
                return View();
            }
           else
           {
               return RedirectToAction("adminlogin", "home");
           }
       }

      public JsonResult userlist3()

        {
           
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                ip = duct.userlistsee2(connectionString);
                return Json(ip.reglist);
            }
           
        }



        public IActionResult idcard ()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                ip = duct.idcard(connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult plan()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                ip = duct.plan(connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
  [HttpPost]
        public IActionResult plan(string name,string amount)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
               duct.addplan(name,amount,connectionString);
                return RedirectToAction("plan");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult planupdate(string name, string amount,string indexid)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                duct.updateplan(name, amount,indexid, connectionString);
                return RedirectToAction("plan");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }



        [HttpPost]
        public IActionResult plandelete(string name)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                duct.plandelete(name, connectionString);
                return RedirectToAction("plan");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }



        public IActionResult auserlist()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                ip = duct.userlistsee(connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult Newuserlist()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                ip = duct.userlistsees(connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult donate()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                ip = duct.donatesee(connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        public IActionResult PaymentRequest()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                incoO = dcO.adminunpaidsee(connectionString);
                ViewBag.error = TempData["tp1"];
                return View(incoO);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult PaymentRequestfranchise()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                incoO = dcO.adminunpaidfranchisesee(connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        public IActionResult greenwalletsummary()
        {
            return View();
        }
        public IActionResult incomewallet()
        {
            return View();
        }
        public IActionResult Feedback(string id)
        {
            ViewBag.bag = id;
            return View();

        }
        public IActionResult FeedbackSystem()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                adminnotification duct = new adminnotification();
                notifee ip = new notifee();
                ip = duct.feedsee(connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        public IActionResult Notification()
        {

            return View();

        }
        [HttpPost]
        public IActionResult Notification(string Userid, string Heading, string Date, string Content)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                modlnotification notifimodel = new modlnotification();
                notifimodel.userid = Userid;
                notifimodel.Heading = Heading;
                notifimodel.date = Date;
                notifimodel.Content = Content;
                adminnotification notifiO = new adminnotification();
                notifiO.notice(notifimodel, connectionString);
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }

        }
        public IActionResult block(string block, string userid)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                directcontext duct = new directcontext();
                userlistModel ip = new userlistModel();
                duct.blockid(block, userid, connectionString);
                return RedirectToAction("UserList", "admin");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        [HttpPost]
        public IActionResult UserList(string userid)
        {

            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                ip = duct.userprofilebydate(userid, connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public async Task<IActionResult> withdrawls(int amount, string indexid, string account, string faccount)
        {
            Notees s = new Notees();
            s.notes_key_1 = "Tea, Earl Grey, Hot";
            s.notes_key_2 = "Tea, Earl Grey… decaf.";
            finlbank t = new finlbank();
            t.account_number = "409001547970";
            t.fund_account_id = faccount;
            t.amount = amount * 100;
            t.currency = "INR";
            t.mode = "IMPS";
            t.purpose = "refund";
            t.queue_if_low_balance = true;
            t.reference_id = "Acme Transaction ID 4567";
            t.narration = "Acme Corp Fund Transfer";
            t.notes = s;
            incomeModel incoO = new incomeModel();
            incoO.indexid = indexid;
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://api.razorpay.com/v1/payouts"))
                {
                    var plainTextBytes = Encoding.UTF8.GetBytes($"rzp_live_O96Ipb4p8jkPIm:611iQixODk8O9EkzjJ68z07h");
                    var basicAuthKey = Convert.ToBase64String(plainTextBytes);

                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {basicAuthKey}");

                    string jsonData = JsonConvert.SerializeObject(t);
                    request.Content = new StringContent(jsonData);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                    string jsonResp = await response.Content.ReadAsStringAsync();
                    TempData["tp1"] = jsonResp;
                   payout resp = JsonConvert.DeserializeObject<payout>(jsonResp);
                    incoO.Detail = resp.id;

                }
            }


            incomewalletContext dcO = new incomewalletContext();
            dcO.withdrawlReqins( incoO,amount, connectionString);
            return RedirectToAction("PaymentRequest", "admin");
        }
        public IActionResult withdrawl(string amount, string indexid)
        {
            incomeModel incoO = new incomeModel();
            incomewalletContext dcO = new incomewalletContext();
            dcO.withdrawlReqin(amount, indexid, connectionString);
            return RedirectToAction("PaymentRequest", "admin");
        }
        public IActionResult reject( string indexid1)
        {
            incomeModel incoO = new incomeModel();
            incomewalletContext dcO = new incomewalletContext();
            dcO.withdrawlReqin1( indexid1, connectionString);
            return RedirectToAction("PaymentRequest", "admin");
        }

        public IActionResult withdrawlfranchise(string amount, string indexid)
        {
            incomeModel incoO = new incomeModel();
            incomewalletContext dcO = new incomewalletContext();
            dcO.withdrawlReqinfranchise(amount, indexid, connectionString);
            return RedirectToAction("PaymentRequestfranchise", "admin");
        }
        public IActionResult rejectfranchise(string indexid1)
        {
            incomeModel incoO = new incomeModel();
            incomewalletContext dcO = new incomewalletContext();
            dcO.withdrawlReqin1(indexid1, connectionString);
            return RedirectToAction("PaymentRequestfranchise", "admin");
        }

        public IActionResult Treejoing()
        {
            string n = HttpContext.Request.Query["id"].ToString();
            string uid;
            string sid = "NWF100001";
            string status;
            if (n != "")
            {
                uid = n;
                status = "0";
            }
            else
            {
                uid = sid;
                status = "1";
            }
            TreeView t = new TreeView();
            t = dbtreeContext.GetAlltree(connectionString, uid, sid, status);
            ViewBag.img1 = t.span1;
            ViewBag.img2 = t.span2;
            ViewBag.img3 = t.span3;
            ViewBag.img4 = t.span4;
            ViewBag.img5 = t.span5;
            ViewBag.img6 = t.span6;
            ViewBag.img7 = t.span7;
            ViewBag.img8 = t.span8;
            ViewBag.img9 = t.span9;
            ViewBag.img10 = t.span10;
            ViewBag.img11 = t.span11;
            ViewBag.img12 = t.span12;
            ViewBag.img13 = t.span13;
            ViewBag.img14 = t.span14;
            ViewBag.img15 = t.span15;

            ViewBag.id1 = t.span1id;
            ViewBag.id2 = t.span2id;
            ViewBag.id3 = t.span3id;
            ViewBag.id4 = t.span4id;
            ViewBag.id5 = t.span5id;
            ViewBag.id6 = t.span6id;
            ViewBag.id7 = t.span7id;
            ViewBag.id8 = t.span8id;
            ViewBag.id9 = t.span9id;
            ViewBag.id10 = t.span10id;
            ViewBag.id11 = t.span11id;
            ViewBag.id12 = t.span12id;
            ViewBag.id13 = t.span13id;
            ViewBag.id14 = t.span14id;
            ViewBag.id15 = t.span15id;

            //...........

            ViewBag.data1 = t.data1id;
            ViewBag.data2 = t.data2id;
            ViewBag.data3 = t.data3id;
            ViewBag.data4 = t.data4id;
            ViewBag.data5 = t.data5id;
            ViewBag.data6 = t.data6id;
            ViewBag.data7 = t.data7id;
            ViewBag.data8 = t.data8id;
            ViewBag.data9 = t.data9id;
            ViewBag.data10 = t.data10id;
            ViewBag.data11 = t.data11id;
            ViewBag.data12 = t.data12id;
            ViewBag.data13 = t.data13id;
            ViewBag.data14 = t.data14id;
            ViewBag.data15 = t.data15id;
            return View(t);
        }


        public IActionResult levellist()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                ip = duct.levellist("NWF100001", connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult levellist(string userid)
        {

            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                ip = duct.levellist(userid, connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult levellists()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                ip = duct.levellists("NWF100001", connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult levellists(string userid)
        {

            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                ip = duct.levellists(userid, connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        public IActionResult bonanzaplan()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
               
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult clube()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult clube(string startdate, string enddate)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                couponwallet n = new couponwallet();
                n.startdate = startdate;
                n.enddate = enddate;
               
                couponwallet np = new couponwallet();
                incomewalletContext dcO = new incomewalletContext();
                np=dcO.top(n, connectionString);
                ViewBag.bag = np.mass;
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        public IActionResult Occasion()
        {

            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }

        }
        public IActionResult clublist()
        {
            string uid = "";
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                IncomeWallet dowm = new IncomeWallet();
                greenwalletCon dcO = new greenwalletCon();
                dowm = dcO.clubsee(uid, connectionString);
                return View(dowm);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
            [HttpPost]
        public IActionResult Occasion(string occasion, string detail)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                IncomeWallet dowm = new IncomeWallet();
                greenwalletCon dcO = new greenwalletCon();
                dcO.occasion(occasion, detail, connectionString);
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult bonanzaplannew()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult newcoupon()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult newcoupon(string userid, string edate, string camount, string tcoupon)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                couponwallet n = new couponwallet();
                
                n.enddate =edate;
                n.userid = userid;
               
                n.coupon = tcoupon;
                n.price = camount;
                couponwallet np = new couponwallet();
                incomewalletContext dcO = new incomewalletContext();
                np = dcO.addnewcoupon(n, connectionString);
                ViewBag.bag = np.mass;
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult bonanzaplannew(string startdate, string enddate, string rank, string direct, string hours, string coupon, string price)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                couponwallet n = new couponwallet();
                n.startdate = startdate;
                n.enddate = enddate;
                n.rank = rank;
                n.Direct = direct;
                n.hours = hours;
                n.coupon = coupon;
                n.price = price;
                couponwallet np = new couponwallet();
                incomewalletContext dcO = new incomewalletContext();
                np = dcO.bonazas(n, connectionString);
                ViewBag.bag = np.mass;
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        [HttpPost]
        public IActionResult bonanzaplan(string startdate, string enddate,string rank,string direct,string hours,string coupon,string price)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                couponwallet n = new  couponwallet();
                n.startdate = startdate;
                n.enddate = enddate;
                n.rank = rank;
                n.Direct = direct;
                n.hours = hours;
                n.coupon = coupon;
                n.price = price;
                couponwallet np = new couponwallet();
                incomewalletContext dcO = new incomewalletContext();
               np= dcO.bonaza(n,connectionString);
                ViewBag.bag = np.mass;
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        public IActionResult bonanzaList()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                couponlist li = new couponlist();
                incomewalletContext dcO = new incomewalletContext();
                li = dcO.bonanzasee(connectionString);
                return View(li);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult bonanzaLists()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                couponlist li = new couponlist();
                incomewalletContext dcO = new incomewalletContext();
                li = dcO.bonanzasees(connectionString);
                return View(li);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult bonanzaedit(int id)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                couponwallet li = new couponwallet();
                incomewalletContext dcO = new incomewalletContext();
                li = dcO.editesee(id,connectionString);
                return View(li);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult updatbonanzaplan(string startdate, string enddate, string rank, string direct, string hours, string coupon, string price,string indexid)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                couponwallet n = new couponwallet();
                n.indexid = indexid;
                n.startdate = startdate;
                n.enddate = enddate;
                n.rank = rank;
                n.Direct = direct;
                n.hours = hours;
                n.coupon = coupon;
                n.price = price;
                couponwallet np = new couponwallet();
                incomewalletContext dcO = new incomewalletContext();
                np = dcO.updatebonaza(n, connectionString);
                ViewBag.bag = np.mass;
                return RedirectToAction("bonanzaList");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        public IActionResult bonanzdel(int id)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                incomewalletContext dcO = new incomewalletContext();
                dcO.delsee(id, connectionString);
                return RedirectToAction("bonanzaList");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult bonanzdels(int id)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                incomewalletContext dcO = new incomewalletContext();
                dcO.delsee(id, connectionString);
                return RedirectToAction("bonanzaLists");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult UploadImage()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                ip = duct.view( connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult UploadVideo()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
               
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult UploadVideo(string url)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                
                incomewalletContext dcO = new incomewalletContext();
                dcO.uploadv(url, connectionString);

                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult userlistkyc()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                kycmodellist ip = new kycmodellist();
                ip = duct.userlistseekyc(connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult userkyc()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
               
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult userkyc(string id)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                kycmodellist ip = new kycmodellist();
                ip = duct.userlistseekycs(id,connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult updatekyc(string userid)
        {

            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                duct.updatekyc(userid, connectionString);
                return RedirectToAction("userlistkyc", "admin");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult rejectkyc(string userid)
        {

            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                user ip = new user();
                duct.rejectkyc(userid, connectionString);
                return RedirectToAction("userlistkyc", "admin");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        public IActionResult bank(string userid)
        {

            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                kyccontext logoc = new kyccontext();
                kycmodel logo = new kycmodel();
                
                logo = logoc.userkycupdatesee(userid, connectionString);
                ViewBag.error = TempData["asdfg"];
                return View(logo);
            }
            else
            {
                return RedirectToAction("Login", "home");
            }
        }
        [HttpPost]
        public IActionResult bank(string accountno, string ifsc, string bankname, string Payment, string branch, string city, IFormFile file, IFormFile file1,
            string adharnumber, string state, string pannumbr, string AccountHolderName, IFormFile file2, IFormFile file3,string uid)
        {
            kyccontext logoc = new kyccontext();
            kycmodel logo = new kycmodel();
            logo.accountno = accountno;
            logo.ifsc = ifsc;
            logo.bankname = bankname;
            logo.branch = branch;
            logo.city = city;
            logo.AccountHolderName = AccountHolderName;
            logo.Payment = Payment;
            logo.pannumbr = pannumbr;
            logo.adharnumber = adharnumber;
            logo.state = state;

            string uniqueFileName = null;
            if (file != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "upload");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            logo.bank = uniqueFileName;

            string uniqueFileName1 = null;
            if (file1 != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "upload");
                uniqueFileName1 = Guid.NewGuid().ToString() + "_" + file1.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName1);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file1.CopyTo(fileStream);
                }
            }
            logo.pancard = uniqueFileName1;
            string uniqueFileName2 = null;
            if (file2 != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "upload");
                uniqueFileName2 = Guid.NewGuid().ToString() + "_" + file2.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName2);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file2.CopyTo(fileStream);
                }
            }
            logo.adharfront = uniqueFileName2;
            string uniqueFileName3 = null;
            if (file3 != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "upload");
                uniqueFileName3 = Guid.NewGuid().ToString() + "_" + file3.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName3);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file3.CopyTo(fileStream);
                }
            }
            logo.adharback = uniqueFileName3;
            
            logoc.bankins(uid, logo, connectionString);
            TempData["asdfg"] = "Your bank inforemation has been update";
            return RedirectToAction("userlistkyc", "admin");
        }
        public IActionResult DelImage(string id)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
               
              
                incomewalletContext dcO = new incomewalletContext();
                dcO.delimg(id, connectionString);
                return RedirectToAction("UploadImage");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        [HttpPost]
        public IActionResult UploadImage(string type, IFormFile file)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                string uniqueFileName = null;
                if (file != null)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "upload");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }
                string image = uniqueFileName;
                incomewalletContext dcO = new incomewalletContext();
                dcO.upload(type, image, connectionString);

                return RedirectToAction("UploadImage");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult UploadImages(string type, IFormFile file, string title)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                string uniqueFileName = null;
                if (file != null)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "upload");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }
                string image = uniqueFileName;
                incomewalletContext dcO = new incomewalletContext();
                dcO.uploads(type, image,title, connectionString);

                return RedirectToAction("UploadImage");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult Idinsert()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
               
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        [HttpPost]
        public IActionResult Idinsert(int id)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                incomewalletContext dcO = new incomewalletContext();
                dcO.insertuser(id,connectionString);

                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult ProductAdd()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

               
                ViewBag.data = TempData["tp2"];
               
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult ProductAdd(string name, string price, string discount, string discription, IFormFile file, string quantity)
        {
            string message = "";
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                ShopKeeperContext logoc = new ShopKeeperContext();
                ProductAddModel logo = new ProductAddModel();
                logo.name = name;
                logo.price = price;
                logo.discount = discount;
                logo.discription = discription;
                logo.quantity = quantity;
                string uniqueFileName = null;
                if (file != null)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "upload");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }
                logo.image = uniqueFileName;
                string uid = HttpContext.Session.GetString("UserId");
                message = logoc.ProductAddInsert(logo, connectionString);
                TempData["tp2"] = message;
                return RedirectToAction("ProductAdd", "admin");

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }


        public IActionResult Productlist()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                string uid = HttpContext.Session.GetString("UserId");
                ViewBag.shukla = uid;
                ViewBag.data = TempData["tp2"];
                ShopKeeperContext logoc = new ShopKeeperContext();
                ProductAddModelList ListObj = new ProductAddModelList();
                ListObj = logoc.ListData(connectionString);
                return View(ListObj);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult delimg(string id)
        {
            adminnotification deletedata = new adminnotification();
            modlnotification lp = new modlnotification();
            lp.delete = id;
            deletedata.pimgdel(lp, connectionString);
            return RedirectToAction("Productlist");
        }

        public IActionResult Orderlist()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

               
                ShopKeeperContext logoc = new ShopKeeperContext();
                ProductAddModelList ListObj = new ProductAddModelList();
                ListObj = logoc.orderlist(connectionString);
                return View(ListObj);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public IActionResult Ordertodeliver()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {


                ShopKeeperContext logoc = new ShopKeeperContext();
                ProductAddModelList ListObj = new ProductAddModelList();
                ListObj = logoc.orderlist(connectionString);
                return View(ListObj);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }


        public IActionResult Allorderlist(string id)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {


                ShopKeeperContext logoc = new ShopKeeperContext();
                ProductAddModelList ListObj = new ProductAddModelList();
                ListObj = logoc.allorderlist(id,connectionString);
                return View(ListObj);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        public JsonResult findamount(string uid)
        {
            dashboardmodel dmO = new dashboardmodel();
            directcontext dcO = new directcontext();
            
            dmO = dcO.balsee(uid, connectionString);
            return Json(dmO);
        }

        public JsonResult findamounts(string uid)
        {
            dashboardmodel dmO = new dashboardmodel();
            directcontext dcO = new directcontext();

            dmO = dcO.balsees(uid, connectionString);
            return Json(dmO);
        }
        public JsonResult donetiontsee(string uid)
        {
            dashboardmodel dmO = new dashboardmodel();
            directcontext dcO = new directcontext();

            dmO = dcO.donetionbalsee(uid, connectionString);
            return Json(dmO);
        }

        public JsonResult franchiesamounts(string uid)
        {
            dashboardmodel dmO = new dashboardmodel();
            directcontext dcO = new directcontext();

            dmO = dcO.franchisebalsees(uid, connectionString);
            return Json(dmO);
        }

        public JsonResult findamountes(string uid,string type)
        {
            dashboardmodel dmO = new dashboardmodel();
            directcontext dcO = new directcontext();

            dmO = dcO.balseees(uid,type, connectionString);
            return Json(dmO);
        }


        public IActionResult Coupon()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Needanoffer()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult Needanoffer(string sdate, string edate, string sincome, string rf,string ru,string ttime, string direct,string directi,string stype,string gdirect,string gamount)
        {

            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                userlistContext duct = new userlistContext();

                duct.Needanoffer(sdate, edate, sincome, rf,ru,ttime,direct,directi,stype,gdirect, gamount ,connectionString);
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        public IActionResult Needanoffersummary()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                userlistContext duct = new userlistContext();
                kycmodellist ip = new kycmodellist();
               
                ip = duct.noffer( connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult delnoffer(string userid)
        {
            userlistContext duct = new userlistContext();
            duct.deloffer(userid,connectionString);
            return RedirectToAction("Needanoffersummary");
        }
            public IActionResult kbcoffer()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult kbcoffer(string sdate, string edate,string amount,string bonus)
        {

            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                
                userlistContext duct = new userlistContext();

                duct.kbcoffer(sdate,edate,amount,bonus, connectionString);
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        [HttpPost]
        public IActionResult Coupon(string value, string type, string sdate, string edate, string exdate, IFormFile file, string gap, string qty)
        {

            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                string uniqueFileName = null;
                if (file != null)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "upload");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }

                string f = uniqueFileName;
                userlistContext duct = new userlistContext();

                duct.coupon(value, type, sdate, edate, exdate, f, gap, qty, connectionString);
                return View();
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        public IActionResult Couponlist()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                IncomeWallet d = new IncomeWallet();
                incomewalletContext dcO = new incomewalletContext();
                d = dcO.couponlist(connectionString);
                return View(d);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult deletecoupon(string id)
        {
            string k = HttpContext.Session.GetString("Adminflag");

            directcontext duct = new directcontext();
            userlistModel ip = new userlistModel();
            duct.delcoupon(id, connectionString);
            return RedirectToAction("couponlist", "admin");


        }

        public IActionResult wincoupon()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                IncomeWallet d = new IncomeWallet();
                incomewalletContext dcO = new incomewalletContext();
                d = dcO.wonlist(connectionString);
                return View(d);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Idupgrade()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                ViewBag.tmt = TempData["tp1"];
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult Idupgrade(string uid)
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                userlistContext m = new userlistContext();
                string n = m.upgradeid(uid, connectionString);
                if (n == "1")
                {

                    TempData["tp1"] = "Id upgrade";
                }
                else
                {
                    TempData["tp1"] = "ID upgrade Fail";
                }
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult charitysummary()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                directlist d = new directlist();
                directcontext dcO = new directcontext();
                d = dcO.charitysee(connectionString);
                return View(d);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult clubdistribution()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                income d = new income();
                incomewalletContext dcO = new incomewalletContext();
                d = dcO.distributionsee(connectionString);
                return View(d);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult pop()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                IncomeWallet d = new IncomeWallet();
                incomewalletContext dcO = new incomewalletContext();
                d = dcO.slideimg(connectionString);
                return View(d);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult pdf()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                IncomeWallet d = new IncomeWallet();
                incomewalletContext dcO = new incomewalletContext();
                d = dcO.slideimg(connectionString);
                return View(d);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }


        public IActionResult poplogin()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                IncomeWallet d = new IncomeWallet();
                incomewalletContext dcO = new incomewalletContext();
                d = dcO.slideimglogin(connectionString);
                return View(d);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult popdashbord()
        {
            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {

                IncomeWallet d = new IncomeWallet();
                incomewalletContext dcO = new incomewalletContext();
                d = dcO.slideimgdashboard(connectionString);
                return View(d);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult pop(IFormFile file)
        {

            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                string uniqueFileName = null;
                if (file != null)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "upload");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }

                string f = uniqueFileName;
                userlistContext duct = new userlistContext();

                duct.pop(f, connectionString);
                return RedirectToAction("pop");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult poplogin(IFormFile file)
        {

            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                string uniqueFileName = null;
                if (file != null)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "upload");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }

                string f = uniqueFileName;
                userlistContext duct = new userlistContext();

                duct.poplogin(f, connectionString);
                return RedirectToAction("poplogin");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult popdashboard(IFormFile file)
        {

            string k = HttpContext.Session.GetString("Adminflag");
            if (k == "1")
            {
                string uniqueFileName = null;
                if (file != null)
                {
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "upload");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                }

                string f = uniqueFileName;
                userlistContext duct = new userlistContext();

                duct.popdashboard(f, connectionString);
                return RedirectToAction("popdashbord");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }



    }
}
