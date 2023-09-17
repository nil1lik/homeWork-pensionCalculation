using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseOdev_EmeklilikHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * ÖDEV:
             kullanıcıdan alınan cinsiyet bilgisine göre
             ==> ERKEK ise
                yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise 
            maaşının 11 katı kadar ikramiye alarak emekli edilecek,    6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
             ==> KADIN ise
                yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 4500 ve üstü ise 
            maaşının 11 katı kadar ikramiye alarak emekli edilecek, 4500 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
             ==> cinsiyet bilgisi switch-case ile sorgulanacak
             */




            Console.WriteLine("Lütfen cinsiyetinizi giriniz: e/k");
            string gender = Console.ReadLine();

            if (gender == "k" || gender == "e")
            {


                if (gender == "Erkek")
                {
                    Console.WriteLine("Lütfen yaşınızı giriniz: ");
                    int yas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Maaş bilginizi giriniz: ");
                    int maas = Convert.ToInt32(Console.ReadLine());
                    if (yas >= 60)
                    {

                        Console.WriteLine("Tebrikler, emeklisiniz! İkramiyeniz: " + (maas * 10));
                    }
                    else
                    {
                        Console.WriteLine("Lütfen çalıştığınız gün sayısını giriniz: ");
                        int gunSayisi = Convert.ToInt32(Console.ReadLine());
                        if (gunSayisi >= 6000)
                        {
                            Console.WriteLine("Tebrikler, emeklisiniz! İkramiyeniz: " + (maas * 11));
                        }
                        else
                        {
                            Console.WriteLine("Maalesef, emekli değilsiniz.");
                        }
                    }
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Lütfen yaşınızı giriniz: ");
                    int yas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Maaş bilginizi giriniz: ");
                    int maas = Convert.ToInt32(Console.ReadLine());
                    if (yas >= 58)
                    {
                        Console.WriteLine("Tebrikler, emeklisiniz! İkramiyeniz: " + (maas * 10));
                    }
                    else
                    {
                        Console.WriteLine("Lütfen çalıştığınız gün sayısını giriniz: ");
                        int gunSayisi = Convert.ToInt32(Console.ReadLine());
                        if (gunSayisi >= 4500)
                        {
                            Console.WriteLine("Tebrikler, emeklisiniz! İkramiyeniz: " + (maas * 11));
                        }
                        else
                        {
                            Console.WriteLine("Maalesef, emekli değilsiniz.");
                        }
                    }

                }

            }
            else
            {
                Console.WriteLine("Lütfen e/k değerlerinden birini giriniz.");
            }
            Console.ReadLine();
        }
    }
}

