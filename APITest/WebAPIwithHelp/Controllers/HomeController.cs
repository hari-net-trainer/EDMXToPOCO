using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebAPIwithHelp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult CashFlowView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetCashFlow(string fromDate, string toDate)
        {
            var mbObj = MethodBase.GetCurrentMethod();
            var topCols = new JArray();
            var cashInFlow = new JArray();
            try
            {
                var fromDt = DateTime.Today;
                var toDt = DateTime.Today;
                DateTime.TryParse(fromDate, out fromDt);
                DateTime.TryParse(toDate, out toDt);
                topCols.Add("Ledger Line");
                var dateMonDif = ((toDt.Year - fromDt.Year) * 12) + toDt.Month - fromDt.Month;
                for (int i = 0; i <= dateMonDif; i++)
                {
                    var newDt = fromDt.AddMonths(i);
                    var colName = string.Format("{0}-{1}", newDt.ToString("MMM"), newDt.ToString("yy"));
                    topCols.Add(colName);
                }
                topCols.Add("TOTAL");
                var emptyList = new string[7] { "Management Fund", "INFLOW", "TOTAL COLLECTION FOR THE MONTH", "TOTAL INFLOW", "OUT FLOW", "TOTAL OUTFLOW", "SURPLUS/(DEFICIT) FOR THE MONTH/PERIOD" };
                /Service Charge
92,685.99
125,362.80
69,626.34
78,472.61
127,130.02
221,697.38
297,665.42
276,906.51
134,348.48
                foreach (var item in emptyList)
                {
                    var row = new JArray();
                    row.Add(item);
                    for (int i = 0; i <= dateMonDif; i++)
                    {
                        row.Add(string.Empty);
                    }
                    row.Add(string.Empty);
                    cashInFlow.Add(row);
                }
            }
            catch (Exception ex)
            {
                //LogHelper.Error(mbObj, "DGCWebSite", this.LoginUserName, ex);
            }

            var retData = JObject.FromObject(new
            {
                ColNames = topCols,
                Series = cashInFlow
            });

            //var jsonResult = Json(retData.ToString(), JsonRequestBehavior.AllowGet);
            //jsonResult.MaxJsonLength = int.MaxValue;
            //return await Task.FromResult(jsonResult);
            return Json(retData.ToString(), JsonRequestBehavior.AllowGet);
        }
    }
}
