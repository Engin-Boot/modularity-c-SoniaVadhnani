using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TelCo.ColorCoder{
    class Mapping{
        private static Color[] colorMapMajor;
        private static Color[] colorMapMinor;


        /// <summary>
        /// Static constructor required to initialize static variable
        /// </summary>
         static Mapping()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }

        #region properties
        //return length
        public Color[] ColorMapMajor
        {
            get
            {
                return colorMapMajor;
            }
        }

        public Color[] ColorMapMinor
        {
            get
            {
                return colorMapMinor;
            }
        }
        #endregion
        
    }
}
