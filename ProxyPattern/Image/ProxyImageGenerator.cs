using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProxyPattern.Image
{
    class ProxyImageGenerator : IImageGenerator
    {
        private RealImageGenerator _realImageGenerator;
        private Timer _timer;
        private bool LoadRealObject = false;

        private void ShowrealImageObject(object o)
        {
            _realImageGenerator = new RealImageGenerator();
            _realImageGenerator.ShowImage();
            LoadRealObject = false;
        }

        public void ShowImage()
        {
            if (_realImageGenerator == null)
                _timer = new System.Threading.Timer(new TimerCallback(ShowrealImageObject), this, 2000, 0);

            if (!LoadRealObject)
                Console.WriteLine("Önizleme gösteriliyor...");
        }
    }
}
