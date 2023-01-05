using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.PharmaDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.PharmaDocs
{
    public class IpdRequistionController : ApiController
    {
        [HttpPost]
        [Route("api/IpdRequisitonForm")]
        public IHttpActionResult Post(IpdRequsitionAll_dt model)         
        {
            IpdRequistion_dt modelok = new IpdRequistion_dt();
            modelok.pcode = model.pcode;
            modelok.ddate = model.ddate;
            modelok.pname = model.pname;
            modelok.address = model.address;
            modelok.telephone = model.telephone;
            modelok.dob = model.dob;
            modelok.remarks = model.remarks;
            modelok.patno = model.patno;
            modelok.bedno = model.bedno;
           // modelok.refid = model.refid;
           // modelok.wardno = model.wardno;
            modelok.particular = model.wardname;
            modelok.referer = model.referer;
            modelok.req_no = model.req_no;
            modelok.username = model.username;

           DapperHelper.ExecuteStoredProcedure("sp_IpdRequisitionMaster", modelok);
     
         //  List<IpdRequistionDetail_dt> model1 = new List<IpdRequistionDetail_dt>();
            List<IpdRequistionDetail1_dt>  model2 = new List<IpdRequistionDetail1_dt>(); 
            
        
            foreach (var x in model.details)
            {
                model2.Add(
                    new IpdRequistionDetail1_dt()
                    {
                        md_code = x.md_code,
                        qty = x.qty,
                        req_no = model.req_no

                    });
                //model2.md_code = x.md_code;
                //model2.qty = x.qty;
                //model2.req_no = model.req_no;
            }

           
            DapperHelper.ExecuteStoredProcedure("sp_IpdRequisitionDetialInsert", model2);

            return Ok();
        }

        /* [HttpPost]
         [Route("api/IpdRequisitonFormMain")]
         public IHttpActionResult PostAll(IpdRequsitionMaster_dt model)
         {
             List<IpdRequistion_dt> a = new List<IpdRequistion_dt>();
               DapperHelper.ExecuteStoredProcedure("sp_IpdRequisitionDetialInsert", model.main);
             foreach (var x in model.details)
             {
                 x.md_code = x.md_code;
                 x.qty = x.qty;
                 x.req_no = x.req_no;
             }


             DapperHelper.ExecuteStoredProcedure("sp_IpdRequisitionDetialInsert", model.details);

             return Ok();
         }*/


   

    }
}
