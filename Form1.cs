using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Практическая_работа__10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Кнопка о программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик Алешина Дарья ИСП-31" +
                "Вариант 6" +
                "Практическая работа №10" +
                "В массиве чисел найти наибольший элемент и поменять его местами с первым элементом.");
        }

        //Коллекция 
        List<int> mas = new List<int>();

        //Кнопка Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка Заполнить(по одному значению)
        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            int x = Convert.ToInt32(textBox1.Text);
            
            //заполняем коллекцию
            mas.Add(x);

            textBox1.Clear();

            //выводим массив в listBox1
            for (int j = 0; j < mas.Count; j++)
            {
                listBox1.Items.Add(mas[j].ToString());
            }
        }

        //Кнопка Заполнить(случайное заполнение)
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //создаем объект 
            Random random = new Random();
            int RandMax = Convert.ToInt32(numericUpDown2.Value);
            int x;

            //заполняем коллекцию случайными значениями
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                mas.Add(x = random.Next(RandMax));
            }
            //выводим массив в listBox1
            for (int j = 0; j < mas.Count; j++)
            {
                listBox1.Items.Add(mas[j].ToString());
            }
        }

        //Кнопка Поменять
        private void button3_Click(object sender, EventArgs e)
        {
            int max = 0, maxind=0;

            //ищем максимальный элемент и запоминаем его индекс
            for(int i = 0; i < mas.Count; i++)
            {
                if (max < mas[i])
                {
                    max = mas[i];
                    maxind = i;
                }
            }

            //меняем местами максимальный элемент с первым
            int a = mas[0];
            mas[0] = mas[maxind];
            mas[maxind] = a;

            //выводим массив в listBox2
            for (int j = 0; j < mas.Count; j++)
            {
                listBox2.Items.Add(mas[j].ToString());
            }

        }

        //Кнопка Очистить
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
