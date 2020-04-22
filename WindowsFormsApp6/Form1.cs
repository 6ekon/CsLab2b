using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        int n, m;
        public int N { get => n; set => n = value; }
        public int M { get => m; set => m = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OupM_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cout_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cout.Text = "";
            N = Convert.ToInt32(OupN.Text);
            M = Convert.ToInt32(OupM.Text);
            Triangle[] conclusion = new Triangle[N];
            double averagesquare = 0;
            for (int i = 0; i < N; i++)
            {
                conclusion[i] = new Triangle();
                conclusion[i].High();
                conclusion[i].Perimeter();
                conclusion[i].Square();
                averagesquare += conclusion[i].square;
            }
            averagesquare /= N;

            RightPyramid[] concl = new RightPyramid[M];
            for (int i = 0; i < M; i++)
            {
                concl[i] = new RightPyramid();
                concl[i].Volume();
            }
            double biggestvolume = int.MinValue;
            for (int i = 0; i < N; i++)
            {
                Cout.Text += $"Triangle №{i + 1}\n";
                Cout.Text += conclusion[i].Out();
            }
            Cout.Text += "\n";
            Cout.Text += "Average Square = ";
            Cout.Text += averagesquare.ToString("n");
            Cout.Text += "\n\n";
            for (int i = 0; i < N; i++)
            {
                if (conclusion[i].square > averagesquare)
                {
                    Cout.Text += $"Bigger square then Average Square = {conclusion[i].square}\n";
                }
            }
            Cout.Text += "\n\n";
            for (int i = 0; i < M; i++)
            {
                Cout.Text += $"Pyramid №{i + 1}\n";
                Cout.Text += concl[i].Out2();
            }
            for (int i = 0; i < concl.Length; i++)
            {
                if (concl[i].volumerr > biggestvolume)
                {
                    biggestvolume = concl[i].volumerr;
                }
            }
            Cout.Text += $"\nThe biggest volume = {biggestvolume}";

        }
    }
}
