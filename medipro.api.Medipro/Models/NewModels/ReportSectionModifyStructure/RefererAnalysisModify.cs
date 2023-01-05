using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class RefererAnalysisModify
    {

        public void DropProc()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_RefererAnalysisGetByDate%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_RefererAnalysisGetByDate  ");
            s.Append(" end ");

            s.Append(" if exists (select name from sys.procedures ");
            s.Append(" where (name like '%sp_RefererAnalysisSumGetByDate%' ) ");
            s.Append(" ) ");
            s.Append(" begin ");
            s.Append(" drop proc sp_RefererAnalysisSumGetByDate  ");
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


        public void Tempopdrec()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create table tempopdrec( ");
            s.Append(" SN int,HOSPID int,DDATE datetime,INV_NO1 varchar(9),SERVID int,QTY int,RATE float,DISC float,VAT float,INV_NO varchar(11), ");
            s.Append(" DONE bit,PANEL bit,hospid1 int,firm int,finish_date datetime,finish_time varchar(100),formatted bit,lines int, ");
            s.Append(" DISC2n numeric(12,2),disc_amt numeric(16,4),vatamt numeric(16,4),dueamt numeric(16,4),paid numeric(16,4),process numeric(16,4), ");
            s.Append(" r_no varchar(11),due varchar(10),duepaid numeric(16,4),rdate datetime,sample_collected bit,sample_date datetime,sample_userid int, ");
            s.Append(" cost numeric(12,2),xchange numeric(12,2),testnote varchar(max),refund bit,sample_no varchar(100),report_datetime datetime,result_id int, ");
            s.Append(" verified_id int,report_userid int,resulted bit,verified bit,reported bit,pathologist_id int,technician_id int, ");
            s.Append(" assistant_id int ");
            s.Append(" ) ");

            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }



        public void Tempopdbill()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create table tempopdbill( ");
            s.Append(" DDATE datetime,HOSPID int,INV_NO1 varchar(9),AC_CODE int,REFID int,AMOUNT float,DISCOUNT float,VAT float,PAID float,TENDER float, ");
            s.Append(" [USER] int,BILLTIME varchar(15),MEMBER bit,DUE float,BILLMODE varchar(10),P_TYPE varchar(10),REMARKS varchar(300),POSTED bit, ");
            s.Append(" CONTACT varchar(50),INV_NO varchar(11),FY varchar(1),AGEDAY float,FIRM int,hospid1 int,canceled bit,PostLedger bit,ADVANCE float, ");
            s.Append(" ipd bit,ipdno int,pathologist int,technician int,bedno varchar(15),labno varchar(20),collection_date datetime,report_date datetime, ");
            s.Append(" grpid int,scheme int,clinical varchar(50),footer text,EDITED varchar(1),er bit,appointment_id varchar(11),reg bit,RegType varchar(11), ");
            s.Append(" MartialStatus varchar(7),Occupation varchar(25),email varchar(50),consid int,FOREIGNER bit,Assistant int,appby varchar(30), ");
            s.Append(" telno varchar(30),reqby varchar(30),organization varchar(50),dpid int,xchange numeric(12,2),foreign_currenty varchar(3),foreign_amount numeric(12,2), ");
            s.Append(" foreign_discount numeric(12,2),foreign_vat numeric(12,2),barcode char(12),sms bit,collection_time char(8),report_time char(8),prev_inv_no varchar(11),refund bit, ");
            s.Append(" print_count int,cancel_id int,cancel_date datetime,service_type_id int,note varchar(10),pathologist_pw bit,Assistant_pw bit, ");
            s.Append(" technician_pw bit,freehealth_id int,salestype char(2),sync_with_ird bit,Is_realtime bit,roundoff numeric(12,2),dailynumber int,pf varchar(50), ");
            s.Append(" speciality varchar(50),patienttype varchar(50),mrlocation varchar(50),patient_category varchar(50),insurance bit,night bit, ");
            s.Append(" ird_datetime datetime,note1 varchar(30),note2 varchar(30),patient_type varchar(20),claim_code int,branch_center varchar(20),return_id int, ");
            s.Append(" labsms bit,telemedicine bit,telemedicineId int,lab_report_upload bit,lab_report_upload_time datetime,website bit,ssf bit, ");
            s.Append(" ssf_scheme_id int,ssf_pc numeric(12,2),fileupload bit,insurance_amount numeric(12,2),reportuserid int ");
            s.Append(" ) ");

            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        //
        public void RefererAnaGet()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_RefererAnalysisGetByDate(@init datetime, @final datetime, @firm int, @ipd int, @insurance int, @val int , @userid int,@search varchar(50)) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select * into #tempopdbill from opdbill where ddate between @init and @final ");
            s.Append(" select * into #tempopdrec from opdrec where ddate between @init and @final ");
            s.Append(" delete from tempopdbill where reportuserid=@userid ");
            s.Append(" insert into tempopdbill (DDATE,HOSPID,INV_NO1,AC_CODE,REFID,AMOUNT,DISCOUNT,VAT,PAID,TENDER,[USER],BILLTIME,MEMBER,DUE,BILLMODE,P_TYPE,REMARKS,POSTED, ");
            s.Append(" CONTACT,INV_NO,FY,AGEDAY,FIRM,hospid1,canceled,PostLedger,ADVANCE,ipd,ipdno,pathologist,technician,bedno,labno,collection_date,report_date,grpid,scheme,clinical, ");
            s.Append(" footer,EDITED,er,appointment_id,reg,RegType,MartialStatus,Occupation,email,consid,FOREIGNER,Assistant,appby,telno,reqby,organization,dpid,xchange, ");
            s.Append(" foreign_currenty,foreign_amount,foreign_discount,foreign_vat,barcode,sms,collection_time,report_time,prev_inv_no,refund,print_count,cancel_id,cancel_date,service_type_id, ");
            s.Append(" note,pathologist_pw,Assistant_pw,technician_pw,freehealth_id,salestype,sync_with_ird,Is_realtime,roundoff,dailynumber,pf,speciality,patienttype, ");
            s.Append(" mrlocation,patient_category,insurance,night,ird_datetime,note1,note2,patient_type,claim_code,branch_center,return_id,labsms,telemedicine, ");
            s.Append(" telemedicineId,lab_report_upload,lab_report_upload_time,website,ssf,ssf_scheme_id,ssf_pc,fileupload,insurance_amount,reportuserid) ");
            s.Append(" select DDATE,HOSPID,INV_NO1,AC_CODE,REFID,AMOUNT,DISCOUNT,VAT,PAID,TENDER,[USER],BILLTIME,MEMBER,DUE,BILLMODE,P_TYPE,REMARKS,POSTED, ");
            s.Append(" CONTACT,INV_NO,FY,AGEDAY,FIRM,hospid1,canceled,PostLedger,ADVANCE,ipd,ipdno,pathologist,technician,bedno,labno,collection_date,report_date,grpid,scheme,clinical, ");
            s.Append(" footer,EDITED,er,appointment_id,reg,RegType,MartialStatus,Occupation,email,consid,FOREIGNER,Assistant,appby,telno,reqby,organization,dpid,xchange, ");
            s.Append(" foreign_currenty,foreign_amount,foreign_discount,foreign_vat,barcode,sms,collection_time,report_time,prev_inv_no,refund,print_count,cancel_id,cancel_date,service_type_id, ");
            s.Append(" note,pathologist_pw,Assistant_pw,technician_pw,freehealth_id,salestype,sync_with_ird,Is_realtime,roundoff,dailynumber,pf,speciality,patienttype, ");
            s.Append(" mrlocation,patient_category,insurance,night,ird_datetime,note1,note2,patient_type,claim_code,branch_center,return_id,labsms,telemedicine, ");
            s.Append(" telemedicineId,lab_report_upload,lab_report_upload_time,website,ssf,ssf_scheme_id,ssf_pc,fileupload,insurance_amount,@userid from #tempopdbill ");
            s.Append(" delete from tempopdrec where report_userid=@userid ");
            s.Append(" insert into tempopdrec (SN,HOSPID,DDATE,INV_NO1,SERVID,QTY,RATE,DISC,VAT,INV_NO,DONE,PANEL,hospid1,firm,finish_date,finish_time,formatted, ");
            s.Append(" lines,DISC2,disc_amt,vatamt,dueamt,paid,process,r_no,due,duepaid,rdate,sample_collected,sample_date,sample_userid,cost,xchange,testnote, ");
            s.Append(" refund,sample_no,report_datetime,result_id,verified_id,report_userid,resulted,verified,reported,pathologist_id,technician_id,assistant_id ");
            s.Append(" ) ");
            s.Append(" select SN,HOSPID,DDATE,INV_NO1,SERVID,QTY,RATE,DISC,VAT,INV_NO,DONE,PANEL,hospid1,firm,finish_date,finish_time,formatted, ");
            s.Append(" lines,DISC2,disc_amt,vatamt,dueamt,paid,process,r_no,due,duepaid,rdate,sample_collected,sample_date,sample_userid,cost,xchange,testnote, ");
            s.Append(" refund,sample_no,report_datetime,result_id,verified_id,@userid,resulted,verified,reported,pathologist_id,technician_id,assistant_id ");
            s.Append(" from #tempopdrec ");
            s.Append(" select (case when @val=1 then a.refid ");
            s.Append(" when @val=0 then a.consid end) as refid ");
            s.Append(" , b.referer, sum(c.qty) as NOB, ");
            s.Append(" sum(c.disc_amt) as disc, sum( (c.qty*c.rate)-c.disc_amt ) as namt ");
            s.Append(" from #tempopdbill a ");
            s.Append(" left join referer b on (case when @val=1 then a.refid ");
            s.Append(" when @val=0 then a.consid end)=b.refid ");
            s.Append(" left join #tempopdrec c on a.inv_no=c.inv_no ");
            s.Append(" where a.ddate>=@init and a.ddate<=@final and isnull(a.canceled,0)=0 ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = case when @insurance = 2 then a.insurance else @insurance end ");
            s.Append(" and b.referer like '%'+@search+'%' ");
            s.Append(" group by b.referer , ");
            s.Append(" (case when @val=1 then a.refid ");
            s.Append(" when @val=0 then a.consid end) ");
            s.Append(" order by ");
            s.Append(" (case when @val=1 then a.refid ");
            s.Append(" when @val=0 then a.consid end) ");
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


        public void RefererAnaGetSum()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_RefererAnalysisSumGetByDate(@init datetime, @final datetime, @firm int,@ipd int, @insurance int, @val int,@search varchar(50)) ");
            s.Append(" as ");
            s.Append(" select sum(c.qty) as NOB, ");
            s.Append(" sum(c.disc_amt) as disc, sum( (c.qty*c.rate)-c.disc_amt ) as namt ");
            s.Append(" from tempopdbill1 a ");
            s.Append(" left join referer b on (case when @val=1 then a.refid ");
            s.Append(" when @val=0 then a.consid end)=b.refid ");
            s.Append(" left join tempopdrec1 c on a.inv_no=c.inv_no ");
            s.Append(" where a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and a.firm=@firm ");
            s.Append(" and a.ipd = case when @ipd = 2 then a.ipd else @ipd end ");
            s.Append(" and a.insurance = case when @insurance = 2 then a.insurance else @insurance end ");
            s.Append(" and b.referer like '%'+@search+'%' ");

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