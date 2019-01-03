using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET.Core.V2_2.Utilities
{
    public class Validate
    {
        /// <summary>
        /// 不能为空
        /// </summary>
        public const string Required = "【{0}】 为必填。";
        public const string Email = "请输入有效的电子邮件地址。";
        public const string Url = "请输入有效的网址。";
        public const string Date = "【{0}】 请输入有效的日期。";
        public const string DateISO = "【{0}】 请输入有效的日期 (YYYY-MM-DD)。";
        public const string Number = "【{0}】 请输入有效的数字。";
        public const string Digits = "【{0}】 只能输入数字。";
        public const string Creditcard = "请输入有效的信用卡号码。";
        public const string EqualTo = "你的输入不相同。";
        public const string Extension = "请输入有效的后缀。";
        public const string StringLengthMax = "【{0}】 最多可以输入 {1} 个字符。";
        public const string StringLengthMin = "【{0}】 最少要输入 {0} 个字符。";
        public const string StringLength = "【{0}】 请输入长度在 {1} 到 {2} 之间的字符。";
        public const string Range = "【{0}】 请输入范围在 {1} 到 {2} 之间的数值。";
        public const string Step = "【{0}】 请输入 {1} 的整数倍值。";
        public const string Max = "【{0}】 请输入不大于 {1} 的数值。";
        public const string Min = "【{0}】 请输入不小于 {1} 的数值。";
        public const string Compare = "【{0}】 不正确。";
        /*
        required: "这是必填字段",
        remote: "请修正此字段",
        email: "请输入有效的电子邮件地址",
        url: "请输入有效的网址",
        date: "请输入有效的日期",
        dateISO: "请输入有效的日期 (YYYY-MM-DD)",
        number: "请输入有效的数字",
        digits: "只能输入数字",
        creditcard: "请输入有效的信用卡号码",
        equalTo: "你的输入不相同",
        extension: "请输入有效的后缀",
        maxlength: $.validator.format( "最多可以输入 {0} 个字符" ),
        minlength: $.validator.format( "最少要输入 {0} 个字符" ),
        rangelength: $.validator.format( "请输入长度在 {0} 到 {1} 之间的字符串" ),
        range: $.validator.format( "请输入范围在 {0} 到 {1} 之间的数值" ),
        step: $.validator.format( "请输入 {0} 的整数倍值" ),
        max: $.validator.format( "请输入不大于 {0} 的数值" ),
        min: $.validator.format( "请输入不小于 {0} 的数值" )
        */
    }
}
