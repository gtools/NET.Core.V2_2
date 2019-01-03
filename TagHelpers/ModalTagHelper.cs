using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace NET.Core.V2_2.TagHelpers
{
    public class ModalTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";    // Replaces <email> with <a> tag
        }
    }
}