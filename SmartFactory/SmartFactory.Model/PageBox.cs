using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

    public class PageBox
    {
        /// <summary>
        /// 当前页
        
        public int PageIndex { get; set; }

        /// <summary>
        /// 总页数
        
        public int PageCount { get; set; }

        /// <summary>
        /// 每页几条数据
        
        public int PageSize { get; set; }

        /// <summary>
        /// 显示数据
        
        public object Data{ get; set; }
    }
