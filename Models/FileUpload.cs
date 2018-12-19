using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NET.Core.V2_2.Models
{
    /// <summary>
    /// 文件上传类
    /// </summary>
    public class FileUpload
    {
        [Required]
        [Display(Name = "文件名")]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "公共清单")]
        public IFormFile UploadPublicSchedule { get; set; }

        [Required]
        [Display(Name = "私有清单")]
        public IFormFile UploadPrivateSchedule { get; set; }
    }
}
