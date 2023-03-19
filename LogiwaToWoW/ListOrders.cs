using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiwaToWoW
{
 class ListOrders
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Datum
        {
            public int ID { get; set; }
            public string Code { get; set; }
            public string PriorityID { get; set; }
            public string CustomerRefCode { get; set; }
            public string DepositorRefCode { get; set; }
            public string CustomerOrderNo { get; set; }
            public string DepositorOrderNo { get; set; }
            public List<int> WarehouseOrderStatusID { get; set; }
            public string WarehouseOrderStatusCode { get; set; }
            public int CustomerID { get; set; }
            public string CustomerCode { get; set; }
            public string CustomerDescription { get; set; }
            public int InventorySiteID { get; set; }
            public string InventorySiteCode { get; set; }
            public int WarehouseID { get; set; }
            public string WarehouseCode { get; set; }
            public string WarehouseDescription { get; set; }
            public int DepositorID { get; set; }
            public string DepositorCode { get; set; }
            public string DepositorDescription { get; set; }
            public object IsPrintCarrierLabelPackListAsLabel { get; set; }
            public object IsPrintCarrierLabelPackListOnSamePage { get; set; }
            public string CarrierTrackingNumber { get; set; }
            public int WarehouseOrderTypeID { get; set; }
            public string WarehouseOrderTypeCode { get; set; }
            public string OrderDate { get; set; }
            public object OrderDate_Start { get; set; }
            public object OrderDate_End { get; set; }
            public string PlannedDeliveryDate { get; set; }
            public object PlannedDeliveryDate_Start { get; set; }
            public object PlannedDeliveryDate_End { get; set; }
            public string PlannedShipDate { get; set; }
            public object PlannedShipDate_Start { get; set; }
            public object PlannedShipDate_End { get; set; }
            public string Notes { get; set; }
            public string IsDocumentExist { get; set; }
            public int PurchaseOrderID { get; set; }
            public string PurchaseOrderCode { get; set; }
            public object IsImported { get; set; }
            public object IsExported { get; set; }
            public object IsExported4 { get; set; }
            public object IsExported5 { get; set; }
            public object IsBackorder { get; set; }
            public int NofShipmentLabel { get; set; }
            public bool? IsAllocated { get; set; }
            public bool IsPickingStarted { get; set; }
            public bool IsPickingCompleted { get; set; }
            public int InvoiceCustomerID { get; set; }
            public int InvoiceCustomerPartyID { get; set; }
            public string InvoiceCustomerDescription { get; set; }
            public int InvoiceCustomerAddressID { get; set; }
            public string InvoiceCustomerAddressDescription { get; set; }
            public double TotalSalesGrossPrice { get; set; }
            public double TotalSalesVat { get; set; }
            public double TotalSalesDiscount { get; set; }
            public string Instructions { get; set; }
            public object AccountNumber { get; set; }
            public string Driver { get; set; }
            public string Platenumber { get; set; }
            public int BillingTypeID { get; set; }
            public string BillingTypeDescription { get; set; }
            public int RouteID { get; set; }
            public string RouteDescription { get; set; }
            public List<int> ChannelID { get; set; }
            public string ChannelDescription { get; set; }
            public object IsCancelRequested { get; set; }
            public List<int> CarrierID { get; set; }
            public string CarrierDescription { get; set; }
            public string IntegrationKey { get; set; }
            public string EnteredBy { get; set; }
            public string CanceledBy { get; set; }
            public int CarrierShippingOptionsID { get; set; }
            public int CarrierDepositorListID { get; set; }
            public int NofProducts { get; set; }
            public string StoreName { get; set; }
            public object LinkedChannelID { get; set; }
            public string LinkedChannelDescription { get; set; }
            public double CarrierRate { get; set; }
            public double CarrierMarkupRate { get; set; }
            public int CarrierPackageTypeID { get; set; }
            public List<DetailInfo> DetailInfo { get; set; }
            public int CustomerAddressID { get; set; }
            public string CustomerAddressDescription { get; set; }
            public string PlannedPickDate { get; set; }
            public string ActualPickDate { get; set; }
            public string ActualDeliveryDate { get; set; }
            public object ProjectID { get; set; }
            public string ProjectDescription { get; set; }
            public object WarehouseReceiptID { get; set; }
            public string WarehouseReceiptCode { get; set; }
            public object BackWarehouseOrderID { get; set; }
            public string BackWarehouseOrderCode { get; set; }
            public object DropShipMasterOrderID { get; set; }
            public string DropShipWarehouseOrderCode { get; set; }
            public object DropShipNotes { get; set; }
            public object IsWaybillPrinted { get; set; }
            public string InvoiceNo { get; set; }
            public string DeliveryNoteNo { get; set; }
            public bool IsCarrierLabelPrinted { get; set; }
            public string ChannelOrderCode { get; set; }
            public string CarrierWeight { get; set; }
            public object ClientPartyID { get; set; }
            public object POWindowWarehouseID { get; set; }
            public int? WareOrderCancelReasonID { get; set; }
            public string WareOrderCancelReasonDescription { get; set; }
            public object IsGift { get; set; }
            public string GiftNote { get; set; }
            public string OrderItems { get; set; }
            public string ExtraNotes { get; set; }
            public string ExtraNotes1 { get; set; }
            public string ExtraNotes2 { get; set; }
            public string ExtraNotes3 { get; set; }
            public string ExtraNotes4 { get; set; }
            public string ExtraNotes5 { get; set; }
            public int Priority { get; set; }
            public int FraudRecommendationID { get; set; }
            public object FraudRecommendationCode { get; set; }
            public string FraudRecommendationDescription { get; set; }
            public double OrderRiskScore { get; set; }
            public object IsExported2 { get; set; }
            public int ShipmentMethodID { get; set; }
            public string ShipmentMethodDescription { get; set; }
            public bool? IsAddressVerified { get; set; }
            public object AvaliableStockQuantity { get; set; }
            public string Store { get; set; }
            public int ChannelDepositorParameterID { get; set; }
            public int CarrierBillingTypeID { get; set; }
            public string CarrierBillingTypeDescription { get; set; }
            public bool? IsPickListPrinted { get; set; }
            public object IsPrimeOrder { get; set; }
            public string InvoiceDate { get; set; }
            public string EntryDateTime { get; set; }
            public object EntryDateTime_Start { get; set; }
            public object EntryDateTime_End { get; set; }
            public double CargoDiscount { get; set; }
            public int WarehouseOrdReturnReasonId { get; set; }
            public string WarehouseOrdReturnReasonDescription { get; set; }
            public string CompanyName { get; set; }
            public double TotalMarkupRate { get; set; }
            public double TotalCarrierRate { get; set; }
            public string ActualShipDate { get; set; }
            public object ActualShipDate_Start { get; set; }
            public object ActualShipDate_End { get; set; }
            public string PlannedPickupDate { get; set; }
            public object PlannedPickupDate_Start { get; set; }
            public object PlannedPickupDate_End { get; set; }
            public string CarrierShippingDescription { get; set; }
            public bool IsGetOrderDetails { get; set; }
            public string LastModifiedDate { get; set; }
            public object LastModifiedDate_Start { get; set; }
            public object LastModifiedDate_End { get; set; }
            public string CancellationDate { get; set; }
            public object CancellationDate_Start { get; set; }
            public object CancellationDate_End { get; set; }
            public string MasterWarehouseOrderCode { get; set; }
            public int PartyCarrierInfoID { get; set; }
            public object BusinessDaysInTransit { get; set; }
            public int SupplierID { get; set; }
            public int SupplierAddressID { get; set; }
            public object ReceiptOrderCode { get; set; }
            public object ReceiptDate { get; set; }
            public int WarehouseReceiptTypeID { get; set; }
            public bool isAutoGenerate { get; set; }
            public bool isUseSameLotNumber { get; set; }
            public object IsAllowChangingTaxAndDutiesPayor { get; set; }
            public bool IsGetCustomerAddressInfo { get; set; }
            public string CustomerEmail { get; set; }
            public string WarehouseDropShipOrderCode { get; set; }
            public string WarehouseBackOrderCode { get; set; }
            public string WarehouseMasterOrderCode { get; set; }
            public string WarehouseReceiptOrderCode { get; set; }
            public string WarehouseOrderOperationStatus { get; set; }
            public List<int> OrderCustomStatusID { get; set; }
            public object selectedOrder { get; set; }
            public List<string> Errors { get; set; }
            public bool Success { get; set; }
            public object SuccessMessage { get; set; }
            public bool IsExcelExport { get; set; }
            public int PageSize { get; set; }
            public int SelectedPageIndex { get; set; }
            public int PageCount { get; set; }
            public int RecordCount { get; set; }
        }

        public class DetailInfo
        {
            public int ID { get; set; }
            public string Code { get; set; }
            public int InventoryItemID { get; set; }
            public string InventoryItemDescription { get; set; }
            public string InventoryItemInfo { get; set; }
            public string Barcode { get; set; }
            public string DisplayMember { get; set; }
            public int InventoryItemPackTypeID { get; set; }
            public string InventoryItemPackTypeDescription { get; set; }
            public int PackQuantity { get; set; }
            public int WarehouseOrderID { get; set; }
            public double UnitWeight { get; set; }
            public double UnitVolume { get; set; }
            public double PACKIIPT_UnitWeight { get; set; }
            public int AllocatedCuQuantity { get; set; }
            public int PickedCuQuantity { get; set; }
            public int LoadedCuQuantity { get; set; }
            public int ShippedCuQuantity { get; set; }
            public int PlannedPackQuantity { get; set; }
            public int PlannedCuQuantity { get; set; }
            public int SortedCUQuantity { get; set; }
            public int PackedCUQuantity { get; set; }
            public int CancelledCuQuantity { get; set; }
            public string FreeAttr1 { get; set; }
            public string FreeAttr2 { get; set; }
            public string FreeAttr3 { get; set; }
            public double CurrencyPrice { get; set; }
            public double TaxRate { get; set; }
            public double NetCurrencyPrice { get; set; }
            public double TotalWeight { get; set; }
            public double TotalVolume { get; set; }
            public double LineWeight { get; set; }
            public int SupplierID { get; set; }
            public string SupplierDescription { get; set; }
            public string Notes1 { get; set; }
            public double SalesUnitPrice { get; set; }
            public string ChannelOrderDetailCode { get; set; }
            public List<string> Errors { get; set; }
            public bool Success { get; set; }
            public string SuccessMessage { get; set; }
            public bool IsExcelExport { get; set; }
            public int? PageSize { get; set; }
            public int? SelectedPageIndex { get; set; }
            public int? PageCount { get; set; }
            public int? RecordCount { get; set; }
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
