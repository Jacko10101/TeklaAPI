using System;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace CreateBeamWithPoints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void beamBtn_Click(object sender, EventArgs e)
        {
            // Create a new Model object that represents the Tekla Structures Model you have opened in Tekla Structures.
            Model myModel = new Model();

            // Check if we have a Tekla Structures Model that you can connect to.
            if (myModel.GetConnectionStatus())
            {
                Tekla.Structures.Model.UI.Picker _picker = new Tekla.Structures.Model.UI.Picker();

                Point startPoint = _picker.PickPoint("Pick the start point.");
                Point endPoint = _picker.PickPoint("Pick the end point.");

                Beam myBeam = new Beam(startPoint, endPoint);

                // Set the Beams Material and Profile and Name.
                myBeam.Name = beamNameTb.Text;
                myBeam.Material.MaterialString = "S235JR";
                myBeam.Profile.ProfileString = "UB406*140*46";

                // Insert the Beam into the Tekla Structures Model.
                myBeam.Insert();

                //Make sure all changes that have been done are updated in Tekla Structures and that the model views are redrawn 
                //accordingly.
                myModel.CommitChanges();
            }
        }
    }
}
