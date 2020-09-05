using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

<<<<<<< HEAD
namespace TelCo.ColorCoder
{
    public class Mapping
    {
        /// <summary>
        /// Array of Major colors
        /// </summary>
=======
namespace TelCo.ColorCoder{
    class Mapping{
>>>>>>> a3d62eb09563100226280ccf6c3e4bac0ceec416
        private static Color[] colorMapMajor;
        private static Color[] colorMapMinor;
<<<<<<< HEAD

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
=======
        static Mapping(){
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray }; }
        internal static ColorPair GetColorFromPairNumber(int pairNumber){
            int minorSize = colorMapMinor.Length;
            int majorSize = colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize){
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));}
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;
            ColorPair pair = new ColorPair(){
                majorColor = colorMapMajor[majorIndex],
                minorColor = colorMapMinor[minorIndex]
            };
            return pair;
        }
        internal static int GetPairNumberFromColor(ColorPair pair) {
            int majorIndex = -1;
            for (int i = 0; i < colorMapMajor.Length; i++){
                if (colorMapMajor[i] == pair.majorColor) {
                    majorIndex = i;
                    break;
                }
            }
            int minorIndex = -1;
            for (int i = 0; i < colorMapMinor.Length; i++){
                if (colorMapMinor[i] == pair.minorColor){
                    minorIndex = i;
                    break;
                }
            }
            if (majorIndex == -1 || minorIndex == -1){
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }}}
>>>>>>> a3d62eb09563100226280ccf6c3e4bac0ceec416
