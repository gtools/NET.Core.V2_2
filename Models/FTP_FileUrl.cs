using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NET.Core.V2_2.Models
{
    /// <summary>
    /// 文件URL表
    /// </summary>
    [Table("FTP_FileUrl")]
    public class FTP_FileUrl
    {
        /// <summary>
        /// ID
        /// </summary>
        public int FUId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(50)]
        [Display(Name = "名称")]
        public string Name { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [Required]
        [StringLength(50)]
        [Display(Name = "URL")]
        public string Url { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [Display(Name = "序号")]
        public int Sort { get; set; }

        /// <summary>
        /// 文件组ID
        /// </summary>
        [Required]
        [Display(Name = "文件组")]
        public int FGId { get; set; }

        /// <summary>
        /// 文件组表
        /// </summary>
        public FTP_FileGroup FTP_FileGroup { get; set; }
    }
}
