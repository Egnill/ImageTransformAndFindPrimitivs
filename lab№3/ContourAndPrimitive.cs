using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using static lab_3.Storage;


namespace lab_3
{
    class ContourAndPrimitive
    {
        public ContourAndPrimitive(string fileName)
        {
            SetSourceImage(new Image<Bgr, byte>(fileName));
            SetResImage(new Image<Bgr, byte>(fileName));
        }

        public void Reset()
        {
            SetResImage(GetSourceImage.Clone());
        }

        public Image<Bgr, byte> GetImage()
        {
            return GetSourceImage;
        }

        private Image<Gray, byte> Blur(Image<Bgr, byte> sourceImage)
        {
            var grayImage = sourceImage.Convert<Gray, byte>();
            
            var bluredImage = grayImage.SmoothGaussian(kernelSize);

            return grayImage;
        }

        private Image<Gray, byte> FindingAreaInterest(Image<Gray, byte> bluredImage)
        {
            var binarizedImage = bluredImage.ThresholdBinary(new Gray(Threshold), color);

            return binarizedImage;
        }

        private List<CircleF> FindingContourCircle(Image<Gray, byte>  bluredImage)
        {
            List<CircleF> circles = new List<CircleF>(CvInvoke.HoughCircles(bluredImage,
                 HoughType.Gradient,
                 1.0,
                 minDistance,
                 100,
                 acTreshold,
                 minRadius,
                 maxRadius));

            return circles;
        }

        private void FindingContour(Image<Gray, byte> binarizedImage)
        {
            CvInvoke.FindContours(
             binarizedImage,
             contours,
             null,
             RetrType.External,
             ChainApproxMethod.ChainApproxNone);
        }

        private Image<Bgr, byte> DrawinCounter()
        {
            for (int i = 0; i < contours.Size; i++)
            {
                var points = contours[i].ToArray();
                GetResImage.Draw(points, new Bgr(Color.GreenYellow), 2);
            }
            return GetResImage;
        }

        public int GetNumberPrimitives()
        {
            return numberOfPrimitives;
        }

        #region Draw
        public Image<Bgr, byte> Draw(TypeFinding TypeFinding, Primitive Primitive, int threshold, int minArea, int Color = 0)
        {
            Threshold = threshold;
            MinArea = minArea;
            var blurImage = Blur(GetSourceImage);
            switch (TypeFinding)
            {
                case TypeFinding.Bin:
                    {
                        switch (Primitive)
                        {
                            case Primitive.Triangle:
                                {
                                    kernelSize = 3;
                                    var cannyEdges = blurImage.PyrDown().PyrUp().Canny(100, 100);
                                    FindingContour(FindingAreaInterest(cannyEdges));
                                    return DrawingTriangle();
                                }
                            case Primitive.Rectangle:
                                {
                                    var FAI = FindingAreaInterest(blurImage.PyrDown().PyrUp());
                                    FindingContour(FAI);
                                    return DrawingRectangle();
                                }
                            case Primitive.Circle:
                                {
                                    var cannyEdges = blurImage.Canny(80, 40);
                                    var FAI = FindingAreaInterest(cannyEdges);
                                    return DrawingCircle(FAI);
                                }
                            default:
                                return null;
                        }
                    }
                case TypeFinding.Color:
                    {
                        var colorChannel = FindingChannel(Color);
                        switch (Primitive)
                        {
                            case Primitive.Triangle:
                                {
                                    //var cannyEdges = colorChannel.Canny(200, 200);
                                    FindingContour(colorChannel);
                                    return DrawingTriangle();
                                }
                            case Primitive.Rectangle:
                                {
                                    //var FAI = FindingAreaInterest(colorChannel);
                                    FindingContour(colorChannel);
                                    return DrawingRectangle();
                                }
                            case Primitive.Circle:
                                {
                                    /*var cannyEdges = colorChannel.Canny(80, 40);
                                    var FAI = FindingAreaInterest(cannyEdges);*/
                                    return DrawingCircle(colorChannel);
                                }
                            default:
                                return null;
                        }
                    }
                case TypeFinding.Bright:
                    {
                        var kern = CvInvoke.GetStructuringElement(ElementShape.Cross, new Size(5, 5), new Point(-1, -1));
                        var t = new Image<Gray, byte>(GetSourceImage.Size);
                        CvInvoke.MorphologyEx(FindingBrightness(30, 10), t, MorphOp.Open, kern, new Point(-1, -1), 4, BorderType.Default, new MCvScalar());
                        FindingContour(t);
                        return DrawinCounter();
                    }
                default:
                    return null;
            }
        }

        private Image<Bgr, byte> DrawingTriangle()
        {
            kernelSize = 5;
            numberOfPrimitives = 0;
            for (int i = 0; i < contours.Size; i++)
            {
                VectorOfPoint approxContour = new VectorOfPoint();
                CvInvoke.ApproxPolyDP(
                    contours[i],
                    approxContour,
                    CvInvoke.ArcLength(contours[i], true) * 0.05,
                    true);
                if (CvInvoke.ContourArea(approxContour, false) > MinArea && approxContour.Size == 3)
                {
                    numberOfPrimitives++;
                    var points = approxContour.ToArray();
                    GetResImage.Draw(points, new Bgr(Color.GreenYellow), 2);
                }
            }

            return GetResImage;
        }

        private Image<Bgr, byte> DrawingRectangle()
        {
            kernelSize = 5;
            numberOfPrimitives = 0;
            for (int i = 0; i < contours.Size; i++)
            {
                VectorOfPoint approxContour = new VectorOfPoint();
                CvInvoke.ApproxPolyDP(
                    contours[i],
                    approxContour,
                    CvInvoke.ArcLength(contours[i], true) * 0.05,
                    true);
                var points = approxContour.ToArray();
                if (CvInvoke.ContourArea(approxContour, false) > MinArea && isRectangle(points))
                {
                    numberOfPrimitives++;
                    GetResImage.Draw(CvInvoke.MinAreaRect(approxContour), new Bgr(Color.GreenYellow), 2);
                }
            }
            return GetResImage;
        }

        private Image<Bgr, byte> DrawingCircle(Image<Gray, byte> FAI)
        {
            kernelSize = 9;
            List<CircleF> circles = FindingContourCircle(FAI);
            numberOfPrimitives = circles.Count;
            foreach (CircleF circle in circles)
            {
                GetResImage.Draw(circle, new Bgr(Color.Blue), 2);
            }
            return GetResImage;
        }
        #endregion
        private bool isRectangle(Point[] points)
        {
            int delta = 10;
            LineSegment2D[] edges = PointCollection.PolyLine(points, true);
            for (int i = 0; i < edges.Length; i++)
            {
                double angle = Math.Abs(edges[(i + 1) %
                edges.Length].GetExteriorAngleDegree(edges[i]));
                if (angle < 90 - delta || angle > 90 + delta)
                {
                    return false;
                }
            }
            return true;
        }
        
        public Image<Gray, byte> FindingChannel(int color)
        {
            return GetSourceImage.Split()[color];
        }

        public Image<Gray, byte> FindingBrightness(byte color, byte rangeDelta)
        {
            var hsvImage = GetSourceImage.Convert<Hsv, byte>();
            var hueChannel = hsvImage.Split()[0];

            return hueChannel.InRange(new Gray(color - rangeDelta), new Gray(color + rangeDelta)).Convert<Gray, byte>();
        }
    }
}
