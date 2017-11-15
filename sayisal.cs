using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class sayisal
    {
        public sayisal() { }

        public int sayi_cek(int min, int max) {

            Random a = new Random();
            int sayi = a.Next(min,max);
            return sayi;
        }
        public bool varmi(int sayi, int[] dizi) {
            bool var = false;
            for(int i=0; i<dizi.Length; i++)
                if (dizi[i] == sayi)
                {
                    var = true;
                    break;
                }
            return var;
        }

        public int kactane(int sayi, int[] dizi)
        {
            int adet = 0;
            for (int i = 0; i < dizi.Length; i++)
                if (dizi[i] == sayi)
                {
                    adet++;
                   
                }
            return adet;
        }

        public int[] cek()
        {
            int[] dizi = new int[6];
            int index = 0;
            string sayilar = "";
            int sayi;
            bool varyok;
            if (index < 6)
            {


                for (;;)
                {

                    sayi = sayi_cek(1, 49);
                    varyok = varmi(sayi, dizi);
                    if (varyok == false)
                    {

                        dizi[index] = sayi;
                        index++;

                    }
                    if (index == 6)
                    {

                        break;


                    }



                }
            }
            return dizi;
        }

        public int[] terscevir(int[] sayilar_)
        {
            int[] sayilar = sayilar_;
            int a;

            for (int i = 0; i < 6; i++)

            {

                for (int j = i + 1; j < 6; j++)

                {

                    if (sayilar[j] < sayilar[i])

                    {

                        a = sayilar[i];

                        sayilar[i] = sayilar[j];

                        sayilar[j] = a;

                    }

                }

            }
            return sayilar;


        }
       


    
    }
}
