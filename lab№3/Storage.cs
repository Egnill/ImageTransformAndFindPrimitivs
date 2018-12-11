using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace lab_3
{
    static class Storage
    {
        public static Image<Bgr, byte> GetSourceImage { get; private set; }

        public static Image<Bgr, byte> GetResImage { get; private set; }

        public static Image<Bgr, byte> SetSourceImage(Image<Bgr, byte> image) => GetSourceImage = image;

        public static Image<Bgr, byte> SetResImage(Image<Bgr, byte> image) => GetResImage = image;

        #region AffineTransformation
        public static Image<Bgr, byte> GetHsImage { get; private set; }
        public static Image<Bgr, byte> SetHsImage(Image<Bgr, byte> image) => GetHsImage = image;

        public static Point point;
        public static double angle = 0.0;
        #endregion

        #region ContourAndPrimitive
        public static VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();

        public enum Primitive
        {
            Triangle,
            Rectangle,
            Circle
        }

        public enum ColorFind
        {
            Blue,
            Green,
            Red
        }

        public enum TypeFinding
        {
            Bin,
            Color,
            Bright
        }

        public static int numberOfPrimitives = 0;
        public static int kernelSize = 5;

        public static int Threshold = 80;
        public static Gray color = new Gray(255);

        public static int MinArea = 256;

        public static double minDistance = 250;
        public static double acTreshold = 36;
        public static int minRadius = 50;
        public static int maxRadius = 150;
        #endregion
    }
}
