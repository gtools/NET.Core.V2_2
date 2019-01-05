using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NET.Core.V2_2.Utilities;


namespace NET.Core.V2_2.Models
{
    /// <summary>
    /// 菜单表
    /// </summary>
    public class SYS_Navbar
    {
        /// <summary>
        /// id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        [Required(ErrorMessage = Validate.Required)]
        [Display(Name = "菜单名称", Order = 1)]
        public string Name { get; set; }
        /// <summary>
        /// 菜单地址
        /// </summary>
        [Display(Name = "菜单地址", Order = 2)]
        public string Url { get; set; }
        [Display(Name = "动作", Order = 9)]
        public string Action { get; set; }
        [Display(Name = "控制", Order = 8)]
        public string Controller { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [Display(Name = "排序", Order = 3)]
        public int Sort { get; set; }
        /// <summary>
        /// 停用
        /// </summary>
        [Display(Name = "停用", Order = 4)]
        public bool Is_Stop { get; set; }
        /// <summary>
        /// 上级
        /// </summary>
        [Display(Name = "上级菜单", Order = 5)]
        public Guid? ParentId { get; set; }//外键允许为空要加上问号。
        /// <summary>
        /// 上级
        /// </summary>
        [Display(Name = "上级菜单", Order = 5)]
        public SYS_Navbar Father { get; set; }
        /// <summary>
        /// 下级
        /// </summary>
        public List<SYS_Navbar> Childs { get; set; }
    }
}
