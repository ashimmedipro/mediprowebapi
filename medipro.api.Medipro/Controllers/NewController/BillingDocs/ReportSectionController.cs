using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs;
using medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection.OpdRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs
{
    public class ReportSectionController : ApiController
    {
        //[HttpGet]
        //[Route("api/salesRegisterOpdrecGet")]
        //public IHttpActionResult GetSalesRegisterOpdrec(DateTime initdate, DateTime finaldate)
        //{
        //    var list = DapperHelper.QueryStoredProcedure<SalesRegisterOpdRecGet_dt>
        //        ("sp_SalesRegGetFromOpdRec", new { initdate = initdate, finaldate = finaldate }).ToList();
        //    return Ok(list);
        //}

            //sales register datewise with search

        [HttpGet]
        [Route("api/salesRegisterOpdBillGetbyDate")]
        public IHttpActionResult GetSalesRegisterOpdbillSearch(DateTime init, DateTime final,int firm, int ipdsave, int ipd,int val, 
            int refid, string initbilltime, string finalbilltime, int er, int discount,int canceled,int insurance, int salesbill,
            int returnbill, int paymode, int billmode, int morbidity,string search , int userid )
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<SalesRegisterOpdBillGet_dt>
                ("sp_SalesRegistrationbyDate", new {
                    init = init,
                    final = final,
                    firm=firm,
                     ipdsave=ipdsave,
                     ipd=ipd,
                     val=val,
                     refid=refid,
                     initbilltime=initbilltime,
                     finalbilltime=finalbilltime,
                    er=er,
                    discount=discount,
                    canceled=canceled,
                    insurance=insurance,
                    salesbill=salesbill,
                     returnbill=returnbill,
                    paymode=paymode,
                     billmode=billmode,
                     morbidity=morbidity,
                     search=search,
                     userid=userid
                }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //sales register datewise with search

        [HttpGet]
        [Route("api/salesRegisterOpdBillGetbyDate")]
        public IHttpActionResult GetSalesRegisterOpdbill(DateTime init, DateTime final, int firm, int ipdsave, int ipd, int val,
            int refid, string initbilltime, string finalbilltime, int er, int discount, int canceled, int insurance, int salesbill,
            int returnbill, int paymode, int billmode, int morbidity , int userid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<SalesRegisterOpdBillGet_dt>
                    ("sp_SalesRegistrationbyDate", new
                    {
                        init = init,
                        final = final,
                        firm = firm,
                        ipdsave = ipdsave,
                        ipd = ipd,
                        val = val,
                        refid = refid,
                        initbilltime = initbilltime,
                        finalbilltime = finalbilltime,
                        er = er,
                        discount = discount,
                        canceled = canceled,
                        insurance = insurance,
                        salesbill = salesbill,
                        returnbill = returnbill,
                        paymode = paymode,
                        billmode = billmode,
                        morbidity = morbidity,
                        search = "",
                        userid = userid
                    }).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //sales register invoicewise with search 

        [HttpGet]
        [Route("api/salesRegisterOpdBillGetbyInvoice")]
        public IHttpActionResult GetSalesRegisterOpdbillInvSearch(DateTime init, DateTime final, int firm, int ipdsave, int ipd, int val,
            int refid,  int er, int discount, int canceled, int insurance, int salesbill,
            int returnbill, int paymode, int billmode, int morbidity,string search, int userid, string start, string end)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<SalesRegisterOpdBillGet_dt>
                    ("sp_SalesRegistrationbyInvoice", new
                    {
                        init = init,
                        final = final,
                        firm = firm,
                        ipdsave = ipdsave,
                        ipd = ipd,
                        val = val,
                        refid = refid,
                        er = er,
                        discount = discount,
                        canceled = canceled,
                        insurance = insurance,
                        salesbill = salesbill,
                        returnbill = returnbill,
                        paymode = paymode,
                        billmode = billmode,
                        morbidity = morbidity,
                        search = "",
                        userid = userid,
                        start = start,
                        end = end
                    }).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //sales register invoicewise without search 

        [HttpGet]
        [Route("api/salesRegisterOpdBillGetbyInvoice")]
        public IHttpActionResult GetSalesRegisterOpdbillInv(DateTime init, DateTime final, int firm, int ipdsave, int ipd, int val,
            int refid, int er, int discount, int canceled, int insurance, int salesbill,
            int returnbill, int paymode, int billmode, int morbidity, int userid, string start, string end )
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<SalesRegisterOpdBillGet_dt>
                    ("sp_SalesRegistrationbyInvoice", new
                    {
                        init = init,
                        final = final,
                        firm = firm,
                        ipdsave = ipdsave,
                        ipd = ipd,
                        val = val,
                        refid = refid,
                        er = er,
                        discount = discount,
                        canceled = canceled,
                        insurance = insurance,
                        salesbill = salesbill,
                        returnbill = returnbill,
                        paymode = paymode,
                        billmode = billmode,
                        morbidity = morbidity,
                        search = "",
                        userid = userid,
                        start = start,
                        end = end 
                    }).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }




        //sales register datewise total
        //when search is passed 
        [HttpGet]
        [Route("salesRegisterOpdBillGetbyDate/Total")]
        public IHttpActionResult GetSalesRegTotalSearch(string search)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<SalesRegisterOpdBillTotal_dt>
                   ("sp_SalesRegisterTotal", new { search=search }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //when search is not passed 

        [HttpGet]
        [Route("salesRegisterOpdBillGetbyDate/Total")]
        public IHttpActionResult GetSalesRegTotalAll()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<SalesRegisterOpdBillTotal_dt>
                   ("sp_SalesRegisterTotal", new { search = "" }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }





        //sales summary 

        [HttpGet]
       [Route("api/salesSummaryOpdBillGet")]
       public IHttpActionResult GetSalesSummaryOpdbill(DateTime init, DateTime final)
        {
            try
            {

            
           var list = DapperHelper.QueryStoredProcedure<SalesSummaryOpdbillGet_dt>
              ("sp_SalesSummaryGetOpdbillByDate", new { init = init, final = final }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/salesSummaryDiscountSumGet")]
        public IHttpActionResult GetSalesSummaryDiscountSum(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<SalesSummaryDiscountSum_dt>
                ("sp_SalesSummaryGetDisSumByDate", new { init = init, final = final }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/salesSummarySumGet")]
        public IHttpActionResult GetSalesSummarySum(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<SalesSummarySum_dt>
                ("sp_SalesSummaryGetAmountSumByDate", new { init = init, final = final }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //opd sales summary 
        [HttpGet]
        [Route("api/OpdSalesSummaryGet")]
        public IHttpActionResult OpdSalesSummary(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OpdSalesSummary_dt>
                ("sp_OpdSalesSummaryGetbyDateRange", new { init = init, final = final, firm = firm }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpGet]
        [Route("api/OpdSalesSummaryTotalGet")]
        public IHttpActionResult OpdSalesSummaryTotal(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OpdSalesSumaryTotal_dt>
                ("sp_OpdSalesSummaryGetTotalbyDateRange", new { init = init, final = final, firm = firm }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }





        //
        //
        //

        //ServiceGroupwiseSales
        //with search 
        [HttpGet]
        [Route("api/ServiceGroupwiseSales")]
        public IHttpActionResult ServiceGroupwiseSalesSearch(DateTime init, DateTime final, int firm, int val, int ipd, int insurance,
            int refid, string initbilltime, string finalbilltime, int wardno, int orgid,string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServiceGroupwiseSales_dt>
                ("sp_ServiceGroupWiseSalesByDate", new { init = init, final = final, firm = firm,
                    val =val, ipd=ipd, insurance=insurance, refid=refid, initbilltime=initbilltime, finalbilltime=finalbilltime,
                    wardno=wardno, orgid=orgid, search = search }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //without search 
        [HttpGet]
        [Route("api/ServiceGroupwiseSales")]
        public IHttpActionResult ServiceGroupwiseSales(DateTime init, DateTime final, int firm, int val, int ipd, int insurance,
            int refid, string initbilltime, string finalbilltime, int wardno, int orgid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ServiceGroupwiseSales_dt>
                    ("sp_ServiceGroupWiseSalesByDate", new
                    {
                        init = init,
                        final = final,
                        firm = firm,
                        val = val,
                        ipd = ipd,
                        insurance = insurance,
                        refid = refid,
                        initbilltime = initbilltime,
                        finalbilltime = finalbilltime,
                        wardno = wardno,
                        orgid = orgid,
                        search = ""
                    }).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //sum with search
        [HttpGet]
        [Route("api/ServiceGroupwiseSalesSum")]
        public IHttpActionResult ServiceGroupwiseSalesSumSearch(DateTime init, DateTime final, int firm, int val, int ipd, int insurance,
            int refid, string initbilltime, string finalbilltime, int wardno, int orgid, string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServiceGroupwiseSalesSum_dt>
                ("sp_ServiceGroupWiseSalesSumByDate", new { init= init, final = final, firm = firm ,
                    val = val,
                    ipd = ipd,
                    insurance = insurance,
                    refid = refid,
                    initbilltime = initbilltime,
                    finalbilltime = finalbilltime,
                    wardno = wardno,
                    orgid = orgid,
                    search = search
                }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //sum without search
        [HttpGet]
        [Route("api/ServiceGroupwiseSalesSum")]
        public IHttpActionResult ServiceGroupwiseSalesSum(DateTime init, DateTime final, int firm, int val, int ipd, int insurance,
            int refid, string initbilltime, string finalbilltime, int wardno, int orgid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ServiceGroupwiseSalesSum_dt>
                    ("sp_ServiceGroupWiseSalesSumByDate", new
                    {
                        init = init,
                        final = final,
                        firm = firm,
                        val = val,
                        ipd = ipd,
                        insurance = insurance,
                        refid = refid,
                        initbilltime = initbilltime,
                        finalbilltime = finalbilltime,
                        wardno = wardno,
                        orgid = orgid,
                        search=""
                    }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //due with search
        [HttpGet]
        [Route("api/ServiceGroupwiseSalesDue")]
        public IHttpActionResult ServiceGroupwiseSalesDueSearch(DateTime init, DateTime final, int firm, int val, int ipd, int insurance,
            int refid,string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServiceGroupwiseSalesDue_dt>
                ("sp_ServiceGroupWiseSalesDuePaidByDate", new { init = init, final = final, firm = firm,
                    val = val,
                    ipd = ipd,
                    insurance = insurance,
                    refid = refid,
                    search=search
                }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //due without search
        [HttpGet]
        [Route("api/ServiceGroupwiseSalesDue")]
        public IHttpActionResult ServiceGroupwiseSalesDue(DateTime init, DateTime final, int firm, int val, int ipd, int insurance,
            int refid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ServiceGroupwiseSalesDue_dt>
                    ("sp_ServiceGroupWiseSalesDuePaidByDate", new
                    {
                        init = init,
                        final = final,
                        firm = firm,
                        val = val,
                        ipd = ipd,
                        insurance = insurance,
                        refid = refid,
                        search = ""
                    }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/PatientCount")]
        public IHttpActionResult patientCount(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServiceGroupwisePatientCount_dt>
                ("sp_OpdrecHospidCount", new
                {
                    init = init,
                    final = final,
                    firm = firm,
                }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }




        // ServiceDivisionwiseSales

            //with search

        [HttpGet]
        [Route("api/ServiceDivisionwiseSales")]
        public IHttpActionResult ServiceDividionwiseSalesSearch(DateTime init, DateTime final, int firm, int ipd, int insurance, 
            string initbilltime, string finalbilltime, string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServiceDivisionwiseSales_dt>
                ("sp_ServiceDivisionwiseSalesGetByDate", new { init = init, final = final, firm= firm, ipd=ipd,
                    insurance =insurance, initbilltime=initbilltime, finalbilltime=finalbilltime, search=search }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //without search

        [HttpGet]
        [Route("api/ServiceDivisionwiseSales")]
        public IHttpActionResult ServiceDividionwiseSales(DateTime init, DateTime final, int firm, int ipd, int insurance,
            string initbilltime, string finalbilltime)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ServiceDivisionwiseSales_dt>
                    ("sp_ServiceDivisionwiseSalesGetByDate", new
                    {
                        init = init,
                        final = final,
                        firm = firm,
                        ipd = ipd,
                        insurance = insurance,
                        initbilltime = initbilltime,
                        finalbilltime = finalbilltime,
                        search = ""
                    }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //sum with search 
        [HttpGet]
        [Route("api/ServiceDivisionwiseSalesSum")]
        public IHttpActionResult ServiceDividionwiseSalesSumSearch(DateTime init, DateTime final, int firm, int ipd, int insurance,
            string initbilltime, string finalbilltime, string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServiceDivisonwiseSalesSum_dt>
                ("sp_ServiceDivisionwiseSalesGetSumByDate", new { init = init, final = final,
                    firm = firm,
                    ipd = ipd,
                    insurance = insurance,
                    initbilltime = initbilltime,
                    finalbilltime = finalbilltime,
                    search=search
                }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //sum without search 
        [HttpGet]
        [Route("api/ServiceDivisionwiseSalesSum")]
        public IHttpActionResult ServiceDividionwiseSalesSum(DateTime init, DateTime final, int firm, int ipd, int insurance,
            string initbilltime, string finalbilltime)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ServiceDivisonwiseSalesSum_dt>
                    ("sp_ServiceDivisionwiseSalesGetSumByDate", new
                    {
                        init = init,
                        final = final,
                        firm = firm,
                        ipd = ipd,
                        insurance = insurance,
                        initbilltime = initbilltime,
                        finalbilltime = finalbilltime,
                        search = ""
                    }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //DISOCOUNT REPORT


            //with search

        [HttpGet]
        [Route("api/DiscountReport/DiscountSelect")]
        public IHttpActionResult DiscountSelectSearch(string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DiscountGet_dt>
                ("sp_DiscountSelect",new { search=search}).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //without search

        [HttpGet]
        [Route("api/DiscountReport/DiscountSelect")]
        public IHttpActionResult DiscountSelect()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<DiscountGet_dt>
                    ("sp_DiscountSelect", new { search=""}).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }



        //with search
        [HttpGet]
        [Route("api/DiscountReport/MemberSelect")]
        public IHttpActionResult MemberSearch(string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DiscRepMemberSelect_dt>
                ("sp_DiscountReportMemberSelect", new { search=search}).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //without search
        [HttpGet]
        [Route("api/DiscountReport/MemberSelect")]
        public IHttpActionResult MemberSelect()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<DiscRepMemberSelect_dt>
                    ("sp_DiscountReportMemberSelect", new { search = "" }).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpGet]
        [Route("api/DiscountReport/OpdDiscountReport")]
        public IHttpActionResult OpdDiscRep(DateTime init, DateTime final, int firm, int scheme, int hospid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OpdDiscReport_dt>
                ("sp_opdDiscountReport", new { init = init, final = final, firm = firm , scheme=scheme, hospid=hospid}).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //get disc by daterange
        [HttpGet]
        [Route("api/DiscountReport/DiscountByDateRange")]
        public IHttpActionResult DiscByDateRange(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DiscByDateRange_dt>
                ("sp_DiscountReportByDate", new { init = init, final=final, firm=firm }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //get opd disc sum  by daterange
        [HttpGet]
        [Route("api/DiscountReport/OpdDiscountSumByDateRange")]
        public IHttpActionResult OpdDiscByDateRangeSum(DateTime init, DateTime final, int firm , int scheme, int hospid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OpdDiscSumByDateRange_dt>
                ("sp_opdDiscountReportSum", new { init = init, final = final, firm = firm , scheme=scheme, hospid=hospid}).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }





        //patient history


        [HttpGet]
        [Route("api/PatientHistory")]
        public IHttpActionResult PatientHistory(DateTime init, DateTime final, int firm, int hospid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<PatientHistory_dt>
                ("sp_PatientHistoryGetByDate", new { init = init, final = final, firm = firm, hospid = hospid }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpGet]
        [Route("api/PatientHistoryDiscount")]
        public IHttpActionResult PatientHistoryDis(DateTime init, DateTime final, int firm, int hospid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<PatientHistoryDiscount_dt>
                ("sp_PatientHistoryDiscountByDate", new { init = init, final = final, firm = firm, hospid = hospid }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/PatientHistorySum")]
        public IHttpActionResult PatientHistorySum(DateTime init, DateTime final, int firm, int hospid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<PatientHistorySum_dt>
                ("sp_PatientHistorySumByDate", new { init = init, final = final, firm = firm, hospid = hospid }).ToList();
            return Ok(list);


            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //with search
        [HttpGet]
        [Route("api/PatientHistory/MemberSelect")]
        public IHttpActionResult PatientHisMemberSearch(string search)
        {
            try
            {
                
            
            
            var list = DapperHelper.QueryStoredProcedure<DiscRepMemberSelect_dt>
                ("sp_PatientHistoryHospidSelect", new {search=search}).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //without search
        [HttpGet]
        [Route("api/PatientHistory/MemberSelect")]
        public IHttpActionResult PatientHisMemberSelect()
        {
            try
            {



                var list = DapperHelper.QueryStoredProcedure<DiscRepMemberSelect_dt>
                    ("sp_PatientHistoryHospidSelect", new { search = "" }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }



        //Cash Register 

        //with search
        [HttpGet]
        [Route("api/CashRegisterSummary")]
        public IHttpActionResult CashRegisterSummarysearch(DateTime init, DateTime final, int firm, int ipd, string due, string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CashRegisterSummary_dt>
                ("sp_ReceiptRegGetByDate", new { init = init, final = final, firm = firm, ipd=ipd, due=due, search=search }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //without search
        [HttpGet]
        [Route("api/CashRegisterSummary")]
        public IHttpActionResult CashRegisterSummary(DateTime init, DateTime final, int firm, int ipd, string due)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<CashRegisterSummary_dt>
                    ("sp_ReceiptRegGetByDate", new { init = init, final = final, firm = firm, ipd = ipd, due = due, search = "" }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/CashRegisterSummarySum")]
        public IHttpActionResult CashRegisterSummarySum(DateTime init, DateTime final, int firm, int ipd, string due)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CashRegisterSummarySum_dt>
                ("sp_ReceiptRegSumGetByDate", new { init = init, final = final, firm = firm, ipd = ipd, due = due }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }



        // 
        //
        //

//--------------------------------------------------------------REFERER ANALYSIS
        //referer analysis 
        //with search param report and total

        [HttpGet]
        [Route("api/RefererAnalysis")]
        public IHttpActionResult RefererAnalysisSearch(DateTime init, DateTime final, int firm, int ipd, int insurance, int val, int userid, string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<RefererAnalysis_dt>
                ("sp_RefererAnalysisGetByDate", new {
                    init = init,
                    final = final,
                    firm = firm ,
                    ipd =ipd,
                    insurance =insurance,
                    val = val,
                    userid = userid,
                    search=search
                }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpGet]
        [Route("api/RefererAnalysisSum")]
        public IHttpActionResult RefererAnalysisSumSearch(DateTime init, DateTime final, int firm, int ipd, int insurance, int val, string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<RefererAnalysisSum_dt>
                ("sp_RefererAnalysisSumGetByDate", new
                {
                    init = init,
                    final = final,
                    firm = firm,
                    ipd = ipd,
                    insurance = insurance,
                    val = val,
                    search=search

                }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }



        //without search param report and total

        [HttpGet]
        [Route("api/RefererAnalysis")]
        public IHttpActionResult RefererAnalysis(DateTime init, DateTime final, int firm, int ipd, int insurance, int val, int userid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<RefererAnalysis_dt>
                    ("sp_RefererAnalysisGetByDate", new
                    {
                        init = init,
                        final = final,
                        firm = firm,
                        ipd = ipd,
                        insurance = insurance,
                        val = val,
                        userid = userid,
                        search = ""
                    }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpGet]
        [Route("api/RefererAnalysisSum")]
        public IHttpActionResult RefererAnalysisSum(DateTime init, DateTime final, int firm, int ipd, int insurance, int val)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<RefererAnalysisSum_dt>
                    ("sp_RefererAnalysisSumGetByDate", new
                    {
                        init = init,
                        final = final,
                        firm = firm,
                        ipd = ipd,
                        insurance = insurance,
                        val = val,
                        search = ""

                    }).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }




        //--------------------------------------------------------------------========

        //referer summary
        //with search
        [HttpGet]
        [Route("api/RefererSelect")]
        public IHttpActionResult RefererSearch(string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<RefererSelect_dt>
                ("sp_RefererSpecialitySelect", new { search=search}).ToList();//
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //without search
        [HttpGet]
        [Route("api/RefererSelect")]
        public IHttpActionResult RefererSelect()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<RefererSelect_dt>
                ("sp_RefererSpecialitySelect", new { search = "" }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/RefererSummary")]
        public IHttpActionResult RefererSummary(DateTime init, DateTime final,int refid,  int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<RefererSummary_dt>
                ("sp_RefererSummaryGetDetailbyDate", new { init = init, final = final, refid=refid ,firm = firm }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/RefererSummary/Groupwise")]
        public IHttpActionResult RefererSummaryGroupwise(int refid, DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<RefererSummaryGrpwise_dt>
                ("sp_RefererSummaryGetGroupwisebyDateRange", new { refid = refid, init = init, final= final, firm = firm }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //Referrer Pay Slip Type B

        //same procs used in referer dist post type 2 except delete templete 

        //delete template

        [HttpPost]
        [Route("api/RefererPaytSlipTypeBDelete")]
        public IHttpActionResult Delete(RefererPaytSlipTypeBDelete_dt model)
        {
            try
            {
                DapperHelper.ExecuteStoredProcedure("sp_temp_RefererTemplateSearchDelete", model);
                return Ok();
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }

        }



        //servicewise
        //with search param
        [HttpGet]
        [Route("api/ServicewiseSalesSummary")]
        public IHttpActionResult ServicewiseSalesSummarySearch(DateTime init, DateTime final, int firm,
            int val, int ipd,int insurance,int refid, int initbilltime, int finalbilltime, int er, string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServicewiseSalesSummary_dt>
                ("sp_ServicewiseSalesGetByDate", new { init = init, final = final,
                firm=firm,
                val=val,
                ipd=ipd,
                insurance=insurance,
                refid=refid,
                initbilltime=initbilltime,
                finalbilltime=finalbilltime,
                er=er,
                search = search

                }
                ).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //without search param
        [HttpGet]
        [Route("api/ServicewiseSalesSummary")]
        public IHttpActionResult ServicewiseSalesSummary(DateTime init, DateTime final, int firm,
            int val, int ipd, int insurance, int refid, string initbilltime, string finalbilltime, int er)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ServicewiseSalesSummary_dt>
                    ("sp_ServicewiseSalesGetByDate", new
                    {
                        init = init,
                        final = final,
                        firm = firm,
                        val = val,
                        ipd = ipd,
                        insurance = insurance,
                        refid = refid,
                        initbilltime = initbilltime,
                        finalbilltime = finalbilltime,
                        er = er,
                        search = ""

                    }
                    ).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpGet]
        [Route("api/ServicewiseSalesSummarySum")]
        public IHttpActionResult ServicewiseSalesSummarySum(DateTime init, DateTime final, int firm,
            int val, int ipd, int insurance, int refid, string initbilltime, string finalbilltime, int er)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServicewiseSalesSum_dt>
                ("sp_ServicewiseSalesGetSum", new { init = init, final = final,
                    firm = firm,
                    val = val,
                    ipd = ipd,
                    insurance = insurance,
                    refid = refid,
                    initbilltime = initbilltime,
                    finalbilltime = finalbilltime,
                    er=er
                }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/ServicewiseSalesSummaryDuePaid")]
        public IHttpActionResult ServicewiseSalesSummaryDuePaid(DateTime init, DateTime final, int firm,
            int val, int ipd, int insurance, int refid,  int er)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServiceSalesDuePaid_dt>
                ("sp_ServiceSalesGetDue", new { init = init, final = final,
                    firm = firm,
                    val = val,
                    ipd = ipd,
                    insurance = insurance,
                    refid = refid,
                    er = er
                }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //General Health Screen Reprot 

        [HttpGet]
        [Route("api/ReportSection/GeneralHealthScreenReprotSelect")]
        public IHttpActionResult GeneralHealthScreenReprotSelect(DateTime init, DateTime final,string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<GeneralHealthScreenReport_dt>
                ("sp_GeneralHealthScreenReportReport", new
                {
                    init = init,
                    final = final,
                    search=search

                }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/ReportSection/GeneralHealthScreenReprotSelect")]
        public IHttpActionResult GeneralHealthScreenReprotSelectbySearch(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<GeneralHealthScreenReport_dt>
                ("sp_GeneralHealthScreenReportReport", new
                {
                    init = init,
                    final = final,
                    search = ""

                }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }



        //Opd Service Cash Detail

        [HttpPost]
        [Route("api/ReportSection/OpdServiceCashDetailInsert")]
        public IHttpActionResult Post(OpdServiceCashDetailInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("temp_opdrecCashDetailInsert", model);
            return Ok();
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/ReportSection/OpdServiceCashDetailSelect")]
        public IHttpActionResult OpdServiceCashDetailSelect(int userid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OpdServiceCashDetailSelect_dt>
                ("temp_opdrecCashDetailSelect", new
                {
                   userid=userid

                }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpGet]
        [Route("api/ReportSection/OpdServiceCashDetailSum")]
        public IHttpActionResult OpdServiceCashDetailSum(int userid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OpdServCashDetailSum_dt>
                ("temp_opdrecCashDetailSelectSum", new
                {
                    userid = userid

                }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/ReportSection/OpdServiceDiscountAndSalesSum")]
        public IHttpActionResult OpdServDiscSalesSum(DateTime init, DateTime final, int firm)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<OpdServDiscServSum_dt>
                    ("sp_OpdServiceDiscountandSalesSum", new
                    {
                        init = init,
                        final=final,
                        firm=firm

                    }).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }





        //Organization Member Section 
        //Organization Statement
        //with search

        [HttpGet]
        [Route("api/ReportSection/OrganizSelect")]
        public IHttpActionResult OrganizSelectSearch(string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OrganizSelect_dt>
                ("sp_OrganizeSelect", new { search = search }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //without search

        [HttpGet]
        [Route("api/ReportSection/OrganizSelect")]
        public IHttpActionResult OrganizSelect()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<OrganizSelect_dt>
                    ("sp_OrganizeSelect", new { search = "" }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/ReportSection/OrganizationStatementMemberSelect")]
        public IHttpActionResult OrganizeMemberSelect(DateTime init, DateTime final, int orgid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OrganizMemberSelect_dt>
                ("sp_OrganizationStatementMemberSelect", new { init=init, final=final, orgid=orgid}).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }


        }

//--
        [HttpGet]
        [Route("api/ReportSection/OrganizationStatementSelect")]
        public IHttpActionResult OrganizeSelect(int hospid,DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OrganizSelectDateRange_dt>
                ("sp_OrganizationStatementSelectByDateRange", new { hospid = hospid, init = init, final = final }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }


        }


        [HttpGet]
        [Route("api/ReportSection/OrganizationStatementSelect")]
        public IHttpActionResult OrganizeSelect1( DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OrganizSelectDateRange_dt>
                ("sp_OrganizationStatementSelectByDateRange", new { hospid = "", init = init, final = final }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }
//--
        //organization statement summary 

        [HttpGet]
        [Route("api/ReportSection/OrganizationStatementSummarySelect")]
        public IHttpActionResult OrganizeSelectSummary( DateTime init, DateTime final, int orgid )
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OrganizeSummarySelect_dt>
                ("sp_OrganizSummaryGroupSelect", new { init = init, final = final, orgid = orgid }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/ReportSection/OrganizationStatementSummarySumSelect")]
        public IHttpActionResult OrganizeSelectSummarySum(DateTime init, DateTime final, int orgid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OrganizeSummarySumSelect_dt>
                ("sp_OrganizSummaryGroupSumSelect", new { init = init, final = final, orgid = orgid }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //organization dpt summary

        [HttpGet]
        [Route("api/DepartmentSelect")]
        public IHttpActionResult OrganizeDeptSelectSummary(int orgid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DeptSelect_dt>
                ("sp_DeptSelectbyOrgid", new { orgid = orgid }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }



        [HttpGet]
        [Route("api/ReportSection/OrganizationDepartmentSummarySelect")]
        public IHttpActionResult OrganizeDeptSelectSummary(int orgid,int dptid,  DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OrganizeSummarySelect_dt>
                ("sp_OrgDeptSmrySelectByDateRange", new { orgid = orgid, dptid=dptid ,init = init, final = final  }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/ReportSection/OrganizationDepartmentSummarySumSelect")]
        public IHttpActionResult OrganizeDeptSelectSummarySum(int orgid, int dptid,DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OrganizeSummarySumSelect_dt>
                ("sp_OrgDeptSmrySumSelectByDateRange", new { orgid = orgid, dptid = dptid, init = init, final = final }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //organization member statement 

        [HttpGet]
        [Route("api/ReportSection/OrganizationMemberStatementSelect")]
        public IHttpActionResult OrgMemberStatement(DateTime init, DateTime final, int orgid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OrgMemberStatementSelect_dt>
                ("sp_OrgMemberStatementDateRangeGet", new { init = init, final = final , orgid = orgid }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/ReportSection/OrganizationMemberStatementSumSelect")]
        public IHttpActionResult OrgMemberStatementSum(DateTime init, DateTime final, int orgid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OrgMemberStatementSumSelect_dt>
                ("sp_OrgMemberStatementSumDateRangeGet", new { init = init, final = final, orgid = orgid }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //Departmentwise Statement 

        [HttpGet]
        [Route("api/ReportSection/DepartmentwiseStatementSelect")]
        public IHttpActionResult DeptwiseStatementSelect(int hospid, DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DptwiseStatementSelect_dt>
                ("sp_DeptWiseStmtDateRangeSelect", new { hospid=hospid , init = init, final = final}).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //without passing hospid
        [HttpGet]
        [Route("api/ReportSection/DepartmentwiseStatementSelect")]
        public IHttpActionResult DeptwiseStatementSelect1( DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DptwiseStatementSelect_dt>
                ("sp_DeptWiseStmtDateRangeSelect", new { hospid = "", init = init, final = final }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //Member Statement
        //with search
        [HttpGet]
        [Route("api/ReportSection/MemberStatementSelect")]
        public IHttpActionResult MemberStatementSelectSearch(string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<MemberStmtSelect_dt>
                ("sp_MemberStatemtGetMember", new { search = search}).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //without search
        [HttpGet]
        [Route("api/ReportSection/MemberStatementSelect")]
        public IHttpActionResult MemberStatementSelect()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<MemberStmtSelect_dt>
                    ("sp_MemberStatemtGetMember", new { search = "" }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/DobToYear")]
        public IHttpActionResult dobToYear(DateTime date)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DobToYear_dt>
                ("sp_dob2year", new { date=date}).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/ReportSection/OrganizationMemberReport")]
        public IHttpActionResult OrgMemReport(DateTime init, DateTime final, int hospid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OrgMemberReport_dt>
                ("sp_OrganizationMemberReport", new { init=init, final=final, hospid=hospid}).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //without hospid

        [HttpGet]
        [Route("api/ReportSection/OrganizationMemberReport")]
        public IHttpActionResult OrgMemReport1(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OrgMemberReport_dt>
                ("sp_OrganizationMemberReport", new { init = init, final = final, hospid ="" }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/ReportSection/OrganizationMemberReportSummary")]
        public IHttpActionResult OrgMemReportSummary(DateTime init, DateTime final, int hospid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OrgMemberReportSummary_dt>
                ("sp_OrganizationMemberReportSummary", new { init = init, final = final, hospid = hospid }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //without hospid
        [HttpGet]
        [Route("api/ReportSection/OrganizationMemberReportSummary")]
        public IHttpActionResult OrgMemReportSummary1(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OrgMemberReportSummary_dt>
                ("sp_OrganizationMemberReportSummary", new { init = init, final = final, hospid = "" }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //servicewise report

            //with search 

        [HttpGet]
        [Route("api/ReportSection/ServiceWise/ServiceGet")]
        public IHttpActionResult ServiceGetSearch(string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<servwiseRptServieGet_dt>
                ("ServiceRptServGet", new { search=search}).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //without search 

        [HttpGet]
        [Route("api/ReportSection/ServiceWise/ServiceGet")]
        public IHttpActionResult ServiceGet()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<servwiseRptServieGet_dt>
                    ("ServwiseRptServGet", new { search = "" }).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }



        [HttpGet]
        [Route("api/ReportSection/ServiceWiseGet")]
        public IHttpActionResult ServiceWiseGet(int servid, DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServicewiseReportGet_dt>
                ("sp_ServiceRptGetByDateRange", new { servid=servid, init=init, final=final}).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //service center report

        [HttpGet]
        [Route("api/ReportSection/ServiceCenterReprotSelect")]
        public IHttpActionResult ServCenterRep(DateTime init, DateTime final, int grpid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServCenterRepSelect_dt>
                ("sp_ServCenterRepGetByDateRange", new {  init = init, final = final, grpid=grpid }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //insurance live claim post 

        [HttpGet]
        [Route("api/ReportSection/InsuranceLiveClaimPost")]
        public IHttpActionResult InsClaimPost(DateTime init, DateTime final, string policyid,
            bool ipd, bool ssf, int posted, string claim_code, string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<SsfPatientSalesList_dt>
                ("sp_SSFPatientSalesList", new { init = init, final = final,
                    policyid = policyid, ipd= ipd, ssf=ssf, posted=posted,
                    claim_code =claim_code, search=search }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpGet]
        [Route("api/ReportSection/InsuranceLiveClaimPost")]
        public IHttpActionResult InsClaimPost1(DateTime init, DateTime final, string policyid,
    bool ipd, bool ssf, int posted, string claim_code)
        {
            try
            {
            

            var list = DapperHelper.QueryStoredProcedure<SsfPatientSalesList_dt>
                ("sp_SSFPatientSalesList", new
                {
                    init = init,
                    final = final,
                    policyid = policyid,
                    ipd = ipd,
                    ssf = ssf,
                    posted = posted,
                    claim_code = claim_code,
                    search = ""
                }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //registration report 
        //with search

        [HttpGet]
        [Route("api/ReportSection/RegistrationReportSelect")]
        public IHttpActionResult RegRepSelect(DateTime init, DateTime final, string search, string type, int userid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<RegSelect_dt>
                ("sp_registrationSelect", new
                {
                    init = init,
                    final = final,
                    search = search,
                    type = type,
                    userid=userid
                }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }
        //without search
        [HttpGet]
        [Route("api/ReportSection/RegistrationReportSelect")]
        public IHttpActionResult RegRepSelect1(DateTime init, DateTime final, string type, int userid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<RegSelect_dt>
                ("sp_registrationSelect", new
                {
                    init = init,
                    final = final,
                    search = "",
                    type = type,
                    userid = userid
                }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //sales materalized view

        [HttpGet]
        [Route("api/ReportSection/SalesMateralizedView")]
        public IHttpActionResult opdbillGetView(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<opdbillViewGet_dt>
                ("sp_OPDBIll_ViewSelect", new
                {
                    init = init,
                    final = final,
                    firm=firm
                    

                }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //Service-Divisionwise Sales Summary For Lab
        //with search

        [HttpGet]
        [Route("api/ReportSection/ServiceDivisionwiseSalesLabSelect")]
        public IHttpActionResult ServDivLabSearch(DateTime init, DateTime final, int firm, int ipd,
            int insurance, string initbilltime, string finalbilltime, string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServdivSalesLabGet_dt>
                ("sp_ServiceDivisionwiseLabSales", new
                {
                    init = init,
                    final = final,
                    firm = firm,
                    ipd=ipd,
                    insurance=insurance,
                    initbilltime=initbilltime,
                    finalbilltime=finalbilltime,
                    search=search

                }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //without search

        [HttpGet]
        [Route("api/ReportSection/ServiceDivisionwiseSalesLabSelect")]
        public IHttpActionResult ServDivLabGet(DateTime init, DateTime final, int firm, int ipd,
            int insurance, string initbilltime, string finalbilltime)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ServdivSalesLabGet_dt>
                    ("sp_ServiceDivisionwiseLabSales", new
                    {
                        init = init,
                        final = final,
                        firm = firm,
                        ipd = ipd,
                        insurance = insurance,
                        initbilltime = initbilltime,
                        finalbilltime = finalbilltime,
                        search=""

                    }).ToList();
                return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //total with search
        [HttpGet]
        [Route("api/ReportSection/ServiceDivisionwiseSalesLabTotalSelect")]
        public IHttpActionResult ServDivLabTotalSearch(DateTime init, DateTime final, int firm, int ipd,
    int insurance, string initbilltime, string finalbilltime, string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServdivSalesLabTotalGet_dt>
                ("sp_ServiceDivisionwiseLabSalesSum", new
                {
                    init = init,
                    final = final,
                    firm = firm,
                    ipd = ipd,
                    insurance = insurance,
                    initbilltime = initbilltime,
                    finalbilltime = finalbilltime,
                    search=search

                }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //total without search
        [HttpGet]
        [Route("api/ReportSection/ServiceDivisionwiseSalesLabTotalSelect")]
        public IHttpActionResult ServDivLabTotalGet(DateTime init, DateTime final, int firm, int ipd,
    int insurance, string initbilltime, string finalbilltime)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ServdivSalesLabTotalGet_dt>
                    ("sp_ServiceDivisionwiseLabSalesSum", new
                    {
                        init = init,
                        final = final,
                        firm = firm,
                        ipd = ipd,
                        insurance = insurance,
                        initbilltime = initbilltime,
                        finalbilltime = finalbilltime,
                        search = ""

                    }).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //service groupwise analysis

        [HttpGet]
        [Route("api/ReportSection/ServiceGroupwiseAnalysisGet")]
        public IHttpActionResult ServGrpAnalysisGet(DateTime init, DateTime final, int ipd, int opd, int wardno, int dp_id,
            bool er, int orgid  )
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServGrpWiseDetailGet_dt>
                ("sp_ServiceGroupwiseSummary", new
                {
                    init = init,
                    final = final,
                    ipd=ipd,
                    opd=opd,
                    wardno=wardno,
                    dp_id=dp_id,
                    er=er,
                    orgid=orgid


                }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //Member Sales Register 

        [HttpGet]
        [Route("api/ReportSection/MemberSalesRegisterGet")]
        public IHttpActionResult MemSalesRegGet(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<MemberSalesRegGet_dt>
                ("sp_MemberSalesRegisterSelect", new
                {
                    init = init,
                    final = final,
                    firm = firm

                }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/ReportSection/MemberSalesRegisterGetTotal")]
        public IHttpActionResult MemSalesRegGetSum(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<MemSalesRegSumGet_dt>
                ("sp_MemberSalesRegisterSum", new
                {
                    init = init,
                    final = final,
                    firm = firm

                }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //   //Credit Invoice Due Clear Report

            //with search

        [HttpGet]
        [Route("api/ReportSection/CreditInvoiceDueClearReportGet")]
        public IHttpActionResult CrtInvDueGetSearch(DateTime init, DateTime final, string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CdtInvDueClearRptGet_dt>
                ("sp_CreditInvoiceDueClearReportSelect", new
                {
                    init = init,
                    final = final,
                    search=search
                    

                }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //without search

        [HttpGet]
        [Route("api/ReportSection/CreditInvoiceDueClearReportGet")]
        public IHttpActionResult CrtInvDueGet(DateTime init, DateTime final)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<CdtInvDueClearRptGet_dt>
                    ("sp_CreditInvoiceDueClearReportSelect", new
                    {
                        init = init,
                        final = final,
                        search = ""


                    }).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //sum with search
        [HttpGet]
        [Route("api/ReportSection/CreditInvoiceDueClearReportGetSum")]
        public IHttpActionResult CrtInvDueGetSumSearch(DateTime init, DateTime final, string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CdtInvDueClearRptGetTotalt_dt>
                ("sp_CreditInvoiceDueClearReportSum", new
                {
                    init = init,
                    final = final,
                    search=search


                }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //sum without search
        [HttpGet]
        [Route("api/ReportSection/CreditInvoiceDueClearReportGetSum")]
        public IHttpActionResult CrtInvDueGetSum(DateTime init, DateTime final)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<CdtInvDueClearRptGetTotalt_dt>
                    ("sp_CreditInvoiceDueClearReportSum", new
                    {
                        init = init,
                        final = final,
                        search = ""


                    }).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        //patient Record 
        //with search

        [HttpGet]
        [Route("api/ReportSection/PatientRecord/MemberSelect")]
        public IHttpActionResult MemSelectSearch(string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<PatientRecMemberGet_dt>
                ("sp_PatientRecMemberGet",new { search=search}).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        //without search

        [HttpGet]
        [Route("api/ReportSection/PatientRecord/MemberSelect")]
        public IHttpActionResult MemSelect()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<PatientRecMemberGet_dt>
                    ("sp_PatientRecMemberGet", new { search = "" }).ToList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpGet]
        [Route("api/ReportSection/PatientRecord/MemberOpdRecSelect")]
        public IHttpActionResult MemopdRecSelect(int hospid, DateTime init, DateTime final, int firm)
        {
            try
            {

            

            var list = DapperHelper.QueryStoredProcedure<MemOpdRecGet_dt>
                ("sp_MemberOPDRecrod", new { hospid = hospid, init = init, final=final, firm=firm }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/ReportSection/PatientRecord/MemberPharmaSelect")]
        public IHttpActionResult MemPharmaSelect(int hospid, DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<MemPharmaRecGet_dt>
                ("sp_MemberPharmacyRecrod", new { hospid = hospid, init = init, final = final, firm = firm }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/ReportSection/PatientRecord/ServiceVsPatientGet")]
        public IHttpActionResult ServVsPatientGet(int hospid, DateTime init, DateTime final, int firm)
        {
            try {
            
            var list = DapperHelper.QueryStoredProcedure<ServiceVsPatientGet_dt>
                ("sp_ServiceVsPatient", new { hospid = hospid, init = init, final = final, firm = firm }).ToList();
            return Ok(list);
            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


    }
}
