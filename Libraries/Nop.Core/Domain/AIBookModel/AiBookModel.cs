﻿using Nop.Core.Domain.Localization;
using Nop.Core.Domain.TableOfContent;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Core.Domain.AIBookModel
{
    public partial class AiBookModel : BaseEntity, ILocalizedEntity
    {


        /// <summary>
        /// 知识点ID
        /// </summary>
        public int BookDirID { get; set; }


        public string Name { get; set; }

        public string Desc { get; set; }

        /// <summary>
        /// 目录标识
        /// </summary>
        public string UniqueID { get; set; }
        /// <summary>
        /// web 3d GLB模型地址 
        /// </summary>
        public string WebModelUrl { get; set; }
        /// <summary>
        /// Webgltf 模型地址 
        /// </summary>
        public string WebGltfUrl { get; set; }

        /// <summary>
        /// Web bin格式地址
        /// </summary>
        public string WebBinUrl { get; set; }

        /// <summary>
        /// 模型资源包
        /// </summary>
        public string AbUrl { get; set; }

        public int DisplayOrder { get; set; }
        /// <summary>
        /// 配置信息
        /// </summary>
        public string StrJson { get; set; }




        /// <summary>
        /// Gets or sets a value indicating whether the entity is published
        /// </summary>
        public bool Published { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity has been deleted
        /// </summary>
        public bool Deleted { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether the entity is active
        /// </summary>
        public bool Active { get; set; }


        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance update
        /// </summary>
        public DateTime UpdatedOnUtc { get; set; }

        /// <summary>
        /// 书籍目录
        /// </summary>
        public virtual BookDir BookDir { get; set; }

        public string ImgUrl { get; set; }
    }
}
