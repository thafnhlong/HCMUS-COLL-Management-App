using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Validator
{
    public class DOBValidator : BaseValidator
    {
        public override bool Validate()
        {
            DateTime temp;
            string target = DateTime.ParseExact(Target.Text, "dd-MM-yyyy", null).ToString();
            if (DateTime.TryParse(target, out temp))
                return temp <= DateTime.Now;
            else
                return false;
        }
    }
}
