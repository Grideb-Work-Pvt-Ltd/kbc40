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
using System.Security.Cryptography;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text.Json;

//using forex.Services;

namespace forex.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        readonly string connectionString = @"Data Source=68.178.203.9;Initial Catalog=KBC40New;User ID=sa;Password=gri12DEB!@;";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            userlistContext duct = new userlistContext();
            user ip = new user ();
            ip = duct.views(connectionString);
            return View(ip);
            
        }
        public IActionResult logout()

        {
            HttpContext.Session.SetString("flag", "0");


            return RedirectToAction("login", "home");

        }

        public IActionResult login()
        {
            userlistContext duct = new userlistContext();
            user ip = new user();
            ip = duct.views(connectionString);
            ViewBag.error= TempData["tp2"];
            return View(ip);

        }

        [HttpPost]
        public IActionResult login(string userid, string password)
        {
            modlogin logmodel = new modlogin();
            adminlogin logco = new adminlogin();
            logmodel.userid = userid;
            logmodel.password = password;
            logmodel = logco.userexpertfun(logmodel, connectionString);
            if (logmodel.result == "1")
            {
                HttpContext.Session.SetString("UserId", logmodel.userid);
                HttpContext.Session.SetString("mobile", logmodel.Mobile);
                HttpContext.Session.SetString("email", logmodel.emailaddress);
                HttpContext.Session.SetString("name", logmodel.name);
                HttpContext.Session.SetString("photo", logmodel.photo);
                HttpContext.Session.SetString("flag", "1");
                return RedirectToAction("Dashboard", "User");
            }
            else
            {
                TempData["tp2"]  = "Invalid Account";
                return RedirectToAction("login");
            }

        }

        public IActionResult register(string id)
        {
            if (id is not null)
            {
                adminlogin m1 = new adminlogin();
                modlogin mq = new modlogin();
                mq = m1.username(id, connectionString);
                ViewBag.sid = id;
                ViewBag.sname = mq.name;
                ViewBag.status = mq.status;
                return View(mq);
            }
            adminlogin m2 = new adminlogin();
            modlogin mqj = new modlogin();
            mqj = m2.usernames(id, connectionString);
            return View(mqj);
        }

       

        public IActionResult identity(string id)
        {
            if (id is not null)
            {
                adminlogin m1 = new adminlogin();
                modlogin mq = new modlogin();
                mq = m1.username(id, connectionString);
                ViewBag.sid = id;
                ViewBag.sname = mq.name;
                ViewBag.status = mq.status;
                ViewBag.rank = mq.rank;
                ViewBag.result = mq.result;
                ViewBag.img = mq.photo;
            }
            
            return View();
        }
        [HttpPost]
        public IActionResult register(string name, string email, string address, string Sponsorid,
            string city, string password, string Mobile, string Transpassword, string Leg,string ConfirmPassword,string plan)
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
            regmodel.plan = plan;
            regmodel.ConfirmPassword = password;
            adminlogin regisO = new adminlogin();
            modlogin ml = new modlogin();
            ml = regisO.datas(regmodel, connectionString);

            HttpContext.Session.SetString("price",ml.plan);
            HttpContext.Session.SetString("orderid", ml.userid);
           // HttpContext.Session.SetString("flag", "2");
            HttpContext.Session.SetString("password", ml.password);
            HttpContext.Session.SetString("mobile", Mobile);
            HttpContext.Session.SetString("name",name);
            
            return RedirectToAction("GeneratePaymentLink", "Home");
        }







    

        public IActionResult payment()
        {
             
                return View();

           
        }


        // POST: /Home/GeneratePaymentLink
        
        public async Task<IActionResult> GeneratePaymentLink(VerifyRequestModel phonePePayment)

        {
            string tid = HttpContext.Session.GetString("orderid");
            string amount = HttpContext.Session.GetString("price");
           
            string mob = HttpContext.Session.GetString("mobile");
           // string saltKey = "099eb0cd-02cf-4e2a-8aca-3e6c6aff0399";
            string saltKey = "0870c0b5-21ec-44f7-b08c-67a1b00a63b3";
            int saltIndex = 1;
           // string jsonPayloads = "{\n  \"merchantId\": \"PGTESTPAYUAT\",\n  \"merchantTransactionId\": \"" + tid + "\",\n  \"merchantUserId\": \"" + tid + "\",\n  \"amount\": " + amount + ",\n  \"redirectUrl\": \"https://localhost:44389/payment\",\n  \"redirectMode\": \"REDIRECT\",\n  \"callbackUrl\": \"https://kbc40.com/\",\n  \"mobileNumber\": \"" + mob+"\",\n  \"paymentInstrument\": {\n    \"type\": \"PAY_PAGE\"\n  }\n}";
            string jsonPayloads = "{\n  \"merchantId\": \"KBC40ONLINE\",\n  \"merchantTransactionId\": \"" + tid + "\",\n  \"merchantUserId\": \"" + tid + "\",\n  \"amount\": " + amount + ",\n  \"redirectUrl\": \"https://kbc40.com/payment\",\n  \"redirectMode\": \"REDIRECT\",\n  \"callbackUrl\": \"https://kbc40.com/\",\n  \"mobileNumber\": \"" + mob+"\",\n  \"paymentInstrument\": {\n    \"type\": \"PAY_PAGE\"\n  }\n}";
           // string jsonPayloads = "{\n  \"merchantId\": \"KBC40ONLINE\",\n  \"merchantTransactionId\": \"" + tid + "\",\n  \"merchantUserId\": \"" + tid + "\",\n  \"amount\": " + amount + ",\n  \"redirectUrl\": \"localhost:44389/payment\",\n  \"redirectMode\": \"REDIRECT\",\n  \"callbackUrl\": \"https://kbc40.com/\",\n  \"mobileNumber\": \"" + mob+"\",\n  \"paymentInstrument\": {\n    \"type\": \"PAY_PAGE\"\n  }\n}";

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
              //  var PhonePeGatewayURL = "https://api-preprod.phonepe.com/apis/pg-sandbox";

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

        [HttpPost]
        public async Task<JsonResult> CheckPaymentStatus(VerifyRequestModel phonePePayment)
        {
           
                string saltKey = "0870c0b5-21ec-44f7-b08c-67a1b00a63b3";
               // string saltKey = "099eb0cd-02cf-4e2a-8aca-3e6c6aff0399";
                phonePePayment.MERCHANTID = "KBC40ONLINE";
               // phonePePayment.MERCHANTID = "PGTESTPAYUAT";
                phonePePayment.TransactionId = HttpContext.Session.GetString("TransactionId");
                string jl = "/pg/v1/status/" + phonePePayment.MERCHANTID + "/" + phonePePayment.TransactionId + saltKey;

                string sha256Hash = BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(jl))).Replace("-", "").ToLower();
                phonePePayment.X_VERIFY = sha256Hash + "###" + 1;
                //var PhonePeGatewayURL = "https://api-preprod.phonepe.com/apis/pg-sandbox";
                var PhonePeGatewayURL = "https://api.phonepe.com/apis/hermes";
                var httpClient = new HttpClient();
                var uri = new Uri($"{PhonePeGatewayURL}/pg/v1/status/{phonePePayment.MERCHANTID}/{phonePePayment.TransactionId}");

                // Add headers
                httpClient.DefaultRequestHeaders.Add("accept", "application/json");
                httpClient.DefaultRequestHeaders.Add("X-VERIFY", phonePePayment.X_VERIFY);
                httpClient.DefaultRequestHeaders.Add("X-MERCHANT-ID", phonePePayment.MERCHANTID);

            // Create JSON request body

            // Send POST request

            // Send POST request
            var response = await httpClient.GetStringAsync(uri);


            // Read and deserialize the response content
            // var responseContent = await response.Content.ReadAsStringAsync();
            JsonDocument jsonDocument = JsonDocument.Parse(response);

            // Get a single value from the JSON document
            JsonElement root = jsonDocument.RootElement;
            if (root.TryGetProperty("data", out JsonElement dataElement) && dataElement.ValueKind == JsonValueKind.Object)
            {
                // Check if "transactionId" property exists within the "data" object
                if (dataElement.TryGetProperty("transactionId", out JsonElement transactionIdElement) && transactionIdElement.ValueKind == JsonValueKind.String)
                {
                    string transactionId = transactionIdElement.GetString();

                    HttpContext.Session.SetString("donations", transactionId);
                }


            }
            if (root.TryGetProperty("message", out JsonElement messageElement) && messageElement.ValueKind == JsonValueKind.String)
            {
                string message = messageElement.GetString();
                return Json(message);
            }

            // Return a response
            return Json(response);



        }
        [HttpPost]
        public JsonResult paymentsuccess()
        {
            string uid = HttpContext.Session.GetString("orderid");
            string id = HttpContext.Session.GetString("donations");
            adminlogin regisO = new adminlogin();
            modlogin mls = new modlogin();
             mls=regisO.paymet(id,uid, connectionString);
            HttpContext.Session.SetString("newuserid", mls.userid);

            return Json(mls);
            //return RedirectToAction("registerSee", "home");
        }


        [HttpPost]
        public IActionResult register1(string name, string email, string address, string Sponsorid,
            string city, string password, string Mobile, string Transpassword, string Leg, string ConfirmPassword)
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
            regmodel.ConfirmPassword = password;
            adminlogin regisO = new adminlogin();
            modlogin ml = new modlogin();
            ml = regisO.datas(regmodel, connectionString);
           
            return View();
        }
        public IActionResult registerSee()
        {
            modlogin ml = new modlogin();
            adminlogin duct = new adminlogin();
            if(TempData["tp1"]==null)
            {
                TempData["tp1"] = HttpContext.Session.GetString("newuserid");
                TempData["tp2"] = HttpContext.Session.GetString("password");
                TempData["tp3"] = HttpContext.Session.GetString("name");
                TempData["tp5"] = HttpContext.Session.GetString("mobile");
            }
            ml.userid = TempData["tp1"].ToString();
            ml.password = TempData["tp2"].ToString();
            ml.name = TempData["tp3"].ToString();
            ml.Mobile = TempData["tp5"].ToString();
            return View(ml);
        }
       
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Privacypolicy()
        {
            return View();
        }
        public IActionResult TermsConditions()
        {
            return View();
        }

        public IActionResult REFUNDCANCELLATIONPOLICY()
        {
            return View();
        }
        public IActionResult Donate()
        {
            return View();
        }
        
       [HttpPost]
        public IActionResult Donate(string name, string email, string mobile, string pan,
           string amount)
        {
            modlogin regmodel = new modlogin();
            regmodel.name = name;
            regmodel.emailaddress = email;
            regmodel.amount = amount;
            regmodel.Mobile = mobile;
            regmodel.pan =pan;
          
            adminlogin regisO = new adminlogin();
            modlogin ml = new modlogin();
            ml = regisO.regdon(regmodel, connectionString);
            HttpContext.Session.SetString("prices", amount);
            HttpContext.Session.SetString("orderids", ml.userid);
            //HttpContext.Session.SetString("flag", "2");  
            HttpContext.Session.SetString("mobiles", mobile);
            HttpContext.Session.SetString("name", name);
           
            return RedirectToAction("payments", "Home");
        }

        public IActionResult payments()
        {         
                return View();
        }


        // POST: /Home/GeneratePaymentLink
        [HttpPost]
        public async Task<JsonResult> GeneratePaymentLinks(VerifyRequestModel phonePePayment)

        {
            string tid = HttpContext.Session.GetString("orderids");
            string amounts = HttpContext.Session.GetString("prices");

            int amont = int.Parse(amounts);
            int amount = amont * 100;
            string mob = HttpContext.Session.GetString("mobiles");
            //string saltKey = "099eb0cd-02cf-4e2a-8aca-3e6c6aff0399";
            string saltKey = "0870c0b5-21ec-44f7-b08c-67a1b00a63b3";
            int saltIndex = 1;
            string jsonPayloads = "{\n  \"merchantId\": \"KBC40ONLINE\",\n  \"merchantTransactionId\": \"" + tid + "\",\n  \"merchantUserId\": \"" + tid + "\",\n  \"amount\": " + amount + ",\n  \"redirectUrl\": \"https://kbc40.com/\",\n  \"redirectMode\": \"REDIRECT\",\n  \"callbackUrl\": \"https://kbc40.com/home/payment\",\n  \"mobileNumber\": \"" + mob + "\",\n  \"paymentInstrument\": {\n    \"type\": \"PAY_PAGE\"\n  }\n}";

            string base64Strings = Convert.ToBase64String(Encoding.UTF8.GetBytes(jsonPayloads));
            string jl = base64Strings + "/pg/v1/pay" + saltKey;

            string sha256Hash = BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(jl))).Replace("-", "").ToLower();
            phonePePayment.X_VERIFY = sha256Hash + "###" + saltIndex;
            phonePePayment.base64 = base64Strings;
            HttpContext.Session.SetString("TransactionIds", tid);
            HttpContext.Session.SetString("X_VERIFYs", phonePePayment.X_VERIFY);


            try
            {

               // var PhonePeGatewayURL = "https://api-preprod.phonepe.com/apis/pg-sandbox";
                var PhonePeGatewayURL = "https://api.phonepe.com/apis/hermes";

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

                // Return a response
                return Json(new { Success = true, Message = "Verification successful", phonepeResponse = responseContent });
            }
            catch (Exception ex)
            {
                // Handle errors and return an error response
                return Json(new { Success = false, Message = "Verification failed", Error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<JsonResult> CheckPaymentStatuss(VerifyRequestModel phonePePayment)
        {
           
               string saltKey = "0870c0b5-21ec-44f7-b08c-67a1b00a63b3";
               // string saltKey = "099eb0cd-02cf-4e2a-8aca-3e6c6aff0399";
                phonePePayment.MERCHANTID = "KBC40ONLINE";
               // phonePePayment.MERCHANTID = "PGTESTPAYUAT";
                phonePePayment.TransactionId = HttpContext.Session.GetString("TransactionIds");
               // phonePePayment.TransactionId = "Don10019";
                string jl = "/pg/v1/status/" + phonePePayment.MERCHANTID + "/" + phonePePayment.TransactionId + saltKey;

                string sha256Hash = BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(jl))).Replace("-", "").ToLower();
                phonePePayment.X_VERIFY = sha256Hash+ "###"+1;
               // var PhonePeGatewayURL = "https://api-preprod.phonepe.com/apis/pg-sandbox";
                var PhonePeGatewayURL = "https://api.phonepe.com/apis/hermes";
                var httpClient = new HttpClient();
                var uri = new Uri($"{PhonePeGatewayURL}/pg/v1/status/{phonePePayment.MERCHANTID}/{phonePePayment.TransactionId}");

                // Add headers
                httpClient.DefaultRequestHeaders.Add("accept", "application/json");
                httpClient.DefaultRequestHeaders.Add("X-VERIFY", phonePePayment.X_VERIFY);
                httpClient.DefaultRequestHeaders.Add("X-MERCHANT-ID", phonePePayment.MERCHANTID);

               

                // Send POST request
                var response = await httpClient.GetStringAsync(uri);
               

                // Read and deserialize the response content
               // var responseContent = await response.Content.ReadAsStringAsync();
                JsonDocument jsonDocument = JsonDocument.Parse(response);

                // Get a single value from the JSON document
                JsonElement root = jsonDocument.RootElement;
            if (root.TryGetProperty("data", out JsonElement dataElement) && dataElement.ValueKind == JsonValueKind.Object)
            {
                // Check if "transactionId" property exists within the "data" object
                if (dataElement.TryGetProperty("transactionId", out JsonElement transactionIdElement) && transactionIdElement.ValueKind == JsonValueKind.String)
                {
                    string transactionId = transactionIdElement.GetString();
                   
                    HttpContext.Session.SetString("donation", transactionId);
                }
               

            }
            if (root.TryGetProperty("message", out JsonElement messageElement) && messageElement.ValueKind == JsonValueKind.String)
            {
                string message = messageElement.GetString();
                return Json(message);
            }

            // Return a response
            return Json(response);
            
            
        }
        [HttpPost]
        public JsonResult paymentsuccesss()
        {
            string uid = HttpContext.Session.GetString("orderids");
            string id = HttpContext.Session.GetString("donation");
            adminlogin regisO = new adminlogin();
            modlogin mls = new modlogin();
            mls = regisO.paymets(id, uid, connectionString);
            return Json(mls);
            //return RedirectToAction("index", "home");
        }


        public IActionResult forgotpassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult forgotpassword(string userid, string password)
        {
            modlogin logmodel = new modlogin();
            modlogin logmod = new modlogin();
            adminlogin logco = new adminlogin();
            logmodel.userid = userid;
            logmodel.password = password;
            logmod = logco.forgot(logmodel, connectionString);
            if (logmod.result == "1")
            {
                connect sms = new connect();
               
                string templateid = "1207169502560524896";
                //sms.SendSMS(Mobile, "Dear " + name + ", Welcome to KBC40 Your account has been created successfully.Your Login Id is: " + ml.userid + " and Password: -" + password + ".Thanks Team kbc40", templateid,"TXN");
                sms.SendSMS(password, "Dear " + logmod.name + ",  Your Password  is " + logmod.password + ",.Team KBC40", templateid, "TXN");


                return RedirectToAction("login", "home");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("forgotpassword");
            }

        }

        public IActionResult shipping()
        {
            return View();
        }

        public IActionResult adminlogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult adminlogin(string userid, string password)
        {
            modlogin logmodel = new modlogin();
            adminlogin logco = new adminlogin();
            logmodel.userid = userid;
            logmodel.password = password;
            string abc = logco.fun(logmodel, connectionString);
            if (abc == "1")
            {
                HttpContext.Session.SetString("UserId", logmodel.userid);
                HttpContext.Session.SetString("Password", logmodel.password);
                HttpContext.Session.SetString("Adminflag", "1");
                return RedirectToAction("Dashboard", "Admin");
            }
            else
            {
                ViewBag.error = "Invalid UserID";
                return View("adminlogin");
            }
        }

        [HttpPost]
        public ActionResult MyAction(string id)
        {

            adminlogin m1 = new adminlogin();
            modlogin mq = new modlogin();
            mq = m1.username(id, connectionString);
            modlogin m = new modlogin()
            {
                name = mq.name,
                status = mq.status,
            };

            return Json(mq);
        }

        [HttpPost]
        public ActionResult MyActions(string id)
        {

            adminlogin m1 = new adminlogin();
            modlogins mq = new modlogins();
            mq = m1.baln(id, connectionString);
           

            return Json(mq);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult test()
        {
            return View();
        }


      

    }
}
