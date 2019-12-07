using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Validator
{
    public class EmptyValidator:BaseValidator
    {
        public override bool Validate()
        {
            return Target.Text.Length != 0;
        }
    }
}
