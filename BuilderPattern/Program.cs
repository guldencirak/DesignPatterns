using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// Bridge pattern 
    /// abstraction ve implementation birbirinden ayırıyor
    /// soyut yapıyı değiştirmeden uygulamaya yeni özellikler kazandırmaktır amacı
    /// amaç open/closed principle
    /// genişleme kolaylıkla yapılacaktır    
    /// duruma göre yapıyı/işlevi değiştirmek gerekiyorsa bridge pattern kullanılabilir
    /// bir işlem farklı yöntemlerle yapılabilme olasılığı varsa Bridge yapısını kurmakta fayda vardır    
    /// Ödeme işlemleri: kredi kartı, nakit, havale
    /// Veritabanı yöntemleri: Ms Sql, My Sql
    /// GUI seçimi birden fazla destekleyebilir
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            ab.Implementor = new ConcreteImplementorA();
            ab.Operating();

            ab.Implementor = new ConcreteImplementorB();
            ab.Operating();
        }
    }
}
