using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure
{
    public class OpdRegistrationModify
    {
        public void ServiceSelect()
        {
            StringBuilder s = new StringBuilder(); 

            s.Append(" create procedure sp_ServiceSelectByReg ");
            s.Append(" as ");
            s.Append(" select servid, serial, servname, NewMember, ratea, vat From service where registration=1 order by serial ");







            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void OpdRegServiceSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_OpdRegService ");
            s.Append(" as ");
            s.Append(" select * from service where servid=1001 ");







            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void OpdRegHospidGeneralSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_OpdRegHospidSelect  @search varchar(100) ");
            s.Append(" as ");
            s.Append(" select top 100 0 as ac_code, d.Detail as district, e.nagar_vdc, 0 as member_code, c.fileno, a.*, datediff(year, dob, getdate()) as age, ' ' as orgname, ");
            s.Append(" ' ' as account_name, ' ' as account_name1, b.discount_name, b.type as discount_type from member a WITH (NOLOCK) ");
            s.Append(" left join discount_name b WITH (NOLOCK) on a.discount_id=b.discount_id left join PatientFileNo c WITH (NOLOCK) on a.hospid=c.hospid ");
            s.Append(" LEFT JOIN District d on A.dis_id=d.Dis_id ");
            s.Append(" left join nagar_vdc e on A.nagar_vdc_id=e.sn ");
            s.Append(" where ");
            s.Append(" 1=1 and ");
            s.Append(" member=0 and ");
            s.Append(" locked=0 and ( pname like '%'+@search+'%' or A.hospid like '%'+@search ) ");
            s.Append(" and (address like '%%' and telephone like '%%' ) ");
            s.Append(" and a.hospid= case when 0=0 then a.hospid else 0 end ");






            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void MemberSearch()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_MemberSearch @search varchar(50) ");
            s.Append(" as ");
            s.Append(" select top 100 0 as ac_code, d.Detail as district, e.nagar_vdc, 0 as member_code, c.fileno, a.*, datediff(year, dob, getdate()) as age, ' ' as orgname, ");
            s.Append(" ' ' as account_name, ' ' as account_name1, b.discount_name, b.type as discount_type from member a WITH (NOLOCK) ");
            s.Append(" left join discount_name b WITH (NOLOCK) on a.discount_id=b.discount_id left join PatientFileNo c WITH (NOLOCK) on a.hospid=c.hospid ");
            s.Append(" LEFT JOIN District d on A.dis_id=d.Dis_id ");
            s.Append(" left join nagar_vdc e on A.nagar_vdc_id=e.sn ");
            s.Append(" where ");
            s.Append(" 1=1 and ");
            s.Append(" member=0 and ");
            s.Append(" locked=0 and ( pname like '%'+@search+'%' or A.hospid like '%'+@search+'%' ) ");
            s.Append(" and ( address like '%%' and telephone like '%%' ) ");
            s.Append(" and a.hospid= case when 0=0 then a.hospid else 0 end ");






            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void OpdRegMemberSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" CREATE procedure sp_OpdRegHospidSelectMember (@search varchar(50)) ");
            s.Append(" as ");
            s.Append(" select top 100 ");
            s.Append(" CAST( b.ref_code+ REPLICATE('0',4-len( a.ref_code))+a.ref_code AS VARCHAR(100)) as new_ref_code, b.ac_code as ac_code1, a.ac_code as member_code, A.*, B.ORGNAME, c.particular as account_name, ");
            s.Append(" d.particular as account_name1, b.pharma_disc1, b.pharma_disc2, b.insurance, b.ssf_member, b.insurance_product ");
            s.Append(" from MEMBER A with (nolock) left join ORGANIZ B with (nolock) on A.ORGID=B.ORGID ");
            s.Append(" left join ac_code c with (nolock) on a.ac_code=c.ac_code ");
            s.Append(" left join ac_code d with (nolock) on b.ac_code=d.ac_code ");
            s.Append(" where a.orgid=case when 0=0 then a.orgid else 0 end and a.member=1 and ( ");
            s.Append(" a.policyid like '%%' or a.ref_code like '%' OR ");
            s.Append(" A.PNAME like '%'+@search+'%' ");
            s.Append(" or a.hospid like '%%' or a.telephone like '%%' or b.ref_code+ REPLICATE('0',4-len( a.ref_code))+a.ref_code like '%%' ");
            s.Append(" ) ");
            s.Append(" order by a.hospid ");







            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void OrganizeSelectMember()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" CREATE procedure sp_OrganizeSelect @search varchar(50) ");
            s.Append(" as ");
            s.Append(" select * from organiz ");
            s.Append(" where ( upper(ORGNAME) like '%'+@search+'%') ");
            s.Append(" order by orgname ");






            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void OpdRegDepartmentSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_OpdRegDepartmentSelect @search varchar(50) ");
            s.Append(" as ");
            s.Append(" select * from servgroup ");
            s.Append(" where upper(groupname) like '%'+@search+'%' ");
            s.Append(" AND OPDDEPART=1 ");
            s.Append(" order by groupname ");






            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void OpdRegConsultantSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_OpdRegConsultantSelect ");
            s.Append(" as ");
            s.Append(" select a.*, b.detail from referer a with (nolock) left join speciality b with (nolock) on a.sp_id=b.sp_id ");
            s.Append(" where ( a.referer like '%%' or a.regno like '%%' ) ");
            s.Append(" and isnull(a.consult,0) <> 1 ");
            s.Append(" AND a.status='Active' ");
            s.Append(" order by referer ");






            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void OdRegReferedBySelect()
        {
            StringBuilder s = new StringBuilder();



            s.Append(" create procedure sp_OpdRegReferedBySelect ");
            s.Append(" as ");
            s.Append(" select a.*, b.detail from referer a with (nolock) left join speciality b with (nolock) on a.sp_id=b.sp_id ");
            s.Append(" where ( a.referer like '%%' or a.regno like '%%' ) ");
            s.Append(" and isnull(a.refering,0) <> 1 ");
            s.Append(" AND a.status='Active' ");
            s.Append(" order by referer ");





            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }


        public void OpdRegInsert()
        {
            StringBuilder s = new StringBuilder();



            s.Append(" create procedure sp_OpdRegistrationInsert( ");
            s.Append(" @fy char, @firm int,@reg_inv_no char(11), ");
            s.Append(" @er bit, ");
            s.Append(" @insurance bit,@member bit,@salestype char(2),@servid int,@ddate datetime,@hospid int, ");
            s.Append(" @refid int,@amount numeric(12,2),@userid int,@billtime varchar(15),@billmode varchar(10) ,@p_type varchar(6),@remarks varchar(100),@ageday int,@grpid int, ");
            s.Append(" @consid int,@service_type_id int,@claim_code int,@dailynumber int, ");
            s.Append(" @ipdno int, @ac_code int, @discount numeric(19,2), @vat numeric(19,2), @paid numeric(19,2), @advance numeric(19,2), @tender numeric(19,2), @due numeric(19,2), ");
            s.Append(" @posted bit, @contact varchar(100) , @opdbill_inv_no varchar(11), @canceled bit, @PostLedger bit, @IPD bit, @bedno varchar(15) , @labno varchar(20), @scheme int , ");
            s.Append(" @clinical varchar(100), ");
            s.Append(" @technician int, @pathologist int, ");
            s.Append(" @appointment_id varchar(11), @RegType varchar(11), ");
            s.Append(" @MartialStatus varchar(7), @Occupation varchar(25), @reg bit, @email varchar(50) , @FOREIGNER bit, @appby varchar(30) , @telno varchar(30) , @reqby varchar(30), ");
            s.Append(" @organization varchar(50), @dpid int, @xchange numeric(12,2) , @foreign_currenty varchar(3), @barcode char(12) , @prev_inv_no varchar(11), @refund bit, @freehealth_id int, ");
            s.Append(" @roundoff numeric(12,2),@pf varchar(50) , @speciality varchar(50), @patienttype varchar(50), @mrlocation varchar(50), @patient_category varchar(50), @night bit, ");
            s.Append(" @patient_type varchar(20), @branch_center varchar(20), @return_id int, @ssf bit, @ssf_scheme_id int,@ssf_pc numeric(12,2), @insurance_amount numeric(12,2), ");
            s.Append(" @QTY int, @RATE numeric(19, 2), @DISC numeric(19, 2), @DONE bit, @PANEL bit,@formatted bit,@lines int,@disc_amt numeric(12, 2), ");
            s.Append(" @vatamt numeric(16, 2),@dueamt numeric(16, 2),@process numeric(16, 2), ");
            s.Append(" @r_no varchar (11), @SerialNo int , @rebate numeric (12, 2), @receipt_due varchar(3) ");
            s.Append(" ) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" declare @max_sn int ");
            s.Append(" select @max_sn=max(sn+1) from opdrec ");
            s.Append(" exec sp_registrationInsert @fy, @firm,@reg_inv_no,0,1,@er,@insurance,@member,@salestype,@servid,@ddate,@hospid,@refid,@amount,@userid,@billtime, ");
            s.Append(" @billmode,@p_type,@remarks,@ageday,@grpid,@consid,@service_type_id,@claim_code,@dailynumber ");
            s.Append(" exec sp_Opdbill_Insert @ddate, @hospid, @ipdno, @ac_code, @refid, @firm, @userid, @amount, @discount, @vat, @paid, @advance, @tender, @due, @ageday, ");
            s.Append(" @member, @posted, @billtime, @billmode, @p_type, @remarks, @contact, @opdbill_inv_no, @fy, @canceled, @PostLedger, @IPD, @bedno, @labno, @grpid, @scheme , @clinical, ");
            s.Append(" @er, @ddate, @ddate, @technician, @pathologist, @appointment_id, @RegType, @MartialStatus, @Occupation, ");
            s.Append(" @reg, @email, @consid, @FOREIGNER, @appby, @telno, @reqby, @organization, @dpid, @xchange, @foreign_currenty, ");
            s.Append(" 0, 0, 0, @barcode, @prev_inv_no, @refund, @service_type_id, @freehealth_id, @salestype, @roundoff , @dailynumber , ");
            s.Append(" @pf, @speciality, @patienttype, @mrlocation, @patient_category, @insurance, @night, @patient_type, @claim_code, @branch_center, @return_id, @ssf, @ssf_scheme_id, ");
            s.Append(" @ssf_pc, @insurance_amount ");
            s.Append(" exec sp_OpdrecInsert ");
            s.Append(" @max_sn ,@HOSPID ,@DDATE,'' ,@servid ,@QTY ,@RATE , @DISC ,@VAT ,@opdbill_inv_no ,@DONE ,@PANEL ,0 ,@firm , '' , ");
            s.Append(" '',@formatted ,@lines ,0 , @disc_amt ,@vatamt ,@dueamt ,@paid ,@process ,'' ,'' , ");
            s.Append(" 0 ,'' ,'' ,'' ,'' ,0 ,0 ,'' ,'' ,'' ,'' ,0 ,0 ,0 ,'' ,'' ,'' ,0 ,0 ,0 ");
            s.Append(" exec sp_ReceiptInsert ");
            s.Append(" @R_NO ,@HOSPID ,@DDATE ,@AMOUNT ,@userid ,@BILLTIME ,@receipt_due ,@REMARKS ,@opdbill_inv_no , ");
            s.Append(" @FY ,@firm , @canceled , @PostLedger ,@ipdno ,@ipd ,'' , ");
            s.Append(" @SerialNo ,@refund ,0 , '' , @rebate ");
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