using System;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace CreateFittingAndCutsOnObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void beamBTN_Click(object sender, EventArgs e)
        {
            Model model = new Model();

            Beam myBeam = new Beam();
            myBeam.StartPoint = new Point(0, 0, 0);
            myBeam.EndPoint = new Point(1000, 0, 0);

            myBeam.Name = "Beam";
            myBeam.Material.MaterialString = "S235JR";
            myBeam.Profile.ProfileString = "UB406*140*46";

            myBeam.Insert();

            Fitting Fitting = new Fitting();
            Fitting.Plane = new Plane();
            Fitting.Plane.Origin = new Point(500, 0, 0);
            Fitting.Plane.AxisX = new Vector(0, 1000, 0);
            Fitting.Plane.AxisY = new Vector(0, 0, -1000);
            Fitting.Father = myBeam;
            Fitting.Insert();

            model.CommitChanges();
            
        }

        private void beamCutsBTN_Click(object sender, EventArgs e)
        {
            Model model = new Model();

            Beam myBeam = new Beam();
            myBeam.StartPoint = new Point(0, 0, 0);
            myBeam.EndPoint = new Point(1000, 0, 0);

            myBeam.Name = "Beam";
            myBeam.Material.MaterialString = "S235JR";
            myBeam.Profile.ProfileString = "UB406*140*46";

            myBeam.Insert();

            CutPlane cutPlane = new CutPlane();
            cutPlane.Plane = new Plane();
            cutPlane.Plane.Origin = new Point(500, 0, 0);
            cutPlane.Plane.AxisX = new Vector(0, 1000, 0);
            cutPlane.Plane.AxisY = new Vector(0, 0, -1000);
            cutPlane.Father = myBeam;
            cutPlane.Insert();

            model.CommitChanges();
        }
    }
}
