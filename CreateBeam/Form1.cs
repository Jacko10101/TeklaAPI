using System;
using System.Windows.Forms;
using Tekla.Structures;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace CreateBeam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void beamButton_Click(object sender, EventArgs e)
        {
            // Create a new Model object that represents the Tekla Structures Model you have opened in Tekla Structures.
            Model myModel = new Model();

            // Check if we have a Tekla Structures Model that you can connect to.
            if (myModel.GetConnectionStatus())
            {
                // Create a new instance of the Beam class based on created start and end points for the beam.
                Beam myBeam = new Beam(new Point(1000, 1000, 1000), new Point(6000, 6000, 1000));

                // Set the Beams Material and Profile.
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
