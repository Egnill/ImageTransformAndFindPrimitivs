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
using static lab_3.Storage;

namespace lab_3
{
    class AffineTransformation
    {
        public List<Point> sP = new List<Point>();

        private delegate void FuncForChannel<Targ0, Targ1, Targ2>(Targ0 y, Targ1 x, Targ2 channel);
        private delegate void FuncForPixel<Targ0, Targ1, Targ2>(Targ0 y, Targ1 x, Targ2 pixel);

        public AffineTransformation(string fileName)
        {
            SetSourceImage(new Image<Bgr, byte>(fileName).Resize(500, 500, Inter.Linear));
            SetHsImage(new Image<Bgr, byte>(fileName).Resize(500, 500, Inter.Linear));
        }

        public Image<Bgr, byte> GetImage()
        {
            return GetSourceImage;
        }

        public Image<Bgr, byte> GetHomoImage()
        {
            return GetHsImage;
        }

        public void Reset()
        {
            SetHsImage(GetSourceImage.Clone());
        }

        public Image<Bgr, byte> Scaling(double sX = 1, double sY = 1)
        {
            var result = new Image<Bgr, byte>((int)(GetSourceImage.Height * sX), (int)(GetSourceImage.Width * sY));
            PixelWalk((y, x, pixel) => 
            { 
                 int newX = (int)(x * sX);
                 int newY = (int)(y * sY);
                 result[newY, newX] = pixel;
            });
            SetResImage(result);
            return BilinearFiltering(result, "Scaling");
        }

        public Image<Bgr, byte> Shearing(double shift = 0, string regarding = "Left")
        {
            switch (regarding)
            {
                case "Left":
                    {
                        Image<Bgr, byte> result = new Image<Bgr, byte>((int)(GetSourceImage.Width + shift * GetSourceImage.Height), GetSourceImage.Height);
                        PixelWalk((y, x, pixel) =>
                        {
                            int newX = (int)(x + shift * (GetSourceImage.Height - y));
                            int newY = y;
                            result[newY, newX] = pixel;
                        });
                        return result;
                    }
                case "Right":
                    {
                        Image<Bgr, byte> result = new Image<Bgr, byte>((int)(GetSourceImage.Width + shift * GetSourceImage.Height), GetSourceImage.Height);
                        PixelWalk((y, x, pixel) =>
                        {
                            int newX = (int)((x + shift * y));
                            int newY = y;
                            result[newY, newX] = pixel;
                        });
                        return result;
                    }
                case "Top":
                    {
                        Image<Bgr, byte> result = new Image<Bgr, byte>(GetSourceImage.Width, (int)(GetSourceImage.Height + shift * GetSourceImage.Height));
                        PixelWalk((y, x, pixel) =>
                        {
                            int newX = x;
                            int newY = (int)(y + shift * (GetSourceImage.Width - x));
                            result[newY, newX] = pixel;
                        });
                        return result;
                    }
                case "Bottom":
                    {
                        Image<Bgr, byte> result = new Image<Bgr, byte>(GetSourceImage.Width, (int)(GetSourceImage.Height + shift * GetSourceImage.Height));
                        PixelWalk((y, x, pixel) =>
                        {
                            int newX = x;
                            int newY = (int)(y + shift * x);
                            result[newY, newX] = pixel;
                        });
                        return result;
                    }
                default:
                    {
                        return null;
                    }
            }
        }

        public Image<Bgr, byte> Rotation(Point center, int ang = 0)
        {
            point = center;
            angle = ang * Math.PI / 180;
            var result = new Image<Bgr, byte>(GetSourceImage.Size);
            PixelWalk((y, x, pixel) =>
            {
                int newX = (int)(Math.Cos(angle) * (x - center.X) - Math.Sin(angle) * (y - center.Y) + center.X);
                int newY = (int)(Math.Sin(angle) * (x - center.X) + Math.Cos(angle) * (y - center.Y) + center.Y);
                if (newX >= 0 && newX < result.Width && newY >= 0 && newY < result.Height)
                {
                    result[newY, newX] = pixel;
                }
            });
            SetResImage(result);
            return BilinearFiltering(result, "Rotation");
        }
        
        public Image<Bgr, byte> Reflection(string com = "Horizontal")
        {
            switch (com)
            {
                case "Horizontal":
                    {
                        Image<Bgr, byte> result = new Image<Bgr, byte>(GetSourceImage.Size);
                        PixelWalk((y, x, pixel) =>
                        {
                            int newX = result.Width - 1 - x;
                            int newY = y;
                            result[newY, newX] = pixel;
                        });

                        return result;
                    }
                case "Vertical":
                    {
                        Image<Bgr, byte> result = new Image<Bgr, byte>(GetSourceImage.Size);
                        PixelWalk((y, x, pixel) =>
                        {
                            int newX = x;
                            int newY = result.Height - 1 - y;
                            result[newY, newX] = pixel;
                        });

                        return result;
                    }
                case "Diagonal":
                    {
                        Image<Bgr, byte> result = new Image<Bgr, byte>(GetSourceImage.Size);
                        PixelWalk((y, x, pixel) =>
                        {
                            int newX = x * (-1) + result.Width - 1;
                            int newY = y * (-1) + result.Height - 1;
                            result[newY, newX] = pixel;
                        });

                        return result;
                    }
                case "Normal":
                    {
                        Image<Bgr, byte> result = new Image<Bgr, byte>(GetSourceImage.Size);
                        PixelWalk((y, x, pixel) =>
                        {
                            int newX = x;
                            int newY = y;
                            result[newY, newX] = pixel;
                        });

                        return result;
                    }
                default:
                    {
                        return null;
                    }
            }
        }

        private Image<Bgr, byte> BilinearFiltering(Image<Bgr, byte> image, string type)
        {
            Image<Bgr, byte> result = new Image<Bgr, byte>(image.Size);

            if (type == "Scaling")
            {
                ChannelWalk((y, x, channel) =>
                {
                    double coefX = (double)result.Width / GetSourceImage.Width; double coefY = (double)result.Height / GetSourceImage.Height;
                    int floorX = (int)(x / coefX); int floorY = (int)(y / coefY);
                    double ratioX = x / coefX - floorX; double ratioY = y / coefY - floorY;
                    double inversXratio = 1 - ratioX; double inversYratio = 1 - ratioY;

                    if (floorX >= 0 && floorX < GetSourceImage.Width - 1 && floorY >= 0 && floorY < GetSourceImage.Height - 1)
                    {
                        double value = (GetSourceImage.Data[floorY, floorX, channel] * inversXratio + GetSourceImage.Data[floorY, floorX + 1, channel] * ratioX) * inversYratio
                                     + (GetSourceImage.Data[floorY + 1, floorX, channel] * inversXratio + GetSourceImage.Data[floorY + 1, floorX + 1, channel] * ratioX) * ratioY;

                        result.Data[y, x, channel] = CheckColor(value);
                    }
                });
            }
            if (type == "Rotation")
            {
                ChannelWalk((y, x, channel) =>
                {
                    double coefX = (Math.Cos(-angle) * (x - point.X) - Math.Sin(-angle) * (y - point.Y) + point.X);
                    int floorX = (int)coefX;
                    double coefY = (Math.Sin(-angle) * (x - point.X) + Math.Cos(-angle) * (y - point.Y) + point.Y);
                    int floorY = (int)coefY;
                    double ratioX = coefX - floorX; double ratioY = coefY - floorY;
                    double inversXratio = 1 - ratioX; double inversYratio = 1 - ratioY;
                    if (floorX >= 0 && floorX < GetResImage.Width - 1 && floorY >= 0 && floorY < GetResImage.Height - 1)
                    {
                        double value = (GetSourceImage.Data[floorY, floorX, channel] * inversXratio + GetSourceImage.Data[floorY, floorX + 1, channel] * ratioX) * inversYratio
                                     + (GetSourceImage.Data[floorY + 1, floorX, channel] * inversXratio + GetSourceImage.Data[floorY + 1, floorX + 1, channel] * ratioX) * ratioY;

                        result.Data[y, x, channel] = CheckColor(value);
                    }
                });
            }
            return result;
        }

        public Image<Bgr, byte> HomoGraphy()
        {
            try
            {
                SortPoint();
                var srcPoints = new PointF[]
                {
                     new PointF(sP[0].X, sP[0].Y),
                     new PointF(sP[1].X, sP[1].Y),
                     new PointF(sP[2].X, sP[2].Y),
                     new PointF(sP[3].X, sP[3].Y)
                };
                var destPoints = new PointF[]
                {
                     new PointF(0, 0),
                     new PointF(0, GetSourceImage.Height - 1),
                     new PointF(GetSourceImage.Width - 1, GetSourceImage.Height - 1),
                     new PointF(GetSourceImage.Width - 1, 0)
                };
                var homographyMatrix = CvInvoke.GetPerspectiveTransform(srcPoints, destPoints);
                var destImage = new Image<Bgr, byte>(GetImage().Size);
                CvInvoke.WarpPerspective(GetImage(), destImage, homographyMatrix, destImage.Size);

                return destImage;
            }
            catch
            {
                MessageBox.Show("Enter 4 points", "Not points");
                return GetSourceImage;
            }
        }

        private void SortPoint()
        {
            Point h = new Point(0, 0);
            for (int i = 0; i < sP.Count; i++)
            {
                for (int j = i + 1; j < sP.Count; j++)
                {
                    if (sP[i].X > sP[j].X)
                    {
                        h = sP[i];
                        sP[i] = sP[j];
                        sP[j] = h;
                    }
                }
            }

            if (sP[0].Y > sP[1].Y)
            {
                h = sP[0];
                sP[0] = sP[1];
                sP[1] = h;
            }

            if (sP[2].Y < sP[3].Y)
            {
                h = sP[2];
                sP[2] = sP[3];
                sP[3] = h;
            }
        }

        private byte CheckColor(double value, int min = 0, int max = 255)
        {
            double res = (value > max) ? max :
                         (value < min) ? min :
                          value;
            return (byte)res;
        }

        private void ChannelWalk(FuncForChannel<int, int, byte> action)
        {
            for (byte channel = 0; channel < GetResImage.NumberOfChannels; channel++)
            {
                for (int y = 0; y < GetResImage.Height; y++)
                {
                    for (int x = 0; x < GetResImage.Width; x++)
                    {
                        action(y, x, channel);
                    }
                }
            }
        }

        private void PixelWalk(FuncForPixel<int, int, Bgr> action)
        {
            for (int y = 0; y < GetSourceImage.Height; y++)
            {
                for (int x = 0; x < GetSourceImage.Width; x++)
                {
                    action(y, x, GetSourceImage[y, x]);
                }
            }
        }
    }
}
