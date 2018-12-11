namespace lab_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AffineT = new System.Windows.Forms.ToolStripMenuItem();
            this.scalingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shearingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reflectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homographyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Reset = new System.Windows.Forms.ToolStripMenuItem();
            this.ConPri = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelScaling = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseScaling = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanelScalingApply = new System.Windows.Forms.Button();
            this.PanelShearing = new System.Windows.Forms.Panel();
            this.ListRegarding = new System.Windows.Forms.ListBox();
            this.PanelShearinApply = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CloseShearing = new System.Windows.Forms.Button();
            this.PanelRotation = new System.Windows.Forms.Panel();
            this.PanelRottationApply = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CloseRotation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelReflection = new System.Windows.Forms.Panel();
            this.PanelReflectionApply = new System.Windows.Forms.Button();
            this.ListRef = new System.Windows.Forms.ListBox();
            this.CloseReflection = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.PanelConPri = new System.Windows.Forms.Panel();
            this.OutNumber = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxMinArea = new System.Windows.Forms.TextBox();
            this.textBoxThreshold = new System.Windows.Forms.TextBox();
            this.LBColor = new System.Windows.Forms.ListBox();
            this.LBPrimitive = new System.Windows.Forms.ListBox();
            this.LBTypeFinding = new System.Windows.Forms.ListBox();
            this.ApplyConPri = new System.Windows.Forms.Button();
            this.CloseConPri = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.PanelScaling.SuspendLayout();
            this.PanelShearing.SuspendLayout();
            this.PanelRotation.SuspendLayout();
            this.PanelReflection.SuspendLayout();
            this.PanelConPri.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox1.Location = new System.Drawing.Point(12, 34);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(500, 500);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imageBox2.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imageBox2.Location = new System.Drawing.Point(518, 34);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(500, 500);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox2.TabIndex = 3;
            this.imageBox2.TabStop = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // AffineT
            // 
            this.AffineT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scalingToolStripMenuItem,
            this.shearingToolStripMenuItem,
            this.rotationToolStripMenuItem,
            this.reflectionToolStripMenuItem,
            this.homographyToolStripMenuItem});
            this.AffineT.Name = "AffineT";
            this.AffineT.Size = new System.Drawing.Size(135, 20);
            this.AffineT.Text = "Affine Transformation";
            // 
            // scalingToolStripMenuItem
            // 
            this.scalingToolStripMenuItem.Name = "scalingToolStripMenuItem";
            this.scalingToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.scalingToolStripMenuItem.Text = "Scaling";
            this.scalingToolStripMenuItem.Click += new System.EventHandler(this.scalingToolStripMenuItem_Click);
            // 
            // shearingToolStripMenuItem
            // 
            this.shearingToolStripMenuItem.Name = "shearingToolStripMenuItem";
            this.shearingToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.shearingToolStripMenuItem.Text = "Shearing";
            this.shearingToolStripMenuItem.Click += new System.EventHandler(this.shearingToolStripMenuItem_Click);
            // 
            // rotationToolStripMenuItem
            // 
            this.rotationToolStripMenuItem.Name = "rotationToolStripMenuItem";
            this.rotationToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.rotationToolStripMenuItem.Text = "Rotation";
            this.rotationToolStripMenuItem.Click += new System.EventHandler(this.rotationToolStripMenuItem_Click);
            // 
            // reflectionToolStripMenuItem
            // 
            this.reflectionToolStripMenuItem.Name = "reflectionToolStripMenuItem";
            this.reflectionToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.reflectionToolStripMenuItem.Text = "Reflection";
            this.reflectionToolStripMenuItem.Click += new System.EventHandler(this.reflectionToolStripMenuItem_Click);
            // 
            // homographyToolStripMenuItem
            // 
            this.homographyToolStripMenuItem.Name = "homographyToolStripMenuItem";
            this.homographyToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.homographyToolStripMenuItem.Text = "Homography";
            this.homographyToolStripMenuItem.Click += new System.EventHandler(this.homographyToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.Reset,
            this.AffineT,
            this.ConPri});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Reset
            // 
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(47, 20);
            this.Reset.Text = "Reset";
            this.Reset.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // ConPri
            // 
            this.ConPri.Name = "ConPri";
            this.ConPri.Size = new System.Drawing.Size(115, 20);
            this.ConPri.Text = "Contour/Primitive";
            this.ConPri.Click += new System.EventHandler(this.ConPri_Click);
            // 
            // PanelScaling
            // 
            this.PanelScaling.Controls.Add(this.label3);
            this.PanelScaling.Controls.Add(this.label2);
            this.PanelScaling.Controls.Add(this.CloseScaling);
            this.PanelScaling.Controls.Add(this.label1);
            this.PanelScaling.Controls.Add(this.textBox2);
            this.PanelScaling.Controls.Add(this.textBox1);
            this.PanelScaling.Controls.Add(this.PanelScalingApply);
            this.PanelScaling.Location = new System.Drawing.Point(1024, 34);
            this.PanelScaling.Name = "PanelScaling";
            this.PanelScaling.Size = new System.Drawing.Size(150, 138);
            this.PanelScaling.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Coef Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coef X";
            // 
            // CloseScaling
            // 
            this.CloseScaling.Location = new System.Drawing.Point(127, 3);
            this.CloseScaling.Name = "CloseScaling";
            this.CloseScaling.Size = new System.Drawing.Size(20, 23);
            this.CloseScaling.TabIndex = 4;
            this.CloseScaling.Text = "X";
            this.CloseScaling.UseVisualStyleBackColor = true;
            this.CloseScaling.Click += new System.EventHandler(this.CloseScaling_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scaling";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelScalingApply
            // 
            this.PanelScalingApply.Location = new System.Drawing.Point(23, 103);
            this.PanelScalingApply.Name = "PanelScalingApply";
            this.PanelScalingApply.Size = new System.Drawing.Size(100, 23);
            this.PanelScalingApply.TabIndex = 0;
            this.PanelScalingApply.Text = "Apply";
            this.PanelScalingApply.UseVisualStyleBackColor = true;
            this.PanelScalingApply.Click += new System.EventHandler(this.PanelScalingApply_Click);
            // 
            // PanelShearing
            // 
            this.PanelShearing.Controls.Add(this.ListRegarding);
            this.PanelShearing.Controls.Add(this.PanelShearinApply);
            this.PanelShearing.Controls.Add(this.label5);
            this.PanelShearing.Controls.Add(this.textBox3);
            this.PanelShearing.Controls.Add(this.label4);
            this.PanelShearing.Controls.Add(this.CloseShearing);
            this.PanelShearing.Location = new System.Drawing.Point(1024, 34);
            this.PanelShearing.Name = "PanelShearing";
            this.PanelShearing.Size = new System.Drawing.Size(150, 163);
            this.PanelShearing.TabIndex = 6;
            // 
            // ListRegarding
            // 
            this.ListRegarding.FormattingEnabled = true;
            this.ListRegarding.Items.AddRange(new object[] {
            "Top",
            "Bottom",
            "Right",
            "Left"});
            this.ListRegarding.Location = new System.Drawing.Point(18, 66);
            this.ListRegarding.Name = "ListRegarding";
            this.ListRegarding.Size = new System.Drawing.Size(114, 56);
            this.ListRegarding.TabIndex = 8;
            // 
            // PanelShearinApply
            // 
            this.PanelShearinApply.Location = new System.Drawing.Point(18, 128);
            this.PanelShearinApply.Name = "PanelShearinApply";
            this.PanelShearinApply.Size = new System.Drawing.Size(114, 23);
            this.PanelShearinApply.TabIndex = 7;
            this.PanelShearinApply.Text = "Apply";
            this.PanelShearinApply.UseVisualStyleBackColor = true;
            this.PanelShearinApply.Click += new System.EventHandler(this.PanelShearinApply_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Shift";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Shearing";
            // 
            // CloseShearing
            // 
            this.CloseShearing.Location = new System.Drawing.Point(127, 3);
            this.CloseShearing.Name = "CloseShearing";
            this.CloseShearing.Size = new System.Drawing.Size(20, 23);
            this.CloseShearing.TabIndex = 7;
            this.CloseShearing.Text = "X";
            this.CloseShearing.UseVisualStyleBackColor = true;
            this.CloseShearing.Click += new System.EventHandler(this.CloseShearing_Click);
            // 
            // PanelRotation
            // 
            this.PanelRotation.Controls.Add(this.PanelRottationApply);
            this.PanelRotation.Controls.Add(this.textBox6);
            this.PanelRotation.Controls.Add(this.label10);
            this.PanelRotation.Controls.Add(this.textBox5);
            this.PanelRotation.Controls.Add(this.textBox4);
            this.PanelRotation.Controls.Add(this.label9);
            this.PanelRotation.Controls.Add(this.label8);
            this.PanelRotation.Controls.Add(this.label7);
            this.PanelRotation.Controls.Add(this.CloseRotation);
            this.PanelRotation.Controls.Add(this.label6);
            this.PanelRotation.Location = new System.Drawing.Point(1024, 34);
            this.PanelRotation.Name = "PanelRotation";
            this.PanelRotation.Size = new System.Drawing.Size(150, 151);
            this.PanelRotation.TabIndex = 7;
            // 
            // PanelRottationApply
            // 
            this.PanelRottationApply.Location = new System.Drawing.Point(18, 119);
            this.PanelRottationApply.Name = "PanelRottationApply";
            this.PanelRottationApply.Size = new System.Drawing.Size(114, 23);
            this.PanelRottationApply.TabIndex = 9;
            this.PanelRottationApply.Text = "Apply";
            this.PanelRottationApply.UseVisualStyleBackColor = true;
            this.PanelRottationApply.Click += new System.EventHandler(this.PanelRottationApply_Click_1);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(55, 93);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(77, 20);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "0";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Angle";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(99, 62);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(33, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(37, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(33, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Center of rottation";
            // 
            // CloseRotation
            // 
            this.CloseRotation.Location = new System.Drawing.Point(127, 5);
            this.CloseRotation.Name = "CloseRotation";
            this.CloseRotation.Size = new System.Drawing.Size(20, 23);
            this.CloseRotation.TabIndex = 9;
            this.CloseRotation.Text = "X";
            this.CloseRotation.UseVisualStyleBackColor = true;
            this.CloseRotation.Click += new System.EventHandler(this.CloseRotation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rotation";
            // 
            // PanelReflection
            // 
            this.PanelReflection.Controls.Add(this.PanelReflectionApply);
            this.PanelReflection.Controls.Add(this.ListRef);
            this.PanelReflection.Controls.Add(this.CloseReflection);
            this.PanelReflection.Controls.Add(this.label11);
            this.PanelReflection.Location = new System.Drawing.Point(1024, 34);
            this.PanelReflection.Name = "PanelReflection";
            this.PanelReflection.Size = new System.Drawing.Size(150, 117);
            this.PanelReflection.TabIndex = 7;
            // 
            // PanelReflectionApply
            // 
            this.PanelReflectionApply.Location = new System.Drawing.Point(18, 89);
            this.PanelReflectionApply.Name = "PanelReflectionApply";
            this.PanelReflectionApply.Size = new System.Drawing.Size(114, 23);
            this.PanelReflectionApply.TabIndex = 9;
            this.PanelReflectionApply.Text = "Apply";
            this.PanelReflectionApply.UseVisualStyleBackColor = true;
            this.PanelReflectionApply.Click += new System.EventHandler(this.PanelReflectionApply_Click);
            // 
            // ListRef
            // 
            this.ListRef.FormattingEnabled = true;
            this.ListRef.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical",
            "Diagonal",
            "Normal"});
            this.ListRef.Location = new System.Drawing.Point(18, 29);
            this.ListRef.Name = "ListRef";
            this.ListRef.Size = new System.Drawing.Size(114, 56);
            this.ListRef.TabIndex = 9;
            // 
            // CloseReflection
            // 
            this.CloseReflection.Location = new System.Drawing.Point(130, 0);
            this.CloseReflection.Name = "CloseReflection";
            this.CloseReflection.Size = new System.Drawing.Size(20, 23);
            this.CloseReflection.TabIndex = 9;
            this.CloseReflection.Text = "X";
            this.CloseReflection.UseVisualStyleBackColor = true;
            this.CloseReflection.Click += new System.EventHandler(this.CloseReflection_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Reflection";
            // 
            // PanelConPri
            // 
            this.PanelConPri.Controls.Add(this.OutNumber);
            this.PanelConPri.Controls.Add(this.label14);
            this.PanelConPri.Controls.Add(this.label13);
            this.PanelConPri.Controls.Add(this.label12);
            this.PanelConPri.Controls.Add(this.textBoxMinArea);
            this.PanelConPri.Controls.Add(this.textBoxThreshold);
            this.PanelConPri.Controls.Add(this.LBColor);
            this.PanelConPri.Controls.Add(this.LBPrimitive);
            this.PanelConPri.Controls.Add(this.LBTypeFinding);
            this.PanelConPri.Controls.Add(this.ApplyConPri);
            this.PanelConPri.Controls.Add(this.CloseConPri);
            this.PanelConPri.Controls.Add(this.label16);
            this.PanelConPri.Location = new System.Drawing.Point(1024, 35);
            this.PanelConPri.Name = "PanelConPri";
            this.PanelConPri.Size = new System.Drawing.Size(150, 352);
            this.PanelConPri.TabIndex = 15;
            // 
            // OutNumber
            // 
            this.OutNumber.AutoSize = true;
            this.OutNumber.Location = new System.Drawing.Point(110, 46);
            this.OutNumber.Name = "OutNumber";
            this.OutNumber.Size = new System.Drawing.Size(13, 13);
            this.OutNumber.TabIndex = 18;
            this.OutNumber.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Number primitives:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "MinArea";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Threshold";
            // 
            // textBoxMinArea
            // 
            this.textBoxMinArea.Location = new System.Drawing.Point(76, 116);
            this.textBoxMinArea.Name = "textBoxMinArea";
            this.textBoxMinArea.Size = new System.Drawing.Size(56, 20);
            this.textBoxMinArea.TabIndex = 14;
            this.textBoxMinArea.Text = "0";
            this.textBoxMinArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxThreshold
            // 
            this.textBoxThreshold.Location = new System.Drawing.Point(76, 90);
            this.textBoxThreshold.Name = "textBoxThreshold";
            this.textBoxThreshold.Size = new System.Drawing.Size(56, 20);
            this.textBoxThreshold.TabIndex = 13;
            this.textBoxThreshold.Text = "0";
            this.textBoxThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBColor
            // 
            this.LBColor.FormattingEnabled = true;
            this.LBColor.Location = new System.Drawing.Point(23, 266);
            this.LBColor.Name = "LBColor";
            this.LBColor.Size = new System.Drawing.Size(109, 56);
            this.LBColor.TabIndex = 12;
            // 
            // LBPrimitive
            // 
            this.LBPrimitive.FormattingEnabled = true;
            this.LBPrimitive.Location = new System.Drawing.Point(22, 142);
            this.LBPrimitive.Name = "LBPrimitive";
            this.LBPrimitive.Size = new System.Drawing.Size(109, 56);
            this.LBPrimitive.TabIndex = 11;
            this.LBPrimitive.SelectedIndexChanged += new System.EventHandler(this.LBPrimitive_SelectedIndexChanged);
            // 
            // LBTypeFinding
            // 
            this.LBTypeFinding.FormattingEnabled = true;
            this.LBTypeFinding.Location = new System.Drawing.Point(23, 204);
            this.LBTypeFinding.Name = "LBTypeFinding";
            this.LBTypeFinding.Size = new System.Drawing.Size(109, 56);
            this.LBTypeFinding.TabIndex = 10;
            this.LBTypeFinding.SelectedIndexChanged += new System.EventHandler(this.LBTypeFinding_SelectedIndexChanged);
            // 
            // ApplyConPri
            // 
            this.ApplyConPri.Location = new System.Drawing.Point(18, 61);
            this.ApplyConPri.Name = "ApplyConPri";
            this.ApplyConPri.Size = new System.Drawing.Size(114, 23);
            this.ApplyConPri.TabIndex = 9;
            this.ApplyConPri.Text = "Apply";
            this.ApplyConPri.UseVisualStyleBackColor = true;
            this.ApplyConPri.Click += new System.EventHandler(this.ApplyConPri_Click);
            // 
            // CloseConPri
            // 
            this.CloseConPri.Location = new System.Drawing.Point(127, 5);
            this.CloseConPri.Name = "CloseConPri";
            this.CloseConPri.Size = new System.Drawing.Size(20, 23);
            this.CloseConPri.TabIndex = 9;
            this.CloseConPri.Text = "X";
            this.CloseConPri.UseVisualStyleBackColor = true;
            this.CloseConPri.Click += new System.EventHandler(this.CloseConPri_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Contour/Primitive";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 543);
            this.Controls.Add(this.PanelConPri);
            this.Controls.Add(this.PanelRotation);
            this.Controls.Add(this.PanelReflection);
            this.Controls.Add(this.PanelShearing);
            this.Controls.Add(this.PanelScaling);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Affine Transformation";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelScaling.ResumeLayout(false);
            this.PanelScaling.PerformLayout();
            this.PanelShearing.ResumeLayout(false);
            this.PanelShearing.PerformLayout();
            this.PanelRotation.ResumeLayout(false);
            this.PanelRotation.PerformLayout();
            this.PanelReflection.ResumeLayout(false);
            this.PanelReflection.PerformLayout();
            this.PanelConPri.ResumeLayout(false);
            this.PanelConPri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AffineT;
        private System.Windows.Forms.ToolStripMenuItem scalingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shearingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reflectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homographyToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel PanelScaling;
        private System.Windows.Forms.Button PanelScalingApply;
        private System.Windows.Forms.Button CloseScaling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelShearing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CloseShearing;
        private System.Windows.Forms.Button PanelShearinApply;
        private System.Windows.Forms.ListBox ListRegarding;
        private System.Windows.Forms.Panel PanelRotation;
        private System.Windows.Forms.Button CloseRotation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PanelRottationApply;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel PanelReflection;
        private System.Windows.Forms.Button CloseReflection;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox ListRef;
        private System.Windows.Forms.Button PanelReflectionApply;
        private System.Windows.Forms.ToolStripMenuItem Reset;
        private System.Windows.Forms.ToolStripMenuItem ConPri;
        private System.Windows.Forms.Panel PanelConPri;
        private System.Windows.Forms.Button ApplyConPri;
        private System.Windows.Forms.Button CloseConPri;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox LBTypeFinding;
        private System.Windows.Forms.ListBox LBColor;
        private System.Windows.Forms.ListBox LBPrimitive;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxMinArea;
        private System.Windows.Forms.TextBox textBoxThreshold;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label OutNumber;
        private System.Windows.Forms.Label label14;
    }
}

