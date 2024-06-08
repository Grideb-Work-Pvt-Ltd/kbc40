﻿using forex.context;
using forex.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace forex.Controllers
{
    public class PaymentController : Controller
    {
        readonly string connectionString = @"Data Source=68.178.203.9;Initial Catalog=KBC40New;User ID=sa;Password=gri12DEB!@;";

       
        public async Task<IActionResult> Index(VerifyRequestModel phonePePayment)
        {

            string saltKey = "0870c0b5-21ec-44f7-b08c-67a1b00a63b3";
           //  string saltKey = "099eb0cd-02cf-4e2a-8aca-3e6c6aff0399";
            phonePePayment.MERCHANTID = "KBC40ONLINE";
           //  phonePePayment.MERCHANTID = "PGTESTPAYUAT";
            phonePePayment.TransactionId = HttpContext.Session.GetString("TransactionId");
            string jl = "/pg/v1/status/" + phonePePayment.MERCHANTID + "/" + phonePePayment.TransactionId + saltKey;

            string sha256Hash = BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(jl))).Replace("-", "").ToLower();
            phonePePayment.X_VERIFY = sha256Hash + "###" + 1;
          //  var PhonePeGatewayURL = "https://api-preprod.phonepe.com/apis/pg-sandbox";
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
                HttpContext.Session.SetString("message", message);
                if (message == "Your payment is successful.")
                {
                    string uid = HttpContext.Session.GetString("orderid");
                    string id = HttpContext.Session.GetString("donations");
                    string Mobile = HttpContext.Session.GetString("mobile");
                    string name = HttpContext.Session.GetString("name");
                    string pass = HttpContext.Session.GetString("password");
                    adminlogin regisO = new adminlogin();
                    modlogin mls = new modlogin();
                    mls = regisO.paymet(id, uid, connectionString);
                    HttpContext.Session.SetString("newuserid", mls.userid);
                    connect sms = new connect();
                    //string templateid = "1207161847338398965";
                    string templateid = "1207169502993389819";
                    //sms.SendSMS(Mobile, "Dear " + name + ", Welcome to KBC40 Your account has been created successfully.Your Login Id is: " + ml.userid + " and Password: -" + password + ".Thanks Team kbc40", templateid,"TXN");
                    sms.SendSMS(Mobile, "Dear " + name + ", Welcome to KBC40 Your account has been created successfully.Your Login Id is: " + mls.userid + " and Password: -" + pass + ".Login at https://kbc40.com/home/login Thanks Team KBC40", templateid, "TXN");



                    return RedirectToAction("registerSee", "Home");
                }

                return Redirect("https://www.kbc40.com");
            }

            // Return a response
            return Redirect("https://www.kbc40.com");




        }
    }
}
