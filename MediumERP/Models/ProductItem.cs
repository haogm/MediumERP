using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediumERP.Models
{
    /// <summary>
    /// 大分类的推荐商品
    /// </summary>
    public class SuggestedBigCategoryItems
    {
        /// <summary>
        /// 大分类信息
        /// </summary>
        public BigCategory bigCategory { get; set; }

        /// <summary>
        /// 推荐商品
        /// </summary>
        public List<ProductItem> suggestedProducts { get; set; }
    }

    /// <summary>
    /// 大分类
    /// </summary>
    public class BigCategory
    {
        public string BigCategoryID { get; set; }
        public string BigCategoryName { get; set; }
    }

    /// <summary>
    /// 商品信息
    /// </summary>
    public class ProductItem
    {
        public string ProductID {get;set;}
        public string ProductName { get; set; }
    }
}