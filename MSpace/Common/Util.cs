using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSpace.Common
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	StringUtil
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Common
     * 文 件 名:	StringUtil
     * 创建时间:	2013/1/20 23:32:21
     * 作    者:	常伟华 Changweihua
	 * 版    权:	StringUtil说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	7769fd4c-1b08-4816-83d3-366de34699bb  
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
    public class CheckCodeUtil
    {
        public static string VerificationText(int Length)
        {
            char[] _verification = new Char[Length];
            Random _random = new Random();
            char[] _dictionary = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < Length; i++)
            {
                _verification[i] = _dictionary[_random.Next(_dictionary.Length - 1)];
            }
            return new string(_verification);
        }
    }
}