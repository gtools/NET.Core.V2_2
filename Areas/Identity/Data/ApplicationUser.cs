using Microsoft.AspNetCore.Identity;
using NET.Core.V2_2.Models;
using System;

namespace NET.Core.V2_2.Areas.Identity.Data
{
    /// <summary>
    /// 用户扩展表
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// 工号
        /// </summary>
        [PersonalData]//标识个人数据
        public string Emp_Code { get; set; }
        /// <summary>
        /// 员工信息表
        /// </summary>
        [PersonalData]
        public SYS_Emp SYS_Emp { get; set; }
    }
}
