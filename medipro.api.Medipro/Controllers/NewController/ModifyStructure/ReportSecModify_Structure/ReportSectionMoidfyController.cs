using medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure;
using medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure.OrganizationMemberSectionModfy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http; 

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.ReportSecModify_Structure
{
    public class ReportSectionMoidfyController : ApiController
    {
        // registration report
        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/RegistrationReport")]
        public IHttpActionResult RegistraionRep()
        {
            RegistrationReportModify r = new RegistrationReportModify(); 

            r.RegReport();








            return Ok();

        }

        //sales summary 

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/SalesSummary")]
        public IHttpActionResult SalesSummary()
        {
            SalesSummayModify s = new SalesSummayModify();

            s.DropProc();
            s.SalesSummOpdBillGet();
            s.SalesDiscSumGet();
            s.SalesSummAmtGet();


            return Ok();

        }

        //opd sales summary 
        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/OpdSalesSummary")]
        public IHttpActionResult OpdSalesSummary()
        {
            OpdSalesSummaryModify o = new OpdSalesSummaryModify();
            o.DropProc();
            o.OpdSalesGet();
            o.OpdSalesGetTotal();


            return Ok();

        }


        //servicewise Sales Summary
        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/ServicewiseSalesSummary")]
        public IHttpActionResult ServSalesSummary()
        {
            ServicewiseSalesSummaryModify s = new ServicewiseSalesSummaryModify();
            s.DropProc();
            s.ServwiseSalesGet();
            s.ServwiseSalesGetSum();
            s.ServwiseSalesGetDue();


            return Ok();

        }


        //Service Divisionwise sales summary 

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/ServicedivisionSalesSummary")]
        public IHttpActionResult ServDivSalesSummary()
        {
            ServiceDivisionwiseSalesSummaryModify s = new ServiceDivisionwiseSalesSummaryModify();
            s.DropProc();
            s.ServDivSalesGet();
            s.ServDivSalesGetSum();


            return Ok();

        }


        //Service Divisionwise sales summary for lab


        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/ServicedivisionSalesSummaryForLab")]
        public IHttpActionResult ServDivSalesSmryLab()
        {
            ServiceDivisionwiseSalesSummaryForLabModify s = new ServiceDivisionwiseSalesSummaryForLabModify();
            s.DropProc();
            s.ServDivSalesForLab();
            s.ServDivSalesForLabSum();




            return Ok();

        }

        //service groupwise sales summary

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/ServiceGroupwiseSalesSummary")]
        public IHttpActionResult ServgrpwiseSalesSmry()
        {
            ServiceGroupwiseSalesSummaryModify s = new ServiceGroupwiseSalesSummaryModify();

            s.ServiceGroupWiseSalesByDate();
            s.ServiceGroupWiseSalesSum();
            s.ServiceGroupWiseSalesDue();


            return Ok();

        }








        //Member Sales Register

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/MemberSalesRegister")]
        public IHttpActionResult MemSalesReg()
        {
            MemberSalesRegisterModify m = new MemberSalesRegisterModify();

            m.MemSalesRegSelect();
            m.MemSalesRegSum();






            return Ok();

        }


        //patient history 


        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/PatientHistory")]
        public IHttpActionResult PatientHis()
        {
            PatientHistoryModify p = new PatientHistoryModify();
            p.DropProc();
            p.PatientHisHospidGet();
            p.PatientHisGet();
            p.PatientHisDis();
            p.PatientHisSum();


            return Ok();

        }


        //referer analysis

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/RefererAnalysis")]
        public IHttpActionResult RefAna()
        {
            RefererAnalysisModify r = new RefererAnalysisModify();
            r.DropProc();
            r.Tempopdrec();
            r.Tempopdbill();
            r.RefererAnaGet();
            r.RefererAnaGetSum();








            return Ok();

        }

        //credit invoice due clear reprot 

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/CreditInvoiceDueClearReprot")]
        public IHttpActionResult CdtInvDueRpt()
        {
            CreditInvoiceDueClearReportModify c = new CreditInvoiceDueClearReportModify();

            c.DropProc();
            c.CrtInvDueRpt();
            c.CrtInvDueRptSum();








            return Ok();

        }

        //cash register summary

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/CashRegisterSummary")]
        public IHttpActionResult CashRegSmry()
        {
            CashRegisterSummaryModify c = new CashRegisterSummaryModify();

            c.DropProc();
            c.ReceiptRegGet();
            c.ReceiptRegGetSum();


            return Ok();

        }


        //Referer Summary 

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/RefererSummary")]
        public IHttpActionResult RefSmry()
        {
            RefererSummaryModify r = new RefererSummaryModify();
            r.DropProc();
            r.RefererSelect();
            r.RefererSmryDetail();
            r.GrpwiseSelect();










            return Ok();

        }

        //Organization Member Section


        //Departmentwise Statement

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/OrganizationMemberSection/DeparmtentwiseStatment")]
        public IHttpActionResult DeptStatement()
        {
            DepartmentwiseStatementModify d = new DepartmentwiseStatementModify();


            d.DropProc();
            d.OrganizSelect();
            d.DeptSelect();
            d.DeptSelectByDate();



            return Ok();

        }






        //Organization Statement Summary 

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/OrganizationMemberSection/OrganizationStatementSummary")]
        public IHttpActionResult OrgSmry()
        {
            OrganizationStatementSummaryModify o = new OrganizationStatementSummaryModify();


            o.DropProc();
            o.OrganizSelect();
            o.OrgSmrySelect();
            o.OrgSmrySumSelect();








            return Ok();

        }


        //organization statement 

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/OrganizationMemberSection/OrganizationStatement")]
        public IHttpActionResult OrgStmnt()
        {
            OrganizationStatementModify o = new OrganizationStatementModify();


            o.DropProc();
            o.OrganizeSelect();
            o.OrgStmtMemSelect();
            o.OrgStmtSelect();




            return Ok();

        }


        //Organization Member Statement
        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/OrganizationMemberSection/OrganizationMemberStatement")]
        public IHttpActionResult OrgMemStmnt()
        {
            OrganizationMemberStatementModify o = new OrganizationMemberStatementModify();
            o.DropProc();
            o.OrganizSelect();
            o.OrgMemStmtGet();
            o.OrgMemStmtSumGet();










            return Ok();

        }


        //Member Statement
        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/OrganizationMemberSection/MemberStatement")]
        public IHttpActionResult MemStmnt()
        {
            MemberStatementModify m = new MemberStatementModify();

            m.DropProc();
            m.GetMember();
            m.DobToYear();


            return Ok();

        }


        //Organization department summary

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/OrganizationMemberSection/OrganizationDetartmentSummary")]
        public IHttpActionResult OrgDeptSmry()
        {
            OrganizationDepartmentSummaryModify o = new OrganizationDepartmentSummaryModify();

            o.DropProc();
            o.OrganizSelect();
            o.DeptSelect();
            o.OrgDeptSmrySelect();
            o.OrgDeptSmrySumSelect();


            return Ok();

        }

        //servicewise report

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/OrganizationMemberSection/ServicewiseReport")]
        public IHttpActionResult ServwiseReprot()
        {
            ServicewiseReprotModify s = new ServicewiseReprotModify();
            s.DropProc();
            s.ServRptServGet();
            s.ServwiseRptGet();






            return Ok();

        }


        //service center report

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/OrganizationMemberSection/ServiceCenterReport")]
        public IHttpActionResult ServCenterRpt()
        {
            ServiceCenterReprotModify s = new ServiceCenterReprotModify();

            s.GrpName();
            s.ServCenterRptGet();






            return Ok();

        }


        //opd service cash detail

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/OpdrecServiceCashDetail")]
        public IHttpActionResult OpdServCashDetail()
        {
            OpdServiceCashDetailModify o = new OpdServiceCashDetailModify();

            o.OpdrecCashDetailPost();
            o.OpdrecCashDetailSelect();
            o.OpdrecCashDetailSumSelect();
            o.OpdServDiscSum();






            return Ok();

        }


        //discount report

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/DiscountReport")]
        public IHttpActionResult DiscountReport()
        {
            DiscountReprotModify d = new DiscountReprotModify();

            d.DiscountGet();
            d.DiscountRptMemberGet();
            d.OpdDiscountRptGet();
            d.OpdDiscountRptSumGet();






            return Ok();

        }

        //patient record 

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/Patientrecord")]
        public IHttpActionResult PatientRecord()
        {
            PatientRecordModify p = new PatientRecordModify();
            p.DropProc();
            p.PatientRecMemGet();







            return Ok();

        }


        //Insurance live claim post

        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/InsuranceLiveClaim")]
        public IHttpActionResult InsLiveClaimPost()
        {
            InsuranceLiveClaimPostModify i = new InsuranceLiveClaimPostModify();
            i.InsuranceClaimPost();

            return Ok();

        }

        //referer pay slip type b
        [HttpGet]
        [Route("api/ModifyStructure/ReprotSection/RefererPaySlipTyprB")]
        public IHttpActionResult RefPaySlip()
        {
            RefererPaySlipTypeBModify r = new RefererPaySlipTypeBModify();
            r.TempRefererTemplateInsert();
            r.RefererPaySlipGetTemplate();
            r.TempRefererTemplateDelete();
            r.RefererPaySlipSelect();
            r.RefPaySlipTotal();

            return Ok();

        }


        //sales register
        [HttpGet] 
        [Route("api/ModifyStructure/ReprotSection/SalesRegister")]
        public IHttpActionResult SalesReg()
        {
            SalesRegisterModify s = new SalesRegisterModify();
            s.SalesRegDatewise();
            s.SalesRegInvwise();

            return Ok();

        }




    }
}
