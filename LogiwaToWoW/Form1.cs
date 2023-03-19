using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using ChoETL;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogiwaToWoW
{
    public partial class Form1 : Form
    {
        string dbConnectionString = string.Empty;
        string listOrderAPI = string.Empty;
        string getTokenAPI = string.Empty;
        string contractBillingReportAPI = string.Empty;
        string transactionHistoryAPI = string.Empty;
        string body = string.Empty;
        string authorization = string.Empty;
        string grant_type = string.Empty;
        string username = string.Empty;
        string password = string.Empty;

        //Process page indexes backwards
        bool processBackwards = true;

        #region Form1
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbConnectionString = System.Configuration.ConfigurationManager.AppSettings.Get("ConnectionString");
            listOrderAPI = System.Configuration.ConfigurationManager.AppSettings.Get("ListOrderAPI");
            getTokenAPI = System.Configuration.ConfigurationManager.AppSettings.Get("GetTokenAPI");
            contractBillingReportAPI = System.Configuration.ConfigurationManager.AppSettings.Get("ContractBillingReportAPI");
            transactionHistoryAPI = System.Configuration.ConfigurationManager.AppSettings.Get("TransactionHistoryAPI");
            body = System.Configuration.ConfigurationManager.AppSettings.Get("Body");
            authorization = System.Configuration.ConfigurationManager.AppSettings.Get("Authorization");
            grant_type = System.Configuration.ConfigurationManager.AppSettings.Get("grant_type");
            username = System.Configuration.ConfigurationManager.AppSettings.Get("username");
            password = System.Configuration.ConfigurationManager.AppSettings.Get("password");

            //txtConnectionString.Text = dbConnectionString;
            ////txtAPI.Text = api;
            //txtBody.Text = body;
            //txtAuthorization.Text = authorization;
            //txtGrant_Type.Text = grant_type;
            //txtUsername.Text = username;
            //txtPassword.Text = password;

            lstTransactionHistoryStart.Items.Add("01.01.2021 00:00:00");
            lstTransactionHistoryEnd.Items.Add("03.31.2021 23:59:59");

            //lstTransactionHistoryStart.Items.Add("04.01.2021 00:00:00");
            //lstTransactionHistoryEnd.Items.Add("06.30.2021 23:59:59");

            //lstTransactionHistoryStart.Items.Add("07.01.2021 00:00:00");
            //lstTransactionHistoryEnd.Items.Add("09.30.2021 23:59:59");

            //lstTransactionHistoryStart.Items.Add("10.01.2021 00:00:00");
            //lstTransactionHistoryEnd.Items.Add("12.31.2021 23:59:59");

            //lstTransactionHistoryStart.Items.Add("01.01.2022 00:00:00");
            //lstTransactionHistoryEnd.Items.Add("03.31.2022 23:59:59");

            //lstTransactionHistoryStart.Items.Add("04.01.2022 00:00:00");
            //lstTransactionHistoryEnd.Items.Add("06.30.2022 23:59:59");

            //lstTransactionHistoryStart.Items.Add("07.01.2022 00:00:00");
            //lstTransactionHistoryEnd.Items.Add("09.30.2022 23:59:59");

            //lstTransactionHistoryStart.Items.Add("10.01.2022 00:00:00");
            //lstTransactionHistoryEnd.Items.Add("12.31.2022 23:59:59");

            //lstTransactionHistoryStart.Items.Add("01.01.2023 00:00:00");
            //lstTransactionHistoryEnd.Items.Add("03.01.2023 23:59:59");

            cmbAPIToCall.Items.Add("Contract Billing Report");
            cmbAPIToCall.Items.Add("Transaction History");
            cmbAPIToCall.Items.Add("List Orders");
            cmbAPIToCall.Items.Add("Get New Token");
            cmbAPIToCall.SelectedIndex = 2;

            lstContractPeriod.Items.Add("Jan 1 2021 / Feb 1 2021");
            lstContractPeriod.Items.Add("Feb 1 2021 / Mar 1 2021");
            lstContractPeriod.Items.Add("Mar 1 2021 / Apr 1 2021");
            lstContractPeriod.Items.Add("Apr 1 2021 / May 1 2021");
            lstContractPeriod.Items.Add("May 1 2021 / Jun 1 2021");
            lstContractPeriod.Items.Add("Jun 1 2021 / Jul 1 2021");
            lstContractPeriod.Items.Add("Jul 1 2021 / Aug 1 2021");
            lstContractPeriod.Items.Add("Aug 1 2021 / Sep 1 2021");
            lstContractPeriod.Items.Add("Sep 1 2021 / Oct 1 2021");
            lstContractPeriod.Items.Add("Oct 1 2021 / Nov 1 2021");
            lstContractPeriod.Items.Add("Nov 1 2021 / Dec 1 2021");
            lstContractPeriod.Items.Add("Dec 1 2021 / Jan 1 2022");
            lstContractPeriod.Items.Add("Jan 1 2022 / Feb 1 2022");
            lstContractPeriod.Items.Add("Feb 1 2022 / Mar 1 2022");
            lstContractPeriod.Items.Add("Mar 1 2022 / Apr 1 2022");
            lstContractPeriod.Items.Add("Apr 1 2022 / May 1 2022");
            lstContractPeriod.Items.Add("May 1 2022 / Jun 1 2022");
            lstContractPeriod.Items.Add("Jun 1 2022 / Jul 1 2022");
            lstContractPeriod.Items.Add("Jul 1 2022 / Aug 1 2022");
            lstContractPeriod.Items.Add("Aug 1 2022 / Sep 1 2022");
            lstContractPeriod.Items.Add("Sep 1 2022 / Oct 1 2022");
            lstContractPeriod.Items.Add("Oct 1 2022 / Nov 1 2022");
            lstContractPeriod.Items.Add("Nov 1 2022 / Dec 1 2022");
            lstContractPeriod.Items.Add("Dec 1 2022 / Jan 1 2023");
            lstContractPeriod.Items.Add("Jan 1 2023 / Feb 1 2023");
            lstContractPeriod.Items.Add("Feb 1 2023 / Mar 1 2023");

            lstContract.Items.Add("Spectrum - Base Contract");
            lstContract.Items.Add("DNA Kit -Base Contract");
            lstContract.Items.Add("Avellino Contract");
            lstContract.Items.Add("Purlab Contract");
            lstContract.Items.Add("AxGen Contract");
            lstContract.Items.Add("Base10 Contract");
            lstContract.Items.Add("BioViva Contract");
            lstContract.Items.Add("Borboleta Contract");
            lstContract.Items.Add("Cell Vault Contract");
            lstContract.Items.Add("Dante Contract");
            lstContract.Items.Add("DxTerity Contract");
            lstContract.Items.Add("Gnarly Contract");
            lstContract.Items.Add("Guardant Contract");
            lstContract.Items.Add("IntellxxDNA Contract");
            lstContract.Items.Add("MethylGentics Contract");
            lstContract.Items.Add("Predictive Contract");
            lstContract.Items.Add("The Spa Dr. Contract");
            lstContract.Items.Add("Viome Contract");
            lstContract.Items.Add("Spectrum InternalVault Health Contract");
            lstContract.Items.Add("VITAGENE Contract");
            lstContract.Items.Add("Hims Contract");
            lstContract.Items.Add("EverlyWell Contract");
            lstContract.Items.Add("Remote Health Contract");
            lstContract.Items.Add("ReliantID Contract");
            lstContract.Items.Add("ShareMy.Health Contract");
            lstContract.Items.Add("labpass Contract");
            lstContract.Items.Add("US Drug Test Centers Contract");
            lstContract.Items.Add("K Health Contract");
            lstContract.Items.Add("Essential Genome Contract");
            lstContract.Items.Add("Reliant Health Contract");
            lstContract.Items.Add("IBX - Tiered Contract");
            lstContract.Items.Add("Providence Contract");
            lstContract.Items.Add("AnyPlaceMD Contract");
            lstContract.Items.Add("Wellness4Humanity Contract");
            lstContract.Items.Add("IX Layer");
            lstContract.Items.Add("Genomics");
            lstContract.Items.Add("IxLayer Reference");
            lstContract.Items.Add("Illumina");
            lstContract.Items.Add("Essential Genome");

            lstContract.SelectedIndex = 0;
            lstContractPeriod.SelectedIndex = 0;

            lstTransactionHistoryStart.SelectedIndex = 0;
            lstTransactionHistoryEnd.SelectedIndex = 0;
        }
        #endregion

        #region Methods
        private int ConvertBillingDetailedReportJSONToSQLAndUploadToDatabase(string content)
        {
            //dynamic billingDetailedReport = JObject.Parse(content); //Pull the response (JSON data) into a dynamic object
            int result = 0;

            BillingDetailedReport.Root myDeserializedClass = Newtonsoft.Json.JsonConvert.DeserializeObject<BillingDetailedReport.Root>(content);

            string connectionString = txtConnectionString.Text;
            var db = new SqlDatabase(connectionString);

            foreach (BillingDetailedReport.Datum bdr in myDeserializedClass.Data)
            {
                Task<int> t = new TaskFactory().StartNew(() => InsertBillingDetailedReport(bdr));
                result = t.Result;
            }

            return result;
        }

        private int ConvertListOrdersJSONToSQLAndUploadToDatabase(string content)
        {
            //dynamic billingDetailedReport = JObject.Parse(content); //Pull die response (JSON data) into a dynamic object
            int result = 0;
            string commandText = string.Empty;
            string parameterText = string.Empty;
            ListOrders.Root myDeserializedClass = Newtonsoft.Json.JsonConvert.DeserializeObject<ListOrders.Root>(content);

            string connectionString = txtConnectionString.Text;
            var db = new SqlDatabase(connectionString);

            foreach (ListOrders.Datum datum in myDeserializedClass.Data)
            {
                    if (datum.DetailInfo != null)
                    {
                        foreach (var di in datum.DetailInfo)
                        {
                            try
                            {
                                var dbCmdDI = db.GetStoredProcCommand("WRHS_insListOrders_Details");
                                db.AddInParameter(dbCmdDI, "@ID", DbType.Int32, di.ID);
                                db.AddInParameter(dbCmdDI, "@Code", DbType.String, di.Code);
                                db.AddInParameter(dbCmdDI, "@InventoryItemID", DbType.Int32, di.InventoryItemID);
                                db.AddInParameter(dbCmdDI, "@InventoryItemDescription", DbType.String, di.InventoryItemDescription);
                                db.AddInParameter(dbCmdDI, "@InventoryItemInfo", DbType.String, di.InventoryItemInfo);
                                db.AddInParameter(dbCmdDI, "@Barcode", DbType.String, di.Barcode);
                                db.AddInParameter(dbCmdDI, "@DisplayMember", DbType.String, di.DisplayMember);
                                db.AddInParameter(dbCmdDI, "@InventoryItemPackTypeID", DbType.Int32, di.InventoryItemPackTypeID);
                                db.AddInParameter(dbCmdDI, "@InventoryItemPackTypeDescription", DbType.String, di.InventoryItemPackTypeDescription);
                                db.AddInParameter(dbCmdDI, "@PackQuantity", DbType.Decimal, di.PackQuantity);
                                db.AddInParameter(dbCmdDI, "@WarehouseOrderID", DbType.Int32, di.WarehouseOrderID);
                                db.AddInParameter(dbCmdDI, "@UnitWeight", DbType.Decimal, di.UnitWeight);
                                db.AddInParameter(dbCmdDI, "@UnitVolume", DbType.Decimal, di.UnitVolume);
                                db.AddInParameter(dbCmdDI, "@PACKIIPT_UnitWeight", DbType.Decimal, di.PACKIIPT_UnitWeight);
                                db.AddInParameter(dbCmdDI, "@AllocatedCuQuantity", DbType.Decimal, di.AllocatedCuQuantity);
                                db.AddInParameter(dbCmdDI, "@PickedCuQuantity", DbType.Decimal, di.PickedCuQuantity);
                                db.AddInParameter(dbCmdDI, "@LoadedCuQuantity", DbType.Decimal, di.LoadedCuQuantity);
                                db.AddInParameter(dbCmdDI, "@ShippedCuQuantity", DbType.Decimal, di.ShippedCuQuantity);
                                db.AddInParameter(dbCmdDI, "@PlannedPackQuantity", DbType.Decimal, di.PlannedPackQuantity);
                                db.AddInParameter(dbCmdDI, "@PlannedCuQuantity", DbType.Decimal, di.PlannedCuQuantity);
                                db.AddInParameter(dbCmdDI, "@SortedCUQuantity", DbType.Decimal, di.SortedCUQuantity);
                                db.AddInParameter(dbCmdDI, "@PackedCUQuantity", DbType.Decimal, di.PackedCUQuantity);
                                db.AddInParameter(dbCmdDI, "@CancelledCuQuantity", DbType.Decimal, di.CancelledCuQuantity);
                                db.AddInParameter(dbCmdDI, "@FreeAttr1", DbType.String, di.FreeAttr1);
                                db.AddInParameter(dbCmdDI, "@FreeAttr2", DbType.String, di.FreeAttr2);
                                db.AddInParameter(dbCmdDI, "@FreeAttr3", DbType.String, di.FreeAttr3);
                                db.AddInParameter(dbCmdDI, "@CurrencyPrice", DbType.Decimal, di.CurrencyPrice);
                                db.AddInParameter(dbCmdDI, "@TaxRate", DbType.Decimal, di.TaxRate);
                                db.AddInParameter(dbCmdDI, "@NetCurrencyPrice", DbType.Decimal, di.NetCurrencyPrice);
                                db.AddInParameter(dbCmdDI, "@TotalWeight", DbType.Decimal, di.TotalWeight);
                                db.AddInParameter(dbCmdDI, "@TotalVolume", DbType.Decimal, di.TotalVolume);
                                db.AddInParameter(dbCmdDI, "@LineWeight", DbType.Decimal, di.LineWeight);
                                db.AddInParameter(dbCmdDI, "@SupplierID", DbType.Decimal, di.SupplierID);
                                db.AddInParameter(dbCmdDI, "@SupplierDescription", DbType.String, di.SupplierDescription);
                                db.AddInParameter(dbCmdDI, "@Notes1", DbType.String, di.Notes1);
                                db.AddInParameter(dbCmdDI, "@SalesUnitPrice", DbType.Decimal, di.SalesUnitPrice);
                                db.AddInParameter(dbCmdDI, "@ChannelOrderDetailCode", DbType.String, string.IsNullOrEmpty(di.ChannelOrderDetailCode) ? "" : di.ChannelOrderDetailCode);

                                if (di.Errors.Count > 0)
                                {
                                    db.AddInParameter(dbCmdDI, "@Errors", DbType.String, string.IsNullOrEmpty(di.Errors[0]) ? "" : di.Errors[0]);
                                }
                                else
                                {
                                    db.AddInParameter(dbCmdDI, "@Errors", DbType.String, "");
                                }

                                db.AddInParameter(dbCmdDI, "@Success", DbType.Boolean, di.Success);
                                db.AddInParameter(dbCmdDI, "@SuccessMessage", DbType.String, string.IsNullOrEmpty(di.SuccessMessage) ? "" : di.SuccessMessage);
                                db.AddInParameter(dbCmdDI, "@IsExcelExport", DbType.Boolean, di.IsExcelExport);
                                db.AddInParameter(dbCmdDI, "@PageSize", DbType.Int32, di.PageSize == null ? 0 : di.PageSize);
                                db.AddInParameter(dbCmdDI, "@SelectedPageIndex", DbType.Int32, di.SelectedPageIndex == null ? 0 : di.SelectedPageIndex);
                                db.AddInParameter(dbCmdDI, "@PageCount", DbType.Int32, di.PageCount == null ? 0 : di.PageCount);
                                db.AddInParameter(dbCmdDI, "@RecordCount", DbType.Int32, di.RecordCount == null ? 0 : di.RecordCount);

                                result = db.ExecuteNonQuery(dbCmdDI);
                            }
                            catch(Exception detailError)
                            {
                            lstBadDBInserts.Items.Add("Detail: " + detailError.Message);
                                int a = 0;
                            }
                        }
                    }

                try
                {

                    var dbCmd = db.GetStoredProcCommand("WRHS_insListOrders");
                    db.AddInParameter(dbCmd, "@ID", DbType.Int32, datum.ID);
                    db.AddInParameter(dbCmd, "@Code", DbType.String, datum.Code);
                    db.AddInParameter(dbCmd, "@PriorityID", DbType.String, datum.PriorityID);
                    db.AddInParameter(dbCmd, "@CustomerRefCode", DbType.String, datum.CustomerRefCode);
                    db.AddInParameter(dbCmd, "@DepositorRefCode", DbType.String, datum.DepositorRefCode);
                    db.AddInParameter(dbCmd, "@CustomerOrderNo", DbType.String, datum.CustomerOrderNo);
                    db.AddInParameter(dbCmd, "@DepositorOrderNo", DbType.String, datum.DepositorOrderNo);

                    if (datum.WarehouseOrderStatusID.Count > 0)
                    {
                        db.AddInParameter(dbCmd, "@WarehouseOrderStatusID", DbType.Int32, datum.WarehouseOrderStatusID[0]);
                    }
                    else
                    {
                        db.AddInParameter(dbCmd, "@WarehouseOrderStatusID", DbType.Int32, 0);
                    }
                    db.AddInParameter(dbCmd, "@WarehouseOrderStatusCode", DbType.String, datum.WarehouseOrderStatusCode);
                    db.AddInParameter(dbCmd, "@CustomerID", DbType.Int32, datum.CustomerID);
                    db.AddInParameter(dbCmd, "@CustomerCode", DbType.String, datum.CustomerCode);
                    db.AddInParameter(dbCmd, "@CustomerDescription", DbType.String, datum.CustomerDescription);
                    db.AddInParameter(dbCmd, "@InventorySiteID", DbType.Int32, datum.InventorySiteID);
                    db.AddInParameter(dbCmd, "@InventorySiteCode", DbType.String, datum.InventorySiteCode);
                    db.AddInParameter(dbCmd, "@WarehouseID", DbType.Int32, datum.WarehouseID);
                    db.AddInParameter(dbCmd, "@WarehouseCode", DbType.String, datum.WarehouseCode);
                    db.AddInParameter(dbCmd, "@WarehouseDescription", DbType.String, datum.WarehouseDescription);
                    db.AddInParameter(dbCmd, "@DepositorID", DbType.Int32, datum.DepositorID);
                    db.AddInParameter(dbCmd, "@DepositorCode", DbType.String, datum.DepositorCode);
                    db.AddInParameter(dbCmd, "@DepositorDescription", DbType.String, datum.DepositorDescription);
                    db.AddInParameter(dbCmd, "@IsPrintCarrierLabelPackListAsLabel", DbType.String, datum.IsPrintCarrierLabelPackListAsLabel);
                    db.AddInParameter(dbCmd, "@IsPrintCarrierLabelPackListOnSamePage", DbType.String, datum.IsPrintCarrierLabelPackListOnSamePage);
                    db.AddInParameter(dbCmd, "@CarrierTrackingNumber", DbType.String, datum.CarrierTrackingNumber);
                    db.AddInParameter(dbCmd, "@WarehouseOrderTypeID", DbType.Int32, datum.WarehouseOrderTypeID);
                    db.AddInParameter(dbCmd, "@WarehouseOrderTypeCode", DbType.String, datum.WarehouseOrderTypeCode);
                    db.AddInParameter(dbCmd, "@OrderDate", DbType.String, datum.OrderDate);
                    db.AddInParameter(dbCmd, "@OrderDate_Start", DbType.String, datum.OrderDate_Start);
                    db.AddInParameter(dbCmd, "@OrderDate_End", DbType.String, datum.OrderDate_End);
                    db.AddInParameter(dbCmd, "@PlannedDeliveryDate", DbType.String, datum.PlannedDeliveryDate);
                    db.AddInParameter(dbCmd, "@PlannedDeliveryDate_Start", DbType.String, datum.PlannedDeliveryDate_Start);
                    db.AddInParameter(dbCmd, "@PlannedDeliveryDate_End", DbType.String, datum.PlannedDeliveryDate_End);
                    db.AddInParameter(dbCmd, "@PlannedShipDate", DbType.String, datum.PlannedShipDate);
                    db.AddInParameter(dbCmd, "@PlannedShipDate_Start", DbType.String, datum.PlannedShipDate_Start);
                    db.AddInParameter(dbCmd, "@PlannedShipDate_End", DbType.String, datum.PlannedShipDate_End);
                    db.AddInParameter(dbCmd, "@Notes", DbType.String, datum.Notes);
                    db.AddInParameter(dbCmd, "@IsDocumentExist", DbType.String, datum.IsDocumentExist);
                    db.AddInParameter(dbCmd, "@PurchaseOrderID ", DbType.Int32, datum.PurchaseOrderID);
                    db.AddInParameter(dbCmd, "@PurchaseOrderCode", DbType.String, datum.PurchaseOrderCode);
                    db.AddInParameter(dbCmd, "@IsImported", DbType.String, datum.IsImported);
                    db.AddInParameter(dbCmd, "@IsExported", DbType.String, datum.IsExported);
                    db.AddInParameter(dbCmd, "@IsExported4", DbType.String, datum.IsExported4);
                    db.AddInParameter(dbCmd, "@IsExported5", DbType.String, datum.IsExported5);
                    db.AddInParameter(dbCmd, "@IsBackorder", DbType.String, datum.IsBackorder);
                    db.AddInParameter(dbCmd, "@NofShipmentLabel ", DbType.Int32, datum.NofShipmentLabel);
                    db.AddInParameter(dbCmd, "@IsAllocated", DbType.String, datum.IsAllocated);
                    db.AddInParameter(dbCmd, "@IsPickingStarted", DbType.String, datum.IsPickingStarted);
                    db.AddInParameter(dbCmd, "@IsPickingCompleted", DbType.String, datum.IsPickingCompleted);
                    db.AddInParameter(dbCmd, "@InvoiceCustomerID ", DbType.Int32, datum.InvoiceCustomerID);
                    db.AddInParameter(dbCmd, "@InvoiceCustomerPartyID ", DbType.Int32, datum.InvoiceCustomerPartyID);
                    db.AddInParameter(dbCmd, "@InvoiceCustomerDescription", DbType.String, datum.InvoiceCustomerDescription);
                    db.AddInParameter(dbCmd, "@InvoiceCustomerAddressID ", DbType.Int32, datum.InvoiceCustomerAddressID);
                    db.AddInParameter(dbCmd, "@InvoiceCustomerAddressDescription", DbType.String, datum.InvoiceCustomerAddressDescription);
                    db.AddInParameter(dbCmd, "@TotalSalesGrossPrice", DbType.Decimal, datum.TotalSalesGrossPrice);
                    db.AddInParameter(dbCmd, "@TotalSalesVat", DbType.Decimal, datum.TotalSalesVat);
                    db.AddInParameter(dbCmd, "@TotalSalesDiscount", DbType.Decimal, datum.TotalSalesDiscount);
                    db.AddInParameter(dbCmd, "@Instructions", DbType.String, datum.Instructions);
                    db.AddInParameter(dbCmd, "@AccountNumber", DbType.String, datum.AccountNumber);
                    db.AddInParameter(dbCmd, "@Driver", DbType.String, datum.Driver);
                    db.AddInParameter(dbCmd, "@Platenumber", DbType.String, datum.Platenumber);
                    db.AddInParameter(dbCmd, "@BillingTypeID", DbType.Int32, datum.BillingTypeID);
                    db.AddInParameter(dbCmd, "@BillingTypeDescription", DbType.String, datum.BillingTypeDescription);
                    db.AddInParameter(dbCmd, "@RouteID", DbType.Int32, datum.RouteID);
                    db.AddInParameter(dbCmd, "@RouteDescription", DbType.String, datum.RouteDescription);

                    if (datum.ChannelID.Count > 0)
                    {
                        db.AddInParameter(dbCmd, "@ChannelID", DbType.Int32, datum.ChannelID[0]);
                    }
                    else
                    {
                        db.AddInParameter(dbCmd, "@ChannelID", DbType.Int32, 0);
                    }

                    db.AddInParameter(dbCmd, "@ChannelDescription", DbType.String, datum.ChannelDescription);
                    db.AddInParameter(dbCmd, "@IsCancelRequested", DbType.String, datum.IsCancelRequested);

                    if (datum.CarrierID.Count > 0)
                    {
                        db.AddInParameter(dbCmd, "@CarrierID", DbType.Int32, datum.CarrierID[0]);
                    }
                    else
                    {
                        db.AddInParameter(dbCmd, "@CarrierID", DbType.Int32, 0);
                    }

                    db.AddInParameter(dbCmd, "@CarrierDescription", DbType.String, datum.CarrierDescription);
                    db.AddInParameter(dbCmd, "@IntegrationKey", DbType.String, datum.IntegrationKey);
                    db.AddInParameter(dbCmd, "@EnteredBy", DbType.String, datum.EnteredBy);
                    db.AddInParameter(dbCmd, "@CanceledBy", DbType.String, datum.CanceledBy);
                    db.AddInParameter(dbCmd, "@CarrierShippingOptionsID", DbType.Int32, datum.CarrierShippingOptionsID);
                    db.AddInParameter(dbCmd, "@CarrierDepositorListID ", DbType.Int32, datum.CarrierDepositorListID);
                    db.AddInParameter(dbCmd, "@NofProducts", DbType.Int32, datum.NofProducts);
                    db.AddInParameter(dbCmd, "@StoreName", DbType.String, datum.StoreName);
                    db.AddInParameter(dbCmd, "@LinkedChannelID", DbType.String, datum.LinkedChannelID);
                    db.AddInParameter(dbCmd, "@LinkedChannelDescription", DbType.String, datum.LinkedChannelDescription);
                    db.AddInParameter(dbCmd, "@CarrierRate", DbType.Decimal, datum.CarrierRate);
                    db.AddInParameter(dbCmd, "@CarrierMarkupRate", DbType.Decimal, datum.CarrierMarkupRate);
                    db.AddInParameter(dbCmd, "@CarrierPackageTypeID", DbType.Int32, datum.CarrierPackageTypeID);
                    db.AddInParameter(dbCmd, "@CustomerAddressID", DbType.Int32, datum.CustomerAddressID);
                    db.AddInParameter(dbCmd, "@CustomerAddressDescription", DbType.String, datum.CustomerAddressDescription);
                    db.AddInParameter(dbCmd, "@PlannedPickDate", DbType.String, datum.PlannedPickDate);
                    db.AddInParameter(dbCmd, "@ActualPickDate", DbType.String, datum.ActualPickDate);
                    db.AddInParameter(dbCmd, "@ActualDeliveryDate", DbType.String, datum.ActualDeliveryDate);
                    db.AddInParameter(dbCmd, "@ProjectID", DbType.String, datum.ProjectID);
                    db.AddInParameter(dbCmd, "@ProjectDescription", DbType.String, datum.ProjectDescription);
                    db.AddInParameter(dbCmd, "@WarehouseReceiptID", DbType.String, datum.WarehouseReceiptID);
                    db.AddInParameter(dbCmd, "@WarehouseReceiptCode", DbType.String, datum.WarehouseReceiptCode);
                    db.AddInParameter(dbCmd, "@BackWarehouseOrderID", DbType.String, datum.BackWarehouseOrderID);
                    db.AddInParameter(dbCmd, "@BackWarehouseOrderCode", DbType.String, datum.BackWarehouseOrderCode);
                    db.AddInParameter(dbCmd, "@DropShipMasterOrderID", DbType.String, datum.DropShipMasterOrderID);
                    db.AddInParameter(dbCmd, "@DropShipWarehouseOrderCode", DbType.String, datum.DropShipWarehouseOrderCode);
                    db.AddInParameter(dbCmd, "@DropShipNotes", DbType.String, datum.DropShipNotes);
                    db.AddInParameter(dbCmd, "@IsWaybillPrinted", DbType.String, datum.IsWaybillPrinted);
                    db.AddInParameter(dbCmd, "@InvoiceNo", DbType.String, datum.InvoiceNo);
                    db.AddInParameter(dbCmd, "@DeliveryNoteNo", DbType.String, datum.DeliveryNoteNo);
                    db.AddInParameter(dbCmd, "@IsCarrierLabelPrinted", DbType.String, datum.IsCarrierLabelPrinted);
                    db.AddInParameter(dbCmd, "@ChannelOrderCode", DbType.String, datum.ChannelOrderCode);
                    db.AddInParameter(dbCmd, "@CarrierWeight", DbType.String, datum.CarrierWeight);
                    db.AddInParameter(dbCmd, "@ClientPartyID", DbType.String, datum.ClientPartyID);
                    db.AddInParameter(dbCmd, "@POWindowWarehouseID", DbType.String, datum.POWindowWarehouseID);
                    db.AddInParameter(dbCmd, "@WareOrderCancelReasonID", DbType.String, datum.WareOrderCancelReasonID);
                    db.AddInParameter(dbCmd, "@WareOrderCancelReasonDescription", DbType.String, datum.WareOrderCancelReasonDescription);
                    db.AddInParameter(dbCmd, "@IsGift", DbType.String, datum.IsGift);
                    db.AddInParameter(dbCmd, "@GiftNote", DbType.String, datum.GiftNote);
                    db.AddInParameter(dbCmd, "@OrderItems", DbType.String, datum.OrderItems);
                    db.AddInParameter(dbCmd, "@ExtraNotes", DbType.String, datum.ExtraNotes);
                    db.AddInParameter(dbCmd, "@ExtraNotes1", DbType.String, datum.ExtraNotes1);
                    db.AddInParameter(dbCmd, "@ExtraNotes2", DbType.String, datum.ExtraNotes2);
                    db.AddInParameter(dbCmd, "@ExtraNotes3", DbType.String, datum.ExtraNotes3);
                    db.AddInParameter(dbCmd, "@ExtraNotes4", DbType.String, datum.ExtraNotes4);
                    db.AddInParameter(dbCmd, "@ExtraNotes5", DbType.String, datum.ExtraNotes5);
                    db.AddInParameter(dbCmd, "@Priority ", DbType.Int32, datum.Priority);
                    db.AddInParameter(dbCmd, "@FraudRecommendationID ", DbType.Int32, datum.FraudRecommendationID);
                    db.AddInParameter(dbCmd, "@FraudRecommendationCode", DbType.String, datum.FraudRecommendationCode);
                    db.AddInParameter(dbCmd, "@FraudRecommendationDescription", DbType.String, datum.FraudRecommendationDescription);
                    db.AddInParameter(dbCmd, "@OrderRiskScore", DbType.Decimal, datum.OrderRiskScore);
                    db.AddInParameter(dbCmd, "@IsExported2", DbType.String, datum.IsExported2);
                    db.AddInParameter(dbCmd, "@ShipmentMethodID", DbType.Int32, datum.ShipmentMethodID);
                    db.AddInParameter(dbCmd, "@ShipmentMethodDescription", DbType.String, datum.ShipmentMethodDescription);
                    db.AddInParameter(dbCmd, "@IsAddressVerified", DbType.String, datum.IsAddressVerified);
                    db.AddInParameter(dbCmd, "@AvaliableStockQuantity", DbType.String, datum.AvaliableStockQuantity);
                    db.AddInParameter(dbCmd, "@Store", DbType.String, datum.Store);
                    db.AddInParameter(dbCmd, "@ChannelDepositorParameterID ", DbType.Int32, datum.ChannelDepositorParameterID);
                    db.AddInParameter(dbCmd, "@CarrierBillingTypeID ", DbType.Int32, datum.CarrierBillingTypeID);
                    db.AddInParameter(dbCmd, "@CarrierBillingTypeDescription", DbType.String, datum.CarrierBillingTypeDescription);
                    db.AddInParameter(dbCmd, "@IsPickListPrinted", DbType.String, datum.IsPickListPrinted);
                    db.AddInParameter(dbCmd, "@IsPrimeOrder", DbType.String, datum.IsPrimeOrder);
                    db.AddInParameter(dbCmd, "@InvoiceDate", DbType.String, datum.InvoiceDate);
                    db.AddInParameter(dbCmd, "@EntryDateTime", DbType.String, datum.EntryDateTime);
                    db.AddInParameter(dbCmd, "@EntryDateTime_Start", DbType.String, datum.EntryDateTime_Start);
                    db.AddInParameter(dbCmd, "@EntryDateTime_End", DbType.String, datum.EntryDateTime_End);
                    db.AddInParameter(dbCmd, "@CargoDiscount", DbType.Decimal, datum.CargoDiscount);
                    db.AddInParameter(dbCmd, "@WarehouseOrdReturnReasonId ", DbType.Int32, datum.WarehouseOrdReturnReasonId);
                    db.AddInParameter(dbCmd, "@WarehouseOrdReturnReasonDescription", DbType.String, datum.WarehouseOrdReturnReasonDescription);
                    db.AddInParameter(dbCmd, "@CompanyName", DbType.String, datum.CompanyName);
                    db.AddInParameter(dbCmd, "@TotalMarkupRate", DbType.Decimal, datum.TotalMarkupRate);
                    db.AddInParameter(dbCmd, "@TotalCarrierRate", DbType.Decimal, datum.TotalCarrierRate);
                    db.AddInParameter(dbCmd, "@ActualShipDate", DbType.String, datum.ActualShipDate);
                    db.AddInParameter(dbCmd, "@ActualShipDate_Start", DbType.String, datum.ActualShipDate_Start);
                    db.AddInParameter(dbCmd, "@ActualShipDate_End", DbType.String, datum.ActualShipDate_End);
                    db.AddInParameter(dbCmd, "@PlannedPickupDate", DbType.String, datum.PlannedPickupDate);
                    db.AddInParameter(dbCmd, "@PlannedPickupDate_Start", DbType.String, datum.PlannedPickupDate_Start);
                    db.AddInParameter(dbCmd, "@PlannedPickupDate_End", DbType.String, datum.PlannedPickupDate_End);
                    db.AddInParameter(dbCmd, "@CarrierShippingDescription", DbType.String, datum.CarrierShippingDescription);
                    db.AddInParameter(dbCmd, "@IsGetOrderDetails", DbType.String, datum.IsGetOrderDetails);
                    db.AddInParameter(dbCmd, "@LastModifiedDate", DbType.String, datum.LastModifiedDate);
                    db.AddInParameter(dbCmd, "@LastModifiedDate_Start", DbType.String, datum.LastModifiedDate_Start);
                    db.AddInParameter(dbCmd, "@LastModifiedDate_End", DbType.String, datum.LastModifiedDate_End);
                    db.AddInParameter(dbCmd, "@CancellationDate", DbType.String, datum.CancellationDate);
                    db.AddInParameter(dbCmd, "@CancellationDate_Start", DbType.String, datum.CancellationDate_Start);
                    db.AddInParameter(dbCmd, "@CancellationDate_End", DbType.String, datum.CancellationDate_End);
                    db.AddInParameter(dbCmd, "@MasterWarehouseOrderCode", DbType.String, datum.MasterWarehouseOrderCode);
                    db.AddInParameter(dbCmd, "@PartyCarrierInfoID ", DbType.Int32, datum.PartyCarrierInfoID);
                    db.AddInParameter(dbCmd, "@BusinessDaysInTransit", DbType.String, datum.BusinessDaysInTransit);
                    db.AddInParameter(dbCmd, "@SupplierID ", DbType.Int32, datum.SupplierID);
                    db.AddInParameter(dbCmd, "@SupplierAddressID ", DbType.Int32, datum.SupplierAddressID);
                    db.AddInParameter(dbCmd, "@ReceiptOrderCode", DbType.String, datum.ReceiptOrderCode);
                    db.AddInParameter(dbCmd, "@ReceiptDate", DbType.String, datum.ReceiptDate);
                    db.AddInParameter(dbCmd, "@WarehouseReceiptTypeID", DbType.Boolean, datum.WarehouseReceiptTypeID);
                    db.AddInParameter(dbCmd, "@isAutoGenerate", DbType.String, datum.isAutoGenerate);
                    db.AddInParameter(dbCmd, "@isUseSameLotNumber", DbType.String, datum.isUseSameLotNumber);
                    db.AddInParameter(dbCmd, "@IsAllowChangingTaxAndDutiesPayor", DbType.String, datum.IsAllowChangingTaxAndDutiesPayor);
                    db.AddInParameter(dbCmd, "@IsGetCustomerAddressInfo", DbType.String, datum.IsGetCustomerAddressInfo);
                    db.AddInParameter(dbCmd, "@CustomerEmail", DbType.String, datum.CustomerEmail);
                    db.AddInParameter(dbCmd, "@WarehouseDropShipOrderCode", DbType.String, datum.WarehouseDropShipOrderCode);
                    db.AddInParameter(dbCmd, "@WarehouseBackOrderCode", DbType.String, datum.WarehouseBackOrderCode);
                    db.AddInParameter(dbCmd, "@WarehouseMasterOrderCode", DbType.String, datum.WarehouseMasterOrderCode);
                    db.AddInParameter(dbCmd, "@WarehouseReceiptOrderCode", DbType.String, datum.WarehouseReceiptOrderCode);
                    db.AddInParameter(dbCmd, "@WarehouseOrderOperationStatus", DbType.String, datum.WarehouseOrderOperationStatus);

                    if (datum.OrderCustomStatusID.Count > 0)
                    {
                        db.AddInParameter(dbCmd, "@OrderCustomStatusID", DbType.Int32, datum.OrderCustomStatusID[0]);
                    }
                    else
                    {
                        db.AddInParameter(dbCmd, "@OrderCustomStatusID", DbType.Int32, 0);
                    }

                    db.AddInParameter(dbCmd, "@selectedOrder", DbType.String, datum.selectedOrder);

                    if (datum.Errors.Count > 0)
                    {
                        db.AddInParameter(dbCmd, "@Errors", DbType.String, datum.Errors[0]);
                    }
                    else
                    {
                        db.AddInParameter(dbCmd, "@Errors", DbType.String, "");
                    }

                    db.AddInParameter(dbCmd, "@Success", DbType.String, datum.Success);
                    db.AddInParameter(dbCmd, "@SuccessMessage", DbType.String, datum.SuccessMessage);
                    db.AddInParameter(dbCmd, "@IsExcelExport ", DbType.Boolean, datum.IsExcelExport);
                    db.AddInParameter(dbCmd, "@PageSize", DbType.Int32, datum.PageSize);
                    db.AddInParameter(dbCmd, "@SelectedPageIndex", DbType.Int32, datum.SelectedPageIndex);
                    db.AddInParameter(dbCmd, "@PageCount", DbType.Int32, datum.PageCount);
                    db.AddInParameter(dbCmd, "@RecordCount", DbType.Int32, datum.RecordCount);

                    commandText = dbCmd.CommandText;

                    parameterText = string.Join(",", dbCmd.Parameters.Cast<SqlParameter>().ToList().Select(p => $"{p.ParameterName}='{p.Value}'"));

                    result = db.ExecuteNonQuery(dbCmd);
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                    lstBadDBInserts.Items.Add("Order: " + ex.Message);
                    string a = commandText;
                    string b = parameterText;
                    result = 0;
                }
            }

            return result;
        }

        private int ConvertTransactionHistoryJSONToSQLAndUploadToDatabase(string content)
        {
            int result = 0;

            TransactionHistory.Root myDeserializedClass = Newtonsoft.Json.JsonConvert.DeserializeObject<TransactionHistory.Root>(content);
            foreach (var th in myDeserializedClass.Data)
            {
                Task<int> t = new TaskFactory().StartNew(() => InsertTransactionHistory(th));
                result = t.Result;
            }

            return result;
        }
        #endregion

        #region InsertBillingDetailedReport
        private int InsertBillingDetailedReport(BillingDetailedReport.Datum bdr)
        {
            string connectionString = txtConnectionString.Text;
            var db = new SqlDatabase(connectionString);
            var dbCmd = db.GetStoredProcCommand("WRHS_insBillingDetailedReport");
            int result = 0;

            try
            {
                //dbCmd = db.GetStoredProcCommand("WRHS_insBillingDetailedReport");
                db.AddInParameter(dbCmd, "@ID", DbType.Int32, bdr.ID);
                db.AddInParameter(dbCmd, "@WarehouseID", DbType.Int32, bdr.WarehouseID);
                db.AddInParameter(dbCmd, "@WarehouseDescription", DbType.String, bdr.WarehouseDescription);
                db.AddInParameter(dbCmd, "@DepositorID", DbType.Int32, bdr.DepositorID);
                db.AddInParameter(dbCmd, "@DepositorDescription", DbType.String, bdr.DepositorDescription);
                db.AddInParameter(dbCmd, "@WarehouseContractID", DbType.Int32, bdr.WarehouseContractID);
                db.AddInParameter(dbCmd, "@WarehouseContractDescription", DbType.String, bdr.WarehouseContractDescription);
                db.AddInParameter(dbCmd, "@WarehouseContractLineID", DbType.Int32, bdr.WarehouseContractLineID);
                db.AddInParameter(dbCmd, "@WarehouseContractLineDescription", DbType.String, bdr.WarehouseContractLineDescription);
                db.AddInParameter(dbCmd, "@WarehouseContractPeriodsID", DbType.String, string.Empty); //th.WarehouseContractPeriodsID);
                db.AddInParameter(dbCmd, "@WarehouseContractPeriodID", DbType.Int32, bdr.WarehouseContractPeriodID);
                db.AddInParameter(dbCmd, "@WarehouseContractPeriodDescription", DbType.String, bdr.WarehouseContractPeriodDescription);
                db.AddInParameter(dbCmd, "@ActivityDate", DbType.String, bdr.ActivityDate);
                db.AddInParameter(dbCmd, "@ActivityDate_Start", DbType.String, bdr.ActivityDate_Start);
                db.AddInParameter(dbCmd, "@ActivityDate_End", DbType.String, bdr.ActivityDate_End);
                db.AddInParameter(dbCmd, "@CalculatedMetricUnit", DbType.Decimal, bdr.CalculatedMetricUnit);
                db.AddInParameter(dbCmd, "@CalculatedTotalPrice", DbType.Decimal, bdr.CalculatedTotalPrice);
                db.AddInParameter(dbCmd, "@ObjectType", DbType.String, bdr.ObjectType);
                db.AddInParameter(dbCmd, "@ObjectID", DbType.String, bdr.ObjectID);
                db.AddInParameter(dbCmd, "@PartyReferance", DbType.String, bdr.PartyReferance);
                db.AddInParameter(dbCmd, "@PartyReference", DbType.String, bdr.PartyReference);
                db.AddInParameter(dbCmd, "@CalculationInfo", DbType.String, bdr.CalculationInfo);
                db.AddInParameter(dbCmd, "@Notes", DbType.String, bdr.Notes);
                db.AddInParameter(dbCmd, "@IsBilled", DbType.Boolean, bdr.IsBilled);
                db.AddInParameter(dbCmd, "@IsInvoiceable", DbType.Boolean, bdr.IsInvoiceable);
                db.AddInParameter(dbCmd, "@IsError", DbType.Boolean, bdr.IsError);
                db.AddInParameter(dbCmd, "@StartQuantity", DbType.Decimal, bdr.StartQuantity);
                db.AddInParameter(dbCmd, "@FinishQuantity", DbType.Decimal, bdr.FinishQuantity);
                db.AddInParameter(dbCmd, "@Price", DbType.Decimal, bdr.Price);
                db.AddInParameter(dbCmd, "@WarehouseContractLinePricingTypeID", DbType.Int32, bdr.WarehouseContractLinePricingTypeID);
                db.AddInParameter(dbCmd, "@WarehouseContractLinePricingTypeCode", DbType.String, bdr.WarehouseContractLinePricingTypeCode);
                db.AddInParameter(dbCmd, "@WarehouseContractLineReference", DbType.String, bdr.WarehouseContractLineReference);
                db.AddInParameter(dbCmd, "@PageSize", DbType.Int32, bdr.PageSize);
                db.AddInParameter(dbCmd, "@SelectedPageIndex", DbType.Int32, bdr.SelectedPageIndex);
                db.AddInParameter(dbCmd, "@PageCount", DbType.Int32, bdr.PageCount);
                db.AddInParameter(dbCmd, "@RecordCount", DbType.Int32, bdr.RecordCount);

                result = db.ExecuteNonQuery(dbCmd);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                result = 0;
            }

            return result;
        }
        #endregion

        #region InsertTransactionHistory
        private int InsertTransactionHistory(TransactionHistory.Datum th)
        {
            string connectionString = txtConnectionString.Text;
            var db = new SqlDatabase(connectionString);
            var dbCmd = db.GetStoredProcCommand("WRHS_insTransactionHistoryThreaded");
            int result = 0;
            try
            {
                db.AddInParameter(dbCmd, "@ID", DbType.Int32, th.ID);
                db.AddInParameter(dbCmd, "@User", DbType.String, th.User);
                db.AddInParameter(dbCmd, "@InventoryItemID", DbType.Int32, th.InventoryItemID);
                db.AddInParameter(dbCmd, "@InventoryItemCode", DbType.String, th.InventoryItemCode);
                db.AddInParameter(dbCmd, "@InventoryItemDescription", DbType.String, th.InventoryItemDescription);
                db.AddInParameter(dbCmd, "@Barcode", DbType.String, th.Barcode);
                db.AddInParameter(dbCmd, "@InventorySiteID", DbType.Int32, th.InventorySiteID);
                db.AddInParameter(dbCmd, "@InventorySiteDescription", DbType.String, th.InventorySiteDescription);
                db.AddInParameter(dbCmd, "@TransactionTypeID", DbType.Int32, th.TransactionTypeID);
                db.AddInParameter(dbCmd, "@TransactionTypeDescription", DbType.String, th.TransactionTypeDescription);
                db.AddInParameter(dbCmd, "@TransactionSubTypeID", DbType.Int32, th.TransactionSubTypeID);
                db.AddInParameter(dbCmd, "@TransactionSubTypeDescription", DbType.String, th.TransactionSubTypeDescription);
                db.AddInParameter(dbCmd, "@LocationID", DbType.Int32, th.LocationID);
                db.AddInParameter(dbCmd, "@LocationDescription", DbType.String, th.LocationDescription);
                db.AddInParameter(dbCmd, "@WarehouseID", DbType.Int32, th.WarehouseID);
                db.AddInParameter(dbCmd, "@WarehouseDescription", DbType.String, th.WarehouseDescription);
                db.AddInParameter(dbCmd, "@DepositorID", DbType.Int32, th.DepositorID);
                db.AddInParameter(dbCmd, "@DepositorDescription", DbType.String, th.DepositorDescription);
                db.AddInParameter(dbCmd, "@WarehouseReceiptID", DbType.Int32, th.WarehouseReceiptID);
                db.AddInParameter(dbCmd, "@WarehouseReceiptDescription", DbType.String, th.WarehouseReceiptDescription);
                db.AddInParameter(dbCmd, "@ReceiptID", DbType.Int32, th.ReceiptID);
                db.AddInParameter(dbCmd, "@ReceiptDescription", DbType.String, th.ReceiptDescription);
                db.AddInParameter(dbCmd, "@EntryDateTime", DbType.String, th.EntryDateTime);
                db.AddInParameter(dbCmd, "@EntryDateTime_Start", DbType.String, th.EntryDateTime_Start);
                db.AddInParameter(dbCmd, "@EntryDateTime_End", DbType.String, th.EntryDateTime_End);
                db.AddInParameter(dbCmd, "@TransactionStartDate", DbType.String, th.TransactionStartDate);
                db.AddInParameter(dbCmd, "@TransactionStartDate_Start", DbType.String, th.TransactionStartDate_Start);
                db.AddInParameter(dbCmd, "@TransactionStartDate_End", DbType.String, th.TransactionStartDate_End);
                db.AddInParameter(dbCmd, "@TransactionFinishDate", DbType.String, th.TransactionFinishDate);
                db.AddInParameter(dbCmd, "@TransactionFinishDate_Start", DbType.String, th.TransactionFinishDate_Start);
                db.AddInParameter(dbCmd, "@TransactionFinishDate_End", DbType.String, th.TransactionFinishDate_End);
                db.AddInParameter(dbCmd, "@Host", DbType.String, th.Host);
                db.AddInParameter(dbCmd, "@Session", DbType.String, th.Session);
                db.AddInParameter(dbCmd, "@ProductionOrderID", DbType.Int32, th.ProductionOrderID);
                db.AddInParameter(dbCmd, "@ProductionOrderDescription", DbType.String, th.ProductionOrderDescription);
                db.AddInParameter(dbCmd, "@ReceiptItemID", DbType.Int32, th.ReceiptItemID);
                db.AddInParameter(dbCmd, "@ShipmentID", DbType.Int32, th.ShipmentID);
                db.AddInParameter(dbCmd, "@ShipmentDescription", DbType.String, th.ShipmentDescription);
                db.AddInParameter(dbCmd, "@ShipmentItemID", DbType.Int32, th.ShipmentItemID);
                db.AddInParameter(dbCmd, "@WarehouseOrderID", DbType.Int32, th.WarehouseOrderID);
                db.AddInParameter(dbCmd, "@WarehouseOrderDescription", DbType.String, th.WarehouseOrderDescription);
                db.AddInParameter(dbCmd, "@WarehouseOrderDetailID", DbType.Int32, th.WarehouseOrderDetailID);
                db.AddInParameter(dbCmd, "@WarehouseReceiptDetailID", DbType.Int32, th.WarehouseReceiptDetailID);
                db.AddInParameter(dbCmd, "@ProductionOrderDetailID", DbType.Int32, th.ProductionOrderDetailID);
                db.AddInParameter(dbCmd, "@ProductionOrderDetailDescription", DbType.String, th.ProductionOrderDetailDescription);
                db.AddInParameter(dbCmd, "@CountPlanRevisionID", DbType.Int32, th.CountPlanRevisionID);
                db.AddInParameter(dbCmd, "@CountPlanRevisionDescription", DbType.String, th.CountPlanRevisionDescription);
                db.AddInParameter(dbCmd, "@Canceled", DbType.Boolean, th.Canceled);
                db.AddInParameter(dbCmd, "@CuInventoryItemPackTypeID", DbType.Int32, th.CuInventoryItemPackTypeID);
                db.AddInParameter(dbCmd, "@CuInventoryItemPackTypeDescription", DbType.String, th.CuInventoryItemPackTypeDescription);
                db.AddInParameter(dbCmd, "@InventoryItemPackTypeID", DbType.Int32, th.InventoryItemPackTypeID);
                db.AddInParameter(dbCmd, "@InventoryItemPackTypeDescription", DbType.String, th.InventoryItemPackTypeDescription);
                db.AddInParameter(dbCmd, "@LotBatchNo", DbType.String, th.LotBatchNo);
                db.AddInParameter(dbCmd, "@ProductionDate", DbType.String, th.ProductionDate);
                db.AddInParameter(dbCmd, "@ProductionDate_Start", DbType.String, th.ProductionDate_Start);
                db.AddInParameter(dbCmd, "@ProductionDate_End", DbType.String, th.ProductionDate_End);
                db.AddInParameter(dbCmd, "@ExpireDate", DbType.String, th.ExpireDate);
                db.AddInParameter(dbCmd, "@ExpireDate_Start", DbType.String, th.ExpireDate_Start);
                db.AddInParameter(dbCmd, "@ExpireDate_End", DbType.String, th.ExpireDate_End);
                db.AddInParameter(dbCmd, "@ReferanceNo", DbType.String, th.ReferanceNo);
                db.AddInParameter(dbCmd, "@StockKitCode", DbType.String, th.StockKitCode);
                db.AddInParameter(dbCmd, "@StockId", DbType.String, th.StockId);
                db.AddInParameter(dbCmd, "@ProjectID", DbType.Int32, th.ProjectID);
                db.AddInParameter(dbCmd, "@ProjectDescription", DbType.String, th.ProjectDescription);
                db.AddInParameter(dbCmd, "@CustomerID", DbType.Int32, th.CustomerID);
                db.AddInParameter(dbCmd, "@CustomerDescription", DbType.String, th.CustomerDescription);
                db.AddInParameter(dbCmd, "@TransactionHistPalletID", DbType.Int32, th.TransactionHistPalletID);
                db.AddInParameter(dbCmd, "@TransactionHistPalletDescription", DbType.String, th.TransactionHistPalletDescription);
                db.AddInParameter(dbCmd, "@Quantity", DbType.Decimal, th.Quantity);
                db.AddInParameter(dbCmd, "@WarehouseReceiptSupplierID", DbType.Int32, th.WarehouseReceiptSupplierID);
                db.AddInParameter(dbCmd, "@WarehouseReceiptSupplierCode", DbType.String, th.WarehouseReceiptSupplierCode);
                db.AddInParameter(dbCmd, "@OrderCustomerID", DbType.Int32, th.OrderCustomerID);
                db.AddInParameter(dbCmd, "@OrderCustomerCode", DbType.String, th.OrderCustomerCode);
                db.AddInParameter(dbCmd, "@QuarantineResaonID", DbType.Int32, th.QuarantineResaonID);
                db.AddInParameter(dbCmd, "@QuarantineResaonDescription", DbType.String, th.QuarantineResaonDescription);
                db.AddInParameter(dbCmd, "@SuitabilityReasonID", DbType.Int32, th.SuitabilityReasonID);
                db.AddInParameter(dbCmd, "@SuitabilityReasonDescription", DbType.String, th.SuitabilityReasonDescription);
                db.AddInParameter(dbCmd, "@FreeAttr1", DbType.String, th.FreeAttr1);
                db.AddInParameter(dbCmd, "@FreeAttr2", DbType.String, th.FreeAttr2);
                db.AddInParameter(dbCmd, "@FreeAttr3", DbType.String, th.FreeAttr3);
                db.AddInParameter(dbCmd, "@PackedQuantity", DbType.Decimal, th.PackedQuantity);
                db.AddInParameter(dbCmd, "@LocationDisplayMember", DbType.String, th.LocationDisplayMember);
                db.AddInParameter(dbCmd, "@HistoryId", DbType.String, th.HistoryId);
                db.AddInParameter(dbCmd, "@WarehouseOrderType", DbType.String, th.WarehouseOrderType);
                db.AddInParameter(dbCmd, "@WarehouseOrderTypeCode", DbType.String, th.WarehouseOrderTypeCode);
                db.AddInParameter(dbCmd, "@WarehouseOrderTypeID", DbType.Int32, string.IsNullOrEmpty(th.WarehouseOrderTypeID) ? "0" : th.WarehouseOrderTypeID);
                db.AddInParameter(dbCmd, "@PageSize", DbType.Int32, th.PageSize);
                db.AddInParameter(dbCmd, "@SelectedPageIndex", DbType.Int32, th.SelectedPageIndex);
                db.AddInParameter(dbCmd, "@PageCount", DbType.Int32, th.PageCount);
                db.AddInParameter(dbCmd, "@RecordCount", DbType.Int32, th.RecordCount);

                result = db.ExecuteNonQuery(dbCmd);
            }
            catch (Exception ex)
            {
                lstBadDBInserts.Items.Add(ex.Message);
                result = 0;
            }
            return result;
        }

        #endregion

        #region Button Clicks
        private void btnExecute_Click(object sender, EventArgs e)
        {
            dynamic jObjectbody = JObject.Parse(txtBody.Text); //Get the body to send

            //Pick up where left off for contract billing report
            if (cmbAPIToCall.SelectedItem.Equals("Contract Billing Report"))
            {
                int selectedPageIndex = GetBillingDetailedReportProgress();
                ((JObject)jObjectbody)["SelectedPageIndex"] = selectedPageIndex.ToString();
                txtBody.Text = Convert.ToString(jObjectbody);
                Application.DoEvents();
            }
            else if (cmbAPIToCall.SelectedItem.Equals("Transaction History"))
            {
                //COMMENTED OUT BELOW TO RUN ANOTHER INSTANCE BACKWARDS

                //int selectedPageIndex = GetTransactionHistoryProgress();
                //((JObject)jObjectbody)["SelectedPageIndex"] = selectedPageIndex.ToString();
                //txtBody.Text = Convert.ToString(jObjectbody);
                //Application.DoEvents();
            }
            //else if (cmbAPIToCall.SelectedItem.Equals("List Orders"))
            //{
            //    int selectedPageIndex = GetListOrdersProgress();
            //    ((JObject)jObjectbody)["SelectedPageIndex"] = selectedPageIndex.ToString();
            //    txtBody.Text = Convert.ToString(jObjectbody);
            //    Application.DoEvents();
            //}


            bool stop = false;
            int contractIndex = lstContract.SelectedIndex;
            int contractPeriodIndex = lstContractPeriod.SelectedIndex;
            int transactionHistoryStartIndex = lstTransactionHistoryStart.SelectedIndex;
            int transactionHistoryEndIndex = lstTransactionHistoryEnd.SelectedIndex;
            int transactionHistoryStartMaxIndex = lstTransactionHistoryStart.Items.Count - 1;
            int transactionHistoryEndMaxIndex = lstTransactionHistoryEnd.Items.Count - 1;
            int contractPeriodMaxIndex = lstContractPeriod.Items.Count - 1;
            int contractMaxIndex = lstContract.Items.Count - 1;

            while (!stop)
            {
                //int x = 18726;
                //Parallel.For(0, x, i =>
                //{
                jObjectbody = JObject.Parse(txtBody.Text); //Get the body to send

                //If billing report we need to populate WarehouseContractDescription and WarehouseContractPeriodDescription
                if (cmbAPIToCall.SelectedItem.Equals("Contract Billing Report"))
                {
                    ((JObject)jObjectbody)["WarehouseContractDescription"] = lstContract.Items[contractIndex].ToString();
                    lstContract.SelectedIndex = contractIndex;
                    ((JObject)jObjectbody)["WarehouseContractPeriodDescription"] = lstContractPeriod.Items[contractPeriodIndex].ToString();
                    lstContractPeriod.SelectedIndex = contractPeriodIndex;
                    //txtBody.Text = Convert.ToString(jObjectbody); //Update the text on screen so that the user can see the current index.
                    Application.DoEvents();
                }
                else if (cmbAPIToCall.SelectedItem.Equals("Transaction History"))
                {
                    ((JObject)jObjectbody)["EntryDateTime_Start"] = lstTransactionHistoryStart.Items[transactionHistoryStartIndex].ToString();
                    lstTransactionHistoryStart.SelectedIndex = transactionHistoryStartIndex;
                    ((JObject)jObjectbody)["EntryDateTime_End"] = lstTransactionHistoryEnd.Items[transactionHistoryEndIndex].ToString();
                    lstTransactionHistoryEnd.SelectedIndex = transactionHistoryEndIndex;
                    txtBody.Text = Convert.ToString(jObjectbody); //Update the text on screen so that the user can see the current index.
                    Application.DoEvents(); //Allow UI to refresh so you can see the SelectedPageIndex update.
                }
                else if (cmbAPIToCall.SelectedItem.Equals("List Orders"))
                {
                    txtBody.Text = Convert.ToString(jObjectbody); //Update the text on screen so that the user can see the current index.
                    Application.DoEvents(); //Allow UI to refresh so you can see the SelectedPageIndex update.
                }

                var client = new RestClient(txtAPI.Text);
                var request = new RestRequest(txtMethod.Text.Trim().ToUpper() == "POST" ? Method.POST : Method.GET);

                request.AddHeader("Content-Type", txtContentType.Text);
                request.AddHeader("Authorization", txtAuthorization.Text);
                request.AddParameter("application/json", jObjectbody, ParameterType.RequestBody);

                try
                {
                    var clientValue = client.Execute(request); //Make the call and populate the return variable

                    try
                    {
                        dynamic jObjectResult = JObject.Parse(clientValue.Content); //Pull the response (JSON data) into a dynamic object

                        var dataElement = jObjectResult.Data; //The data property is where the call's data is stored

                        int pageIndex = Convert.ToInt32(jObjectbody.SelectedPageIndex); //Get the current page index

                        if (dataElement.HasValues == false) //If the data element is empty then that means we have no more page data.
                        {
                            if (cmbAPIToCall.SelectedItem.Equals("Contract Billing Report"))
                            {
                                //Check to see if we can move to a new contract period
                                if (contractPeriodIndex < contractPeriodMaxIndex)
                                {
                                    //Move to next contract period.
                                    contractPeriodIndex = contractPeriodIndex + 1;
                                    //Reset page index
                                    pageIndex = 0;
                                    ((JObject)jObjectbody)["SelectedPageIndex"] = pageIndex.ToString(); //Update the current page index so that the next loop will call for the next page.

                                    txtBody.Text = Convert.ToString(jObjectbody); //Update the text on screen so that the user can see the current index.

                                    Application.DoEvents(); //Allow UI to refresh so you can see the SelectedPageIndex update.
                                }
                                else
                                {
                                    //We've reached the end of the current contract period. So check for another client and move on to them.
                                    if (contractIndex < contractMaxIndex)
                                    {
                                        contractIndex = contractIndex + 1;
                                        pageIndex = 0;
                                        contractPeriodIndex = 0; //Reset the contract period because we moved onto the next client
                                        ((JObject)jObjectbody)["SelectedPageIndex"] = pageIndex.ToString(); //Update the current page index so that the next loop will call for the next page.

                                        txtBody.Text = Convert.ToString(jObjectbody); //Update the text on screen so that the user can see the current index.

                                        Application.DoEvents(); //Allow UI to refresh so you can see the SelectedPageIndex update.
                                    }
                                    else
                                    {
                                        stop = true; //We're done with all contracts and all contract periods.
                                    }
                                }
                            }
                            else if (cmbAPIToCall.SelectedItem.Equals("Transaction History"))
                            {
                                //Check to see if we can move to a new contract period
                                if (transactionHistoryStartIndex < transactionHistoryStartMaxIndex)
                                {
                                    //Move to next contract period.
                                    transactionHistoryStartIndex = transactionHistoryStartIndex + 1;
                                    transactionHistoryEndIndex = transactionHistoryEndIndex + 1;
                                    //Reset page index
                                    pageIndex = 0;
                                    ((JObject)jObjectbody)["SelectedPageIndex"] = pageIndex.ToString(); //Update the current page index so that the next loop will call for the next page.

                                    txtBody.Text = Convert.ToString(jObjectbody); //Update the text on screen so that the user can see the current index.

                                    Application.DoEvents(); //Allow UI to refresh so you can see the SelectedPageIndex update.
                                }
                                else
                                {
                                    stop = true; //We're done with all contracts and all contract periods.
                                }
                            }
                            else
                            {
                                stop = true; //Set flag to stop. Do not write file and exit the loop.
                            }
                        }
                        else
                        {
                            if (cmbAPIToCall.SelectedItem.Equals("Contract Billing Report"))
                            {
                                //string directory = string.Format(@"" + string.Format(txtWriteTo.Text.EndsWith(@"\") ? txtWriteTo.Text : txtWriteTo.Text + @"\{0}", lstContract.Items[contractIndex].ToString()));

                                //if (!Directory.Exists(directory))
                                //{
                                //    Directory.CreateDirectory(directory);
                                //}
                                //string billingReportFilePath = @"" + txtWriteTo.Text + lstContract.Items[contractIndex].ToString() + " - "
                                //    + lstContractPeriod.Items[contractPeriodIndex].ToString().Replace("/", " To ")
                                //    + " - PageIndex " + pageIndex.ToString() + ".json";

                                //File.WriteAllText(@"" + billingReportFilePath, clientValue.Content); //Write JSON response to a rolling number file.

                                int result = ConvertBillingDetailedReportJSONToSQLAndUploadToDatabase(clientValue.Content);

                                if (result == 0) //If 0 then record insert failed.
                                {
                                    lstBadDBInserts.Items.Add
                                    (
                                        lstContract.Items[contractIndex].ToString() + " - " + lstContractPeriod.Items[contractPeriodIndex].ToString().Replace("/", " To ") + " - PageIndex " + pageIndex.ToString()
                                    );
                                }
                            }
                            else if (cmbAPIToCall.SelectedItem.Equals("Transaction History"))
                            {
                                int result = ConvertTransactionHistoryJSONToSQLAndUploadToDatabase(clientValue.Content);

                                if (result == 0) //If 0 then record insert failed.
                                {
                                    lstBadDBInserts.Items.Add
                                    (
                                        lstTransactionHistoryStart.Items[transactionHistoryStartIndex].ToString() + " - " + lstTransactionHistoryEnd.Items[transactionHistoryEndIndex].ToString() + " - PageIndex " + pageIndex.ToString()
                                    );
                                }
                            }
                            else if (cmbAPIToCall.SelectedItem.Equals("List Orders"))
                            {
                                int result = ConvertListOrdersJSONToSQLAndUploadToDatabase(clientValue.Content);

                                if (result == 0) //If 0 then record insert failed.
                                {
                                    lstBadDBInserts.Items.Add
                                    (
                                    "List Orders - PageIndex " + pageIndex.ToString()
                                    );
                                }
                            }
                            else
                            {
                                File.WriteAllText(@"" + txtWriteTo.Text + pageIndex + ".json", clientValue.Content); //Write JSON response to a rolling number file.
                            }

                            if (processBackwards)
                            {
                                pageIndex -= 1;

                                if (pageIndex < 0)
                                {
                                    stop = true;
                                }
                            }
                            else
                            {
                                pageIndex += 1;
                            }
                            ((JObject)jObjectbody)["SelectedPageIndex"] = pageIndex.ToString(); //Update the current page index so that the next loop will call for the next page.

                            txtBody.Text = Convert.ToString(jObjectbody); //Update the text on screen so that the user can see the current index.
                        }

                        Application.DoEvents(); //Allow UI to refresh so you can see the SelectedPageIndex update.
                    }
                    catch (Exception err)
                    {
                        string errMsg = err.Message;
                    }

                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }
        }

        public int GetBillingDetailedReportProgress()
        {
            int selectedPageIndex = 0;
            SqlDataReader reader = null;
            SqlConnection conSql2000 = new SqlConnection(txtConnectionString.Text);
            //configsettings = new ResourceManager("WarehouseService.configsettings", this.GetType().Assembly);
            //sConnectionString = this.configsettings.GetString("Connection_String");
            try
            {
                SqlCommand command = new SqlCommand("WRHS_GetBillingDetailedReportMaxPageIndex", conSql2000);
                command.CommandType = CommandType.StoredProcedure;
                conSql2000.Open();
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                reader.Read();
                if (reader.HasRows)
                {
                    lstContract.SelectedItem = reader["WarehouseContractDescription"].ToString();
                    lstContractPeriod.SelectedItem = reader["WarehouseContractPeriodDescription"].ToString();
                    selectedPageIndex = Convert.ToInt32(reader["SelectedPageIndex"]);
                }
                reader.Close();
            }
            catch (SqlException errSql)
            {
            }

            return selectedPageIndex;
        }

        public int GetTransactionHistoryProgress()
        {
            int selectedPageIndex = 0;
            SqlDataReader reader = null;
            SqlConnection conSql2000 = new SqlConnection(txtConnectionString.Text);
            //configsettings = new ResourceManager("WarehouseService.configsettings", this.GetType().Assembly);
            //sConnectionString = this.configsettings.GetString("Connection_String");
            try
            {
                SqlCommand command = new SqlCommand("WRHS_GetTransactionHistoryMaxPageIndex", conSql2000);
                command.CommandType = CommandType.StoredProcedure;
                conSql2000.Open();
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                reader.Read();
                if (reader.HasRows)
                {
                    lstTransactionHistoryStart.SelectedItem = reader["StartDate"].ToString();
                    lstTransactionHistoryEnd.SelectedIndex = lstTransactionHistoryStart.SelectedIndex;
                    selectedPageIndex = Convert.ToInt32(reader["SelectedPageIndex"]);
                }
                reader.Close();
            }
            catch (SqlException errSql)
            {
            }

            return selectedPageIndex;
        }

        private void btnMergeJSON_Click(object sender, EventArgs e)
        {
            //Open first file. To be used to merge the other files into
            string masterFile = lstFiles.Items[0].ToString();
            string[] masterFileLines = File.ReadAllLines(masterFile);
            string masterFileGuts = string.Join("", masterFileLines);

            dynamic masterFileJSON = JObject.Parse(masterFileGuts); //Get the body to send

            lstFiles.Items.RemoveAt(0); //Remove first item.
            var mergedFiles = new JObject();

            foreach (string file in lstFiles.Items)
            {
                string[] fileLines = System.IO.File.ReadAllLines(file);
                string fileGuts = string.Join("", fileLines);
                dynamic fileJSON = JObject.Parse(fileGuts); //Get the body to send

                mergedFiles.Merge(masterFileJSON);
                mergedFiles.Merge(fileJSON);
            }
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(txtFolderToMerge.Text); //Assuming Test is your Folder

            FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files

            foreach (FileInfo file in Files)
            {
                lstFiles.Items.Add(file.FullName);
            }

            //ArrayList q = new ArrayList();
            List<string> fileList = new List<string>();

            foreach (string o in lstFiles.Items) 
            {
                fileList.Add(o);
            }

            fileList.Sort();

            var sortedList = fileList.OrderBy(item => int.Parse(item));

            lstFiles.Items.Clear();
            
            foreach(string o in fileList)
            {
                lstFiles.Items.Add(o); 
            }

            btnCondenseFiles.Enabled = true;
        }

        private void btnCondenseFiles_Click(object sender, EventArgs e)
        {
            int fileIndex = 1;
            JsonConvert converter = new JsonConvert();
            //foreach (string file in lstFiles.Items)
            while (lstFiles.Items.Count > 0)
            {
                string mergedFile = @"C:\Users\JasonHalvorson\Desktop\Logiwa\ListOrders\Merged\ListOrders" + fileIndex.ToString() + ".json";
                string mergedFileAsSQL = @"C:\Users\JasonHalvorson\Desktop\Logiwa\ListOrders\Merged\ListOrders" + fileIndex.ToString() + ".sql";
                string mergedFileAsCSV = @"C:\Users\JasonHalvorson\Desktop\Logiwa\ListOrders\Merged\ListOrders" + fileIndex.ToString() + ".csv";

                if (File.Exists(mergedFile))
                {
                    File.Delete(mergedFile);
                }

                if (File.Exists(mergedFileAsSQL))
                {
                    File.Delete(mergedFileAsSQL);
                }

                if (File.Exists(mergedFileAsCSV))
                {
                    File.Delete(mergedFileAsCSV);
                }

                for (int x = 0; x < 50; x++)
                {
                    try
                    {
                        //string[] fileLines = System.IO.File.ReadAllLines(file);
                        if (!string.IsNullOrEmpty(lstFiles.Items[x].ToString()))
                        {
                            string[] fileLines = File.ReadAllLines(lstFiles.Items[x].ToString());
                            string fileGuts = string.Join("", fileLines);
                            //txtMergedJSON.Text += fileGuts + ",";

                            if (!File.Exists(mergedFile))
                            {
                                // Create a file to write to.
                                using (StreamWriter sw = File.CreateText(mergedFile))
                                {
                                    sw.WriteLine("[");
                                }
                            }

                            if (x == 0)
                            {
                                using (StreamWriter sw = File.AppendText(mergedFile))
                                {
                                    sw.WriteLine(fileGuts);
                                }
                            }
                            else
                            {
                                using (StreamWriter sw = File.AppendText(mergedFile))
                                {
                                    sw.WriteLine("," + fileGuts);
                                }
                            }

                            lstFiles.Items.RemoveAt(x);
                        }
                    }
                    catch(Exception err)
                    {

                    }
                }

                fileIndex++;

                using (StreamWriter sw = File.AppendText(mergedFile))
                {
                    sw.WriteLine("]");
                }

                using (var r = new ChoJSONReader(mergedFile))
                {
                    using (var w = new ChoCSVWriter(mergedFileAsCSV).WithFirstLineHeader())
                    {
                        w.Write(r);
                    }
                }

                //converter.DatabaseName = "Logiwa";
                //converter.TableName = "ListOrders";

                //string json = File.ReadAllText(mergedFile);
                //string sqlScript = converter.ToSQL(json);

                //if (File.Exists(mergedFileAsSQL))
                //{
                //    File.Delete(mergedFileAsSQL);
                //}

                //// Create a file to write to.
                //using (StreamWriter sw = File.CreateText(mergedFileAsSQL))
                //{
                //    sw.WriteLine(sqlScript);
                //}
            }

            btnCondenseFiles.Enabled = false;
        }
        #endregion

        private void btnTranHistExecute_Click(object sender, EventArgs e)
        {
            cmbAPIToCall.SelectedIndex = cmbAPIToCall.FindStringExact("Transaction History");

            int processors = 1;
            string processorsStr = Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS");
            if (processorsStr != null)
            {
                processors = int.Parse(processorsStr) - 1; //Leave one core out.
            }

            int pageIndex = 0;
            
            for (int j = 0; j < processors; j++)
            {
                Task t = new TaskFactory().StartNew(() => PullTransactionHistory(pageIndex));
            }
        }

        private void PullTransactionHistory(int pageIndex)
        {
            bool stop = false;
            int transactionHistoryStartIndex = 0;
            int transactionHistoryEndIndex = 0;
            int transactionHistoryStartMaxIndex = lstTransactionHistoryStart.Items.Count - 1;
            int transactionHistoryEndMaxIndex = lstTransactionHistoryEnd.Items.Count - 1;

            while (!stop)
            {
                dynamic jObjectbody = JObject.Parse(txtBody.Text); //Get the body to send

                ((JObject)jObjectbody)["EntryDateTime_Start"] = lstTransactionHistoryStart.Items[transactionHistoryStartIndex].ToString();
                lstTransactionHistoryStart.SelectedIndex = transactionHistoryStartIndex;
                ((JObject)jObjectbody)["EntryDateTime_End"] = lstTransactionHistoryEnd.Items[transactionHistoryEndIndex].ToString();
                lstTransactionHistoryEnd.SelectedIndex = transactionHistoryEndIndex;
                //txtBody.Text = Convert.ToString(jObjectbody); //Update the text on screen so that the user can see the current index.
                Application.DoEvents(); //Allow UI to refresh so you can see the SelectedPageIndex update.

                var client = new RestClient(txtAPI.Text);
                var request = new RestRequest(txtMethod.Text.Trim().ToUpper() == "POST" ? Method.POST : Method.GET);

                request.AddHeader("Content-Type", txtContentType.Text);
                request.AddHeader("Authorization", txtAuthorization.Text);
                request.AddParameter("application/json", jObjectbody, ParameterType.RequestBody);

                try
                {
                    var clientValue = client.Execute(request); //Make the call and populate the return variable

                    try
                    {
                        dynamic jObjectResult = JObject.Parse(clientValue.Content); //Pull the response (JSON data) into a dynamic object

                        var dataElement = jObjectResult.Data; //The data property is where the call's data is stored

                        pageIndex = Convert.ToInt32(jObjectbody.SelectedPageIndex); //Get the current page index

                        if (dataElement.HasValues == false) //If the data element is empty then that means we have no more page data.
                        {
                            if (cmbAPIToCall.SelectedItem.Equals("Transaction History"))
                            {
                                //Check to see if we can move to a new contract period
                                if (transactionHistoryStartIndex < transactionHistoryStartMaxIndex)
                                {
                                    //Move to next contract period.
                                    transactionHistoryStartIndex = transactionHistoryStartIndex + 1;
                                    transactionHistoryEndIndex = transactionHistoryEndIndex + 1;
                                    //Reset page index
                                    pageIndex = 0;
                                    ((JObject)jObjectbody)["SelectedPageIndex"] = pageIndex.ToString(); //Update the current page index so that the next loop will call for the next page.

                                    txtBody.Text = Convert.ToString(jObjectbody); //Update the text on screen so that the user can see the current index.

                                    Application.DoEvents(); //Allow UI to refresh so you can see the SelectedPageIndex update.
                                }
                                else
                                {
                                    stop = true; //We're done with all contracts and all contract periods.
                                }
                            }
                            else
                            {
                                stop = true; //Set flag to stop. Do not write file and exit the loop.
                            }
                        }
                        else
                        {
                            if (cmbAPIToCall.SelectedItem.Equals("Transaction History"))
                            {
                                int result = ConvertTransactionHistoryJSONToSQLAndUploadToDatabase(clientValue.Content);

                                if (result == 0) //If 0 then record insert failed.
                                {
                                    lstBadDBInserts.Items.Add
                                    (
                                        lstTransactionHistoryStart.Items[transactionHistoryStartIndex].ToString() + " - " + lstTransactionHistoryEnd.Items[transactionHistoryEndIndex].ToString() + " - PageIndex " + pageIndex.ToString()
                                    );
                                }
                            }
                            else
                            {
                                File.WriteAllText(@"" + txtWriteTo.Text + pageIndex + ".json", clientValue.Content); //Write JSON response to a rolling number file.
                            }

                            pageIndex += 1;
                            ((JObject)jObjectbody)["SelectedPageIndex"] = pageIndex.ToString(); //Update the current page index so that the next loop will call for the next page.

                            txtBody.Text = Convert.ToString(jObjectbody); //Update the text on screen so that the user can see the current index.
                        }

                        Application.DoEvents(); //Allow UI to refresh so you can see the SelectedPageIndex update.
                    }
                    catch (Exception err)
                    {
                        string errMsg = err.Message;
                    }

                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }
        }

        private void btnParallelExecute_Click(object sender, EventArgs e)
        {
            dynamic jObjectbody = JObject.Parse(txtBody.Text); //Get the body to send
            dynamic qwert = null;
            bool stop = false;
            int contractIndex = lstContract.SelectedIndex;
            int contractPeriodIndex = lstContractPeriod.SelectedIndex;
            int transactionHistoryStartIndex = lstTransactionHistoryStart.SelectedIndex;
            int transactionHistoryEndIndex = lstTransactionHistoryEnd.SelectedIndex;
            int transactionHistoryStartMaxIndex = lstTransactionHistoryStart.Items.Count - 1;
            int transactionHistoryEndMaxIndex = lstTransactionHistoryEnd.Items.Count - 1;
            int contractPeriodMaxIndex = lstContractPeriod.Items.Count - 1;
            int contractMaxIndex = lstContract.Items.Count - 1;

            int x = 18726;

            Parallel.For(0, x, i =>
            {
                Debug.WriteLine("Parallel: " + i.ToString());
            var client = new RestClient(txtAPI.Text);
            var request = new RestRequest(txtMethod.Text.Trim().ToUpper() == "POST" ? Method.POST : Method.GET);

            request.AddHeader("Content-Type", txtContentType.Text);
            request.AddHeader("Authorization", txtAuthorization.Text);
            request.AddParameter("application/json", jObjectbody, ParameterType.RequestBody);

                try
                {
                    var clientValue = client.Execute(request); //Make the call and populate the return variable

                    dynamic jObjectResult = JObject.Parse(clientValue.Content); //Pull the response (JSON data) into a dynamic object

                    var dataElement = jObjectResult.Data; //The data property is where the call's data is stored
                    qwert = dataElement;
                    int pageIndex = Convert.ToInt32(jObjectbody.SelectedPageIndex); //Get the current page index

                    if (dataElement.HasValues == false) //If the data element is empty then that means we have no more page data.
                    {
                        stop = true;
                    }
                    else
                    {
                        int result = ConvertTransactionHistoryJSONToSQLAndUploadToDatabase(clientValue.Content);

                        if (processBackwards)
                        {
                            pageIndex -= 1;

                            if (pageIndex < 0)
                            {
                                stop = true;
                            }
                        }
                        else
                        {
                            pageIndex += 1;
                        }
                        
                        ((JObject)jObjectbody)["SelectedPageIndex"] = pageIndex.ToString(); //Update the current page index so that the next loop will call for the next page.

                    }
                }
                catch(Exception perror)
                {
                    string q = Convert.ToString(jObjectbody);
                    string w = Convert.ToString(qwert);
                    Debug.WriteLine(perror.Message);
                }
            });

        }
    }
}
