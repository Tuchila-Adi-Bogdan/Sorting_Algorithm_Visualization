using System.Collections.Specialized;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.CompilerServices;

namespace Sorting_Algorithm_Visualizer
{
    public partial class Form1 : Form
    {
        int n;
        int[] A;
        PictureBox[,] P;
        int c = 0;
        int m = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            //incarc sursa c++
            StreamReader fin = new StreamReader("c++.txt");
            string c = fin.ReadToEnd();

            fin.Close();
            ///incarc sursa c#
            fin = new StreamReader("cs.txt");
            c=fin.ReadToEnd();
            */

        }

        private void Button_Start_Click(object sender, EventArgs e)
        {

        }

        private void Button_Load_Vector_Click(object sender, EventArgs e)
        {
            openFileDialog4.InitialDirectory = Application.StartupPath;
            openFileDialog4.Filter = "(*.in)|*.in";
            openFileDialog4.FileName = "";
            if (openFileDialog4.ShowDialog() == DialogResult.OK)
            {
                string f = openFileDialog4.FileName;
                StreamReader fin = new StreamReader(f);
                string l = fin.ReadLine();
                string[] s = l.Split();
                n = int.Parse(s[0]);
                A = new int[n + 1];
                int maxim = 0;
                for (int i = 1; i <= n; i++)
                {
                    A[i] = int.Parse(s[i]);
                    if (A[i] > maxim)
                        maxim = A[i];
                }
                m = maxim;
                creare();
                fin.Close();
            }
        }
        private void creare()
        {
            panel_Vizualizator.Controls.Clear();
            P = new PictureBox[n + 1, m + 1];
            int L = panel_Vizualizator.Width;
            int H = panel_Vizualizator.Height;
            int w = Math.Min(L / m, H / n) - 3;
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= m; j++)
                {
                    P[i, j] = new PictureBox();
                    P[i, j].Width = w;
                    P[i, j].Height = w;
                    P[i, j].Top = (w + 2) * (i - 1);
                    P[i, j].Left = (w + 2) * (j - 1);
                    if (A[i] == 0) P[i, j].BackColor = Color.Aqua;
                    else P[i, j].BackColor = Color.Maroon;
                    panel_Vizualizator.Controls.Add(P[i, j]);
                }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button_Create_Vector_Click(object sender, EventArgs e)
        {

        }
    }
}