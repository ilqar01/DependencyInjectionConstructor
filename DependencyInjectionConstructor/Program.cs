using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionConstructor
{

    public interface IMusteri
    {
        void Ekle();
        void Guncelle();
        void Sil();
    }

    public class MsSql : IMusteri
    {
        public void Ekle()
        {
            Console.WriteLine("MsSql Ekledi");
        }

        public void Guncelle()
        {
            Console.WriteLine("MsSql Guncelledi");
        }

        public void Sil()
        {
            Console.WriteLine("MsSql Sildi");
        }
    }

    public class MySql : IMusteri
    {
        public void Ekle()
        {
            Console.WriteLine("MySql Ekledi");
        }

        public void Guncelle()
        {
            Console.WriteLine("MySql Guncelledi");
        }

        public void Sil()
        {
            Console.WriteLine("MySql Sildi");
        }
    }

    public class Oracle : IMusteri
    {
        public void Ekle()
        {
            Console.WriteLine("Oracle Ekledi");
        }

        public void Guncelle()
        {
            Console.WriteLine("Oracle Guncelledi");
        }

        public void Sil()
        {
            Console.WriteLine("Oracle Sildi");
        }
    }


    public class MusteriController
    {
        private readonly IMusteri veriTabani;

        public MusteriController(IMusteri veriTabani)
        {
            this.veriTabani = veriTabani;
        }
         

        public void MusteriEkle()
        {
            veriTabani.Ekle();
        }

        public void MusteriGuncelle()
        {
            veriTabani.Guncelle();
        }

        public void MusteriSil()
        {
            veriTabani.Sil();
        }

       }
    internal class Program
    {
        static void Main(string[] args)
        {
            MsSql db = new MsSql();
            MusteriController controller = new MusteriController(db);
            controller.MusteriEkle();

            //MusteriController controller = new MusteriController(new MsSql());
            //controller.MusteriEkle();



        }
    }
}
