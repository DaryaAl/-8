using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_6
{
    //Интерфейс Человек
    interface iPerson
    {
        string FirstName { get; set; }//свойство Имя
        string LastName { get; set; }//свойство Фамилия
        string Patronymic { get; set; }//свойство Отчество
        int Age { get; set; }//свойство Возраст

    }


    //Интерфейс Печать
    interface iPrint
    {
        string Print();//метод Печать
    }



    //Класс Student, в котором определены интерфейсы iPerson, iPrint, IComparable, ICloneable
    public class Student : iPerson, iPrint, IComparable, ICloneable
    {
        public int course;//поле Курс
        public int Course//свойство 
        {
            get
            {
                return course;
            }
            set
            {
                if (value > 0 && value <= 4)
                {
                    course = value;
                }
                else
                {
                    MessageBox.Show("Курс должен быть 1, 2, 3 или 4");
                }
            }
        }
        public int age;//поле Возраст
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 15)
                {
                    age = value;
                }
                else
                {
                    MessageBox.Show("Недопустимый возраст, укажите правильно");
                }
            }
        }

        public string FirstName { get; set; }//Поле Имя
        public string LastName { get; set; }//Поле Фамилия
        public string Patronymic { get; set; }//Поле Отчество
        public string Department { get; set; }//Поле Отделение


        //Метод Печать
        public string Print()
        {
            //возвращает строку
            return "Имя: " +  FirstName + " , " + "Фамилия: " + LastName + " , " + " Отчество: " + Patronymic + " , " + " Курс " + Course + " , " + " Отделение: " + Department + " , " + " Возраст: " + Age;
        }

        //метод сравнения
        public int CompareTo(object obj)
        {
            Student student = (Student)obj;
            if (this.LastName == student.LastName) { return 1; }
            return 0;
        }

        //метод клонирования
        public object Clone()
        {
            Student st = new Student();
            st.FirstName = this.FirstName;
            st.LastName = this.LastName;
            st.Patronymic = this.Patronymic;
            st.Department = this.Department;
            st.Age = this.Age;
            st.Course = this.Course;
            return st;
        }
    }
}
