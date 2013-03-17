using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MSpace.Models;

namespace MSpace.Repository
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	PrivateMessageReplyRepository
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Repository
     * 文 件 名:	PrivateMessageReplyRepository
     * 创建时间:	2013/3/15 20:59:41
     * 作    者:	常伟华 Changweihua
	 * 版    权:	PrivateMessageReplyRepository说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	49448113-e78c-478b-87ea-217ebffda36a  
	 *
	 * 登录用户:	Changweihua
	 * 所 属 域:	Lumia800

	 * 创建年份:	2013
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    #endregion

    /// <summary>
    /// 摘要
    /// </summary>
    public class PrivateMessageReplyRepository : RepositoryBase<PrivateMessageReply>
    {
        public override bool Add(PrivateMessageReply Tmodel)
        {
            if (Tmodel == null)
            {
                return false;
            }

            dbContext.PrivateMessageReplys.Add(Tmodel);
            if (dbContext.SaveChanges() == 1)
            {
                return true;
            }
            return false;
        }

        public IQueryable<PrivateMessageReply> List()
        {
            return dbContext.PrivateMessageReplys;
        }
    }
}