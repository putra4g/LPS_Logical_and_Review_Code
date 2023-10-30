using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPS_Logical_and_Review_Code
{
	public class Application
	{
        /*public static ApplicationInfo GetInfo()
        {
            var application = new ApplicationInfo
            {
                Path = "C:/apps/",
                Name = "Shield.exe"
            };

            return application;
        }*/

        // Use Tuple Instead Off Classes, for simple way to return more than one value 
        public (string Path, string Name) GetApplicationInfo()
        {
            return ("C:/apps/", "Shield.exe");
        }

        

    }
}
