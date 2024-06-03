using System;
using System.Configuration;
using System.Data;
using System.Web;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

/// <summary>
/// Summary description for connect
/// </summary>
public class connect
{
    public connect()
    {
        //
        // TODO: Add constructor logic here
        //
    }


    public void SendSMS(string mobile_Number, string Message, string templateid)
    {
        string text = ConvertStringIntoURLFormat(Message);
        //string mobileno = ConvertSeprateComma(mobile_Number);
        //string strPushURL = "http://sms.smswala.in/app/smsapi/index.php?key=55D3C05F01A2AA&campaign=7945&routeid=100922&type=text&contacts=" + mobile_Number + "&senderid=CFINDI&msg=" + Message ;
        //string strPushURL = "https://api-alerts.kaleyra.com/v4/?api_key=A136c313133b0beef25cb839a709fa477&method=sms&message=" + Message + "&to=" + mobile_Number + "&sender=KBCCOM&format=xml";
        string strPushURL =  "https://api-alerts.kaleyra.com/v4/?api_key=A136c313133b0beef25cb839a709fa477&method=sms&message=" + Message + "&to=" + mobile_Number + "&sender=KBCNWF&entity_id=1201159203329086746&template_id=" + templateid;
        //string strPushURL = "https://api-alerts.kaleyra.com/v4/?api_key=A136c313133b0beef25cb839a709fa477&method=sms&message=" + Message + "&to=" + mobile_Number + "&sender=KBCCOM&entity_id=1207161890032865835&template_id=1201159203329086746";
        //string strPushURL = "https://api-alerts.kaleyra.com/v4/?api_key=%20A136c313133b0beef25cb839a709fa477&method=sms&message=" + Message + "&to=" + mobile_Number + "&sender=KBCCOM&format=xml";
        //string strPushURL = "http://139.162.49.213/api/push?apikey=5a2a7f5a34790&route=transactional&sender=AVALON&mobileno=" + mobile_Number + "&text=" + Message;
        //string strPushURL = "http://106.50.163.45/vendorsms/pushsms.aspx?user=testing1&password=11&msisdn=" + mobile_Number + "&sid=KEPLEA&msg=" + Message + "&fl=0&gwid=2";
        //// string strPushURL = "http://zoopsms.com/api.php?username=goseva&password=pass1234&route=1&sender=GOSEVA&mobile[]=" + mobileno + "&message[]=" + text;
        WebRequest webrequest = WebRequest.Create(strPushURL);
        WebResponse response = webrequest.GetResponse();
        Stream ReceiveStream = response.GetResponseStream();
        StreamReader readStream = new StreamReader(ReceiveStream);
        string strResponse = readStream.ReadToEnd();
        GetResponse(strResponse);
        // return ("sucess");
    }

    public void SendSMS(string mobile_Number, string Message, string templateid, string type)
    {
        string text = ConvertStringIntoURLFormat(Message); 
        string strPushURL= "https://api.in.kaleyra.io/v1/HXIN1696817637IN/messages?api-key=A96ff1cb05899c93ddfed2d51f1013799&to=+91" + mobile_Number + "&sender=KBCNWF&body=" + Message + "&type="+type+"&source=API&templateid=" + templateid;
        WebRequest webrequest = WebRequest.Create(strPushURL);
        WebResponse response = webrequest.GetResponse();
        Stream ReceiveStream = response.GetResponseStream();
        StreamReader readStream = new StreamReader(ReceiveStream);
        string strResponse = readStream.ReadToEnd();
        GetResponse(strResponse);
        // return ("sucess");
    }

    public void SSendSMS(string mobile_Number, string Message, string templateid, string type)
    {
        string text = ConvertStringIntoURLFormat(Message);
        string strPushURL = "https://api.in.kaleyra.io/v1/HXIN1696817637IN/messages?api-key=A496ce07795e216b3a5cf6b003fa14a4f&to=+91" + mobile_Number + "&sender=112340&body=" + Message + "&type=" + type + "&source=API&templateid=" + templateid;
        WebRequest webrequest = WebRequest.Create(strPushURL);
        WebResponse response = webrequest.GetResponse();
        Stream ReceiveStream = response.GetResponseStream();
        StreamReader readStream = new StreamReader(ReceiveStream);
        string strResponse = readStream.ReadToEnd();
        GetResponse(strResponse);
        // return ("sucess");
    }

    public void fmail(string to1, string toname, string subject1, string from1, string fromname, string mailtxt1)
    {
        ////string UrlRequest = "https://sendgrid.com/api/mail.send.json?api_user=eurocointrading&api_key=love1980&to=" + to1 + "&toname=" + toname + "&subject=" + subject1 + "&html=" + mailtxt1 + "&from=" + from1;
        ////string UrlRequest = "https://sendgrid.com/api/mail.send.json?api_user=indiatca&api_key=Abc@123abc&to=" + to1 + "&toname=" + toname + "&subject=" + subject1 + "&html=" + mailtxt1 + "&from=" + from1;
        string UrlRequest = "https://sendgrid.com/api/mail.send.json?api_user=gowmukh1&api_key=arvindkumar1&to=" + to1 + "&toname=" + toname + "&subject=" + subject1 + "&html=" + mailtxt1 + "&from=" + from1;
        Uri url = new Uri(UrlRequest);

        WebRequest request = WebRequest.Create(url);

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
    }



    private string ConvertStringIntoURLFormat(string SenderID)
    {
        string senderid = "";
        string retstring = "";
        char[] s = SenderID.ToCharArray();
        for (int ind = 0; ind < s.Length; ind++)
        {
            if (Convert.ToInt32(s[ind]) == 13)
            {
                senderid = senderid + "\n";
            }
            else
            {
                senderid = senderid + SenderID.Substring(ind, 1);
            }
        }

        retstring = senderid.Replace("%", "%25");
        retstring = retstring.Replace("'", "%60");
        retstring = retstring.Replace("~", "%7E");
        retstring = retstring.Replace("\"", "%22");
        retstring = retstring.Replace("+", "%2B");
        retstring = retstring.Replace("^", "%5E");
        retstring = retstring.Replace("{", "%7B");
        retstring = retstring.Replace("}", "%7D");
        retstring = retstring.Replace(@"\", "%5C");
        retstring = retstring.Replace("|", "%7C");
        retstring = retstring.Replace("[", "%5B");
        retstring = retstring.Replace("]", "%5D");
        retstring = retstring.Replace(",", "%2C");
        retstring = retstring.Replace("`", "%60");
        retstring = retstring.Replace(" ", "%20");
        retstring = retstring.Replace("$", "%24");
        retstring = retstring.Replace("&", "%26");
        retstring = retstring.Replace("@", "%40");
        retstring = retstring.Replace("?", "%3F");
        retstring = retstring.Replace(":", "%3A");
        retstring = retstring.Replace(";", "%3B");
        retstring = retstring.Replace("<", "%3C");
        retstring = retstring.Replace(">", "%3E");
        retstring = retstring.Replace("#", "%23");
        return retstring;
    }

    private string ConvertSeprateComma(string mobile)
    {
        string mobileno = "";
        string[] arrmobile = mobile.Split(',', ' ', '\n');
        for (int i = 0; i < arrmobile.Length; i++)
        {
            mobileno += arrmobile[i] + ",";
        }
        mobileno = mobileno.TrimEnd(',');
        return mobileno;
    }


    private void GetResponse(string strResponse)
    {
        int count = 0;
        // string strResponse = "\nNDNC Number\n<br/>\nNDNC Number\n<br/>Message sent!!!!!Your Transaction Id- 4049969\n<br/>\nNDNC Number\n<br/>\nNDNC Number\n<br/>\r\n\r\n<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n\r\n<html xmlns=\"http://ww...";
        strResponse = strResponse.Replace("\n", "");
        strResponse = strResponse.Replace("<br/>", ",");
        string[] word1 = strResponse.Split(',');

        for (int i = 0; i < word1.Length; i++)
        {
            if (word1[i].ToString() == "NDNC Number")
            {
                count = count + 1;
            }
        }
        strResponse = strResponse.Replace("NDNC Number,", "");
        string[] word = strResponse.Split('\r', '<', ',');
        if (count > 0)
        {
            //lblTransactionId.Text = "" + word[0].ToString() + " NDNC Numbers= " + count + "";
        }
        else
        {
            // lblTransactionId.Text = word[0].ToString();
        }

        //lblTransactionId.Visible = true;
    }

    public string btc(string curr,string value)
    {

        string strPushURL = "https://blockchain.info/tobtc?currency="+curr+"&value=" + value;

        WebRequest webrequest = WebRequest.Create(strPushURL);
        WebResponse response = webrequest.GetResponse();
        Stream ReceiveStream = response.GetResponseStream();
        StreamReader readStream = new StreamReader(ReceiveStream);
        string strResponse = readStream.ReadToEnd();
        GetResponse(strResponse);
        return (strResponse);
    }

    private static Random RNG = new Random();

    public string Create16DigitString()
    {
        var builder = new StringBuilder();
        while (builder.Length < 16)
        {
            builder.Append(RNG.Next(10).ToString());
        }
        return builder.ToString();
    }
    private static HashSet<string> Results = new HashSet<string>();

    public string CreateUnique16DigitString()
    {
        var result = Create16DigitString();
        while (!Results.Add(result))
        {
            result = Create16DigitString();
        }

        return result;
    }

}



public static class WebExtensions
{

    /// <summary>
    /// Selects the item in the list control that contains the specified value, if it exists.
    /// </summary>
    /// <param name="dropDownList"></param>
    /// <param name="selectedValue">The value of the item in the list control to select</param>
    /// <returns>Returns true if the value exists in the list control, false otherwise</returns>
    //public static Boolean SetSelectedValue(this DropDownList dropDownList, String selectedValue)
    //{
    //    ListItem selectedListItem = dropDownList.Items.FindByValue(selectedValue);

    //    if (selectedListItem != null)
    //    {
    //        selectedListItem.Selected = true;
    //        return true;
    //    }
    //    else
    //        return false;
    //}
}