using ProxyPattern.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// Proxy pattern
    /// büyük veri akışlarında    
    /// server-client projelerinde
    /// Oluşturulması zaman alan büyük veri 
    /// daha önce yaratılan instance kullanılır
    /// Remote Proxy - client server 
    /// Virtual Proxy - creating&getting zaman alıcı büyük veri
    /// Protection Proxy - Login-Authentication işlemleri
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ProxyImageGenerator imageGenerator = new ProxyImageGenerator();
            imageGenerator.ShowImage();

            Console.ReadLine();
        }
    }
}
