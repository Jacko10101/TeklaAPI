using System;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;

namespace TeklaHelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create a model instance and check the connection status

            Model model = new Model();

            if(!model.GetConnectionStatus())
            {
                MessageBox.Show("Tekla structures not connected");
                return;
            }

            //Get model info and send a "Hello World" message
            ModelInfo modelInfo = model.GetInfo();
            string name = modelInfo.ModelName;

            MessageBox.Show(string.Format("Hello world! your current model is named; {0}", name));

            //Send a hello world message to the tekla structures user command prompt
            Operation.DisplayPrompt(string.Format("Hello world! your current model is named: {0}", name));
        }
    }
}
