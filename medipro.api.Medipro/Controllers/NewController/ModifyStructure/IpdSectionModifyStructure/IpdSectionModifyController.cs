using medipro.api.Medipro.Models.NewModels.IpdSectionModifyStructure;
using medipro.api.Medipro.Models.NewModels.IpdSectionModifyStructure.IpdBillingSectionModify;
using medipro.api.Medipro.Models.NewModels.IpdSectionModifyStructure.IpdReportSectionModify;
using medipro.api.Medipro.Models.NewModels.IpdSectionModifyStructure.IpdSupervisionSectionModify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.IpdSectionModifyStructure
{
    public class IpdSectionModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/DischargeSheetRegistrationModify")]
        public IHttpActionResult Get()
        {
            DischargeSheetModify d = new DischargeSheetModify();

            d.InpatientSelect();
            d.RefererSelect();
            d.DischargeSheetSelect();
            d.DischargeSheetInsert();







            return Ok();

        }


        [HttpGet]
        [Route("api/ModifyStructure/BedRackListModify")]
        public IHttpActionResult BedRackGet()
        {
            BedRackListModify b = new BedRackListModify();

            b.BedRackSelect();


            return Ok();

        }


        [HttpGet]
        [Route("api/ModifyStructure/BedTransferModify")]
        public IHttpActionResult BedTransfer()
        {
            BedTransferModify bt = new BedTransferModify();

            bt.InpatientSelect();
            bt.BedRackPartSelect();
            bt.BedRackSelect();
            bt.BedTransferInsert();


            return Ok();

        }


        [HttpGet]
        [Route("api/ModifyStructure/DepositModify")]
        public IHttpActionResult Deposit()
        {
            DepositModify d = new DepositModify();

           // d.InpatientSelect();
            d.DepositGetTotal();
            d.DepositGet();
            d.DepositGetRefund();
            d.DepositGetReceipt();
            d.DepositGetAdvance();
            d.DepositInsert();




            return Ok();

        }



        [HttpGet]
        [Route("api/ModifyStructure/BedBookingModify")]
        public IHttpActionResult BedBooking()
        {
            BedBookingModify b = new BedBookingModify();

            //has sp_InpatientSelect and sp_BedrackSelect
            b.BedBookingInsert();







            return Ok();

        }


        [HttpGet]
        [Route("api/ModifyStructure/BedBookedClearModify")]
        public IHttpActionResult BedBookedClear()
        {
            BedBookedClearModify b = new BedBookedClearModify();

            //   sp_BedrackSelect created previously
            b.BedBookedClearInsert();









            return Ok();




        }


        [HttpGet]
        [Route("api/ModifyStructure/BedTransactionReportModify")]
        public IHttpActionResult BedTransactionReport()
        {
            BedTransactionReportModify b = new BedTransactionReportModify();

            b.BedTransInPatientSelect();
            b.BedTransactionReport();



            return Ok();




        }


        [HttpGet]
        [Route("api/ModifyStructure/DischargeSheetReportModify")]
        public IHttpActionResult DischargeSheetReport()
        {
            DischargeSheetReportModify d = new DischargeSheetReportModify();

            d.DischargeSheetReport();



            return Ok();




        }


        [HttpGet]
        [Route("api/ModifyStructure/DischargeReportModify")]
        public IHttpActionResult DischargeReport()
        {
            DischargeReportModify d = new DischargeReportModify();

            d.DischargeReportSelect();
            d.DischargeReportCount();



            return Ok();

        }



        [HttpGet]
        [Route("api/ModifyStructure/IpdSaveBillCancelModify")]
        public IHttpActionResult IpdSaveBillCancel()
        {
            IpdSaveBillCancelModify i = new IpdSaveBillCancelModify();

            i.IpdSaveBillCancel();






            return Ok();

        }


        [HttpGet]
        [Route("api/ModifyStructure/IpdRegistrationRegisterModify")]
        public IHttpActionResult IpdRegistrationRegister()
        {
            IpdRegistrationRegisterModify i = new IpdRegistrationRegisterModify();

            i.IpdRegSelect();
            i.IpdRegCount();









            return Ok();

        }


    }
}
