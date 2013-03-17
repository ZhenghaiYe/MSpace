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
     * 类 名 称:	ComponentRepository
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Repository
     * 文 件 名:	ComponentRepository
     * 创建时间:	2013/3/8 17:24:21
     * 作    者:	常伟华 Changweihua
	 * 版    权:	ComponentRepository说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	0bed589f-fac6-4fc0-a96e-6d6c381a2d78  
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
    public class ComponentRepository : RepositoryBase<Component>
    {
        public override bool Add(Component Tmodel)
        {
            if (Tmodel == null)
            {
                return false;
            }
            NLog.LogManager.GetCurrentClassLogger().Debug("添加记录");
            dbContext.Components.Add(Tmodel);
            if (dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Delete(int Id)
        {
            Component component = dbContext.Components.SingleOrDefault(_ => _.Id == Id);
            if (component == null)
            {
                return false;
            }
            dbContext.Components.Remove(component);
            if (dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override Component Find(int Id)
        {
            return dbContext.Components.SingleOrDefault(_ => _.Id == Id);
        }

        public IQueryable<Component> List()
        {
            return dbContext.Components;
        }

    }
}