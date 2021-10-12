using System;
using System.Windows.Forms;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace CreateBoltArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boltButton_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            Tekla.Structures.Model.UI.Picker _picker = new Tekla.Structures.Model.UI.Picker();

            ModelObject mo = _picker.PickObject(Tekla.Structures.Model.UI.Picker.PickObjectEnum.PICK_ONE_PART);
            Part cp = mo as Part;

            Tekla.Structures.Model.BoltArray B = new Tekla.Structures.Model.BoltArray();

            B.PartToBeBolted = cp;
            B.PartToBoltTo = cp;

            B.FirstPosition = _picker.PickPoint("Pick the start point.");
            B.SecondPosition = _picker.PickPoint("Pick the end point.");

            B.BoltSize = Convert.ToInt32(bSizeTB.Text);
            B.Tolerance = 3.00;
            B.BoltStandard = bStanTB.Text;
            B.BoltType = BoltGroup.BoltTypeEnum.BOLT_TYPE_WORKSHOP;
            B.Length = 150;
            B.ThreadInMaterial = BoltGroup.BoltThreadInMaterialEnum.THREAD_IN_MATERIAL_NO;

            B.Position.Depth = Position.DepthEnum.MIDDLE;
            B.Position.Plane = Position.PlaneEnum.MIDDLE;
            B.Position.Rotation = Position.RotationEnum.FRONT;

            B.AddBoltDistX(100);
            B.AddBoltDistX(90);
            B.AddBoltDistX(80);
            B.StartPointOffset.Dx = 200;

            B.AddBoltDistY(70);
            B.AddBoltDistY(60);
            B.AddBoltDistY(50);
            B.EndPointOffset.Dy = 200;

            if (!B.Insert())
            {
                MessageBox.Show("BoltArray insert failed");
            }

            model.CommitChanges();
        }
    }
}
