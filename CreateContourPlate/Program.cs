using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateContourPlate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}< Component Id = "TheExtensionComponent" Guid = "7709FE25-5293-4BBF-AB37-13F72C6F6CCB" >
   

   < File Id = "Icon" Source = "%BinariesFolder%\et_element_Bolt Group Creator.bmp" Target = "%BitmapsDirectory%" />
        

        < File Id = "BoltGroupCreator" Source = "%BinariesFolder%\BoltGroupCreator.dll" Target = "%BinariesTargetDirectory%" />

             File Id = "BoltGroupCreator.ail" Source = "%BinariesFolder%\BoltGroupCreator.ail" Target = "%BinariesTargetDirectory%" />
                 

                 < File Id = "standard.BoltGroupCreator.BoltGroupCreatorForm.xml" Source = "%BinariesFolder%\standard.BoltGroupCreator.BoltGroupCreatorForm.xml" Target = "%AttributeFileDirectory%" />
