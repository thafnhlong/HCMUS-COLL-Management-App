using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils.Validator
{
    public class DOBValidator : BaseValidator
    {
        public override bool Validate()
        {
            //DateTime temp;
            //if (DateTime.TryParse(Target.Text, out temp))
            //    return temp <= DateTime.Now;
            //else
            //    return false;
            var temp = Target as DateTimePicker;
            return temp.Value.Year >= 1900 && temp.Value <= DateTime.Now;
        }
    }
}
