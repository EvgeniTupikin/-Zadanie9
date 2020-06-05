using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Zadan5
{


    class RS
    {
        public static int Length { get; set; }

        public static string Id()
        {
            Random r = new Random();
            StringBuilder @string = new StringBuilder();

            for (int i = 0; i < Length; i++)
            {
                @string.Append((Char)r.Next(50, 100));
            }
            return @string.ToString();
        }

        public class Student
        {
            public int Age { get; set; }
            public string FIO { get; set; }
            public string Gruppa { get; set; }
            public string Id { get; set; }
            private string Id1 { get; set; }

            public override string ToString()
            {

                return string.Format("Успешно выполнено! ФИО:{0},Группа:{1},Ваш Возраст:{2}, Id:{3},", FIO, Gruppa, Age, Id);

            }






            class Program
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Ваш уникальный идентификатор студента:");
                    Length = 10;
                    Console.WriteLine(RS.Id());
                    Console.WriteLine("Сегодня прекрасный день вот на сегодня дата");
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine("Введите дату регистрации в формате (DD.MM.YYYY): \n");
                    string input = Console.ReadLine();
                    string[] split = input.Split('.');
                    double day = Double.Parse(split[0]);
                    double month = Double.Parse(split[1]);
                    double year = Double.Parse(split[2]);

                    bool kones = true;
                    ArrayList al = new ArrayList();


                    while (kones)
                    {
                        Console.WriteLine("            Главная меню");
                        PrintMessage();
                        int a = int.Parse(Console.ReadLine());
                        if (a == 1)
                        {
                            AddNewStudent(al);
                        }
                        else if (a == 2)
                        {
                            RemoveStudent(al);
                        }

                        else if (a == 3)
                        {
                            IzmenaStudent(al);
                        }

                        else if (a == 4)
                        {
                            Spisok(al);
                        }
                        else if (a == 5)
                        {
                            Id_SpisokStudenta(al);

                        }
                        else if (a == 6)
                        {
                            Id_LetStudent(al);

                        }
                        else if (a == 7)
                        {
                            inizial(al);
                        }
                        else if (a == 8)
                        {
                            vosrast(al);
                        }
                        else if (a == 9)
                        {
                            vosrast1(al);
                        }

                        else if (a == 10)
                        {
                            FindFioStudent(al);
                        }
                        else if (a == 11)
                        {
                            FindStroka(al);
                        }


                    }

                }





                private static void RemoveStudent(ArrayList al)
                {
                    Console.WriteLine("Введите фамилию:");
                    string findFIO = Console.ReadLine();
                    bool fd = false;
                    Student findSt = new Student();
                    foreach (var item in al)
                    {
                        Student st = (Student)item;
                        if (findFIO == st.FIO)
                        {
                            findSt = st;
                            al.Remove(st);
                            fd = true;
                            break;
                        }
                    }
                    if (fd) { Console.WriteLine(findSt.ToString()); }
                    else { Console.WriteLine("Студент не найден"); }
                }


                private static void IzmenaStudent(ArrayList al)
                {
                    Console.WriteLine("Введите фио:");
                    string findFIO = Console.ReadLine();
                    bool fd = false;
                    Student findSt = new Student();
                    foreach (var item in al)
                    {
                        Student st = (Student)item;
                        if (findFIO == st.FIO)
                        {
                            findSt = st;
                            al.Remove(st);
                            fd = true;
                            break;
                        }
                    }
                    if (fd) { Console.WriteLine(findSt.ToString()); }
                    else { Console.WriteLine("Студент не найден"); }

                    string fio; int age; string grupa;
                    Console.WriteLine("Введите пожалуйста фио студента для изменения");
                    fio = Console.ReadLine();
                    Console.WriteLine("Возраст дял изменения:");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Группа для изменения:");
                    grupa = Console.ReadLine();
                    al.Add(new Student { Age = age, FIO = fio, Gruppa = grupa });
                }


                private static void PrintMessage()
                {
                    Console.WriteLine("Для добавления студента нажмите на 1");
                    Console.WriteLine("Для удаления студента нажмите на 2");
                    Console.WriteLine("Для изменения студента нажмите на 3");
                    Console.WriteLine("Для получения списка нажмите на 4");
                    Console.WriteLine("Выводящий по id студента всю информацию о нем нажмите на 5");
                    Console.WriteLine("Выводящий количество лет студента по id нажмите на 6");
                    Console.WriteLine("Выводящий инициал студента  нажмите на 7");
                    Console.WriteLine("Выводящий старше 18 лет студента  нажмите на 8");
                    Console.WriteLine("Выводящий меньше 18 лет студента  нажмите на 9");
                    Console.WriteLine("Поиск по фамилии нажмите на 10");
                    Console.WriteLine("Поиск по подстроке нажмите на 11");
                }

                private static void Spisok(ArrayList al) //поиск студента для удаления
                {
                    foreach (var item in al)
                    {
                        Student p = (Student)item;
                        Console.WriteLine(p.ToString());
                    }
                }

                private static void AddNewStudent(ArrayList al) //добавление студента
                {
                    string fio; int age; string grupa; string id;
                    Console.WriteLine("Введите пожалуйста фио студента");
                    fio = Console.ReadLine();
                    Console.WriteLine("Возраст:");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Группа:");
                    grupa = Console.ReadLine();
                    Console.WriteLine("Id:");
                    id = Console.ReadLine();
                    al.Add(new Student { Age = age, FIO = fio, Gruppa = grupa, Id = id });

                }
                private static void Id_SpisokStudenta(ArrayList al)
                {
                    Console.WriteLine("Введите Id:");
                    string findId = Console.ReadLine();
                    bool fd = false;
                    Student findSt = new Student();
                    foreach (var item in al)
                    {
                        Student st = (Student)item;
                        if (findId == st.Id)
                        {
                            findSt = st;
                            fd = true;
                            break;
                        }
                    }
                    if (fd) { Console.WriteLine(findSt.ToString()); }
                    else { Console.WriteLine("Студент не найден"); }
                }
                private static void Id_LetStudent(ArrayList al)
                {
                    Console.WriteLine("Введите Id:");
                    string findAge;
                    findAge = Console.ReadLine();
                    bool fd = false;
                    Student findSt = new Student();
                    foreach (var item in al)
                    {
                        Student st = (Student)item;
                        if (findAge == st.Id)
                        {
                            findSt = st;
                            fd = true;
                            break;
                        }
                    }
                    if (fd) { Console.WriteLine(findSt.Age); }
                    else { Console.WriteLine(" Студент не найден"); }
                }
                private static void inizial(ArrayList al)
                {
                    Console.WriteLine("Введите свое ФИО вот таком формате:Иванов Иван Иванович");
                    string[] fio = Console.ReadLine().Split(' ');
                    Console.WriteLine(fio[0] + " " + fio[1][0] + " " + fio[2][0]); //Вот, фамилия и инициалы
                }
                private static void vosrast(ArrayList al)
                {


                    bool fd = false;
                    Student findSt = new Student();
                    foreach (var item in al)
                    {
                        Student st = (Student)item;
                        if (st.Age > 18)
                        {
                            findSt = st;
                            fd = true;
                            break;
                        }
                    }
                    if (fd) { Console.WriteLine(findSt.ToString()); }
                    else { Console.WriteLine("Не найдены"); }



                }
                private static void vosrast1(ArrayList al)
                {


                    bool fd = false;
                    Student findSt = new Student();
                    foreach (var item in al)
                    {
                        Student st = (Student)item;
                        if (st.Age < 18)
                        {
                            findSt = st;
                            fd = true;
                            break;
                        }
                    }
                    if (fd) { Console.WriteLine(findSt.ToString()); }
                    else { Console.WriteLine("Не найдены"); }



                }




                private static void FindFioStudent(ArrayList al)
                {

                    Console.WriteLine("Введите фамилию:");
                    string findFIO = Console.ReadLine();
                    bool fd = false;
                    Student findSt = new Student();
                    foreach (var item in al)
                    {
                        Student st = (Student)item;
                        if (findFIO == st.FIO)
                        {
                            findSt = st;
                            fd = true;
                            break;
                        }
                    }
                    if (fd) { Console.WriteLine(findSt.ToString()); }
                    else { Console.WriteLine("Студент не найден"); }
                }
                private static void FindStroka(ArrayList al)
                {
                    while (true)
                    {

                        bool fd = false;
                        Student findSt = new Student();
                        Console.WriteLine("Введите подстроку");
                        string podstroka = Console.ReadLine();
                        foreach (var item in al)
                        {
                            Student st = (Student)item;
                            if (st.FIO.Length < podstroka.Length)
                            {
                                Console.WriteLine("строка не может быть меньше подстроки");
                                findSt = st;
                                fd = true;
                                break;
                            }
                            else
                            {
                                if (st.FIO.Contains(podstroka)) //строка Содержит подстроку
                                    Console.WriteLine("{0} содержит подстроку {1}", st.FIO, podstroka);
                                else
                                    Console.WriteLine("Строка {0} не содержит подстроку {1}", st.FIO, podstroka);
                            }
                        }

                    }
                }




                private static void LoadStudent(ArrayList al) //загрузка данных
                {
                    al.Add(new Student { Age = 1, FIO = "", Gruppa = "", Id = "" });
                    al.Add(new Student { Age = 2, FIO = "", Gruppa = "", Id = "" });
                    al.Add(new Student { Age = 3, FIO = "", Gruppa = "", Id = "" });
                }

            }

        }
    }

}