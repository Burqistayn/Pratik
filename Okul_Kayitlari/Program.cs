using System;
using System.Collections.Generic;

namespace Okul_Kayitlari
{
    class Program
    {
        static void Main(string[] args)
        {
            string islem;
            Kayit kayit = new Kayit();

            List<Student> students = new List<Student>();

            List<int> studentTCs = new List<int>();
            foreach (var student in students)
            {
                studentTCs.Add(student.TC);
            }

            Console.WriteLine("İşlemler : Ekle, Çıkar, Listele");

            while (1 == 1)
            {
                Console.Write("İşlem Seçiniz : ");
                islem = Console.ReadLine();

                if (islem == "Listele")
                {
                    foreach (var student in students)
                    {
                        kayit.List(student);
                    }
                }
                else if (islem == "Ekle")
                {
                    kayit.Add(students, studentTCs);
                }
                else if (islem == "Çıkar")
                {
                    kayit.Remove(studentTCs, students);
                }
                else
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("İşlem seçilemedi.");
                    Console.WriteLine("--------------------");
                }
            }
        }
    }
}
