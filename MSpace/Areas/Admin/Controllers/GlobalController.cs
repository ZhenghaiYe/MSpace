using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace MSpace.Areas.Admin.Controllers
{
    public class GlobalController : AdminBaseController
    {
        public ActionResult Footer()
        {
            return View();
        }

        public ActionResult Header()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        /// <summary>
        /// 获取访客公网IP
        /// </summary>
        /// <returns></returns>
        public ActionResult PublicIP()
        {
            string ip = "";
            string strUrl = "http://iframe.ip138.com/ic.asp"; //获得IP的网址了
            //得到数据为：您的IP是：[117.90.82.191] 来自：江苏省镇江市 电信
            Uri uri = new Uri(strUrl);
            System.Net.WebRequest wr = System.Net.WebRequest.Create(uri);
            using (System.IO.Stream s = wr.GetResponse().GetResponseStream())
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(s, Encoding.Default))
                {
                    string all = sr.ReadToEnd(); //读取网站的数据
                    NLog.LogManager.GetCurrentClassLogger().Info(all);
                    int i = all.IndexOf("[") + 1;
                    string tempip = all.Substring(i, 15);
                    ip = tempip.Replace("]", "").Replace(" ", "");//找出i
                }
            }

            return Content("您的IP:" + ip);
        }

        /// <summary>
        /// 获取访客IP所处位置天气信息
        /// </summary>
        /// <returns></returns>
        public ActionResult Weather()
        {
            

            //HttpWebRequest wNetr = (HttpWebRequest)HttpWebRequest.Create("http://61.4.185.48:81/g/");
            //HttpWebResponse wNetp = (HttpWebResponse)wNetr.GetResponse();
            //wNetr.ContentType = "text/html";
            //wNetr.Method = "Get";
            //Stream Streams = wNetp.GetResponseStream();
            //StreamReader Reads = new StreamReader(Streams, Encoding.UTF8);
            //String ReCode = Reads.ReadToEnd();
            ////关闭暂时不适用的资源
            //Reads.Dispose();
            //Streams.Dispose();
            //wNetp.Close();
            ////分析返回代码
            //String[] Temp = ReCode.Split(';');
            //string cityCode = Temp[1].Replace("var id=", "");

            //string wUrl = string.Format("http://m.weather.com.cn/data/{0}.html", cityCode);
            //HttpWebRequest wNetr2 = (HttpWebRequest)HttpWebRequest.Create(wUrl);
            //HttpWebResponse wNetp2 = (HttpWebResponse)wNetr.GetResponse();
            //wNetr2.ContentType = "text/html";
            //wNetr2.Method = "Get";
            //Stream Streams2 = wNetp.GetResponseStream();
            //StreamReader Reads2 = new StreamReader(Streams2, Encoding.UTF8);
            //String ReCode2 = Reads.ReadToEnd();
            ////关闭暂时不适用的资源
            //Reads2.Dispose();
            //Streams2.Dispose();
            //wNetp2.Close();
            ////分析返回代码
            //String[] Splits = new String[] { "\"", ",", "\"" };
            //String[] Temp2 = ReCode.Split(Splits, StringSplitOptions.RemoveEmptyEntries);
            //ReCode2 = String.Format("天气:{0} {1} {2}", Temp[5], Temp[62], Temp[26]);

            //return Content(ReCode2);
            string City = "丹阳";
            string Html = "";       //返回来天气预报源码
            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = string.Format("city=" + City);
            byte[] data = encoding.GetBytes(postData);
            string weather = string.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://php.weather.sina.com.cn/search.php?city=" + System.Web.HttpContext.Current.Server.UrlEncode(City) + "&f=1&dpc=1");
                request.Method = "Get";
                request.ContentType = "application/x-www-form-urlencoded ";
                WebResponse response = request.GetResponse();
                Stream s = response.GetResponseStream();
                StreamReader sr = new StreamReader(s, System.Text.Encoding.GetEncoding("GB2312"));
                Html = sr.ReadToEnd();
                s.Close();
                sr.Close();
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            //去除多余代码提高效率
            int count = Html.Length;
            int starIndex = Html.IndexOf("<li class=\"li_04\">", 0, count);
            int endIndex = Html.IndexOf("</li>", starIndex);
            Html = Html.Substring(starIndex, endIndex - starIndex);
            NLog.LogManager.GetCurrentClassLogger().Debug(Html);
            try
            {
                #region 得到天气
                int WeatherStartIndex = Html.IndexOf(City + "今日", 0);
                int WeatherEndIndex = Html.IndexOf("');", 0);
                weather = Html.Substring(WeatherStartIndex, WeatherEndIndex - WeatherStartIndex);
                #endregion
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            return Content(weather);

        }

    }
}
