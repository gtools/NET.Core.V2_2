using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NET.Core.V2_2.Utilities;


namespace NET.Core.V2_2.Models
{
    /// <summary>
    /// 人员表
    /// </summary>
    [Table("SYS_Emp")]
    public class SYS_Emp
    {
        /// <summary>
        /// 工号
        /// </summary>
        [Remote(action: "VerifyEmp_Code", controller: "SYS_Emp")]
        [Required(ErrorMessage = Validate.Required)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = Validate.StringLength)]
        [Display(Name = "工号",Order = 1)]
        public string Emp_Code { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required(ErrorMessage = Validate.Required)]
        [StringLength(50, MinimumLength = 3, ErrorMessage = Validate.StringLength)]
        [Display(Name = "姓名", Order = 2)]
        public string Emp_Name { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        [Required(ErrorMessage = Validate.Required)]
        [Display(Name = "科室", Order = 3)]
        public string Dept_Code { get; set; }
        /// <summary>
        /// 部门表
        /// </summary>
        [Display(Name = "科室", Order = 4)]
        public SYS_Dept SYS_Dept { get; set; }
    }
}
