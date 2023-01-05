using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.AdvanceAndChangeSection
{
    public class AdvanceReceiptModify
    {
        public void AccodeCardSelect()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_accodecardselect1 ");
            s.Append(" as ");
            s.Append(" select AC_CODE,Ref_code,GR_CODE,SB_CODE,FIRM,PARTICULAR,C_PERSON,REG_NO,ADDRESS,TELEPHONE,CR_LIMIT,SECT_CODE,LOCKED,WITHHELD, ");
            s.Append(" FIXED as fixxed,BOSS,CR_DAYS,TDS_CODE,dep_code,Main_Code,serial,inactive,DP_ID,tds,disc,bank_code,bankno,paymode,u_category, ");
            s.Append(" category,debtor,supplier,shortname,BANK,CrCard,PRINT_DATE,term,mobileno,pan,dda,ncda,subledger,email,email1,mobile1,sect_code1,created_date ");
            s.Append(" from ac_code where crcard=1 and len(shortname)>0 ");
            s.Append(" order by shortname ");







            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }
        }

        public void AdvanceNewMemberInsert()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_AdvanceNewMemberInsert( ");
            s.Append(" @Orgid int, @Dptid int, @firm int, @Pid int, @DOb datetime, @ddate datetime, @Exp_date smalldatetime, @pname varchar(50), @Contact varchar(50), ");
            s.Append(" @Address varchar(250), @Sex varchar(10), @Relation varchar(10), @Telephone varchar(50) , ");
            s.Append(" @P_Type varchar(10), @M_Type varchar(1), @member_Remarks varchar(50), @Credit bit, @Locked bit, @WithHeld bit, @Member bit, @CrLimit numeric(16,2), @ac_code int, ");
            s.Append(" @payfrom varchar(15), @MartialStatus varchar(7), @Occupation varchar(25), @email varchar(25), @dis_id tinyint, ");
            s.Append(" @regno varchar(20), @discount_id int, @nagar_vdc_id int, @ethinic_code int, @wardno varchar(3), @member_name_id int , @army_type_id int, @soilder varchar(20) , ");
            s.Append(" @rank_id int , @pension_id int,@units_id int, @relation_id int, @policyid varchar(30), @patient_type varchar(20) , @ref_code varchar(20), @claim_code int, ");
            s.Append(" @rem_balance numeric(12,2), @baby bit, @ssf bit,@adv_remarks varchar(11),@adv_contact varchar(30) ,@amount float,@paid float,@user int,@billtime varchar(15), ");
            s.Append(" @posted bit, @clear_posted bit,@adv_ac_code int,@adv_p_type varchar(4) ");
            s.Append(" ) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" declare @max_sn int , @max_hospid int ");
            s.Append(" select @max_hospid = max(hospid+1) from member ");
            s.Append(" select @max_sn = max(sn+1) from advance ");
            s.Append(" Insert Into Member (Orgid, Hospid, Dptid, firm, Pid, DOb, Ddate, Exp_date, Pname, Contact, Address, Sex, Relation, Telephone , ");
            s.Append(" P_Type, M_Type, Remarks, Credit, Locked, WithHeld, Member, CrLimit, ac_code, payfrom, MartialStatus, ");
            s.Append(" Occupation, email, dis_id, regno, discount_id, nagar_vdc_id, ethinic_code, wardno, ");
            s.Append(" member_name_id , army_type_id , soilder , rank_id , pension_id ,units_id, relation_id, policyid, patient_type , ref_code, claim_code, rem_balance, baby, ssf ) ");
            s.Append(" values( @Orgid, @max_hospid,@Dptid, @firm, @Pid, @DOb, @Ddate, @Exp_date, @Pname, @Contact, @Address, @Sex, @Relation, @Telephone , ");
            s.Append(" @P_Type, @M_Type, @member_Remarks, @Credit, @Locked, @WithHeld, @Member, @CrLimit, @ac_code, @payfrom, @MartialStatus, @Occupation, @email, @dis_id, ");
            s.Append(" @regno, @discount_id, @nagar_vdc_id, @ethinic_code, @wardno, @member_name_id , @army_type_id , @soilder , @rank_id , @pension_id ,@units_id, @relation_id, ");
            s.Append(" @policyid, @patient_type , @ref_code, @claim_code, @rem_balance, @baby, @ssf ) ");
            s.Append(" insert into advance (sn, ddate, hospid, remarks, contact, amount, paid, [user], billtime, posted, clear_posted, p_type, ac_code ) ");
            s.Append(" values(@max_sn,@ddate, @max_hospid, @adv_remarks, @adv_contact, @amount, @paid, @user, @billtime, @posted, @clear_posted, @adv_p_type, @adv_ac_code ) ");
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


        public void AdvanceOldMemberInsert()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_AdvanceOldMemberInsert( ");
            s.Append(" @ddate datetime, @hospid int,@remarks varchar(11),@contact varchar(30) ,@amount float,@paid float,@user int,@billtime varchar(15), ");
            s.Append(" @posted bit, @clear_posted bit,@ac_code int,@p_type varchar(4) ");
            s.Append(" ) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" declare @max_sn int ");
            s.Append(" select @max_sn = max(sn+1) from advance ");
            s.Append(" update member set contact=@contact ");
            s.Append(" where hospid=@hospid ");
            s.Append(" insert into advance (sn, ddate, hospid, remarks, contact, amount, paid, [user], billtime, posted, clear_posted, p_type, ac_code ) ");
            s.Append(" values(@max_sn,@ddate, @hospid, @remarks, @contact, @amount, @paid, @user, @billtime, @posted, @clear_posted, @p_type, @ac_code ) ");
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

        public void AdvanceMemberSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" create procedure sp_AdvMemberSelect ");
            s.Append(" as ");
            s.Append(" select top 100 0 as ac_code1, d.Detail as district, e.nagar_vdc, 0 as member_code, c.fileno, a.*, datediff(year, dob, getdate()) as age, ' ' as orgname, ");
            s.Append(" ' ' as account_name, ' ' as account_name1, b.discount_name, b.type as discount_type from member a WITH (NOLOCK) ");
            s.Append(" left join discount_name b WITH (NOLOCK) on a.discount_id=b.discount_id left join PatientFileNo c WITH (NOLOCK) on a.hospid=c.hospid ");
            s.Append(" LEFT JOIN District d on A.dis_id=d.Dis_id ");
            s.Append(" left join nagar_vdc e on A.nagar_vdc_id=e.sn ");
            s.Append(" where ");
            s.Append(" 1=1 and ");
            s.Append(" member=0 and ");
            s.Append(" locked=0 and ( pname like '%%' or A.hospid like '%') ");
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

    }
}