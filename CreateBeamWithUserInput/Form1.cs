using System;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Geometry3d;

namespace CreateBeamWithUserInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void beamButton_Click(object sender, EventArgs e)
        {
            Model myModel = new Model();
            Picker picker = new Picker();

            Point startPoint = picker.PickPoint("Select the start point of the beam");
            Point endPoint = picker.PickPoint("Select the end point of the beam");
            Beam myBeam = new Beam(startPoint, endPoint);

            myBeam.Profile.ProfileString = profileTB.Text;
            myBeam.Material.MaterialString = materialTB.Text;
            myBeam.Class = classTB.Text;
            myBeam.Name = nameTB.Text;

            myBeam.PartNumber.Prefix = psTB.Text;
            myBeam.PartNumber.StartNumber = Convert.ToInt32(pnTB.Text);

            myBeam.AssemblyNumber.Prefix = asTB.Text;
            myBeam.AssemblyNumber.StartNumber = Convert.ToInt32(anTB.Text);

            myBeam.Position.Plane = updatePlane(planeCB.SelectedIndex);
            myBeam.Position.Rotation = updateRotation(rotationCB.SelectedIndex);
            myBeam.Position.Depth = updateDepth(depthCB.SelectedIndex);

            myBeam.Insert();
            myModel.CommitChanges();

        }
        private Position.PlaneEnum planeEnum;
        private Position.RotationEnum rotationEnum;
        private Position.DepthEnum depthEnum;
        private Position.PlaneEnum updatePlane(int OnPlane)
        {
            switch (OnPlane)
            {
                case 0:
                    return planeEnum = Position.PlaneEnum.LEFT;
                case 1:
                    return planeEnum = Position.PlaneEnum.MIDDLE;
                case 2:
                    return planeEnum = Position.PlaneEnum.RIGHT;

                default:
                    return planeEnum = Position.PlaneEnum.MIDDLE;
            }
        }
        private Position.RotationEnum updateRotation(int OnPlane)
        {
            switch (OnPlane)
            {
                case 0:
                    return rotationEnum = Position.RotationEnum.FRONT;
                case 1:
                    return rotationEnum = Position.RotationEnum.TOP;
                case 2:
                    return rotationEnum = Position.RotationEnum.BACK;
                case 3:
                    return rotationEnum = Position.RotationEnum.BELOW;

                default:
                    return rotationEnum = Position.RotationEnum.FRONT;
            }
        }
        private Position.DepthEnum updateDepth(int OnPlane)
        {
            switch (OnPlane)
            {
                case 0:
                    return depthEnum = Position.DepthEnum.MIDDLE;
                case 1:
                    return depthEnum = Position.DepthEnum.FRONT;
                case 2:
                    return depthEnum = Position.DepthEnum.BEHIND;

                default:
                    return depthEnum = Position.DepthEnum.MIDDLE;
            }
        }
    }
}
