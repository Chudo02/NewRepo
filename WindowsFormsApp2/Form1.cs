using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Объявление рандомной переменной rnd
        private static Random rnd = new Random();
        private static int GetNumber()
        {
           //Создание рандомного числа
            
            int value = rnd.Next();
            return value;
        }
        // Объявлнение массива
        private static int[] massive;
        private void button1_Click(object sender, EventArgs e)
        {

            

            //Условие

            if (textBox1.Text != "" && Convert.ToInt32(textBox1.Text)>0)
            {
                //Обнуление label1 
                label1.Text = "";

                int Enter_Number = Convert.ToInt32(textBox1.Text);

                //Создание нового массива
                massive = new int[Enter_Number];

                //Запись рандомных чисел в массив
                for (int i = 0; i < Enter_Number; i++)
                {
                    massive[i] = GetNumber();
                }
                // [0, 1, 2, 3];
                //Счётчик элементов массива
                int counter = 0;
                //Вывод масива в label1
                foreach (int a in massive)
                {
                    label1.Text += "[" + counter + "]  " + Convert.ToString(a) + "\n";
                    counter++;
                }
            }
            else
            {   //Предупреждение 
                label1.Text = "Введите положительное число";

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int len_massive = massive.Length;
            for (int i = 0; i< len_massive; i++ )
            {
                massive[i] = 0;
                label1.Text +="[" + i +"]  "+ massive[i].ToString() + "\n";
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
