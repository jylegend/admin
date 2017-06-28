using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Soul.Models
{
    [Table("Product")]
    public class Product
    {
        private int? id;

        /// <summary>
        /// 主键id
        /// </summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string ename;

        /// <summary>
        /// 英文名
        /// </summary>
        public string Ename
        {
            get { return ename; }
            set { ename = value; }
        }

        private double? vipPrice;

        /// <summary>
        /// vip价格
        /// </summary>
        public double? VipPrice
        {
            get { return vipPrice; }
            set { vipPrice = value; }
        }

        private double? currentPrice;

        /// <summary>
        /// 当前价格
        /// </summary>
        public double? CurrentPrice
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }

        private double? costPrice;

        /// <summary>
        /// 成本价格
        /// </summary>
        public double? CostPrice
        {
            get { return costPrice; }
            set { costPrice = value; }
        }

        private string size;

        /// <summary>
        /// 大小
        /// </summary>
        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        private string supplyNo;
        /// <summary>
        /// 供货号
        /// </summary>
        public string SupplyNo
        {
            get { return supplyNo; }
            set { supplyNo = value; }
        }

        private string brand;
        /// <summary>
        /// 所属品牌
        /// </summary>
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
    }
}