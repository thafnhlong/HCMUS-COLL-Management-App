using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utils.Validator
{
    public class RegexValidator:BaseValidator
    {
        public string Pattern { get; set; } = "";
        public override bool Validate()
        {
            var re = new Regex(Pattern);
            return re.IsMatch(Target.Text);
        }
    }
}
