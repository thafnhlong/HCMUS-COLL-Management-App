using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utils.Validator
{
    public class BaseValidator : Component
    {
        static List<BaseValidator> ListValidator = new List<BaseValidator>();
        public static void ClearList()
        {
            ListValidator.Clear();
        }

        public static bool CheckAll()
        {
            foreach (BaseValidator valid in ListValidator)
            {
                if (valid.errorProvider.GetError(valid.Target).Length != 0)
                    return false;
            }
            return true;
        }

        public BaseValidator()
        {
            ListValidator.Add(this);
        }

        ErrorProvider errorProvider = new ErrorProvider();

        public string ErrorMessage { get; set; } = "_ERROR_";

        [TypeConverter(typeof(ReferenceConverter))]
        public Control Target
        {
            get
            {
                return target;
            }

            set
            {
                if (target != null && !DesignMode)
                    target.Validating -= Validating;
                target = value;
                if (target != null && !DesignMode)
                    target.Validating += Validating;
            }
        }
        Control target;

        private void Validating(object sender, CancelEventArgs e)
        {
            if (Validate())
                errorProvider.SetError(Target, "");
            else
                errorProvider.SetError(Target, ErrorMessage);
        }

        public virtual bool Validate()
        {
            return true;
        }
    }
}
