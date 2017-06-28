using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Soul.Models
{
    [Table("ExchangeActionConfig")]
    public class ExchangeActionConfig
    {
        /// <summary>
        /// ID
        /// </summary>		
        private int? _id;
        public int? ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// 兑换来源
        /// </summary>		
        private string _exchangesource;
        public string ExchangeSource
        {
            get { return _exchangesource; }
            set { _exchangesource = value; }
        }
        /// <summary>
        /// 开始卡号段 可能有多条
        /// </summary>		
        private string _startno;
        public string StartNo
        {
            get { return _startno; }
            set { _startno = value; }
        }
        /// <summary>
        /// 结束卡号段
        /// </summary>		
        private string _endno;
        public string EndNo
        {
            get { return _endno; }
            set { _endno = value; }
        }
        /// <summary>
        /// 卡密前几位 匹配类型
        /// </summary>		
        private string _cardpwdtype;
        public string CardPwdType
        {
            get { return _cardpwdtype; }
            set { _cardpwdtype = value; }
        }
        /// <summary>
        /// 匹配类型 0 卡号段 1卡密
        /// </summary>		
        private int? _exchangetype;
        public int? ExchangeType
        {
            get { return _exchangetype; }
            set { _exchangetype = value; }
        }
        /// <summary>
        /// 备注 
        /// </summary>		
        private string _remarks;
        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        } 
    }
}