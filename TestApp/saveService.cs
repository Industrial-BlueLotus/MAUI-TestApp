using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    // Change the namespace as desired, but make sure that all source files use this same namespace,
    // or there will be errors!

    // SaveService partial class declaration ... this allows a layer of abstraction
    // as we implement the save file details specially for each platform on which this app will
    // operate! 
    public partial class SaveService
    {
        public void SaveAndView(string filename, string contentType, MemoryStream stream)
        {
            SaveFile(filename, contentType, stream);
        }
        // Additional partial files will provide implementations for this method specifically.
        partial void SaveFile(string filename, string contentType, MemoryStream stream);
    }

}
