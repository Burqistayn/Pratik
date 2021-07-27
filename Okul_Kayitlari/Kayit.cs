using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul_Kayitlari
{
    class Kayit
    {
        public void List(Student student)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Ad : {student.Name}");
            Console.WriteLine($"Soy Ad : {student.Surname}");
            Console.WriteLine($"Yaş : {student.Age}");
            Console.WriteLine($"TC : {student.TC}");
            Console.WriteLine("--------------------");
        }
        public void Add(List<Student> students, List<int> studentTCs)
        {
            string ad;
            Console.Write("Ad : ");
            ad = Console.ReadLine();

            string soyad;
            Console.Write("Soyad : ");
            soyad = Console.ReadLine();

            int yas;
            Console.Write("Yaş : ");
            yas = Convert.ToInt32(Console.ReadLine());

            int TC;
            Console.Write("TC : ");
            TC = Convert.ToInt32(Console.ReadLine());

            Student student = new Student();
            student.Name = ad;
            student.Surname = soyad;
            student.Age = yas;
            student.TC = TC;

            if (studentTCs.Contains(student.TC))
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"{student.TC} numaralı kimlik no zaten kayıtlı");
                Console.WriteLine("--------------------");
            }
            else
            {
                students.Add(student);
                studentTCs.Add(student.TC);
            }
        }
        public void Remove(List<int> studentTCs, List<Student> students)
        {
            int TC;
            Console.Write("TC : ");
            TC = Convert.ToInt32(Console.ReadLine());

            Student student = new Student();
            student.TC = TC;

            int TCsirasi = studentTCs.BinarySearch(student.TC);
            if (TCsirasi < 0)
            {
                Console.WriteLine("Seçtiğiniz TC listede mevcut değildir.");
            }
            else
            {
                students.RemoveAt(TCsirasi);
            }
        }
    }
}
