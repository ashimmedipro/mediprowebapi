
using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure
{
    public class ChallanModify
    {
        public void challanParty()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" drop procedure sp_SelectPartyByAc_CodeForChallanrec ");
            s.Append(" create procedure sp_SelectPartyByAc_CodeForChallanrec (@search varchar(100)) ");
            s.Append(" as ");
            s.Append(" select top(100) case when ( isnull( a.pan,0))=0 then a.reg_no else CAST( a.pan as varchar) end as reg_no, * from ac_code_view A where ( debtor=1 or sb_code=102 ");
            s.Append(" or a.billmode='Y' ");
            s.Append(" ) and (firm=0 or firm=1 ) AND ");
            s.Append(" (PARTICULAR LIKE '%'+@search+'%' ");
            s.Append(" and paymode<>'Cash' ");
            s.Append(" and (inactive='FALSE' or inactive is null ) ) ");
            s.Append(" order by ");
            s.Append(" particular ");



            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);

            }

        }


        public void ChallanMdCodeSelect()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_GetMdCodeForChallanrec ");//executed
            s.Append(" as ");
            s.Append(" select MD_code,ProdName, cast ( isnull(b.qty,0) as float) as qty,isnull(b.dayss,0) as dayss, ");
            s.Append(" Code, vat_Free, insurance_rate, insurance,ref_code, ");
            s.Append(" compcode, Packing, I_price, Ic_price, c_price, s_price, mrp, EXCISE, EX_PRICE, margin,custom, ");
            s.Append(" vatamt,vat,Disc,OnMinQ*1.00 as OnMinq,OnMinL*1.00 as OnMinL,Bonus*1.00 as Bonus,qty_limit*1.00 as qty_limit, ");
            s.Append(" LotBonus*1.00 as LotBonus,NcBill,NcTrade, ");
            s.Append(" SuperStock,firm,Unit,barcode,wsunit,rolevel,MRP_IC_NC,t_price , drugcat ");
            s.Append(" from drug_view a with (nolock) ");

            s.Append(" left join (select md_code as md_codes, sum(qty) as qty, DATEDIFF(DAY, GETDATE(), min(exp_date)) ");
            s.Append(" as dayss from stbal with (nolock) ");
            // s.Append(" --where firm=3 and ');
            s.Append(" where EXP_DATE>GETDATE() ");
            s.Append(" group by md_code ) b on a.md_code=md_codes ");
            s.Append(" where 1=1 AND qty>0 and ");
            s.Append(" isnull(a.insurance,0)=case when 0=0 then isnull(a.insurance,0) else 0 end and ");
            // s.Append(' --firm=3 and ');
            s.Append(" ( tag<>'I' or tag is null ) AND ");
            s.Append(" status='Active' and ");
            //s.Append(' --firm=3 AND ');
            s.Append(" (prodname like '%' or md_code like '%' or code like '%' or barcode like '%' or ref_code like '%') ");
            s.Append(" order by prodname, code, md_code ");

            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {

                Console.Write("Error info:" + ex.Message);

            }

        }

       // qty mdcode

        public void StbalSelectByMdcode()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_StbalSelectByMdCode @md_code int ");//executed
            s.Append(" as ");
            s.Append(" declare @stop_exp_value int ");
            s.Append(" select @stop_exp_value = value from config where item='STOPEXPAIRY' ");
            s.Append(" SELECT sum(qty-ncommitted) as quantity FROM STBAL with (nolock) WHERE locked=0 and (qty-ncommitted)>0 and md_code=@md_code ");
            s.Append(" and CONVERT(INT,exp_date)-convert(int,GETDATE())>= @stop_exp_value ");
            s.Append(" and purdate<=GETDATE() ");

            try
            {
                DapperHelper.ExecuteSqlStatement(s.ToString());
            }
            catch (Exception ex)
            {

                Console.Write("Error info:" + ex.Message);

            }
        }

     //   get batch by mdcode

        public void StbalSelectByDate()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_StbalSelectbydate @md_code int ");
            s.Append(" as ");
            s.Append(" declare @stop_exp_value int ");
            s.Append(" select @stop_exp_value = value from config where item='STOPEXPAIRY' ");
            s.Append(" select sn, md_code, batch, exp_date, cast( qty as float) as qty, cast( ncommitted as float) as ncommitted , i_price, c_price, ");
            s.Append(" s_price, mrp, excise, locked, remarks, cast(onminq as float) as onminq, cast( bonus as float) as bonus, purdate, firm, mrnno, ");
            s.Append(" ac_code, cast((qty-nCommitted) as float) as Quantity, store , barcode, tran_id, t_price from stbal ");
            s.Append(" where isnull(reserved,0)=0 and locked=0 and (qty-nCommitted)>0 and md_code=@md_code and ");
            s.Append(" CONVERT(INT,exp_date)-convert(int,GETDATE())>@stop_exp_value ");
            s.Append(" order by exp_date ");
        }


        public void ChallanInsert()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_ChallanrecMasterInsert( ");
            s.Append(" @id int, @nid int, @comp_code int , @qty int, @Free int,@md_code int, ");
            s.Append(" @Batch varchar(20), ");
            s.Append(" @Type varchar(10),@Rate numeric(16,2),@CC numeric(16,2), @Disco numeric(16,2), ");
            s.Append(" @Remarks varchar(50), @scheme numeric(16,2), @inv_no varchar(11), @fy varchar(1), @ddate datetime, ");
            s.Append(" @pt_code int, @post bit,@userid int ");
            s.Append(" ) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" declare @max_sn int ");
            s.Append(" select @max_sn=max(sn)+1 from challanrec ");
            s.Append(" insert into challanrec( ");
            s.Append(" id, nid, comp_code, Particular, Pack ,sn, MD_code, qty, Free, Ac_code, Firm, Batch, [Type], MRNNO, Exp_Date, Purdate , ");
            s.Append(" I_price, C_Price, S_PRice, Rate, CC, MRP, VAt, Excise, Disco, Amount, VatAmt, Remarks, scheme, store, inv_no, salestype, fy, ");
            s.Append(" ddate, pt_code, post, bonus, onminq, tran_id, t_price, rep_code, hospid, ipdno, ipd,userid ");
            s.Append(" ) ");
            s.Append(" select ");
            s.Append(" @id, @nid, @comp_code, b.PRODNAME as particular, b.Packing as Pack ,@max_sn, @MD_code, @qty, @Free, Ac_code,'1', Batch, @Type, MRNNO, Exp_Date, Purdate, ");
            s.Append(" b.I_price, b.C_Price, b.S_PRice, @Rate, @CC, b.MRP, 0, b.Excise, @Disco, (@qty*@rate) as amount, b.VatAmt, @Remarks, @scheme, store, ");
            s.Append(" @inv_no,'CH' ,@fy, @ddate, @pt_code, @post, b.bonus, b.onminq, tran_id, b.t_price, 0, 0, 0, 0,@userid from stbal a ");
            s.Append(" left join drug b on (a.MD_CODE=b.MD_CODE) ");
            s.Append(" where sn=@id ");
            s.Append(" update STBAL ");
            s.Append(" set QTY=QTY-(@qty+@Free) ");
            s.Append(" where sn=@id ");
            s.Append(" commit transaction ");
            s.Append(" end try ");
            s.Append(" begin catch ");
            s.Append(" rollback transaction ");
            s.Append(" select ERROR_MESSAGE() as err_msg, ERROR_NUMBER() as errnunber, ");
            s.Append(" ERROR_STATE() as errstate ");
            s.Append(" end catch ");
            s.Append(" end ");

        }


        public void ChallanSelectByDate()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_ChallanrecSelectByDate (@init_date datetime, @final_date datetime) ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" select c.bs_date, a.ddate, a.inv_no, a.pt_code, a.hospid, a.ipdno, a.ipd, d.pname, b.particular, ");
            s.Append(" case when isnull(a.hospid,0)>0 then d.pname else b.particular end as particular_, sum(a.qty*a.rate) as amount, a.post , a.userid ");
            s.Append(" from challanrec a left join ac_code b on a.pt_code=b.ac_code ");
            s.Append(" left join calendar c on (a.ddate=c.ad_date) ");
            s.Append(" left join member d on (a.hospid=d.hospid) ");
            s.Append(" where a.post=0 ");
            s.Append(" and case when isnull(a.hospid,0)>0 then d.pname else b.particular end like '%%' ");
            s.Append(" and a.ddate between @init_date and @final_date ");
            s.Append(" group by a.ddate, a.inv_no, a.pt_code, b.particular, d.pname, a.hospid, a.ipdno, a.ipd, a.post, c.bs_date,a.userid ");
            s.Append(" order by a.ddate, a.inv_no ");
            s.Append(" end ");
        }

        public void ChallanSelectByInvno()
        {
            StringBuilder s = new StringBuilder();
            s.Append(" create procedure sp_ChallanrecSelectbyInvno @inv_no varchar(11) ");
            s.Append(" as ");
            s.Append(" select MD_CODE, particular, batch,pack, qty,[type],rate, DISCO as Discount ,scheme, rate*qty as amount, Remarks from challanrec ");
            s.Append(" where inv_no=@inv_no ");
            s.Append(" order by sn ");
        }

    }
}