﻿using System;

namespace Mins.QuarkDoc.DataEntities
{
    public class Documents
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 项目主键
        /// </summary>
        public string ApplicationId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 上级目录主键
        /// </summary>
        public string DirectoryId { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 文档内容
        /// </summary>
        public string Document { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 启用标识
        /// </summary>
        public bool IsEnabled { get; set; } = true;

    }
}
