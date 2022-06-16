using ClassApp14._06._2022.Helpers;
using System;

namespace ClassApp14._06._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Course it = new Course();
            //Group p323 = new Group();


            while (true)
            {
            Main:

                Helper.Printer("1) Qrup elave et", ConsoleColor.Blue);
                Helper.Printer("2) Qruplari gor ", ConsoleColor.Blue);
                Helper.Printer("3) Qrupa student elave et", ConsoleColor.Blue);
                Helper.Printer("4) Studentleri gor", ConsoleColor.Blue);
                Helper.Printer("5) Studentler uzre axtaris", ConsoleColor.Blue);
                Helper.Printer("6) Qrupdan student sil", ConsoleColor.Blue);
                Helper.Printer("7) Qrupdaki studenti editle", ConsoleColor.Blue);
                string chooseMenyu = Console.ReadLine();
                bool isMenyu = int.TryParse(chooseMenyu, out int menu);
                if (!isMenyu) { Helper.Equals("Duzgun daxil et", ConsoleColor.Red); goto Main; }
                //else if (isMenyu && menu >= 1 && menu <= 7)
                //{
                switch (menu)
                {
                    case 1:
                        Helper.Printer("Qrupun adini daxil edin", ConsoleColor.Yellow);
                        string gName = Console.ReadLine();
                        Group newGroup = new Group(gName);

                        it.Group.Add(newGroup);
                        Helper.Printer($"{gName}  qrupu yaradildi", ConsoleColor.Green);

                        break;
                    case 2:
                        if (it.Group.Count == 0)
                        {
                            Helper.Printer("Qrup yoxdur", ConsoleColor.Red);
                            goto Main;
                        }
                        foreach (var item in it.Group)
                        {
                            Helper.Printer($"{item.Name} ", ConsoleColor.Green);
                        }

                        break;
                    case 3:
                        if (it.Group.Count == 0)
                        {
                            Helper.Printer("Qrup boshdur", ConsoleColor.Red);
                            goto Main;
                        }
                        Helper.Printer("Movcud qruplarin siyahisi : ", ConsoleColor.White);

                        foreach (var item in it.Group)
                        {
                            Helper.Printer($"{item.Name} ", ConsoleColor.Green);
                        }                 
                        Helper.Printer("Telebeni daxil etmek istediyiniz qrupu secin", ConsoleColor.Yellow);
                        string chosGroup = Console.ReadLine();                       
                        foreach (var item in it.Group)
                        {

                            if (item.Name.ToUpper() == chosGroup.ToUpper())
                            {

                                Helper.Printer("Telebenin adin daxil edin", ConsoleColor.White);
                                string studName = Console.ReadLine();
                                Helper.Printer("Soyadini daxil edin", ConsoleColor.White);
                                string studSurname = Console.ReadLine();
                            stAge:
                                Helper.Printer("Yasini daxil edin", ConsoleColor.White);
                                string stAge = Console.ReadLine();

                                bool IstAge = int.TryParse(stAge, out int age);
                                if (!IstAge || age < 0)
                                {
                                    Helper.Printer("Duzgun yash daxil edin !", ConsoleColor.Red);
                                    goto stAge;
                                }
                            grade:
                                Helper.Printer("Qiymetini daxil edin", ConsoleColor.White);
                                string stGrade = Console.ReadLine();
                                bool IsGrade = double.TryParse(stGrade, out double grade);
                                if (!IsGrade || grade < 0 || grade > 100)
                                {
                                    Helper.Printer("Duzgun qiymet daxil edin !", ConsoleColor.Red);
                                    goto grade;
                                }
                                Student newStuden = new Student(studName, studSurname, age, grade);
                                item.Students.Add(newStuden);
                                Helper.Printer($"{studName}   {studSurname}  telebe elave olundu ", ConsoleColor.Green);

                            }
                        }


                        //Helper.Printer("Axtardiginiz studenti daxil edin",)
                        //    List<Student> foundStud = p323.Students.FindAll(x =>)
                        break;

                    case 4:
                        if (it.Group.Count == 0)
                        {
                            Helper.Printer("Qrup yoxdur", ConsoleColor.Red);
                            goto Main;
                        }
                        foreach (var item in it.Group)
                        {
                            Helper.Printer($"{item.Name} ", ConsoleColor.Green);
                        }
                    viewGroup:
                        Helper.Printer("Baxmaq istediyiniz qrupun adini daxil edin : ", ConsoleColor.White);
                        string viewGroup = Console.ReadLine();
                        foreach (var item in it.Group)
                        {
                            if (viewGroup.ToUpper() == item.Name.ToUpper())
                            {
                                foreach (var ite in item.Students)
                                {
                                    Helper.Printer($"Telebe adi - {ite.Name}  Soyadi {ite.Surname} - yas : {ite.Age} - qiymet : {ite.Grade}", ConsoleColor.Green);
                                }
                                goto Main;
                            }

                        }
                        Helper.Printer("Bu adda qrup movcud deyil !", ConsoleColor.Red);
                        break;
                    case 5:
                        if (it.Group.Count == 0)
                        {
                            Helper.Printer("Qrup yoxdur", ConsoleColor.Red);
                            goto Main;
                        }
                        Helper.Printer("Axtardiginiz telebenin adini daxil edin", ConsoleColor.Yellow);
                        string searchStud = Console.ReadLine();
                        //List<Student> res = newgroup.Students.FindAll(x=>x.Name.Contains(searchStud));
                        foreach (var item in it.Group)
                        {
                            foreach (var st in item.Students)
                            {
                                if (st.Name.Contains(searchStud))
                                {
                                    Helper.Printer($"Telebe  {st.Name}   {st.Surname} ", ConsoleColor.Green);

                                }
                            }
                        }

                        break;
                    case 6:
                        if (it.Group.Count == 0)
                        {
                            Helper.Printer("Qrup yoxdur", ConsoleColor.Red);
                            goto Main;
                        }
                        foreach (var item in it.Group)
                        {
                            Helper.Printer($"{item.Name} ", ConsoleColor.Green);
                        }
                        Helper.Printer("Hansi qrupdan telebe silmek isteyirsiniz hemin qrupu daxil edin ", ConsoleColor.Yellow);
                        string delStud = Console.ReadLine();
                        foreach (var gr in it.Group)
                        {
                            if (delStud == gr.Name)
                            {
                                foreach (var stitem in gr.Students)
                                {
                                    Helper.Printer($"Telebe ID - {stitem.Id }   Telebe ad : {stitem.Name}", ConsoleColor.Gray);
                                }
                            }
                        }
                    IDdel:
                        Helper.Printer("Silmek istediyiniz telebenin ID daxil edin : ", ConsoleColor.Yellow);
                        string stId = Console.ReadLine();
                        bool isstId = int.TryParse(stId, out int id);
                        if (!isstId)
                        {
                            Helper.Printer("Duzgun ID daxil edin", ConsoleColor.Red);
                            goto IDdel;
                        }
                        foreach (var gr in it.Group)
                        {


                            foreach (var stitem in gr.Students)
                            {

                                if (id == stitem.Id)
                                {
                                    gr.Students.Remove(stitem);
                                    Helper.Printer($"{stitem.Name} adli telebe silindi ", ConsoleColor.Green);
                                }

                            }

                        }

                        break;
                    default:
                        break;
                        //}
                }
            }

        }
    }
}
