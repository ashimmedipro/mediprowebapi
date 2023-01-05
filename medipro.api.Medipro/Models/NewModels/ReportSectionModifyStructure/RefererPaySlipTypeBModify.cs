using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.ReportSectionModifyStructure
{
    public class RefererPaySlipTypeBModify
    {
        public void TempRefererTemplateInsert()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_temp_RefererTemplateSearchInsert @tempalteid int, @userid int, @all bit, @already bit ");
            s.Append(" as ");
            s.Append(" if @all=1 ");
            s.Append(" begin ");
            s.Append(" delete from temp_RefererTemplateSearch where userid=@userid ");
            s.Append(" insert into temp_RefererTemplateSearch (tempalteid, userid) ");
            s.Append(" select sn, @userid from referer_analysis_template where typeid=0 ");
            s.Append(" end ");
            s.Append(" if @all=0 ");
            s.Append(" begin ");
            s.Append(" if @already=1 ");
            s.Append(" begin ");
            s.Append(" delete from temp_RefererTemplateSearch where userid=@userid and tempalteid=@tempalteid ");
            s.Append(" end ");
            s.Append(" if @already=0 ");
            s.Append(" begin ");
            s.Append(" insert into temp_RefererTemplateSearch (tempalteid, userid) values (@tempalteid, @userid) ");
            s.Append(" end ");
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

        //

        public void RefererPaySlipGetTemplate()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" CREATE procedure sp_RefererPaySlipGetTemplate ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select * from referer_analysis_template where isnull(typeid,0)=0 ");
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

        //

        public void TempRefererTemplateDelete()
        {
            StringBuilder s = new StringBuilder();

            s.Append(" create procedure sp_temp_RefererTemplateSearchDelete @tempalteid int, @userid int, @ALL BIT ");
            s.Append(" as ");
            s.Append(" if @all=1 ");
            s.Append(" begin ");
            s.Append(" delete from temp_RefererTemplateSearch where userid=@userid ");
            s.Append(" end ; ");
            s.Append(" if @all=0 ");
            s.Append(" begin ");
            s.Append(" delete from temp_RefererTemplateSearch where userid=@userid and tempalteid=@tempalteid ");
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

        //

        public void RefererPaySlipSelect()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" CREATE procedure sp_RefererPaySlipSelectFromtRefererAnalysis1 @init datetime, @final datetime,@val int ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" IF EXISTS(SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES ");
            s.Append(" WHERE TABLE_NAME = 'tRefererAnalysis1') ");
            s.Append(" DROP TABLE tRefererAnalysis1 ");
            s.Append(" IF EXISTS(SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES ");
            s.Append(" WHERE TABLE_NAME = '#TEMP_OPDBILL') ");
            s.Append(" DROP TABLE #TEMP_OPDBILL ");
            s.Append(" IF EXISTS(SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES ");
            s.Append(" WHERE TABLE_NAME = '#TEMP_OPDREC') ");
            s.Append(" DROP TABLE #TEMP_OPDREC ");
            s.Append(" SELECT * INTO #TEMP_OPDBILL FROM OPDBILL WHERE firm=1 and DDATE BETWEEN @init AND @final ");
            s.Append(" SELECT * INTO #TEMP_OPDREC FROM OPDREC WHERE firm=1 and DDATE BETWEEN @init AND @final ");
            s.Append(" select a.ddate, a.inv_no,(case when @val=1 then b.refid when @val=0 then b.consid end) as refid, c.grpid, e.groupname, f.detail, ");
            s.Append(" a.servid, a.qty, a.rate, a.disc, a.disc_amt, a.vat , d.pc, d.amount, d.tds, d.discount, d.gross, ");
            s.Append(" cast( ( (a.qty*a.rate)- (a.disc_amt) )*d.pc/100 as numeric(12,2) ) as RefAmt , ");
            s.Append(" cast( ( ( (a.qty*a.rate)- (a.disc_amt) )*d.pc/100 ) *d.tds/100 as numeric(12,2)) as RefTDS, ");
            s.Append(" cast( ( ( (a.qty*a.rate)- (a.disc_amt) )*d.pc/100 ) as numeric(12,2) ) - ");
            s.Append(" cast( ( ( ( (a.qty*a.rate)- (a.disc_amt) )*d.pc/100 ) *d.tds/100 ) as numeric(12,2) ) as RefNet ");
            s.Append(" into tRefererAnalysis1 ");
            s.Append(" from #TEMP_OPDREC a ");
            s.Append(" left join #TEMP_OPDBILL b on a.inv_no=b.inv_no ");
            s.Append(" left join service c on a.servid=c.servid ");
            s.Append(" left join referer_analysis_service d on (case when @val=1 then b.refid when @val=0 then b.consid end)=d.refid and c.servid=d.servid ");
            s.Append(" left join servgroup e on c.grpid=e.grpid ");
            s.Append(" left join division f on f.dp_id=e.dp_id ");
            s.Append(" where d.pc>0 ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and f.detail=1 and e.referer=1 ");
            s.Append(" and (case when @val=1 then b.refid when @val=0 then b.consid end) in (select refid from referer where 1=1 ");
            s.Append(" and (case when @val=1 then templateid when @val=0 then consultid end) in (select TEMPALTEID from temp_RefererTemplateSearch where userid=1 ) ");
            s.Append(" ) ");
            s.Append(" union all ");
            s.Append(" select a.ddate, a.inv_no,(case when @val=1 then b.refid when @val=0 then b.consid end) as refid, c.grpid, e.groupname, f.detail, a.servid, a.qty, a.rate, a.disc,a.disc_amt, a.vat , d.pc, d.amount, d.tds, d.discount, d.gross, ");
            s.Append(" cast( (a.qty*d.amount) as numeric(12,2) ) as RefAmt , ");
            s.Append(" cast( ( (a.qty*d.amount) ) *d.tds/100 as numeric(12,2) ) as RefTDS, ");
            s.Append(" cast( (a.qty*d.amount) - ");
            s.Append(" ( (a.qty*d.amount) ) *d.tds/100 as numeric(12,2) ) as RefNet ");
            s.Append(" from #TEMP_OPDREC a ");
            s.Append(" left join #TEMP_OPDBILL b on a.inv_no=b.inv_no ");
            s.Append(" left join service c on a.servid=c.servid ");
            s.Append(" left join referer_analysis_service d on (case when @val=1 then b.refid when @val=0 then b.consid end)=d.refid and c.servid=d.servid ");
            s.Append(" left join servgroup e on c.grpid=e.grpid ");
            s.Append(" left join division f on f.dp_id=e.dp_id ");
            s.Append(" where d.amount>0 ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and f.detail=1 and e.referer=1 ");
            s.Append(" and (case when @val=1 then b.refid when @val=0 then b.consid end) in (select refid from referer where 1=1 ");
            s.Append(" and (case when @val=1 then templateid when @val=0 then consultid end) in (select TEMPALTEID from temp_RefererTemplateSearch where userid=1 ) ");
            s.Append(" ) ");
            s.Append(" union all ");
            s.Append(" select a.ddate, a.inv_no, (case when @val=1 then b.refid when @val=0 then b.consid end) as refid, e.dp_id as grpid, f.groupname, f.detail, a.servid, a.qty, a.rate, a.disc, a.disc_amt, a.vat , d.pc, d.amount, d.tds, d.discount, d.gross, ");
            s.Append(" cast( ( (a.qty*a.rate)- (a.disc_amt) )*d.pc/100 as numeric(12,2) ) as RefAmt , ");
            s.Append(" cast( ( ( (a.qty*a.rate)- (a.disc_amt) )*d.pc/100 ) *d.tds/100 as numeric(12,2)) as RefTDS, ");
            s.Append(" cast( ( ( (a.qty*a.rate)- (a.disc_amt) )*d.pc/100 ) as numeric(12,2) ) - ");
            s.Append(" cast( ( ( ( (a.qty*a.rate)- (a.disc_amt) )*d.pc/100 ) *d.tds/100 ) as numeric(12,2) ) as RefNet ");
            s.Append(" from #TEMP_OPDREC a ");
            s.Append(" left join #TEMP_OPDBILL b on a.inv_no=b.inv_no ");
            s.Append(" left join service c on a.servid=c.servid ");
            s.Append(" left join referer_analysis_service d on (case when @val=1 then b.refid when @val=0 then b.consid end)=d.refid and c.servid=d.servid ");
            s.Append(" left join servgroup e on c.grpid=e.grpid ");
            s.Append(" left join division f on f.dp_id=e.dp_id ");
            s.Append(" where d.pc>0 ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and f.detail=0 and e.referer=1 ");
            s.Append(" and (case when @val=1 then b.refid when @val=0 then b.consid end) in (select refid from referer where 1=1 ");
            s.Append(" and (case when @val=1 then templateid when @val=0 then consultid end) in (select TEMPALTEID from temp_RefererTemplateSearch where userid=1 ) ");
            s.Append(" ) ");
            s.Append(" union all ");
            s.Append(" select a.ddate, a.inv_no, (case when @val=1 then b.refid when @val=0 then b.consid end) as refid, e.dp_id as grpid, f.groupname, f.detail, a.servid, a.qty, a.rate, a.disc, a.disc_amt, a.vat , d.pc, d.amount, d.tds, d.discount, d.gross, ");
            s.Append(" cast( (a.qty*d.amount) as numeric(12,2) ) as RefAmt , ");
            s.Append(" cast( ( (a.qty*d.amount) ) *d.tds/100 as numeric(12,2) ) as RefTDS, ");
            s.Append(" cast( (a.qty*d.amount) - ");
            s.Append(" ( (a.qty*d.amount) ) *d.tds/100 as numeric(12,2) ) as RefNet ");
            s.Append(" from #TEMP_OPDREC a ");
            s.Append(" left join #TEMP_OPDBILL b on a.inv_no=b.inv_no ");
            s.Append(" left join service c on a.servid=c.servid ");
            s.Append(" left join referer_analysis_service d on (case when @val=1 then b.refid when @val=0 then b.consid end)=d.refid and c.servid=d.servid ");
            s.Append(" left join servgroup e on c.grpid=e.grpid ");
            s.Append(" left join division f on f.dp_id=e.dp_id ");
            s.Append(" where d.amount>0 ");
            s.Append(" and a.ddate>=@init and a.ddate<=@final ");
            s.Append(" and f.detail=0 and e.referer=1 ");
            s.Append(" and (case when @val=1 then b.refid when @val=0 then b.consid end) in (select refid from referer where 1=1 ");
            s.Append(" and (case when @val=1 then templateid when @val=0 then consultid end) in (select TEMPALTEID from temp_RefererTemplateSearch where userid=1 ) ");
            s.Append(" ) ");
            s.Append(" select b.ac_code, a.refid, b.referer, b.address, b.telephone, sum(a.qty) as qty , sum(a.qty*a.rate) as amount, sum(a.qty*a.rate*a.disc/100) as discount, ");
            s.Append(" sum( (a.qty*a.rate)- (a.qty*a.rate*a.disc/100) ) as Net, ");
            s.Append(" sum(a.refamt) as RefAmt, sum(a.reftds) as Tds, sum(a.refnet) as RefNet ");
            s.Append(" from trefererAnalysis1 a ");
            s.Append(" left join referer b on a.refid=b.refid ");
            s.Append(" where (a.disc<=a.discount ) ");
            s.Append(" group by a.refid, b.referer,b.address, b.telephone, b.ac_code order by b.referer ");
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

        //

        public void RefPaySlipTotal()
        {
            StringBuilder s = new StringBuilder();


            s.Append(" CREATE procedure sp_RefererPaySlipGetTotal ");
            s.Append(" as ");
            s.Append(" begin ");
            s.Append(" begin try ");
            s.Append(" begin transaction ");
            s.Append(" select sum(a.qty) as qty , sum(a.qty*a.rate) as amount, sum(a.qty*a.rate*a.disc/100) as discount, ");
            s.Append(" sum( (a.qty*a.rate)- (a.qty*a.rate*a.disc/100) ) as Net, ");
            s.Append(" sum(a.refamt) as RefAmt, sum(a.reftds) as Tds, sum(a.refnet) as RefNet ");
            s.Append(" from trefererAnalysis1 a ");
            s.Append(" where a.disc<=a.discount ");
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