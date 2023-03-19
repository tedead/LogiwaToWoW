using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiwaToWoW
{
    class BillingDetailedReport
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Datum
        {
            public int ID { get; set; }
            public int WarehouseID { get; set; }
            public string WarehouseDescription { get; set; }
            public int DepositorID { get; set; }
            public string DepositorDescription { get; set; }
            public int WarehouseContractID { get; set; }
            public string WarehouseContractDescription { get; set; }
            public int WarehouseContractLineID { get; set; }
            public string WarehouseContractLineDescription { get; set; }
            public List<object> WarehouseContractPeriodsID { get; set; }
            public int WarehouseContractPeriodID { get; set; }
            public string WarehouseContractPeriodDescription { get; set; }
            public string ActivityDate { get; set; }
            public object ActivityDate_Start { get; set; }
            public object ActivityDate_End { get; set; }
            public double CalculatedMetricUnit { get; set; }
            public double CalculatedTotalPrice { get; set; }
            public string ObjectType { get; set; }
            public string ObjectID { get; set; }
            public string PartyReferance { get; set; }
            public object PartyReference { get; set; }
            public string CalculationInfo { get; set; }
            public string Notes { get; set; }
            public bool IsBilled { get; set; }
            public bool IsInvoiceable { get; set; }
            public object IsError { get; set; }
            public double StartQuantity { get; set; }
            public double FinishQuantity { get; set; }
            public double Price { get; set; }
            public int WarehouseContractLinePricingTypeID { get; set; }
            public string WarehouseContractLinePricingTypeCode { get; set; }
            public string WarehouseContractLineReference { get; set; }
            public int PageSize { get; set; }
            public int SelectedPageIndex { get; set; }
            public int PageCount { get; set; }
            public int RecordCount { get; set; }
        }

        public class LAClassInfo
        {
            public object ClassName { get; set; }
            public object PrimaryKey { get; set; }
            public string TypeId { get; set; }
        }

        public class Root
        {
            public LAClassInfo LAClassInfo { get; set; }
            public List<Datum> Data { get; set; }
            public List<object> Errors { get; set; }
            public List<object> Columns { get; set; }
            public bool Success { get; set; }
            public object SuccessMessage { get; set; }
            public object LAClassName { get; set; }
            public DateTime EventPlannedFinishDateTime { get; set; }
            public object EventAssessment { get; set; }
            public int EventuserId { get; set; }
        }


    }
}
