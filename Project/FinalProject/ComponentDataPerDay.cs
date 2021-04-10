using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public class ComponentDataPerDay
    {
        public string LabelData { get; set; }
        public string RichTextBoxData { get; set; }

        public ComponentDataPerDay()
        {
            LabelData = string.Empty;
            RichTextBoxData = string.Empty;
        }
    }
}
