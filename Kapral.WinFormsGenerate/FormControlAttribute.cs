using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kapral.WinFormsGenerate
{
    public class FormControlAttribute : Attribute
    {
        public FormControlType Type { get; set; }

        public string LabelText { get; set; }

        public object DataSourse { get; set; }
    }
}
