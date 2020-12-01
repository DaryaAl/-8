using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_6;

namespace Практическая_работа__8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Кнопка О программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создать интерфейсы – человек и печать (для формирования информации об объекте)." +
                "Создать класс – студент.Класс должен включать конструкторы функцию для формирования строки информации о студенте." +
                "Сравнение производить по фамилии.");
        }

        //Кнопка Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Создание объектов
        Student student1 = new Student();
        Student student2 = new Student();

        //Кнопка Заполнить данные о студенте 1
        private void button1_Click(object sender, EventArgs e)
        {
            student1.FirstName = textBox1.Text;
            student1.LastName = textBox3.Text;
            student1.Patronymic = textBox2.Text;
            student1.Department = textBox4.Text;
            student1.Age = Convert.ToInt32(textBox6.Text);
            student1.Course = Convert.ToInt32(textBox5.Text);
            listBox1.Items.Add(student1.Print().ToString());
        }

        //Кнопка Заполнить данные о студенте 2
        private void button2_Click(object sender, EventArgs e)
        {
            student2.FirstName = textBox7.Text;
            student2.LastName = textBox10.Text;
            student2.Patronymic = textBox8.Text;
            student2.Department = textBox12.Text;
            student2.Age = Convert.ToInt32(textBox9.Text);
            student2.Course = Convert.ToInt32(textBox11.Text);
            listBox2.Items.Add(student2.Print().ToString());
        }

        //Кнопка Клонировать
        private void button3_Click(object sender, EventArgs e)
        {
            Student student2 = (Student)student1.Clone();
            listBox2.Items.Add(student2.Print().ToString());
        }

        //Кнопка Сравнить
        private void button4_Click(object sender, EventArgs e)
        {
            if (student1.CompareTo(student2) == 1)
            {
                MessageBox.Show("Фамилии студентов одинаковые");
            }
            else
            {
                MessageBox.Show("Фамилии студентов не одинаковые");
            }
        }

        //Кнопка Очистить
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }

        //Очистить информацию о первом студенте
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }


        //Очистить информацию о втором студенте
        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
    }
}
