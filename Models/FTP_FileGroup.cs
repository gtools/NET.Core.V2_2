using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET.Core.V2_2.Models
{
    /// <summary>
    /// 文件组表
    /// </summary>
    [Table("FTP_FileGroup")]
    public class FTP_FileGroup
    {
        /// <summary>
        /// ID
        /// </summary>
        public int FGId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(50)]
        [Display(Name = "名称")]
        public string Name { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [Display(Name = "序号")]
        public int Sort { get; set; }

        /// <summary>
        /// 页面ID
        /// </summary>
        [Required]
        [Display(Name = "页面")]
        public int PId { get; set; }

        /// <summary>
        /// 页面表
        /// </summary>
        public FTP_Page FTP_Page { get; set; }

        /// <summary>
        /// 文件Url 列表
        /// </summary>
        public List<FTP_FileUrl> FTP_FileUrls { get; set; }
    }
}
