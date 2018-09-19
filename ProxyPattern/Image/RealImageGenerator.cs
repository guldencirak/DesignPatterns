using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Image
{
    class RealImageGenerator : IImageGenerator
    {
        public void ShowImage()
        {
            Console.WriteLine("Real Image Show...");
        }
    }
}
