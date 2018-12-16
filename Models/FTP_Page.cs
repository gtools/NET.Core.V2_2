using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET.Core.V2_2.Models
{
    /// <summary>
    /// 页面表
    /// </summary>
    [Table("FTP_Page")]
    public class FTP_Page
    {
        //前台验证
        //[CreditCard]：验证属性是否具有信用卡格式。
        //[Compare]：验证某个模型中的两个属性是否匹配。
        //[EmailAddress]：验证属性是否具有电子邮件格式。
        //[Phone]：验证属性是否具有电话格式。
        //[Range]：验证属性值是否落在给定范围内。
        //[RegularExpression]：验证数据是否与指定的正则表达式匹配。
        //[Required]：将属性设置为必需属性。
        //[StringLength]：验证字符串属性是否最多具有给定的最大长度。
        //[Url]：验证属性是否具有 URL 格式。
        /// <summary>
        /// ID
        /// </summary>
        public int PId { get; set; }

        /// <summary>
        /// 页面地址
        /// </summary>
        [Required]
        [StringLength(50)]
        [Display(Name = "地址")]
        public string Address { get; set; }

        /// <summary>
        /// 页面说明
        /// </summary>
        [StringLength(50)]
        [Display(Name = "页面说明")]
        public string Explain { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [Display(Name = "序号")]
        public int Sort { get; set; }

        /// <summary>
        /// 文件组 列表
        /// </summary>
        public List<FTP_FileGroup> FTP_FileGroups { get; set; }
    }
}
