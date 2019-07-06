﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Web.Areas.Admin.Models.TableOfContent
{
    public class BookDirSearchModel : BaseSearchModel
    {
        #region Ctor  构造函数

        public BookDirSearchModel()
        {
            AvailableStores = new List<SelectListItem>();
            AvailableBooks = new List<SelectListItem>();
            AvailableCategories = new List<SelectListItem>();
            AvailableBookDirs = new List<SelectListItem>();
        }
        #endregion
        #region Properties

        /// <summary>
        ///
        /// </summary>
        [NopResourceDisplayName("Admin.AiBook.BookDir.List.SearchCategoryName")]
        public string SearchDirName { get; set; }

        /// <summary>
        /// 获取上级目录ID
        /// </summary>
        public int BookDirId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [NopResourceDisplayName("Admin.AiBook.BookDir.List.SearchStore")]
        public int SearchStoreId { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [NopResourceDisplayName("Admin.AiBook.BookDir.List.BookID")]
        public int BookID { get; set; }


        [NopResourceDisplayName("Admin.AiBook.BookDir.List.CategoryID")]
        public int CategoryID { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public IList<SelectListItem> AvailableStores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [NopResourceDisplayName("Admin.AiBook.BookDir.List.AvailableBooks")]
        public IList<SelectListItem> AvailableBooks { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [NopResourceDisplayName("Admin.AiBook.BookDir.List.AvailableBookDirs")]
        public IList<SelectListItem> AvailableBookDirs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [NopResourceDisplayName("Admin.AiBook.BookDir.List.Category")]
        public IList<SelectListItem> AvailableCategories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool HideStoresList { get; set; }
        #endregion
    }
}
