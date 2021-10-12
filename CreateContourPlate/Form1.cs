using System;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Geometry3d;
using System.Collections;

namespace CreateContourPlate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            Picker _picker = new Picker();
            ArrayList pickedPoints = _picker.PickPoints(Picker.PickPointEnum.PICK_POLYGON, "Pick polygon points");

            ArrayList contourPoints = new ArrayList();
            foreach (Point point in pickedPoints)
            {
                ContourPoint contourPoint = new ContourPoint(point, new Chamfer());
                contourPoints.Add(contourPoint);
            }

            ContourPlate CP = new ContourPlate();
            CP.Contour.ContourPoints = contourPoints;
            CP.Profile.ProfileString = cpProfileTB.Text;
            CP.Material.MaterialString = "S235";
            CP.Class = "99";

            CP.Insert();
            model.CommitChanges();

        }
    }
}
