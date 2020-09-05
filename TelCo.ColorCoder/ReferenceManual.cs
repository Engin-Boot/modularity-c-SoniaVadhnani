using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.ColorCoder
{
    class ReferenceManual
    {
       
        
        public override string ToString()
        {
            Mapping obj1 = new Mapping();
            string manual="";

            int totalPairs = obj1.ColorMapMajor.Length * obj1.ColorMapMinor.Length;
            for (int i=1;i<=totalPairs;i++)
            {
                manual += i.ToString() + " - " + NumToColor.GetColorFromPairNumber(i) + "\n";   
            }
            return manual;
        }
    }
}
