using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.EyeDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.EyeDocs
{
    public class DentalInformationController : ApiController
    {
        [HttpPost]
        [Route("api/DentalInformationAll")]
        public IHttpActionResult Post(DentalInformationAll_dt model)
        {
            try
            {

            
            DentalInformationDetailsInsert_dt model1 = new DentalInformationDetailsInsert_dt();
            DentalInsert(model, model1);

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

        [HttpPost]
        [Route("api/DentalInformationAll/Update")]
        public IHttpActionResult Update(DentalInformationAll_dt model)
        {
            try
            {

            
            DentalInformationDetailsDelete_dt model_new = new DentalInformationDetailsDelete_dt();
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsDelete", model_new);
            DentalInformationDetailsInsert_dt model1 = new DentalInformationDetailsInsert_dt();
            DentalInsert(model, model1);
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

        private static void DentalInsert(DentalInformationAll_dt model, DentalInformationDetailsInsert_dt model1)
        {
            model1.mrdno = model.mrdno;
            model1.ddate = model.ddate;
            model1.hospid = model.hospid;
            model1.title = "allergy_tick";
            model1.result = "";
            model1.tick_mark = model.allergy_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "diabetes_tick";
            model1.result = "";
            model1.tick_mark = model.diabetes_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "bp_tick";
            model1.result = "";
            model1.tick_mark = model.bp_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "heart_disease_tick";
            model1.result = "";
            model1.tick_mark = model.heart_disease_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "liver_disease_tick";
            model1.result = "";
            model1.tick_mark = model.liver_disease_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "kidney_disease_tick";
            model1.result = "";
            model1.tick_mark = model.kidney_disease_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "medications_tick";
            model1.result = "";
            model1.tick_mark = model.medications_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "other_history_tick";
            model1.result = "";
            model1.tick_mark = model.other_history_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            //model1.title = "brushing_tick";
            //model1.result = "";
            //model1.tick_mark = model.brushing_tick;
            //DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "alcohol_tick";
            model1.result = "";
            model1.tick_mark = model.alcohol_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "smoking_tick";
            model1.result = "";
            model1.tick_mark = model.smoking_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "tobacco_tick";
            model1.result = "";
            model1.tick_mark = model.tobacco_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "thumb_suck_tick";
            model1.result = "";
            model1.tick_mark = model.thumb_suck_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "pan_masala_tick";
            model1.result = "";
            model1.tick_mark = model.pan_masala_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "mouth_breathe_tick";
            model1.result = "";
            model1.tick_mark = model.mouth_breathe_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "tongue_thrust_tick";
            model1.result = "";
            model1.tick_mark = model.tongue_thrust_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "clench_tick";
            model1.result = "";
            model1.tick_mark = model.clench_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "bruxism_tick";
            model1.result = "";
            model1.tick_mark = model.bruxism_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            // model1.title = "diet_tick";
            //model1.result = "";
            //model1.tick_mark = model.diet_tick;
            //DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "other_habit_tick";
            model1.result = "";
            model1.tick_mark = model.other_habit_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "tmj_extra_oral_tick";
            model1.result = "";
            model1.tick_mark = model.tmj_extra_oral_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "masseter_extra_oral_tick";
            model1.result = "";
            model1.tick_mark = model.masseter_extra_oral_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "lymph_nodes_extra_oral_tick";
            model1.result = "";
            model1.tick_mark = model.lymph_nodes_extra_oral_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "others_extra_oral_tick";
            model1.result = "";
            model1.tick_mark = model.others_extra_oral_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "buccal_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.buccal_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "tongue_intra_oral_tick";
            model1.result = "";
            model1.tick_mark = model.tongue_intra_oral_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "palate_intra_oral_tick";
            model1.result = "";
            model1.tick_mark = model.palate_intra_oral_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            model1.title = "teeth_tick";
            model1.result = "";
            model1.tick_mark = model.teeth_tick;
            DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);

            if ((model.allergy is null ? "" : model.allergy).Length > 0)
            {
                model1.title = "allergy";
                model1.result = model.allergy;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            if ((model.other_history is null ? "" : model.other_history).Length > 0)
            {
                model1.title = "other_history";
                model1.result = model.other_history;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            if ((model.chief_complain is null ? "" : model.chief_complain).Length > 0)
            {
                model1.title = "chief_complain";
                model1.result = model.chief_complain;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            if ((model.hopi is null ? "" : model.hopi).Length > 0)
            {
                model1.title = "hopi";
                model1.result = model.hopi;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            if ((model.dental_history is null ? "" : model.dental_history).Length > 0)
            {
                model1.title = "dental_history";
                model1.result = model.dental_history;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            if ((model.other_habit is null ? "" : model.other_habit).Length > 0)
            {
                model1.title = "other_habit";
                model1.result = model.other_habit;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            if ((model.others_extra_oral is null ? "" : model.others_extra_oral).Length > 0)
            {
                model1.title = "others_extra_oral";
                model1.result = model.others_extra_oral;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            if ((model.bpe_score is null ? "" : model.bpe_score).Length > 0)
            {
                model1.title = "bpe_score";
                model1.result = model.bpe_score;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            /*if ((model.a_18_to_11_teeth is null ? "" : model.a_18_to_11_teeth).Length > 0)
            {
                model1.title = "a_18_to_11_teeth";
                model1.result = model.a_18_to_11_teeth;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            if ((model.a_21_to_28_teeth is null ? "" : model.a_21_to_28_teeth).Length > 0)
            {
                model1.title = "a_21_to_28_teeth";
                model1.result = model.a_21_to_28_teeth;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            if ((model.a_38_to_31_teeth is null ? "" : model.a_38_to_31_teeth).Length > 0)
            {
                model1.title = "a_38_to_31_teeth";
                model1.result = model.a_38_to_31_teeth;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            if ((model.a_41_to_48_teeth is null ? "" : model.a_41_to_48_teeth).Length > 0)
            {
                model1.title = "a_41_to_48_teeth";
                model1.result = model.a_41_to_48_teeth;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }*/

            if ((model.emergency_mgmt is null ? "" : model.emergency_mgmt).Length > 0)
            {
                model1.title = "emergency_mgmt";
                model1.result = model.emergency_mgmt;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            if ((model.stabilization is null ? "" : model.stabilization).Length > 0)
            {
                model1.title = "stabilization";
                model1.result = model.stabilization;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            if ((model.maintenance is null ? "" : model.maintenance).Length > 0)
            {
                model1.title = "maintenance";
                model1.result = model.maintenance;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            if ((model.definitive_mgmt is null ? "" : model.definitive_mgmt).Length > 0)
            {
                model1.title = "definitive_mgmt";
                model1.result = model.definitive_mgmt;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            if ((model.treatment_done is null ? "" : model.treatment_done).Length > 0)
            {
                model1.title = "treatment_done";
                model1.result = model.treatment_done;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
            }

            if ((model.brush_habit is null ? "" : model.brush_habit).Length > 0) { model1.title = "brush_habit"; model1.result = model.brush_habit; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
            if ((model.diet_habit is null ? "" : model.diet_habit).Length > 0) { model1.title = "diet_habit"; model1.result = model.diet_habit; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
            if ((model.teeth_11 is null ? "" : model.teeth_11).Length > 0) { model1.title = "teeth_11"; model1.result = model.teeth_11; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
            if ((model.teeth_12 is null ? "" : model.teeth_12).Length > 0) { model1.title = "teeth_12"; model1.result = model.teeth_12; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
            if ((model.teeth_13 is null ? "" : model.teeth_13).Length > 0) { model1.title = "teeth_13"; model1.result = model.teeth_13; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
            if ((model.teeth_14 is null ? "" : model.teeth_14).Length > 0) { model1.title = "teeth_14"; model1.result = model.teeth_14; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
            if ((model.teeth_15 is null ? "" : model.teeth_15).Length > 0) { model1.title = "teeth_15"; model1.result = model.teeth_15; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
            if ((model.teeth_16 is null ? "" : model.teeth_16).Length > 0) { model1.title = "teeth_16"; model1.result = model.teeth_16; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
            if ((model.teeth_17 is null ? "" : model.teeth_17).Length > 0) { model1.title = "teeth_17"; model1.result = model.teeth_17; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
            if ((model.teeth_18 is null ? "" : model.teeth_18).Length > 0)
            {
                model1.title = "teeth_18"; model1.result = model.teeth_18; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1);
                if ((model.teeth_21 is null ? "" : model.teeth_21).Length > 0) { model1.title = "teeth_21"; model1.result = model.teeth_21; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_22 is null ? "" : model.teeth_22).Length > 0) { model1.title = "teeth_22"; model1.result = model.teeth_22; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_23 is null ? "" : model.teeth_23).Length > 0) { model1.title = "teeth_23"; model1.result = model.teeth_23; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_24 is null ? "" : model.teeth_24).Length > 0) { model1.title = "teeth_24"; model1.result = model.teeth_24; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_25 is null ? "" : model.teeth_25).Length > 0) { model1.title = "teeth_25"; model1.result = model.teeth_25; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_26 is null ? "" : model.teeth_26).Length > 0) { model1.title = "teeth_26"; model1.result = model.teeth_26; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_27 is null ? "" : model.teeth_27).Length > 0) { model1.title = "teeth_27"; model1.result = model.teeth_27; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_28 is null ? "" : model.teeth_28).Length > 0) { model1.title = "teeth_28"; model1.result = model.teeth_28; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_31 is null ? "" : model.teeth_31).Length > 0) { model1.title = "teeth_31"; model1.result = model.teeth_31; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_32 is null ? "" : model.teeth_32).Length > 0) { model1.title = "teeth_32"; model1.result = model.teeth_32; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_33 is null ? "" : model.teeth_33).Length > 0) { model1.title = "teeth_33"; model1.result = model.teeth_33; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_34 is null ? "" : model.teeth_34).Length > 0) { model1.title = "teeth_34"; model1.result = model.teeth_34; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_35 is null ? "" : model.teeth_35).Length > 0) { model1.title = "teeth_35"; model1.result = model.teeth_35; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_36 is null ? "" : model.teeth_36).Length > 0) { model1.title = "teeth_36"; model1.result = model.teeth_36; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_37 is null ? "" : model.teeth_37).Length > 0) { model1.title = "teeth_37"; model1.result = model.teeth_37; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_38 is null ? "" : model.teeth_38).Length > 0) { model1.title = "teeth_38"; model1.result = model.teeth_38; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_41 is null ? "" : model.teeth_41).Length > 0) { model1.title = "teeth_41"; model1.result = model.teeth_41; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_42 is null ? "" : model.teeth_42).Length > 0) { model1.title = "teeth_42"; model1.result = model.teeth_42; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_43 is null ? "" : model.teeth_43).Length > 0) { model1.title = "teeth_43"; model1.result = model.teeth_43; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_44 is null ? "" : model.teeth_44).Length > 0) { model1.title = "teeth_44"; model1.result = model.teeth_44; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_45 is null ? "" : model.teeth_45).Length > 0) { model1.title = "teeth_45"; model1.result = model.teeth_45; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_46 is null ? "" : model.teeth_46).Length > 0) { model1.title = "teeth_46"; model1.result = model.teeth_46; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_47 is null ? "" : model.teeth_47).Length > 0) { model1.title = "teeth_47"; model1.result = model.teeth_47; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_48 is null ? "" : model.teeth_48).Length > 0) { model1.title = "teeth_48"; model1.result = model.teeth_48; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_51 is null ? "" : model.teeth_51).Length > 0) { model1.title = "teeth_51"; model1.result = model.teeth_51; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_52 is null ? "" : model.teeth_52).Length > 0) { model1.title = "teeth_52"; model1.result = model.teeth_52; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_53 is null ? "" : model.teeth_53).Length > 0) { model1.title = "teeth_53"; model1.result = model.teeth_53; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_54 is null ? "" : model.teeth_54).Length > 0) { model1.title = "teeth_54"; model1.result = model.teeth_54; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_55 is null ? "" : model.teeth_55).Length > 0) { model1.title = "teeth_55"; model1.result = model.teeth_55; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_56 is null ? "" : model.teeth_56).Length > 0) { model1.title = "teeth_56"; model1.result = model.teeth_56; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_57 is null ? "" : model.teeth_57).Length > 0) { model1.title = "teeth_57"; model1.result = model.teeth_57; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_58 is null ? "" : model.teeth_58).Length > 0) { model1.title = "teeth_58"; model1.result = model.teeth_58; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_61 is null ? "" : model.teeth_61).Length > 0) { model1.title = "teeth_61"; model1.result = model.teeth_61; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_62 is null ? "" : model.teeth_62).Length > 0) { model1.title = "teeth_62"; model1.result = model.teeth_62; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_63 is null ? "" : model.teeth_63).Length > 0) { model1.title = "teeth_63"; model1.result = model.teeth_63; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_64 is null ? "" : model.teeth_64).Length > 0) { model1.title = "teeth_64"; model1.result = model.teeth_64; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_65 is null ? "" : model.teeth_65).Length > 0) { model1.title = "teeth_65"; model1.result = model.teeth_65; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_66 is null ? "" : model.teeth_66).Length > 0) { model1.title = "teeth_66"; model1.result = model.teeth_66; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_67 is null ? "" : model.teeth_67).Length > 0) { model1.title = "teeth_67"; model1.result = model.teeth_67; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_68 is null ? "" : model.teeth_68).Length > 0) { model1.title = "teeth_68"; model1.result = model.teeth_68; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_71 is null ? "" : model.teeth_71).Length > 0) { model1.title = "teeth_71"; model1.result = model.teeth_71; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_72 is null ? "" : model.teeth_72).Length > 0) { model1.title = "teeth_72"; model1.result = model.teeth_72; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_73 is null ? "" : model.teeth_73).Length > 0) { model1.title = "teeth_73"; model1.result = model.teeth_73; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_74 is null ? "" : model.teeth_74).Length > 0) { model1.title = "teeth_74"; model1.result = model.teeth_74; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_75 is null ? "" : model.teeth_75).Length > 0) { model1.title = "teeth_75"; model1.result = model.teeth_75; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_76 is null ? "" : model.teeth_76).Length > 0) { model1.title = "teeth_76"; model1.result = model.teeth_76; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_77 is null ? "" : model.teeth_77).Length > 0) { model1.title = "teeth_77"; model1.result = model.teeth_77; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_78 is null ? "" : model.teeth_78).Length > 0) { model1.title = "teeth_78"; model1.result = model.teeth_78; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_81 is null ? "" : model.teeth_81).Length > 0) { model1.title = "teeth_81"; model1.result = model.teeth_81; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_82 is null ? "" : model.teeth_82).Length > 0) { model1.title = "teeth_82"; model1.result = model.teeth_82; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_83 is null ? "" : model.teeth_83).Length > 0) { model1.title = "teeth_83"; model1.result = model.teeth_83; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_84 is null ? "" : model.teeth_84).Length > 0) { model1.title = "teeth_84"; model1.result = model.teeth_84; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_85 is null ? "" : model.teeth_85).Length > 0) { model1.title = "teeth_85"; model1.result = model.teeth_85; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_86 is null ? "" : model.teeth_86).Length > 0) { model1.title = "teeth_86"; model1.result = model.teeth_86; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_87 is null ? "" : model.teeth_87).Length > 0) { model1.title = "teeth_87"; model1.result = model.teeth_87; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
                if ((model.teeth_88 is null ? "" : model.teeth_88).Length > 0) { model1.title = "teeth_88"; model1.result = model.teeth_88; model1.tick_mark = false; DapperHelper.ExecuteStoredProcedure("sp_dental_information_detailsInsert", model1); }
            }
        }

        [HttpPost]
        [Route("api/DentalInformation")]
        public IHttpActionResult Post(DentalInformationInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_dental_informationInsert", model);
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

        [HttpPost]
        [Route("api/DentalInformation/Update")]
        public IHttpActionResult Update(DentalInformationUpdate_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_dental_informationUpdate", model);
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
        [Route("api/DentalInformation")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DentalInformationSelect_dt>
                ("sp_dental_informationSelect", new { mrdno = mrdno }).ToList();
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

        [HttpPost]
        [Route("api/DentalInformation/Delete")]
        public IHttpActionResult Delete(DentalInformationDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_dental_informationDelete ", model);
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
        [Route("api/DentalInformationAll")]
        public IHttpActionResult GetAll(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DentalInformationDetailsSelect_dt>
                ("sp_dental_information_detailsSelect", new { mrdno = mrdno }).ToList();
            DentalInformationAll_dt model_new = new DentalInformationAll_dt();
            foreach (var x in list)
            {
                model_new.mrdno = x.mrdno;

                if (x.title == "allergy_tick")
                {
                    model_new.allergy_tick = x.tick_mark;
                }

                if (x.title == "allergy")
                {
                    model_new.allergy = x.result;
                }

                if (x.title == "diabetes_tick")
                {
                    model_new.diabetes_tick = x.tick_mark;
                }

                if (x.title == "bp_tick")
                {
                    model_new.bp_tick = x.tick_mark;
                }

                if (x.title == "heart_disease_tick")
                {
                    model_new.heart_disease_tick = x.tick_mark;
                }

                if (x.title == "liver_disease_tick")
                {
                    model_new.liver_disease_tick = x.tick_mark;
                }

                if (x.title == "kidney_disease_tick")
                {
                    model_new.kidney_disease_tick = x.tick_mark;
                }

                if (x.title == "medications_tick")
                {
                    model_new.medications_tick = x.tick_mark;
                }

                if (x.title == "other_history_tick")
                {
                    model_new.other_history_tick = x.tick_mark;
                }

                if (x.title == "other_history")
                {
                    model_new.other_history = x.result;
                }

                if (x.title == "chief_complain")
                {
                    model_new.chief_complain = x.result;
                }

                if (x.title == "hopi")
                {
                    model_new.hopi = x.result;
                }

                if (x.title == "dental_history")
                {
                    model_new.dental_history = x.result;
                }

                if (x.title == "alcohol_tick")
                {
                    model_new.alcohol_tick = x.tick_mark;
                }

                if (x.title == "smoking_tick")
                {
                    model_new.smoking_tick = x.tick_mark;
                }

                if (x.title == "tobacco_tick")
                {
                    model_new.tobacco_tick = x.tick_mark;
                }

                if (x.title == "thumb_suck_tick")
                {
                    model_new.thumb_suck_tick = x.tick_mark;
                }

                if (x.title == "pan_masala_tick")
                {
                    model_new.pan_masala_tick = x.tick_mark;
                }

                if (x.title == "mouth_breathe_tick")
                {
                    model_new.mouth_breathe_tick = x.tick_mark;
                }

                if (x.title == "tongue_thrust_tick")
                {
                    model_new.tongue_thrust_tick = x.tick_mark;
                }

                if (x.title == "clench_tick")
                {
                    model_new.clench_tick = x.tick_mark;
                }

                if (x.title == "bruxism_tick")
                {
                    model_new.bruxism_tick = x.tick_mark;
                }

                if (x.title == "other_habit_tick")
                {
                    model_new.other_habit_tick = x.tick_mark;
                }

                if (x.title == "other_habit")
                {
                    model_new.other_habit = x.result;
                }

                if (x.title == "tmj_extra_oral_tick")
                {
                    model_new.tmj_extra_oral_tick = x.tick_mark;
                }

                if (x.title == "masseter_extra_oral_tick")
                {
                    model_new.masseter_extra_oral_tick = x.tick_mark;
                }

                if (x.title == "lymph_nodes_extra_oral_tick")
                {
                    model_new.lymph_nodes_extra_oral_tick = x.tick_mark;
                }

                if (x.title == "others_extra_oral_tick")
                {
                    model_new.others_extra_oral_tick = x.tick_mark;
                }

                if (x.title == "others_extra_oral")
                {
                    model_new.others_extra_oral = x.result;
                }

                if (x.title == "buccal_mucosa_tick")
                {
                    model_new.buccal_mucosa_tick = x.tick_mark;
                }

                if (x.title == "tongue_intra_oral_tick")
                {
                    model_new.tongue_intra_oral_tick = x.tick_mark;
                }

                if (x.title == "palate_intra_oral_tick")
                {
                    model_new.palate_intra_oral_tick = x.tick_mark;
                }

                if (x.title == "bpe_score")
                {
                    model_new.bpe_score = x.result;
                }

                if (x.title == "teeth_tick")
                {
                    model_new.teeth_tick = x.tick_mark;
                }

                if (x.title == "emergency_mgmt")
                {
                    model_new.emergency_mgmt = x.result;
                }

                if (x.title == "stabilization")
                {
                    model_new.stabilization = x.result;
                }

                if (x.title == "maintenance")
                {
                    model_new.maintenance = x.result;
                }

                if (x.title == "definitive_mgmt")
                {
                    model_new.definitive_mgmt = x.result;
                }

                if (x.title == "treatment_done")
                {
                    model_new.treatment_done = x.result;
                }

                if (x.title == "brush_habit") { model_new.brush_habit = x.result; }
                if (x.title == "diet_habit") { model_new.diet_habit = x.result; }
                if (x.title == "teeth_11") { model_new.teeth_11 = x.result; }
                if (x.title == "teeth_12") { model_new.teeth_12 = x.result; }
                if (x.title == "teeth_13") { model_new.teeth_13 = x.result; }
                if (x.title == "teeth_14") { model_new.teeth_14 = x.result; }
                if (x.title == "teeth_15") { model_new.teeth_15 = x.result; }
                if (x.title == "teeth_16") { model_new.teeth_16 = x.result; }
                if (x.title == "teeth_17") { model_new.teeth_17 = x.result; }
                if (x.title == "teeth_18") { model_new.teeth_18 = x.result; }
                if (x.title == "teeth_21") { model_new.teeth_21 = x.result; }
                if (x.title == "teeth_22") { model_new.teeth_22 = x.result; }
                if (x.title == "teeth_23") { model_new.teeth_23 = x.result; }
                if (x.title == "teeth_24") { model_new.teeth_24 = x.result; }
                if (x.title == "teeth_25") { model_new.teeth_25 = x.result; }
                if (x.title == "teeth_26") { model_new.teeth_26 = x.result; }
                if (x.title == "teeth_27") { model_new.teeth_27 = x.result; }
                if (x.title == "teeth_28") { model_new.teeth_28 = x.result; }
                if (x.title == "teeth_31") { model_new.teeth_31 = x.result; }
                if (x.title == "teeth_32") { model_new.teeth_32 = x.result; }
                if (x.title == "teeth_33") { model_new.teeth_33 = x.result; }
                if (x.title == "teeth_34") { model_new.teeth_34 = x.result; }
                if (x.title == "teeth_35") { model_new.teeth_35 = x.result; }
                if (x.title == "teeth_36") { model_new.teeth_36 = x.result; }
                if (x.title == "teeth_37") { model_new.teeth_37 = x.result; }
                if (x.title == "teeth_38") { model_new.teeth_38 = x.result; }
                if (x.title == "teeth_41") { model_new.teeth_41 = x.result; }
                if (x.title == "teeth_42") { model_new.teeth_42 = x.result; }
                if (x.title == "teeth_43") { model_new.teeth_43 = x.result; }
                if (x.title == "teeth_44") { model_new.teeth_44 = x.result; }
                if (x.title == "teeth_45") { model_new.teeth_45 = x.result; }
                if (x.title == "teeth_46") { model_new.teeth_46 = x.result; }
                if (x.title == "teeth_47") { model_new.teeth_47 = x.result; }
                if (x.title == "teeth_48") { model_new.teeth_48 = x.result; }
                if (x.title == "teeth_51") { model_new.teeth_51 = x.result; }
                if (x.title == "teeth_52") { model_new.teeth_52 = x.result; }
                if (x.title == "teeth_53") { model_new.teeth_53 = x.result; }
                if (x.title == "teeth_54") { model_new.teeth_54 = x.result; }
                if (x.title == "teeth_55") { model_new.teeth_55 = x.result; }
                if (x.title == "teeth_56") { model_new.teeth_56 = x.result; }
                if (x.title == "teeth_57") { model_new.teeth_57 = x.result; }
                if (x.title == "teeth_58") { model_new.teeth_58 = x.result; }
                if (x.title == "teeth_61") { model_new.teeth_61 = x.result; }
                if (x.title == "teeth_62") { model_new.teeth_62 = x.result; }
                if (x.title == "teeth_63") { model_new.teeth_63 = x.result; }
                if (x.title == "teeth_64") { model_new.teeth_64 = x.result; }
                if (x.title == "teeth_65") { model_new.teeth_65 = x.result; }
                if (x.title == "teeth_66") { model_new.teeth_66 = x.result; }
                if (x.title == "teeth_67") { model_new.teeth_67 = x.result; }
                if (x.title == "teeth_68") { model_new.teeth_68 = x.result; }
                if (x.title == "teeth_71") { model_new.teeth_71 = x.result; }
                if (x.title == "teeth_72") { model_new.teeth_72 = x.result; }
                if (x.title == "teeth_73") { model_new.teeth_73 = x.result; }
                if (x.title == "teeth_74") { model_new.teeth_74 = x.result; }
                if (x.title == "teeth_75") { model_new.teeth_75 = x.result; }
                if (x.title == "teeth_76") { model_new.teeth_76 = x.result; }
                if (x.title == "teeth_77") { model_new.teeth_77 = x.result; }
                if (x.title == "teeth_78") { model_new.teeth_78 = x.result; }
                if (x.title == "teeth_81") { model_new.teeth_81 = x.result; }
                if (x.title == "teeth_82") { model_new.teeth_82 = x.result; }
                if (x.title == "teeth_83") { model_new.teeth_83 = x.result; }
                if (x.title == "teeth_84") { model_new.teeth_84 = x.result; }
                if (x.title == "teeth_85") { model_new.teeth_85 = x.result; }
                if (x.title == "teeth_86") { model_new.teeth_86 = x.result; }
                if (x.title == "teeth_87") { model_new.teeth_87 = x.result; }
                if (x.title == "teeth_88") { model_new.teeth_88 = x.result; }

            }
            return Ok(model_new);

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
