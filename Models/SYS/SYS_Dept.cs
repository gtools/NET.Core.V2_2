using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using NET.Core.V2_2.Utilities;


namespace NET.Core.V2_2.Models
{
    /// <summary>
    /// 科室表
    /// </summary>
    [Table("SYS_Dept")]
    public class SYS_Dept
    {
        /// <summary>
        /// 科室编号
        /// </summary>
        [Remote(action: "VerifyDept_Code", controller: "SYS_Dept")]
        [Required(ErrorMessage = Validate.Required)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = Validate.StringLength)]
        [Display(Name = "科室编号", Order = 1)]
        public string Dept_Code { get; set; }
        /// <summary>
        /// 科室名称
        /// </summary>
        [Required(ErrorMessage = Validate.Required)]
        [StringLength(50, ErrorMessage = Validate.StringLengthMax)]
        [Display(Name = "科室名称", Order = 2)]
        public string Dept_Name { get; set; }
        /// <summary>
        /// 人员表
        /// </summary>
        public List<SYS_Emp> SYS_Emps { get; set; }
    }
}
