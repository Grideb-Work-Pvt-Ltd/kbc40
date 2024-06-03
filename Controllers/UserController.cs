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
using System.Text;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text.Json;
using System.Net;
using System.Security.Cryptography;
using static forex.Models.dashboardmodel;

namespace forex.Controllers
{
    public class UserController : Controller
    {
        readonly TreeDataaccess dbtreeContext = new TreeDataaccess();
        private readonly IWebHostEnvironment webHostEnvironment;
        readonly string connectionString = @"Data Source=68.178.203.9;Initial Catalog=KBC40New;User ID=sa;Password=gri12DEB!@;";

        public UserController(ILogger<UserController> logger, IWebHostEnvironment hostEnvironment)
        {
            webHostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                dashboardmodel dmO = new dashboardmodel();
                directcontext dcO = new directcontext();
                string uid = HttpContext.Session.GetString("UserId");
                dmO = dcO.dashboardsee(uid, connectionString);
                return View(dmO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult charitywallet()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                dashboardmodel dmO = new dashboardmodel();
                directcontext dcO = new directcontext();
                string uid = HttpContext.Session.GetString("UserId");
                dmO = dcO.dashboardsee(uid, connectionString);
                return View(dmO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult DirectReferral()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                directlist dmO = new directlist();
                directcontext dcO = new directcontext();
                string uid = HttpContext.Session.GetString("UserId");
                dmO = dcO.directsee(uid, connectionString);
                return View(dmO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult TeamReferral()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                Downline dowm = new Downline();
                downlinedata dcO = new downlinedata();
                string uid = HttpContext.Session.GetString("UserId");
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
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                userlistModel ip = new userlistModel();
                string uid = HttpContext.Session.GetString("UserId");
                ip = duct.userprofilesee(uid, connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult AddPost()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {

                string uid = HttpContext.Session.GetString("UserId");

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Viewpost()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {

                string uid = HttpContext.Session.GetString("UserId");
                userlistContext cons = new userlistContext();
                Rootes n = new Rootes();
                n = cons.fadd(uid, connectionString);
                if (n.adurl == "1")
                {
                    return View(n);
                }
                else
                {

                    post p = new post();
                    greenwalletCon dcO = new greenwalletCon();
                    p = dcO.postview(connectionString);
                    p.companykey = "kbc40-mt";
                    p.companysecret = "E3398265-41DE-47E0-8F60-D52852010A97";
                    p.name = HttpContext.Session.GetString("name");
                    p.company = "KBC40";
                    p.no = HttpContext.Session.GetString("mobile");

                    p.url = "https://kbc40.com/registers/" + uid;


                    // string strPushURL = "https://partner.imwallet.in/web_services/recharge_process.jsp?webToken=Ie2mSwGPbNSIjzVy7jrmCmRziXq6OEI2&userCode=IMAPI9311985&orderid=" + mk.orderid + "&skey=" + opretor + "&accountNo=" + product + "&amount=" + amount + "&callBack=https://mlmtrend.org";
                    string strPushURL = "https://mlmtrend.org/api/values?companykey=kbc40-mt&companysecret=E3398265-41DE-47E0-8F60-D52852010A97&add=" + p.occasion + "&name=" + p.name + "&company=" + p.company + "&use=" + p.detail + "&no=" + p.no + "&url=" + p.url + "&userid=" + uid + "";
                    WebRequest webrequest = WebRequest.Create(strPushURL);
                    WebResponse response = webrequest.GetResponse();
                    Stream ReceiveStream = response.GetResponseStream();
                    StreamReader readStream = new StreamReader(ReceiveStream);

                    string strResponse = readStream.ReadToEnd();
                    Rootes myreqest = JsonConvert.DeserializeObject<Rootes>(strResponse);
                    userlistContext con = new userlistContext();
                    con.addsave(uid, myreqest, connectionString);

                    return View(myreqest);
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult pass(string name, string accountno, string Mobile, string City, string emailaddress, string address, IFormFile file, string nominee)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                userlistModel ip = new userlistModel();
                ip.name = name;
                ip.accountno = accountno;
                ip.Mobile = Mobile;
                ip.City = City;
                ip.emailaddress = emailaddress;
                ip.address = address;
                ip.nominee = nominee;
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

                ip.image = uniqueFileName;

                string uid = HttpContext.Session.GetString("UserId");
                ip = duct.userupdatepass(ip, uid, connectionString);
                TempData["message"] = ip.message;
                return RedirectToAction("Profile", "user");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        public IActionResult passwordchange()
        {
            return View();
        }
        [HttpPost]
        public IActionResult passwordchange(string CurrentPassword, string NewPassword, string ConfirmPassword)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                userlistModel ip = new userlistModel();
                ip.CurrentPassword = CurrentPassword;
                ip.NewPassword = NewPassword;
                ip.ConfirmPassword = ConfirmPassword;
                string uid = HttpContext.Session.GetString("UserId");
                ip = duct.userupdatepassword(ip, uid, connectionString);
                TempData["message"] = ip.message;
                return RedirectToAction("passwordchange", "user");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }


        public IActionResult Addfund()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {

                string uid = HttpContext.Session.GetString("UserId");
                ViewBag.shukla = uid;
                ViewBag.data = TempData["tp2"];
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult Addfund(string amount, string transection, IFormFile file)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                kyccontext logoc = new kyccontext();
                kycmodel logo = new kycmodel();
                logo.amount = amount;
                logo.transection = transection;
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
                string uid = HttpContext.Session.GetString("UserId");
                logoc.active(uid, logo, connectionString);
                TempData["tp2"] = "Add Fund Successfully!";
                return RedirectToAction("Addfund", "User");

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Howitworks()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {

                string uid = HttpContext.Session.GetString("UserId");
                ViewBag.shukla = uid;
                ViewBag.data = TempData["tp2"];
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Legal()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {

                string uid = HttpContext.Session.GetString("UserId");
                ViewBag.shukla = uid;
                ViewBag.data = TempData["tp2"];
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult AddfundUSDT()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {

                string uid = HttpContext.Session.GetString("UserId");
                ViewBag.shukla = uid;
                ViewBag.data = TempData["tp2"];
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult AddfundUSDT(string amount, string transection, IFormFile file)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                kyccontext logoc = new kyccontext();
                kycmodel logo = new kycmodel();
                logo.amount = amount;
                logo.transection = transection;
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
                string uid = HttpContext.Session.GetString("UserId");
                logoc.active(uid, logo, connectionString);
                TempData["tp2"] = "Add Fund Successfully!";
                return RedirectToAction("AddfundUSDT", "User");

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Topup()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                IncomeWallet dowm = new IncomeWallet();
                greenwalletCon dcO = new greenwalletCon();
                string uid = HttpContext.Session.GetString("UserId");
                ViewBag.sms = uid;
                ViewBag.payreq = TempData["tp2"];
                dowm = dcO.greenwalletsee(uid, connectionString);
                return View(dowm);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult Topup(string userid, float package, string SelectPlan)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                walletmodel greenModeluserid = new walletmodel();
                greenModeluserid.userid = userid;
                greenModeluserid.SelectPlan = SelectPlan;
                greenModeluserid.package = package;
                greenwalletCon dcO = new greenwalletCon();
                string uid = HttpContext.Session.GetString("UserId");
                dcO.greenwalletuserid(uid, greenModeluserid, connectionString);
                ViewBag.payreq = "Value is 20 or Multipal of 20$ !.";
                return RedirectToAction("Topup", "User");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult MainWalletSummery()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                IncomeWallet dowm = new IncomeWallet();
                greenwalletCon dcO = new greenwalletCon();
                string uid = HttpContext.Session.GetString("UserId");
                dowm = dcO.transwalletsee(uid, connectionString);
                return View(dowm);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult charityWalletSummery()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                IncomeWallet dowm = new IncomeWallet();
                greenwalletCon dcO = new greenwalletCon();
                string uid = HttpContext.Session.GetString("UserId");
                dowm = dcO.ctranswalletsee(uid, connectionString);
                return View(dowm);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult addfundpay()
        {
            string k = HttpContext.Session.GetString("flag");
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
        public IActionResult addfundpay(string amount)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                int am = int.Parse(amount);
                if (am < 999)
                {
                    TempData["tp1"] = "Amount should be 1000 and multiple";
                    return View();
                }

                if (am % 1000 == 0)
                {
                    walletmodel greenModeluserid = new walletmodel();

                    greenModeluserid.amount = amount;
                    greenwalletCon dcO = new greenwalletCon();
                    string uid = HttpContext.Session.GetString("UserId");
                    string tamount = dcO.findlastpay(uid, connectionString);
                    int amt = int.Parse(tamount);
                    int amot = int.Parse(amount);
                    if (amt <= amot)
                    {
                        string orderid = dcO.addpayfund(uid, greenModeluserid, connectionString);
                        HttpContext.Session.SetString("orderid", orderid);
                        HttpContext.Session.SetString("price", amount);
                        return RedirectToAction("GeneratePaymentLink", "User");
                    }
                    else
                    {
                        TempData["tp1"] = "Please amount incrase";
                        return View();
                    }
                }
                else
                {
                    TempData["tp1"] = "Amount should be 1000 and multiple";
                    return View();

                }
            }

            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public async Task<IActionResult> GeneratePaymentLink(VerifyRequestModel phonePePayment)

        {
            string tid = HttpContext.Session.GetString("orderid");
            string amounts = HttpContext.Session.GetString("price");
            //string amounts = "1";
            int amont = int.Parse(amounts);
            int amount = amont * 100;

            string mob = HttpContext.Session.GetString("mobile");
            //  string saltKey = "099eb0cd-02cf-4e2a-8aca-3e6c6aff0399";
            string saltKey = "0870c0b5-21ec-44f7-b08c-67a1b00a63b3";
            int saltIndex = 1;
            // string jsonPayloads = "{\n  \"merchantId\": \"PGTESTPAYUAT\",\n  \"merchantTransactionId\": \"" + tid + "\",\n  \"merchantUserId\": \"" + tid + "\",\n  \"amount\": " + amount + ",\n  \"redirectUrl\": \"https://localhost:44389/payment\",\n  \"redirectMode\": \"REDIRECT\",\n  \"callbackUrl\": \"https://kbc40.com/\",\n  \"mobileNumber\": \"" + mob+"\",\n  \"paymentInstrument\": {\n    \"type\": \"PAY_PAGE\"\n  }\n}";
            string jsonPayloads = "{\n  \"merchantId\": \"KBC40ONLINE\",\n  \"merchantTransactionId\": \"" + tid + "\",\n  \"merchantUserId\": \"" + tid + "\",\n  \"amount\": " + amount + ",\n  \"redirectUrl\": \"https://kbc40.com/pay\",\n  \"redirectMode\": \"REDIRECT\",\n  \"callbackUrl\": \"https://kbc40.com/\",\n  \"mobileNumber\": \"" + mob + "\",\n  \"paymentInstrument\": {\n    \"type\": \"PAY_PAGE\"\n  }\n}";
            //  string jsonPayloads = "{\n  \"merchantId\": \"PGTESTPAYUAT\",\n  \"merchantTransactionId\": \"" + tid + "\",\n  \"merchantUserId\": \"" + tid + "\",\n  \"amount\": " + amount + ",\n  \"redirectUrl\": \"https://localhost:44389/pay\",\n  \"redirectMode\": \"REDIRECT\",\n  \"callbackUrl\": \"https://kbc40.com/\",\n  \"mobileNumber\": \"" + mob+"\",\n  \"paymentInstrument\": {\n    \"type\": \"PAY_PAGE\"\n  }\n}";

            string base64Strings = Convert.ToBase64String(Encoding.UTF8.GetBytes(jsonPayloads));
            string jl = base64Strings + "/pg/v1/pay" + saltKey;

            string sha256Hash = BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(jl))).Replace("-", "").ToLower();
            phonePePayment.X_VERIFY = sha256Hash + "###" + saltIndex;
            phonePePayment.base64 = base64Strings;
            HttpContext.Session.SetString("TransactionId", tid);
            HttpContext.Session.SetString("X_VERIFY", phonePePayment.X_VERIFY);


            try
            {
                var PhonePeGatewayURL = "https://api.phonepe.com/apis/hermes";
                //    var PhonePeGatewayURL = "https://api-preprod.phonepe.com/apis/pg-sandbox";

                var httpClient = new HttpClient();
                var uri = new Uri($"{PhonePeGatewayURL}/pg/v1/pay");

                // Add headers
                httpClient.DefaultRequestHeaders.Add("accept", "application/json");
                httpClient.DefaultRequestHeaders.Add("X-VERIFY", phonePePayment.X_VERIFY);

                // Create JSON request body
                var jsonBody = $"{{\"request\":\"{phonePePayment.base64}\"}}";
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                // Send POST request
                var response = await httpClient.PostAsync(uri, content);

                response.EnsureSuccessStatusCode();

                // Read and deserialize the response content
                var responseContent = await response.Content.ReadAsStringAsync();
                var responseData = JsonDocument.Parse(responseContent).RootElement;

                // Access the properties of the JSON document
                var paymentUrl = responseData.GetProperty("data").GetProperty("instrumentResponse").GetProperty("redirectInfo").GetProperty("url").GetString();
                return Redirect(paymentUrl);
            }
            catch (Exception ex)
            {
                // Handle errors and return an error response
                return Json(new { Success = false, Message = "Verification failed", Error = ex.Message });
            }
        }

        public IActionResult crowdwallet_statement()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                IncomeWallet dowm = new IncomeWallet();
                greenwalletCon dcO = new greenwalletCon();
                string uid = HttpContext.Session.GetString("UserId");
                dowm = dcO.crowdwalletsee(uid, connectionString);
                return View(dowm);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult crowdrecieved()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                IncomeWallet dowm = new IncomeWallet();
                greenwalletCon dcO = new greenwalletCon();
                string uid = HttpContext.Session.GetString("UserId");
                dowm = dcO.recivedwalletsee(uid, connectionString);
                return View(dowm);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult crowdgiven()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                IncomeWallet dowm = new IncomeWallet();
                greenwalletCon dcO = new greenwalletCon();
                string uid = HttpContext.Session.GetString("UserId");
                dowm = dcO.givenwalletsee(uid, connectionString);
                return View(dowm);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult TopupWallet()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                IncomeWallet dowm = new IncomeWallet();
                greenwalletCon dcO = new greenwalletCon();
                string uid = HttpContext.Session.GetString("UserId");
                dowm = dcO.greenwalletsee(uid, connectionString);
                return View(dowm);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult incomeSummary(string id)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.incomesee(uid, id, connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult ProfitSharing()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                string id = "daily";
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.incomesee(uid, id, connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult IncomeOnProfitSharing()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                string id = "Level";
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.incomesee(uid, id, connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult ReferralIncome()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                string id = "Direct";
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.incomesee(uid, id, connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult TeamIncome()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                string id = "team";
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.incomesee(uid, id, connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult RewardsRoyalty()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                string id = "Reward";
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.incomesee(uid, id, connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult Bonnanza()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                string id = "Bonnanza";
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.incomesee(uid, id, connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult PaymentRequest()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.paySee(uid, connectionString);
                ViewBag.pay = TempData["tp2"];
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult fundtransfer()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");

                incoO = dcO.paySee(uid, connectionString);
                ViewBag.data1 = TempData["tp1"];
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }


        [HttpPost]
        public IActionResult fundtransfer(float ramount, float amount)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                if (ramount >= amount && amount >= 10)
                {

                    incomeModel incoO = new incomeModel();
                    incomewalletContext dcO = new incomewalletContext();
                    string uid = HttpContext.Session.GetString("UserId");
                    dcO.fundReqin(amount, uid, connectionString);
                    TempData["tp1"] = "Transfer Successfully";
                    incoO = dcO.paySee(uid, connectionString);
                    return View(incoO);

                }
                else
                {
                    TempData["tp1"] = "Value is less than 10$.";
                    return RedirectToAction("fundtransfer", "user");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult ClubReservation()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.paySeeClub(uid, connectionString);
                ViewBag.data1 = TempData["tp1"];
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult fundtransto2XWallet()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.kbcSee(uid, connectionString);
                ViewBag.data1 = TempData["tp1"];
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult fundtransto2XWallet(float ramount, float amount, string byuserid, string enterotp)
        {
            string otp = HttpContext.Session.GetString("otp");
            string name = HttpContext.Session.GetString("name");
            string mobile = HttpContext.Session.GetString("mobile");
            string k = HttpContext.Session.GetString("flag");
            string n = amount.ToString();
            HttpContext.Session.SetString("damount", n);
            if (k == "1")
            {
                if (IsMultipleOf1000(amount))

                {
                    if (ramount >= amount)
                    {


                        incomeModel incoO = new incomeModel();
                        incomewalletContext dcO = new incomewalletContext();
                        greenwalletCon dcOs = new greenwalletCon();
                        string uid = HttpContext.Session.GetString("UserId");
                        string tamount = dcOs.findlastpay(uid, connectionString);
                        int amt = int.Parse(tamount);

                        if (amt <= amount)
                        {
                            string p = dcO.fundReqintrans2xw(amount, uid, byuserid, connectionString);


                            TempData["tp1"] = p;
                            incoO = dcO.kbcSee(uid, connectionString);
                            return View(incoO);
                        }
                        else
                        {
                            TempData["tp1"] = "Plese increase Amount";
                            return RedirectToAction("fundtransto2XWallet", "user");
                        }
                    }
                    else
                    {
                        TempData["tp1"] = "Less Amount";
                        return RedirectToAction("fundtransto2XWallet", "user");
                    }
                }
                else
                {
                    TempData["tp1"] = "Amount Should be multiple of 1000.";
                    return RedirectToAction("fundtransto2XWallet", "user");

                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult fundtranstofranchisetoNeedan()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.franchisebalSee(uid, connectionString);
                ViewBag.data1 = TempData["tp1"];
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult fundtranstofranchisetoNeedan(float ramount, float amount, string byuserid, string enterotp, string kt)
        {
            string otp = HttpContext.Session.GetString("otp");
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                if (ramount >= amount)
                {

                    incomeModel incoO = new incomeModel();
                    incomewalletContext dcO = new incomewalletContext();
                    string uid = HttpContext.Session.GetString("UserId");

                    if (otp == enterotp & 5 == 5)
                    {
                        kt = dcO.fundReqintransTofranchisetoneedan(amount, uid, byuserid, connectionString);
                    }
                    else
                    {
                        ViewBag.mess = "Enter OTP is Wrong";
                    }

                    // TempData["tp1"] = "Transfer Successfully";
                    TempData["tp1"] = kt;
                    incoO = dcO.franchisebalSee(uid, connectionString);
                    HttpContext.Session.SetString("otp", "nothingexp");
                    return View(incoO);

                }
                else
                {
                    TempData["tp1"] = "Value is less than 10$.";
                    return RedirectToAction("fundtranstogreen", "user");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult fundtranstokbctoNeedan()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.kbcSee(uid, connectionString);
                ViewBag.data1 = TempData["tp1"];
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult fundtranstokbctoNeedan(float ramount, float amount, string byuserid, string enterotp, string kt)
        {
            string otp = HttpContext.Session.GetString("otp");
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                if (ramount >= amount)
                {

                    incomeModel incoO = new incomeModel();
                    incomewalletContext dcO = new incomewalletContext();
                    string uid = HttpContext.Session.GetString("UserId");

                    if (otp == enterotp & 5 == 5)
                    {
                        kt = dcO.fundReqintransTokbctoneedan(amount, uid, byuserid, connectionString);
                    }
                    else
                    {
                        ViewBag.mess = "Enter OTP is Wrong";
                    }

                    // TempData["tp1"] = "Transfer Successfully";
                    TempData["tp1"] = kt;
                    incoO = dcO.kbcSee(uid, connectionString);
                    HttpContext.Session.SetString("otp", "nothingexp");
                    return View(incoO);

                }
                else
                {
                    TempData["tp1"] = "Value is less than 10$.";
                    return RedirectToAction("fundtranstogreen", "user");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult fundtranstokbctokbc()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.kbcSee(uid, connectionString);
                ViewBag.data1 = TempData["tp1"];
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult fundtranstokbctokbc(float ramount, float amount, string byuserid, string enterotp, string kt)
        {
            string otp = HttpContext.Session.GetString("otp");
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                if (ramount >= amount)
                {

                    incomeModel incoO = new incomeModel();
                    incomewalletContext dcO = new incomewalletContext();
                    string uid = HttpContext.Session.GetString("UserId");

                    if (otp == enterotp)
                    {
                        kt = dcO.fundReqintransTokbc(amount, uid, byuserid, connectionString);
                    }
                    else
                    {
                        ViewBag.mess = "Enter OTP is Wrong";
                    }

                    // TempData["tp1"] = "Transfer Successfully";
                    TempData["tp1"] = kt;
                    incoO = dcO.kbcSee(uid, connectionString);
                    HttpContext.Session.SetString("otp", "nothingexp");
                    return View(incoO);

                }
                else
                {
                    TempData["tp1"] = "Value is less than 10$.";
                    return RedirectToAction("fundtranstogreen", "user");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult fundtranstogreen()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.paySee(uid, connectionString);
                ViewBag.data1 = TempData["tp1"];
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult fundtranstogreen_otp()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                treelist tre = new treelist();
                treeContext treeCon = new treeContext();
                string uid = HttpContext.Session.GetString("UserId");
                tre = treeCon.treeSee(uid, connectionString);
                Random r = new Random();
                int otp = r.Next(11111, 99999);
                string o = Convert.ToString(otp);
                HttpContext.Session.SetString("otp", o);
                //string templateid = "1207161847338398965";
                string templateid = "1207169502437973133";
                connect sms = new connect();
                sms.SendSMS(tre.mobile, "Dear " + tre.name + ", Your OTP is " + otp + ". Team  kbc40", templateid, "OTP");
                TempData["otp"] = otp;
                return RedirectToAction("fundtranstogreen", "user");
            }
            else
            {
                return RedirectToAction("Index", "home");
            }
        }

        [HttpPost]
        public IActionResult fundtranstogreen(float ramount, float amount, string byuserid, string enterotp, string kt)
        {
            string otp = HttpContext.Session.GetString("otp");
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                if (ramount >= amount)
                {

                    incomeModel incoO = new incomeModel();
                    incomewalletContext dcO = new incomewalletContext();
                    string uid = HttpContext.Session.GetString("UserId");

                    if (otp == enterotp)
                    {
                        kt = dcO.fundReqintransTogreen(amount, uid, byuserid, connectionString);
                    }
                    else
                    {
                        ViewBag.mess = "Enter OTP is Wrong";
                    }

                    // TempData["tp1"] = "Transfer Successfully";
                    TempData["tp1"] = kt;
                    incoO = dcO.paySee(uid, connectionString);
                    HttpContext.Session.SetString("otp", "nothingexp");
                    return View(incoO);

                }
                else
                {
                    TempData["tp1"] = "Value is less than 10$.";
                    return RedirectToAction("fundtranstogreen", "user");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }




        public IActionResult fundtranstocharity()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.paySee(uid, connectionString);
                ViewBag.data1 = TempData["tp1"];
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Donetionrecipt(int id)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                IncomeWallet incoO = new IncomeWallet();
                paymentwithdrawl dcO = new paymentwithdrawl();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.donetions(uid, id, connectionString);

                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Donetionrecipts()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                IncomeWallet incoO = new IncomeWallet();
                paymentwithdrawl dcO = new paymentwithdrawl();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.donetion(uid, connectionString);

                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult sendsms()
        {
            string k = HttpContext.Session.GetString("flag");
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

        public IActionResult sendsms(string mobile)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                string templateid = "1207170358647029120";

                string uid = HttpContext.Session.GetString("UserId");
                string umobile = HttpContext.Session.GetString("mobile");
                connect sms = new connect();
                //sms.SendSMS(tre.mobile, "Dear " + tre.name + ", Your OTP is " + otp + ". Team  kbc40", templateid, "OTP");
                sms.SSendSMS(mobile, "Hey friend! Join our NGO and become financially strong!Click here https://kbc40.com/home/register/" + uid + " and Register.Contact us at: " + umobile + " Team KBC40", templateid, "MKT");



                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult fundtranstocharity_otp()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                treelist tre = new treelist();
                treeContext treeCon = new treeContext();
                string uid = HttpContext.Session.GetString("UserId");
                tre = treeCon.treeSee(uid, connectionString);
                Random r = new Random();
                int otp = r.Next(11111, 99999);
                string o = Convert.ToString(otp);
                HttpContext.Session.SetString("otp", o);
                string templateid = "1207169502437973133";
                connect sms = new connect();
                sms.SendSMS(tre.mobile, "Dear " + tre.name + ", Your OTP is " + otp + ". Team  kbc40", templateid, "OTP");
                TempData["otp"] = otp;
                return RedirectToAction("fundtranstocharity", "user");
            }
            else
            {
                return RedirectToAction("Index", "home");
            }
        }

        [HttpPost]
        public IActionResult fundtranstocharity(float ramount, float amount, string byuserid, string enterotp)
        {
            string otp = HttpContext.Session.GetString("otp");
            string name = HttpContext.Session.GetString("name");
            string mobile = HttpContext.Session.GetString("mobile");
            string k = HttpContext.Session.GetString("flag");
            string n = amount.ToString();
            HttpContext.Session.SetString("damount", n);
            if (k == "1")
            {
                if (IsMultipleOf1000(amount))

                {
                    if (ramount >= amount)
                    {

                        incomeModel incoO = new incomeModel();
                        incomewalletContext dcO = new incomewalletContext();
                        string uid = HttpContext.Session.GetString("UserId");
                        string p = dcO.fundReqintransTcharity(amount, uid, byuserid, connectionString);
                        //if (otp == enterotp)
                        //{

                        //}
                        //else
                        //{
                        //    ViewBag.mess = "Enter OTP is Wrong";
                        //}

                        TempData["tp1"] = p;
                        incoO = dcO.paySee(uid, connectionString);
                        string templateid = "1207169951265836691";

                        connect sms = new connect();
                        sms.SendSMS(mobile, "Dear " + name + ", Congratulations On Your Decision To Donate " + amount + " In Your Charity Wallet and Now, You Will Get 2X Volunteer Welfare Fund. Team KBC40", templateid, "TXN");
                        if (p == "Transfer Successfully")
                        {
                            return RedirectToAction("Donetionreciptes");
                        }
                        else
                        {
                            return View(incoO);
                        }
                        // return View(incoO);

                    }
                    else
                    {
                        TempData["tp1"] = "Value is less than 10$.";
                        return RedirectToAction("fundtranstocharity", "user");
                    }
                }
                else
                {
                    TempData["tp1"] = "Amount Should be multiple of 1000.";
                    return RedirectToAction("fundtranstocharity", "user");

                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        private bool IsMultipleOf1000(float number)
        {
            return number % 1000 == 0;
        }

        public IActionResult Donetionreciptes()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                userlistModel m = new userlistModel();
                Random random = new Random();
                int randomNumber = random.Next(1000, 10001); // Generates a number between 1000 and 10000 (inclusive)

                m.userid = randomNumber.ToString();
                m.accountno = HttpContext.Session.GetString("damount");
                m.name = HttpContext.Session.GetString("name");
                return View(m);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }



        public IActionResult withdrawalwallet()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");

                incoO = dcO.paySee(uid, connectionString);
                ViewBag.data1 = TempData["tp1"];
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Addfundfranchise()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.needanSee(uid, connectionString);
                ViewBag.pay = TempData["tp2"];
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult franchiseBank(string uid)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                kyccontext logoc = new kyccontext();
                kycmodel logo = new kycmodel();

                logo = logoc.userkycupdatesee(uid, connectionString);
                ViewBag.error = TempData["asdfg"];
                return View(logo);
            }
            else
            {
                return RedirectToAction("Login", "home");
            }
        }

        public IActionResult requestforwallet()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                kyccontext logoc = new kyccontext();
                kycmodellist dmo = new kycmodellist();
                string uid = HttpContext.Session.GetString("UserId");
                dmo = logoc.activesees(uid, connectionString);
                return View(dmo);
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }
        [HttpPost]

        public IActionResult requestforwallet(string id)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                kyccontext logoc = new kyccontext();
                kycmodellist dmo = new kycmodellist();
                string uid = HttpContext.Session.GetString("UserId");
                logoc.updateactivesees(id, connectionString);
                return RedirectToAction("requestforwallet");
            }
            else
            {
                return RedirectToAction("adminlogin", "home");
            }
        }

        [HttpPost]
        public IActionResult franchiseBanks(string kamount, string namount, string byuserid, string transection, IFormFile file)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                kyccontext logoc = new kyccontext();
                kycmodel logo = new kycmodel();
                logo.kamount = kamount;
                logo.namount = namount;
                logo.byuserid = byuserid;
                logo.transection = transection;
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
                string uid = HttpContext.Session.GetString("UserId");
                logoc.franchiseactive(uid, logo, connectionString);
                TempData["tp2"] = "Add Fund Successfully!";
                return RedirectToAction("Addfundfranchise", "User");

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult withdrawalRequestNeedan()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.needanSee(uid, connectionString);
                ViewBag.pay = TempData["tp2"];
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult withdrawalRequestNeedan(float amount, string franchise)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");

                string pay = dcO.paymentReqinfranchise(amount, uid, franchise, connectionString);

                //TempData["tp2"] = "Payment Withdrawal Successfully!";
                // ViewBag.payreq = "Payment Withdrawal Successfully!";
                TempData["tp2"] = pay;
                ViewBag.payreq = pay;
                return RedirectToAction("withdrawalRequestneedan", "user");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult PaymentRequestfranchise()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                income incoO = new income();
                string uid = HttpContext.Session.GetString("UserId");
                incomewalletContext dcO = new incomewalletContext();
                incoO = dcO.userunpaidfranchisesee(uid, connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("login", "home");
            }
        }

        public IActionResult withdrawlfranchise(string amount, string indexid)
        {
            incomeModel incoO = new incomeModel();
            incomewalletContext dcO = new incomewalletContext();
            dcO.withdrawlReqinfranchise(amount, indexid, connectionString);
            return RedirectToAction("PaymentRequestfranchise", "user");
        }
        public IActionResult rejectfranchise(string indexid1)
        {
            incomeModel incoO = new incomeModel();
            incomewalletContext dcO = new incomewalletContext();
            dcO.withdrawlReqin1(indexid1, connectionString);
            return RedirectToAction("PaymentRequestfranchise", "user");
        }

        public IActionResult withdrawalRequest()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.kbcSee(uid, connectionString);
                ViewBag.pay = TempData["tp2"];
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult withdrawalRequest(float amount)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                string name = HttpContext.Session.GetString("name");

                string pay = dcO.paymentReqin(amount, uid, connectionString);

                //TempData["tp2"] = "Payment Withdrawal Successfully!";
                // ViewBag.payreq = "Payment Withdrawal Successfully!";
                TempData["tp2"] = pay;
                ViewBag.payreq = pay;
                if (pay == "your payment is Successfully")
                {
                    connect sms = new connect();
                    string Mobile = "9971114246";
                    string templateid = "1207171627898403620";
                    //sms.SendSMS(Mobile, "Dear " + name + ", Welcome to KBC40 Your account has been created successfully.Your Login Id is: " + ml.userid + " and Password: -" + password + ".Thanks Team kbc40", templateid,"TXN");
                    sms.SendSMS(Mobile, "Dear Admin , " + name + " With User I.D. :- " + uid + " has initiated a withdrawal request of Rs. " + amount + ". Kindly process this transaction at your earliest Team KBC40", templateid, "TXN");
                }

                return RedirectToAction("withdrawalRequest", "user");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult withdrawalsummary()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                paymentwithdrawl walletO = new paymentwithdrawl();
                IncomeWallet dcO = new IncomeWallet();
                string uid = HttpContext.Session.GetString("UserId");
                dcO = walletO.paymentsummary(uid, connectionString);
                return View(dcO);
            }
            else
            {
                return RedirectToAction("Index", "home");
            }
        }


        public IActionResult diposite()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                paymentwithdrawl walletO = new paymentwithdrawl();
                IncomeWallet dcO = new IncomeWallet();
                string uid = HttpContext.Session.GetString("UserId");
                dcO = walletO.diposite(uid, connectionString);
                return View(dcO);
            }
            else
            {
                return RedirectToAction("Index", "home");
            }
        }


        public IActionResult Notification()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                notifee dmo = new notifee();
                adminnotification dco = new adminnotification();
                string uid = HttpContext.Session.GetString("UserId");
                dmo = dco.noticesee(uid, connectionString);
                return View(dmo);
            }
            else
            {
                return RedirectToAction("Index", "home");
            }
        }

        public IActionResult Supportsystem()
        {
            ViewBag.data = TempData["tp6"];
            modlnotification feed = new modlnotification();
            feed.username = HttpContext.Session.GetString("username"); ;
            feed.userid = HttpContext.Session.GetString("UserId");
            adminnotification noc = new adminnotification();
            notifee tl = new notifee();
            tl = noc.feedseeuser(HttpContext.Session.GetString("UserId"), connectionString);

            return View(tl);
        }
        [HttpPost]
        public IActionResult Supportsystem(string username, string userid, string message)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                modlnotification feed = new modlnotification();
                feed.username = HttpContext.Session.GetString("username"); ;
                feed.userid = HttpContext.Session.GetString("UserId");
                feed.Content = message;
                adminnotification noc = new adminnotification();
                noc.feedbac(feed, connectionString);
                TempData["tp6"] = "Message Successfull!";
                return RedirectToAction("Supportsystem", "user");
            }
            else
            {
                return RedirectToAction("Index", "home");
            }
        }
        public IActionResult tree()
        {
            string k = HttpContext.Session.GetString("flag");
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
                return RedirectToAction("Index", "home");
            }
        }

        [HttpPost]
        public IActionResult tree(string level, string topenter)
        {
            string otp = HttpContext.Session.GetString("otp");

            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                treelist tre = new treelist();
                treeContext treeCon = new treeContext();
                string uid = HttpContext.Session.GetString("UserId");
                if (otp == topenter)
                {
                    treeCon.LevelSee(uid, connectionString);
                }
                else
                {
                    ViewBag.mess = "Enter OTP is Wrong";
                }
                return RedirectToAction("tree", "user");
            }
            else
            {
                return RedirectToAction("Index", "home");
            }
        }

        public IActionResult otp()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                treelist tre = new treelist();
                treeContext treeCon = new treeContext();
                string uid = HttpContext.Session.GetString("UserId");
                tre = treeCon.treeSee(uid, connectionString);
                Random r = new Random();
                int otp = r.Next(11111, 99999);
                string o = Convert.ToString(otp);
                HttpContext.Session.SetString("otp", o);
                string templateid = "1207169502437973133";
                connect sms = new connect();
                sms.SendSMS(tre.mobile, "Dear " + tre.name + ", Your OTP is " + otp + ". Team  kbc40", templateid, "OTP");
                return RedirectToAction("tree", "user");
            }
            else
            {
                return RedirectToAction("Index", "home");
            }
        }


        [HttpPost]
        public IActionResult myotp()
        {
            string k = HttpContext.Session.GetString("flag");

            treelist tre = new treelist();
            treeContext treeCon = new treeContext();
            string uid = HttpContext.Session.GetString("UserId");
            tre = treeCon.treeSee(uid, connectionString);
            Random r = new Random();
            int otp = r.Next(11111, 99999);
            string o = Convert.ToString(otp);
            HttpContext.Session.SetString("otp", o);
            string templateid = "1207169502437973133";
            connect sms = new connect();
            sms.SendSMS(tre.mobile, "Dear " + tre.name + ", Your OTP is " + otp + ". Team  kbc40", templateid, "OTP");
            TempData["otp"] = otp;



            return Json("ok");
        }

        public IActionResult incomeWallet(string id)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.incomesee(uid, id, connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult community()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                string id = "community income";
                income incoO = new income();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                incoO = dcO.incomesee(uid, id, connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }


        public IActionResult greentogreen()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                ViewBag.sms = uid;
                ViewBag.tmt = TempData["tp1"];
                incoO = dcO.greenwalletsee(uid, connectionString);
                return View(incoO);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult greentogreen(float ramount, float amount, string useridgreen, string otp, string wallet)
        {
            string transpassword = HttpContext.Session.GetString("passwordtrans");
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                incomeModel incoO = new incomeModel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                string otps = HttpContext.Session.GetString("otp");
                if (transpassword == otp)
                {
                    incoO = dcO.greenfundReqin(amount, useridgreen, uid, wallet, connectionString);
                    TempData["tp1"] = "Main to Main Transfer";
                }
                else
                {
                    TempData["tp1"] = "Transaction Password not Match";
                }
                incoO = dcO.greenwalletsee(uid, connectionString);
                return View(incoO);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult bank()
        {

            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                kyccontext logoc = new kyccontext();
                kycmodel logo = new kycmodel();
                string uid = HttpContext.Session.GetString("UserId");
                logo = logoc.userkycupdatesee(uid, connectionString);
                ViewBag.error = TempData["asdfg"];
                return View(logo);
            }
            else
            {
                return RedirectToAction("Login", "home");
            }
        }
        [HttpPost]
        public async Task<JsonResult> accountverify(string accountno, string ifsc)

        {
            kyccontext logoc = new kyccontext();
            kycmodel logo = new kycmodel();
            logo.accountno = accountno;
            logo.ifsc = ifsc;


            string vid = HttpContext.Session.GetString("UserId");
            {

                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, "https://payout-api.cashfree.com/payout/v1/authorize");
                request.Headers.Add("X-Cf-Signature", "sdf1234er");
                request.Headers.Add("X-Client-Secret", "cfsk_ma_prod_f01e02fa50d1adceb036a819463f5233_a1a7a1d4");
                request.Headers.Add("X-Client-Id", "CF458961CP2QF5PRDGT6F8SHAR90");
                request.Headers.Add("accept", "application/json");
                var response = await client.SendAsync(request);
                string responseBody = await response.Content.ReadAsStringAsync();
                response.EnsureSuccessStatusCode();
                btoken resp = JsonConvert.DeserializeObject<btoken>(responseBody);
                logo.token = resp.data.token;
                //Console.WriteLine(await response.Content.ReadAsStringAsync());
            }
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, "https://payout-api.cashfree.com/payout/v1.2/validation/bankDetails?bankAccount=" + accountno + "&ifsc=" + ifsc + "");
                //request.Headers.Add("Authorization", logo.token);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", logo.token);

                request.Headers.Add("accept", "application/json");
                var content = new StringContent(string.Empty);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                request.Content = content;
                var response = await client.SendAsync(request);

                string responseBody = await response.Content.ReadAsStringAsync();
                bankveri resp = JsonConvert.DeserializeObject<bankveri>(responseBody);
                logo.TStatus = resp.message;

                response.EnsureSuccessStatusCode();
                if (resp.message != "Bank Account details verified successfully")
                {
                    TempData["asdfg"] = "Invaild Account number / ifsc code";
                    return Json(resp);
                }

                return Json(resp);
                // Console.WriteLine(await response.Content.ReadAsStringAsync());

            }




        }

        public async Task<JsonResult> pancardverify(IFormFile file1)

        {
            kyccontext logoc = new kyccontext();
            kycmodel logo = new kycmodel();

            string vid = HttpContext.Session.GetString("UserId");
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
            pan p = new pan();
            // Get your IFormFile from the form submission or other source
            string originalFileName = file1.FileName;
            panmod di = new panmod();
            di = await p.CheckAsync(file1, originalFileName, vid);
            //if (di.message != "PAN card is valid")
            //{
            //    TempData["asdfg"] = "Invaild pan Card";
            //    return RedirectToAction("bank");
            //}

            return Json(di);

        }

        public async Task<JsonResult> adhaarcardverify(IFormFile file2, IFormFile file3)

        {
            kyccontext logoc = new kyccontext();
            kycmodel logo = new kycmodel();

            string vid = HttpContext.Session.GetString("UserId");
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


            aadhar ad = new aadhar();
            string frontImageFileName = file2.FileName;
            string backImageFileName = file3.FileName;
            adharv av = new adharv();
            av = await ad.adCheckAsync(file2, frontImageFileName, file3, backImageFileName, vid);
            if (av.message != "Aadhaar card is valid")
            {
                TempData["asdfg"] = "Invaild Aadhaar Card";
                return Json(av);
            }

            return Json(av);

        }



        [HttpPost]
        public async Task<IActionResult> bank(string accountno, string ifsc, string bankname, string Payment, string branch, string city, IFormFile files, IFormFile file1,
            string adharnumber, string state, string pannumbr, string AccountHolderName, IFormFile file2, IFormFile file3)
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
            string vid = HttpContext.Session.GetString("UserId");
           
           

            string uniqueFileName = null;
            if (files != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "upload");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + files.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    files.CopyTo(fileStream);
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

            
           
            string uid = HttpContext.Session.GetString("UserId");
            string mobile = HttpContext.Session.GetString("mobile");
            string email = HttpContext.Session.GetString("email");
            using (var httpClient = new HttpClient())
            {
                notess s = new notess();
                s.notes_key_1 = "sdgf";
                s.notes_key_2 = "sdgfg";

                Rootmodel t = new Rootmodel();
                t.name = AccountHolderName;
                t.contact = mobile;
                t.email = email;
                t.type = "employee";
                t.reference_id = uid;
                t.notes = s;
                //new HttpMethod("POST")
                using (var request = new HttpRequestMessage(new System.Net.Http.HttpMethod("POST"), "https://api.razorpay.com/v1/contacts"))
                {
                    var plainTextBytes = Encoding.UTF8.GetBytes($"rzp_live_O96Ipb4p8jkPIm:611iQixODk8O9EkzjJ68z07h");
                    var basicAuthKey = Convert.ToBase64String(plainTextBytes);

                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {basicAuthKey}");

                    string jsonData = JsonConvert.SerializeObject(t);
                    request.Content = new StringContent(jsonData);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                    string jsonResp = await response.Content.ReadAsStringAsync();
                    Rootsmodel resp = JsonConvert.DeserializeObject<Rootsmodel>(jsonResp);
                    logo.contactid = resp.id;

                }
            }

            using (var httpClient = new HttpClient())
            {
                BankAccount s = new BankAccount();
                s.name = AccountHolderName;
                s.ifsc = ifsc; 
                s.account_number = accountno;
                bank t = new bank();
                t.contact_id = logo.contactid;
                t.account_type = "bank_account";

                t.bank_account = s;

                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://api.razorpay.com/v1/fund_accounts"))
                {
                    var plainTextBytes = Encoding.UTF8.GetBytes($"rzp_live_O96Ipb4p8jkPIm:611iQixODk8O9EkzjJ68z07h");
                    var basicAuthKey = Convert.ToBase64String(plainTextBytes);

                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {basicAuthKey}");

                    string jsonData = JsonConvert.SerializeObject(t);
                    request.Content = new StringContent(jsonData);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                    string jsonResp = await response.Content.ReadAsStringAsync();
                    fbank resp = JsonConvert.DeserializeObject<fbank>(jsonResp);
                    logo.faccount = resp.id;
                   
                }
            }

            logoc.bankin(uid, logo, connectionString);
            TempData["asdfg"] = "Your bank inforemation has been update";
            return RedirectToAction("bank", "User");
        }
        public IActionResult register()
        {
            
            adminlogin m1 = new adminlogin();
            modlogin mq = new modlogin();
            string k = HttpContext.Session.GetString("flag").ToString();
            string parentid = HttpContext.Request.Query["id"].ToString();
            string Leg = HttpContext.Request.Query["L"];
            if (k == "1")
            {
                string uid = HttpContext.Session.GetString("UserId");

                mq = m1.username(uid, connectionString);
                mq.parentid = parentid;
                mq.Leg = Leg;
            }
            else
            {
                return RedirectToAction("Login", "home");
            }
            ViewBag.colour = TempData["button"];
            return View(mq);
        }
        [HttpPost]
        public IActionResult register(string name, string email, string address, string Sponsorid,
            string city, string password, string Mobile, string Transpassword, string Leg, string ConfirmPassword, string parentid, string coupon,string plan)
        {
            modlogin regmodel = new modlogin();
            regmodel.name = name;
            regmodel.emailaddress = email;
            regmodel.address = address;
            regmodel.Sponsorid = Sponsorid;
            regmodel.city = city;
            regmodel.password = password;
            regmodel.Mobile = Mobile;
            regmodel.Transpassword = Transpassword;
            regmodel.Leg = Leg;
            regmodel.parentid = parentid;
            regmodel.ConfirmPassword = password;
            regmodel.coupon = coupon;
            regmodel.plan = plan;
            adminlogin regisO = new adminlogin();
            modlogin ml = new modlogin();
            ml = regisO.data(regmodel, connectionString);
            TempData["tp1"] = ml.userid;
            TempData["tp2"] = password;
            TempData["tp3"] = name;
            TempData["tp5"] = Mobile;
            connect sms = new connect();
            //string templateid = "1207161847338398965";
            string templateid = "1207169502993389819";
            //sms.SendSMS(Mobile, "Dear " + name + ", Welcome to KBC40 Your account has been created successfully.Your Login Id is: " + ml.userid + " and Password: -" + password + ".Thanks Team kbc40", templateid,"TXN");
            sms.SendSMS(Mobile, "Dear " + name + ", Welcome to KBC40 Your account has been created successfully.Your Login Id is: " + ml.userid + " and Password: -" + password + ".Login at https://kbc40.com/home/login Thanks Team KBC40", templateid, "TXN");

            return RedirectToAction("registerSee", "Home");
        }

        //public IActionResult Treejoing(string id)
        //{
        //    treelist tre = new treelist();
        //    treeContext treeCon = new treeContext();
        //    string uid;
        //    if (Request.Query.Count > 0)
        //    {
        //        uid = Request.Query["id"].ToString();

        //    }
        //    else
        //    {
        //        uid = HttpContext.Session.GetString("UserId");
        //    }
        //    if (id==null)
        //    {
        //        tre = treeCon.treeSee(uid, connectionString);
        //    }
        //   else
        //    { 
        //        tre = treeCon.treeSee(id, connectionString); 
        //    }                   
        //    return View(tre);

        //}

        public IActionResult test()
        {

            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {

                return View();
            }
            else
            {
                return RedirectToAction("Login", "home");
            }
        }
        [HttpPost]

        public async Task<JsonResult> tests()
        {
            kyccontext logoc = new kyccontext();
            kycmodel logo = new kycmodel();

            using var httpClient = new HttpClient();

            var requestUrl = "https://payout-api.cashfree.com/payout/v1/authorize";
            var formData = Uri.EscapeDataString("{\"X-client-Id\":\"CF458961CKP421JOQGPIVESTHNEG\",\"X-client-Secret\":\"e528f21caf309dfcfca3e0e89d73af6da40224dc\"}");

            var content = new StringContent(formData, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(requestUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStreamAsync();

                // Deserialize the JSON response into an appropriate object
                // var jsonResponse = await JsonSerializer.DeserializeAsync<Roots>(responseStream);
                var jsonResponse = await System.Text.Json.JsonSerializer.DeserializeAsync<Root>(responseStream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });




                return Json("");

            }

            return Json("logo");
        }
        public IActionResult Newuserlist()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                string uid = HttpContext.Session.GetString("UserId");
                userlistContext duct = new userlistContext();
                user ip = new user();
                ip = duct.userlistseess(uid, connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("login", "home");
            }
        }
        public IActionResult Treejoing()
        {
            string n = HttpContext.Request.Query["id"].ToString();
            string uid;
            string sid = HttpContext.Session.GetString("UserId");
            string status;
            if (n != "")
            {
                uid = n;
                status = "0";
            }
            else
            {
                uid = HttpContext.Session.GetString("UserId");
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

            //----------



            ViewBag.name1 = t.name1id;
            ViewBag.name2 = t.name2id;
            ViewBag.name3 = t.name3id;
            ViewBag.name4 = t.name4id;
            ViewBag.name5 = t.name5id;
            ViewBag.name6 = t.name6id;
            ViewBag.name7 = t.name7id;
            ViewBag.name8 = t.name8id;
            ViewBag.name9 = t.name9id;
            ViewBag.name10 = t.name10id;
            ViewBag.name11 = t.name11id;
            ViewBag.name12 = t.name12id;
            ViewBag.name13 = t.name13id;
            ViewBag.name14 = t.name14id;
            ViewBag.name15 = t.name15id;
            return View(t);
        }


        public IActionResult visitingcard_and_id()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                userlistModel ip = new userlistModel();
                string uid = HttpContext.Session.GetString("UserId");
                ip = duct.userprofilesee(uid, connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult receipt()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                userlistModel ip = new userlistModel();
                string uid = HttpContext.Session.GetString("UserId");
                ip = duct.userprofilesee(uid, connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult couponwallet()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                userlistContext duct = new userlistContext();
                couponlist ip = new couponlist();
                string uid = HttpContext.Session.GetString("UserId");
                ip = duct.couponsee(uid, connectionString);
                return View(ip);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult couponTransfer(string couponid, string userid)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {

                couponwallet ip = new couponwallet();
                ip.couponid = couponid;
                ip.userid = userid;

                return View(ip);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult UpdateTransfer(string couponid, string byuserid)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                string uid = HttpContext.Session.GetString("UserId");
                couponwallet ip = new couponwallet();
                userlistContext duct = new userlistContext();
                duct.updatecoupon(couponid, byuserid, uid, connectionString);

                return RedirectToAction("couponwallet");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }


        public IActionResult level()
        {
            string k = HttpContext.Session.GetString("flag");
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
        public IActionResult level(string id)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                Downline dowm = new Downline();
                downlinedata dcO = new downlinedata();
                string uid = HttpContext.Session.GetString("UserId");
                dowm = dcO.levelsee(uid,id, connectionString);
                return View(dowm);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult shop()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {

               
                ShopKeeperContext logoc = new ShopKeeperContext();
                ProductAddModelList ListObj = new ProductAddModelList();
                ListObj = logoc.ListData(connectionString);
                return View(ListObj);
            }
            else
            {
                return RedirectToAction("login", "home");
            }
        }

        [HttpPost]
        public JsonResult card(string id)
        {
            
                string uid = HttpContext.Session.GetString("UserId");
                couponwallet ip = new couponwallet();
                userlistContext duct = new userlistContext();
                duct.addcard(id, uid, connectionString);

                return Json("");
            
           
        }
        public IActionResult cardlist()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {

                string uid = HttpContext.Session.GetString("UserId");
                ShopKeeperContext logoc = new ShopKeeperContext();
                ProductAddModelList ListObj = new ProductAddModelList();
                ListObj = logoc.cardlist(uid,connectionString);
                return View(ListObj);
            }
            else
            {
                return RedirectToAction("login", "home");
            }
        }

        [HttpPost]
        public IActionResult delcard(string id)
        {

            string uid = HttpContext.Session.GetString("UserId");
            couponwallet ip = new couponwallet();
            userlistContext duct = new userlistContext();
            duct.delcard(id, uid, connectionString);

            return RedirectToAction("cardlist");


        }

        [HttpPost]
        public JsonResult Buy(string products,string finalTotal)
        {
            string message = "";
            string uid = HttpContext.Session.GetString("UserId");
            ShopKeeperContext logoc = new ShopKeeperContext();

            message=logoc.buypro(uid, products,finalTotal, connectionString);
            return Json(message);
        }

        public IActionResult Orderlist()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {

                string uid = HttpContext.Session.GetString("UserId");
                ShopKeeperContext logoc = new ShopKeeperContext();
                ProductAddModelList ListObj = new ProductAddModelList();
                ListObj = logoc.orderlists(uid,connectionString);
                return View(ListObj);
            }
            else
            {
                return RedirectToAction("login", "home");
            }
        }

        public IActionResult Allorderlist(string id)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {


                ShopKeeperContext logoc = new ShopKeeperContext();
                ProductAddModelList ListObj = new ProductAddModelList();
                ListObj = logoc.allorderlists(id, connectionString);
                return View(ListObj);
            }
            else
            {
                return RedirectToAction("login", "home");
            }
        }

        public JsonResult findaddress()
        {
            

                string uid = HttpContext.Session.GetString("UserId");
            userlistModel u = new userlistModel ();
            userlistContext co = new userlistContext();
            u = co.findadress(uid, connectionString);
                return Json(u);
            
           
        }

        public JsonResult updateaddress(string city,string address,string pin,string state)
        {
            string uid = HttpContext.Session.GetString("UserId");
            userlistModel u = new userlistModel();
            u.City = city;
            u.state = state;
            u.address = address;
            u.pin = pin;
            userlistContext co = new userlistContext();
             co.updateaddress(uid,u, connectionString);
            return Json(u);
        }

        public IActionResult Couponlist()
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                IncomeWallet d = new IncomeWallet();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                d = dcO.userwonlist(uid, connectionString);
                return View(d);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult Coupon(string id)
        {
            string k = HttpContext.Session.GetString("flag");
            if (k == "1")
            {
                walletmodel d = new walletmodel();
                incomewalletContext dcO = new incomewalletContext();
                string uid = HttpContext.Session.GetString("UserId");
                d = dcO.userwonlists(id, connectionString);
                HttpContext.Session.SetString("couponid", d.couponid);
                return View(d);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

    }
}
