using System;
using System.Drawing;
using System.Windows.Forms;
using GlobalDentalClasses.Model;

namespace GlobalDentalUI
{
    public partial class OdontogramPanel : UserControl
    {
        public OdontogramPanel(MainWindow MainForm, Patient selectedPatient, int toothNumber)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            this.MainForm = MainForm;
            ToothNumber = toothNumber;
            ResizeRedraw = true;
            SelectedPatient = selectedPatient;
        }

        private MainWindow MainForm { get; set; }
        private int ToothNumber { get; set; }

        private Patient SelectedPatient { get; set; }

        private Brush StatusToBrushColor(Treatment.TreatmentStatus Status)
        {
            switch (Status)
            {
                case Treatment.TreatmentStatus.Existing:
                    return Brushes.Blue;
                case Treatment.TreatmentStatus.Planned:
                    return Brushes.Red;
                case Treatment.TreatmentStatus.Completed:
                    return Brushes.Green;
                default:
                    return Brushes.White;
            }

        }

        private void determineColors()
        {
            BuccalColor   = Brushes.White;
            DistalColor   = Brushes.White;
            LingualColor  = Brushes.White;
            MesialColor   = Brushes.White;
            OcclusalColor = Brushes.White;
            PenColor      = Pens.Black;

            foreach (Treatment t in SelectedPatient.TreatmentsList)
            {
                var setColor = StatusToBrushColor(t.Status);
                if (t.ToothNumber == null || t.ToothNumber < 1 || t.ToothNumber > 32 || t.ToothNumber != ToothNumber)
                {
                    continue;
                }

                if (t.Type == Treatment.TreatmentType.Extraction && (t.Status == Treatment.TreatmentStatus.Completed || t.Status == Treatment.TreatmentStatus.Existing))
                {
                    Parent.Enabled = false;
                    var brush = new SolidBrush(Parent.BackColor);
                    BuccalColor   = brush;
                    DistalColor   = brush;
                    LingualColor  = brush;
                    MesialColor   = brush;
                    OcclusalColor = brush;
                    PenColor      = Pens.LightGray;
                }
                else if (t.Type == Treatment.TreatmentType.Extraction || t.Type == Treatment.TreatmentType.Amalgam || t.Type == Treatment.TreatmentType.Composite || t.Type == Treatment.TreatmentType.Sealants)
                {
                    if (t.Surfaces.Buccal == true)
                    {
                        BuccalColor = setColor;
                    }
                    if (t.Surfaces.Distal == true)
                    {
                        DistalColor = setColor;
                    }
                    if (t.Surfaces.Lingual == true)
                    {
                        LingualColor = setColor;
                    }
                    if (t.Surfaces.Mesial == true)
                    {
                       MesialColor = setColor;
                    }
                    if (t.Surfaces.Occlusal == true)
                    {
                        OcclusalColor = setColor;
                    }
                }
                else if (t.Type == Treatment.TreatmentType.Extraction)
                {
                    BuccalColor   = setColor;
                    DistalColor   = setColor;
                    LingualColor  = setColor;
                    MesialColor   = setColor;
                    OcclusalColor = setColor;
                }
            }
        }

        private Brush BuccalColor { get; set; }
        private Brush DistalColor { get; set; }
        private Brush LingualColor { get; set; }
        private Brush MesialColor { get; set; }
        private Brush OcclusalColor { get; set; }
        private Pen PenColor { get; set; }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(Parent.BackColor);

            if (SelectedPatient != null)
            {
                int divisor = 4;

                int RightMost = Right - 5;
                int BottomMost = Top + Width;
                int LeftMost = Left + 5;
                int TopMost = Top + 5;

                int IconWidth = Width;
                int IconHeight = IconWidth;

                Point innerUpperLeft = new Point(LeftMost + IconWidth / divisor, TopMost + IconWidth / divisor);
                Point innerUpperRight = new Point(RightMost - IconWidth / divisor, TopMost + IconWidth / divisor);
                Point innerBottomLeft = new Point(LeftMost + IconWidth / divisor, BottomMost - IconWidth / divisor);
                Point innerBottomRight = new Point(RightMost - IconWidth / divisor, BottomMost - IconWidth / divisor);

                Point outerUpperLeft = new Point(LeftMost, TopMost);
                Point outerUpperRight = new Point(RightMost, TopMost);
                Point outerBottomLeft = new Point(LeftMost, BottomMost);
                Point outerBottomRight = new Point(RightMost, BottomMost);

                Point[] topChunk = { outerUpperLeft, outerUpperRight, innerUpperRight, innerUpperLeft, outerUpperLeft };
                Point[] leftChunk = { outerUpperLeft, innerUpperLeft, innerBottomLeft, outerBottomLeft, outerUpperLeft };
                Point[] rightChunk = { outerUpperRight, innerUpperRight, innerBottomRight, outerBottomRight, outerUpperRight };
                Point[] centerChunk = { innerUpperLeft, innerUpperRight, innerBottomRight, innerBottomLeft, innerUpperLeft };
                Point[] bottomChunk = { outerBottomLeft, outerBottomRight, innerBottomRight, innerBottomLeft, outerBottomLeft };

                Point[] buccal;
                Point[] distal;
                Point[] lingual;
                Point[] mesial;
                Point[] occlusal = centerChunk;

                if (ToothNumber < 17)
                {
                    lingual = bottomChunk;
                    buccal = topChunk;
                }
                else
                {
                    lingual = topChunk;
                    buccal = bottomChunk;
                }

                if (ToothNumber < 9 || ToothNumber > 24)
                {
                    mesial = rightChunk;
                    distal = leftChunk;
                }
                else
                {
                    mesial = rightChunk;
                    distal = leftChunk;
                }

                determineColors();

                g.FillPolygon(BuccalColor, buccal);
                g.FillPolygon(DistalColor, distal);
                g.FillPolygon(LingualColor, lingual);
                g.FillPolygon(MesialColor, mesial);
                g.FillPolygon(OcclusalColor, occlusal);

                g.DrawPolygon(PenColor, topChunk);
                g.DrawPolygon(PenColor, leftChunk);
                g.DrawPolygon(PenColor, bottomChunk);
                g.DrawPolygon(PenColor, rightChunk);
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
