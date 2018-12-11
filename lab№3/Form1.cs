using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using static lab_3.Storage;

namespace lab_3
{
    public partial class Form1 : Form
    {
        private AffineTransformation AT;
        private ContourAndPrimitive CAP;
        public Form1()
        {
            InitializeComponent();
            imageBox1.MouseClick += new MouseEventHandler(imageBox1_MouseClick);

            PanelScaling.Visible = false;
            PanelShearing.Visible = false;
            PanelRotation.Visible = false;
            PanelReflection.Visible = false;
            PanelConPri.Visible = false;

            AffineT.Enabled = false;
            Reset.Enabled = false;
            ConPri.Enabled = false;

            imageBox1.Visible = false;
            imageBox2.Visible = false;
            Width = 1050;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = null;
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File Image (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            var act = openFileDialog.ShowDialog();
            if (act == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
            }
            
            if (fileName != null)
            {
                AT = new AffineTransformation(fileName);
                CAP = new ContourAndPrimitive(fileName);

                imageBox1.Visible = true;
                imageBox2.Visible = true;
                imageBox1.Image = AT.GetImage();
                imageBox2.Image = AT.GetImage();

                AffineT.Enabled = true;
                Reset.Enabled = true;
                ConPri.Enabled = true;
            }
            else
            {
                MessageBox.Show("Load image", "Error load");
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox1.Image = AT.GetImage();
            imageBox2.Image = AT.GetImage();
            AT.Reset();
            CAP.Reset();
            OutNumber.Text = "0";
        }

        #region LAB#3

        private void imageBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = (int)(e.Location.X / imageBox1.ZoomScale);
            int y = (int)(e.Location.Y / imageBox1.ZoomScale);
            Point center = new Point(x, y);
            int radius = 2;
            int thickness = 2;
            var color = new Bgr(Color.Red).MCvScalar;
            CvInvoke.Circle(AT.GetHomoImage(), center, radius, color, thickness);
            imageBox1.Image = AT.GetHomoImage();
            if (AT.sP.Count != 4)
            {
                AT.sP.Add(new Point(x, y));
            }
        }

        private void scalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Width += 150;
            PanelShearing.Visible = false;
            PanelRotation.Visible = false;
            PanelReflection.Visible = false;
            PanelScaling.Visible = true;
        }

        private void shearingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Width += 150;
            PanelScaling.Visible = false;
            PanelRotation.Visible = false;
            PanelReflection.Visible = false;
            PanelShearing.Visible = true;
        }

        private void rotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Width += 150;
            PanelScaling.Visible = false;
            PanelShearing.Visible = false;
            PanelReflection.Visible = false;
            PanelRotation.Visible = true;
        }

        private void reflectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Width += 150;
            PanelScaling.Visible = false;
            PanelShearing.Visible = false;
            PanelRotation.Visible = false;
            PanelReflection.Visible = true;
        }

        private void homographyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox2.Image = AT.HomoGraphy();
        }

        private void PanelScalingApply_Click(object sender, EventArgs e)
        {
            try
            {
                imageBox2.Image = AT.Scaling(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }
            catch
            {
                MessageBox.Show("Please put a comma and not a period!", "Syntax error");
            }
        }

        private void PanelShearinApply_Click(object sender, EventArgs e)
        {
            try
            {
                imageBox2.Image = AT.Shearing(Convert.ToDouble(textBox3.Text), ListRegarding.Text);
            }
            catch
            {
                MessageBox.Show("Please put a comma and not a period!", "Syntax error");
            }
        }

        private void PanelRottationApply_Click_1(object sender, EventArgs e)
        {
            try
            {
                imageBox2.Image = AT.Rotation(new Point(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text)), Convert.ToInt32(textBox6.Text));
            }
            catch
            {
                MessageBox.Show("Please enter whole numbers!", "Syntax error");
            }
        }

        private void PanelReflectionApply_Click(object sender, EventArgs e)
        {
            imageBox2.Image = AT.Reflection(ListRef.Text);
        }

        private void CloseScaling_Click(object sender, EventArgs e)
        {
            PanelScaling.Visible = false;
            Width -= 150;
        }

        private void CloseShearing_Click(object sender, EventArgs e)
        {
            PanelShearing.Visible = false;
            Width -= 150;
        }

        private void CloseRotation_Click(object sender, EventArgs e)
        {
            PanelRotation.Visible = false;
            Width -= 150;
        }

        private void CloseReflection_Click(object sender, EventArgs e)
        {
            PanelReflection.Visible = false;
            Width -= 150;
        }
        #endregion

        #region LAB#4
        private void ConPri_Click(object sender, EventArgs e)
        {
            Width += 150;
            PanelConPri.Visible = true;
            LBPrimitive.DataSource = Enum.GetValues(typeof(Primitive)).Cast<Primitive>().ToList();
            LBTypeFinding.DataSource = Enum.GetValues(typeof(TypeFinding)).Cast<TypeFinding>().ToList();
            LBColor.DataSource = Enum.GetValues(typeof(ColorFind)).Cast<ColorFind>().ToList();
            LBColor.Visible = false;

        }

        private void CloseConPri_Click(object sender, EventArgs e)
        {
            PanelConPri.Visible = false;
            Width -= 150;
        }

        private void ApplyConPri_Click(object sender, EventArgs e)
        {
            if (LBTypeFinding.SelectedIndex != Convert.ToInt32(TypeFinding.Color))
            {
                imageBox2.Image = CAP.Draw((TypeFinding)LBTypeFinding.SelectedItem,
                                           (Primitive)LBPrimitive.SelectedItem,
                                           Convert.ToInt32(textBoxThreshold.Text),
                                           Convert.ToInt32(textBoxMinArea.Text));
            }
            else
            {
                imageBox2.Image = CAP.Draw((TypeFinding)LBTypeFinding.SelectedItem,
                                           (Primitive)LBPrimitive.SelectedItem,
                                           Convert.ToInt32(textBoxThreshold.Text),
                                           Convert.ToInt32(textBoxMinArea.Text),
                                           LBColor.SelectedIndex);
            }
            OutNumber.Text = Convert.ToString(CAP.GetNumberPrimitives());
        }

        private void LBTypeFinding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBTypeFinding.SelectedIndex == Convert.ToInt32(TypeFinding.Color))
            {
                LBColor.Visible = true;
            }
            else
            {
                LBColor.Visible = false;
            }
        }

        private void LBPrimitive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBPrimitive.SelectedIndex == Convert.ToInt32(Primitive.Triangle))
            {
                textBoxThreshold.Text = "80";
                textBoxMinArea.Text = "256";
            }
            if (LBPrimitive.SelectedIndex == Convert.ToInt32(Primitive.Rectangle))
            {
                textBoxThreshold.Text = "120";
                textBoxMinArea.Text = "99";
            }
            if (LBPrimitive.SelectedIndex == Convert.ToInt32(Primitive.Circle))
            {
                textBoxThreshold.Text = "0";
                textBoxMinArea.Text = "0";
            }
        }
        #endregion
    }
}
