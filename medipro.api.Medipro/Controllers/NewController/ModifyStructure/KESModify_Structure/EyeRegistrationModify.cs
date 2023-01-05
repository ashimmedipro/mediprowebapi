using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class EyeRegistrationModify
    {
        public void EyeRegInsert()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_eye_registrationInsert ");
            s.Append(" @mrdno varchar(11), ");
            s.Append(" @hospid int, ");
            s.Append(" @clusterNo int, ");
            s.Append(" @kesId int, ");
            s.Append(" @tole varchar(200), ");
            s.Append(" @contact varchar(10), ");
            s.Append(" @contact1 varchar(10), ");
            s.Append(" @education varchar(15), ");
            s.Append(" @edu_specify varchar(50), ");
            s.Append(" @ethnicity varchar(10), ");
            s.Append(" @ethnic_specify varchar(20), ");
            s.Append(" @religion varchar(10), ");
            s.Append(" @religion_specify varchar(20), ");
            s.Append(" @marital_specify varchar(20), ");
            s.Append(" @occupation_specify varchar(20), ");
            s.Append(" @familySize varchar(10), ");
            s.Append(" @annualIncome int, ");
            s.Append(" @examStatus bit, ");
            s.Append(" @exam_healthIssues bit, ");
            s.Append(" @health_visionImpair bit, ");
            s.Append(" @health_deaf bit, ");
            s.Append(" @health_mentalhealth bit, ");
            s.Append(" @health_intellectinjury bit, ");
            s.Append(" @health_braininjury bit, ");
            s.Append(" @health_autism bit, ");
            s.Append(" @health_physicaldisability bit, ");
            s.Append(" @health_others bit, ");
            s.Append(" @health_others_specify varchar(20), ");
            s.Append(" @exam_death bit, ");
            s.Append(" @exam_migration bit, ");
            s.Append(" @exam_notavail bit, ");
            s.Append(" @exam_others bit, ");
            s.Append(" @exam_others_specify varchar(20), ");
            s.Append(" @pt_status bit, ");
            s.Append(" @pt_abnormal_deaf bit, ");
            s.Append(" @pt_abnormal_mentalhealth bit, ");
            s.Append(" @pt_abnormal_intellectinjury bit, ");
            s.Append(" @pt_abnormal_braininjury bit, ");
            s.Append(" @pt_abnormal_autism bit, ");
            s.Append(" @pt_abnormal_physicaldisability bit, ");
            s.Append(" @pt_abnormal_others bit, ");
            s.Append(" @pt_abnormal_others_specify varchar(20), ");
            s.Append(" @pt_wt decimal, ");
            s.Append(" @pt_ht decimal, ");
            s.Append(" @pt_bp_sys int, ");
            s.Append(" @pt_bp_dias int, ");
            s.Append(" @pt_bmi_status varchar(20), ");
            s.Append(" @pt_bp_status varchar(20) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" insert into eye_registration ");
            s.Append(" ( ");
            s.Append(" mrdno, ");
            s.Append(" hospid, ");
            s.Append(" clusterNo, ");
            s.Append(" kesId, ");
            s.Append(" tole, ");
            s.Append(" contact, ");
            s.Append(" contact1, ");
            s.Append(" education, ");
            s.Append(" edu_specify, ");
            s.Append(" ethnicity, ");
            s.Append(" ethnic_specify, ");
            s.Append(" religion, ");
            s.Append(" religion_specify, ");
            s.Append(" marital_specify, ");
            s.Append(" occupation_specify, ");
            s.Append(" familySize, ");
            s.Append(" annualIncome, ");
            s.Append(" examStatus, ");
            s.Append(" exam_healthIssues, ");
            s.Append(" health_visionImpair, ");
            s.Append(" health_deaf, ");
            s.Append(" health_mentalhealth, ");
            s.Append(" health_intellectinjury, ");
            s.Append(" health_braininjury, ");
            s.Append(" health_autism, ");
            s.Append(" health_physicaldisability, ");
            s.Append(" health_others, ");
            s.Append(" health_others_specify, ");
            s.Append(" exam_death, ");
            s.Append(" exam_migration, ");
            s.Append(" exam_notavail, ");
            s.Append(" exam_others, ");
            s.Append(" exam_others_specify, ");
            s.Append(" pt_status, ");
            s.Append(" pt_abnormal_deaf, ");
            s.Append(" pt_abnormal_mentalhealth, ");
            s.Append(" pt_abnormal_intellectinjury, ");
            s.Append(" pt_abnormal_braininjury, ");
            s.Append(" pt_abnormal_autism, ");
            s.Append(" pt_abnormal_physicaldisability, ");
            s.Append(" pt_abnormal_others, ");
            s.Append(" pt_abnormal_others_specify, ");
            s.Append(" pt_wt, ");
            s.Append(" pt_ht, ");
            s.Append(" pt_bp_sys, ");
            s.Append(" pt_bp_dias, ");
            s.Append(" pt_bmi_status, ");
            s.Append(" pt_bp_status ");
            s.Append(" ) ");
            s.Append(" values ");
            s.Append(" ( ");
            s.Append(" @mrdno, ");
            s.Append(" @hospid, ");
            s.Append(" @clusterNo, ");
            s.Append(" @kesId, ");
            s.Append(" @tole, ");
            s.Append(" @contact, ");
            s.Append(" @contact1, ");
            s.Append(" @education, ");
            s.Append(" @edu_specify, ");
            s.Append(" @ethnicity, ");
            s.Append(" @ethnic_specify, ");
            s.Append(" @religion, ");
            s.Append(" @religion_specify, ");
            s.Append(" @marital_specify, ");
            s.Append(" @occupation_specify, ");
            s.Append(" @familySize, ");
            s.Append(" @annualIncome, ");
            s.Append(" @examStatus, ");
            s.Append(" @exam_healthIssues, ");
            s.Append(" @health_visionImpair, ");
            s.Append(" @health_deaf, ");
            s.Append(" @health_mentalhealth, ");
            s.Append(" @health_intellectinjury, ");
            s.Append(" @health_braininjury, ");
            s.Append(" @health_autism, ");
            s.Append(" @health_physicaldisability, ");
            s.Append(" @health_others, ");
            s.Append(" @health_others_specify, ");
            s.Append(" @exam_death, ");
            s.Append(" @exam_migration, ");
            s.Append(" @exam_notavail, ");
            s.Append(" @exam_others, ");
            s.Append(" @exam_others_specify, ");
            s.Append(" @pt_status, ");
            s.Append(" @pt_abnormal_deaf, ");
            s.Append(" @pt_abnormal_mentalhealth, ");
            s.Append(" @pt_abnormal_intellectinjury, ");
            s.Append(" @pt_abnormal_braininjury, ");
            s.Append(" @pt_abnormal_autism, ");
            s.Append(" @pt_abnormal_physicaldisability, ");
            s.Append(" @pt_abnormal_others, ");
            s.Append(" @pt_abnormal_others_specify, ");
            s.Append(" @pt_wt, ");
            s.Append(" @pt_ht, ");
            s.Append(" @pt_bp_sys, ");
            s.Append(" @pt_bp_dias, ");
            s.Append(" @pt_bmi_status, ");
            s.Append(" @pt_bp_status ");
            s.Append(" ) ");
            s.Append(" commit transaction ");
            s.Append(" end try ");
            s.Append(" begin catch ");
            s.Append(" declare @err_msg varchar(max), @errnunber varchar(max), @errstate varchar(max) ");
            s.Append(" select @err_msg= ERROR_MESSAGE() ,@errnunber = ERROR_NUMBER() , @errstate = ERROR_STATE() ");
            s.Append(" raiserror(@err_msg,16,1) ");
            s.Append(" rollback transaction ");
            s.Append(" end catch ");
            s.Append(" end ");




            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void EyeRegUpdate()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_eye_registrationUpdate ");
            s.Append(" @mrdno varchar(11), ");
            s.Append(" @hospid int, ");
            s.Append(" @clusterNo int, ");
            s.Append(" @kesId int, ");
            s.Append(" @tole varchar(200), ");
            s.Append(" @contact varchar(10), ");
            s.Append(" @contact1 varchar(10), ");
            s.Append(" @education varchar(15), ");
            s.Append(" @edu_specify varchar(50), ");
            s.Append(" @ethnicity varchar(10), ");
            s.Append(" @ethnic_specify varchar(20), ");
            s.Append(" @religion varchar(10), ");
            s.Append(" @religion_specify varchar(20), ");
            s.Append(" @marital_specify varchar(20), ");
            s.Append(" @occupation_specify varchar(20), ");
            s.Append(" @familySize varchar(10), ");
            s.Append(" @annualIncome int, ");
            s.Append(" @examStatus bit, ");
            s.Append(" @exam_healthIssues bit, ");
            s.Append(" @health_visionImpair bit, ");
            s.Append(" @health_deaf bit, ");
            s.Append(" @health_mentalhealth bit, ");
            s.Append(" @health_intellectinjury bit, ");
            s.Append(" @health_braininjury bit, ");
            s.Append(" @health_autism bit, ");
            s.Append(" @health_physicaldisability bit, ");
            s.Append(" @health_others bit, ");
            s.Append(" @health_others_specify varchar(20), ");
            s.Append(" @exam_death bit, ");
            s.Append(" @exam_migration bit, ");
            s.Append(" @exam_notavail bit, ");
            s.Append(" @exam_others bit, ");
            s.Append(" @exam_others_specify varchar(20), ");
            s.Append(" @pt_status bit, ");
            s.Append(" @pt_abnormal_deaf bit, ");
            s.Append(" @pt_abnormal_mentalhealth bit, ");
            s.Append(" @pt_abnormal_intellectinjury bit, ");
            s.Append(" @pt_abnormal_braininjury bit, ");
            s.Append(" @pt_abnormal_autism bit, ");
            s.Append(" @pt_abnormal_physicaldisability bit, ");
            s.Append(" @pt_abnormal_others bit, ");
            s.Append(" @pt_abnormal_others_specify varchar(20), ");
            s.Append(" @pt_wt decimal, ");
            s.Append(" @pt_ht decimal, ");
            s.Append(" @pt_bp_sys int, ");
            s.Append(" @pt_bp_dias int, ");
            s.Append(" @pt_bmi_status varchar(20), ");
            s.Append(" @pt_bp_status varchar(20) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" update eye_registration ");
            s.Append(" set ");
            s.Append(" mrdno=@mrdno, ");
            s.Append(" hospid=@hospid, ");
            s.Append(" tole=@tole, ");
            s.Append(" contact=@contact, ");
            s.Append(" contact1=@contact1, ");
            s.Append(" education=@education, ");
            s.Append(" edu_specify=@edu_specify, ");
            s.Append(" ethnicity=@ethnicity, ");
            s.Append(" ethnic_specify=@ethnic_specify, ");
            s.Append(" religion=@religion, ");
            s.Append(" religion_specify=@religion_specify, ");
            s.Append(" marital_specify=@marital_specify, ");
            s.Append(" occupation_specify=@occupation_specify, ");
            s.Append(" familySize=@familySize, ");
            s.Append(" annualIncome=@annualIncome, ");
            s.Append(" examStatus=@examStatus, ");
            s.Append(" exam_healthIssues=@exam_healthIssues, ");
            s.Append(" health_visionImpair=@health_visionImpair, ");
            s.Append(" health_deaf=@health_deaf, ");
            s.Append(" health_mentalhealth=@health_mentalhealth, ");
            s.Append(" health_intellectinjury=@health_intellectinjury, ");
            s.Append(" health_braininjury=@health_braininjury, ");
            s.Append(" health_autism=@health_autism, ");
            s.Append(" health_physicaldisability=@health_physicaldisability, ");
            s.Append(" health_others=@health_others, ");
            s.Append(" health_others_specify=@health_others_specify, ");
            s.Append(" exam_death=@exam_death, ");
            s.Append(" exam_migration=@exam_migration, ");
            s.Append(" exam_notavail=@exam_notavail, ");
            s.Append(" exam_others=@exam_others, ");
            s.Append(" exam_others_specify=@exam_others_specify, ");
            s.Append(" pt_status=@pt_status, ");
            s.Append(" pt_abnormal_deaf=@pt_abnormal_deaf, ");
            s.Append(" pt_abnormal_mentalhealth=@pt_abnormal_mentalhealth, ");
            s.Append(" pt_abnormal_intellectinjury=@pt_abnormal_intellectinjury, ");
            s.Append(" pt_abnormal_braininjury=@pt_abnormal_braininjury, ");
            s.Append(" pt_abnormal_autism=@pt_abnormal_autism, ");
            s.Append(" pt_abnormal_physicaldisability=@pt_abnormal_physicaldisability, ");
            s.Append(" pt_abnormal_others=@pt_abnormal_others, ");
            s.Append(" pt_abnormal_others_specify=@pt_abnormal_others_specify, ");
            s.Append(" pt_wt=@pt_wt, ");
            s.Append(" pt_ht=@pt_ht, ");
            s.Append(" pt_bp_sys=@pt_bp_sys, ");
            s.Append(" pt_bp_dias=@pt_bp_dias, ");
            s.Append(" pt_bmi_status=@pt_bmi_status, ");
            s.Append(" pt_bp_status=@pt_bp_status ");
            s.Append(" where ");
            s.Append(" clusterNo=@clusterNo and ");
            s.Append(" kesId=@kesId ");
            s.Append(" commit transaction ");
            s.Append(" end try ");
            s.Append(" begin catch ");
            s.Append(" declare @err_msg varchar(max), @errnunber varchar(max), @errstate varchar(max) ");
            s.Append(" select @err_msg= ERROR_MESSAGE() ,@errnunber = ERROR_NUMBER() , @errstate = ERROR_STATE() ");
            s.Append(" raiserror(@err_msg,16,1) ");
            s.Append(" rollback transaction ");
            s.Append(" end catch ");
            s.Append(" end ");





            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void EyeRegSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_EyeRegistrationSelectAllByMrdno @mrdno varchar(11) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select * from eye_registration ");
            s.Append(" where mrdno=@mrdno ");
            s.Append(" commit transaction ");
            s.Append(" end try ");
            s.Append(" begin catch ");
            s.Append(" declare @err_msg varchar(max), @errnunber varchar(max), @errstate varchar(max) ");
            s.Append(" select @err_msg= ERROR_MESSAGE() ,@errnunber = ERROR_NUMBER() , @errstate = ERROR_STATE() ");
            s.Append(" raiserror(@err_msg,16,1) ");
            s.Append(" rollback transaction ");
            s.Append(" end catch ");
            s.Append(" end ");




            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void EyeRegMemberUpdate()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_EyeRegMemberUpdate ");
            s.Append(" ( ");
            s.Append(" @hospid int, ");
            s.Append(" @pname varchar(50), ");
            s.Append(" @dob datetime, ");
            s.Append(" @gender varchar(10), ");
            s.Append(" @address varchar(50), ");
            s.Append(" @wardno varchar(3), ");
            s.Append(" @occupation varchar(25), ");
            s.Append(" @martialStatus varchar(7) ");
            s.Append(" ) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" update member ");
            s.Append(" set ");
            s.Append(" pname=@pname , ");
            s.Append(" dob=@dob , ");
            s.Append(" sex=@gender , ");
            s.Append(" [address]=@address, ");
            s.Append(" wardno=@wardno , ");
            s.Append(" occupation=@occupation , ");
            s.Append(" martialStatus=@martialStatus ");
            s.Append(" where ");
            s.Append(" hospid=@hospid ");
            s.Append(" commit transaction ");
            s.Append(" end try ");
            s.Append(" begin catch ");
            s.Append(" declare @err_msg varchar(max), @errnunber varchar(max), @errstate varchar(max) ");
            s.Append(" select @err_msg= ERROR_MESSAGE() ,@errnunber = ERROR_NUMBER() , @errstate = ERROR_STATE() ");
            s.Append(" raiserror(@err_msg,16,1) ");
            s.Append(" rollback transaction ");
            s.Append(" end catch ");
            s.Append(" end ");





            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void EyeRegMemberSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_EyeRegMemberGetbyHospid @hospid int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select hospid, pname, dob, sex, [address], wardno, occupation, martialStatus from member ");
            s.Append(" where hospid =@hospid ");
            s.Append(" commit transaction ");
            s.Append(" end try ");
            s.Append(" begin catch ");
            s.Append(" declare @err_msg varchar(max), @errnunber varchar(max), @errstate varchar(max) ");
            s.Append(" select @err_msg= ERROR_MESSAGE() ,@errnunber = ERROR_NUMBER() , @errstate = ERROR_STATE() ");
            s.Append(" raiserror(@err_msg,16,1) ");
            s.Append(" rollback transaction ");
            s.Append(" end catch ");
            s.Append(" end ");




            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }
    }
}