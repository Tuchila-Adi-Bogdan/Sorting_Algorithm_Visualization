using System.Collections.Specialized;
using System.DirectoryServices.ActiveDirectory;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Sorting_Algorithm_Visualizer
{
    public partial class Form1 : Form
    {
        private int[] mainArray;
        private List<SortStep> playbackSteps;
        private int currentStep;

        private List<InterfaceSortAlgorithm> algorithms;

        private PaintController paintController;

        private Dictionary<int, Color> specialBarColors;

        private int selectedAlgorithmIndex = -1;

        public Form1()
        {
            InitializeComponent();
            paintController = new PaintController();
            specialBarColors = new Dictionary<int, Color>();

            algorithms = new List<InterfaceSortAlgorithm> { new BubbleSort() /*, new MergeSort(), */ };

            generateRandomArray(10, 80);
        }
        private void generateRandomArray(int size, int maxValue)
        {
            Random rand = new Random();
            mainArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                mainArray[i] = rand.Next(1, maxValue + 1);
            }
            playbackSteps = null;
            currentStep = 0;
            specialBarColors.Clear();
            pictureBox1.Invalidate();
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            paintController.ClearAll(g);

            if (mainArray == null) return;

            float barWidth = (float)pictureBox1.Width / mainArray.Length;
            float maxVal = mainArray.Max();

            for (int i = 0; i < mainArray.Length; i++)
            {
                float barHeight = (mainArray[i] / maxVal) * pictureBox1.Height;
                float x = i * barWidth;
                float y = pictureBox1.Height - barHeight;

                Color barColor = Color.White;

                if (specialBarColors.ContainsKey(i))
                {
                    barColor = specialBarColors[i];
                }

                paintController.DrawBar(g, x, y, barWidth, barHeight, barColor);
            }
        }

        private void ApplyStep(SortStep step)
        {
            specialBarColors.Clear();

            if (step.StepType == SortStepType.Compare)
            {
                specialBarColors[step.IndexA] = Color.Red;
                specialBarColors[step.IndexB] = Color.Red;
            }
            else if (step.StepType == SortStepType.Swap)
            {
                MySwap.swap(ref mainArray[step.IndexA], ref mainArray[step.IndexB]);
                specialBarColors[step.IndexA] = Color.Blue;
                specialBarColors[step.IndexB] = Color.Blue;
            }
        }

        private async void Button_Start_Click(object sender, EventArgs e)
        {
            if (selectedAlgorithmIndex == -1)
            {
                MessageBox.Show("Select a sorting algorithm first.");
                return;
            }
            button_Start.Enabled = false;
            button_random_n.Enabled = false;
            button_Load_Vector.Enabled = false;
            button_Go.Enabled = false;
            InterfaceSortAlgorithm selectedAlgorithm = algorithms[selectedAlgorithmIndex];
            playbackSteps = await Task.Run(() => selectedAlgorithm.GenerateSortSteps(mainArray));
            for(int i=0;i<playbackSteps.Count; i++)
            {
                currentStep = i;
                ApplyStep(playbackSteps[i]);
                pictureBox1.Invalidate();
                await Task.Delay(100);
            }

            specialBarColors.Clear();
            pictureBox1.Invalidate();
            button_Start.Enabled = true;
            button_random_n.Enabled = true;
            button_Load_Vector.Enabled = true;
            button_Go.Enabled = true;
        }

        private void button_Bubble_Sort_Click(object sender, EventArgs e)
        {
            reset_buttons();
            method_selected("Bubble Sort");
        }

        private void method_selected(String clicked_button)
        {
            switch (clicked_button)
            {
                case "Bubble Sort":
                    selectedAlgorithmIndex = 0;
                    button_Bubble_Sort.BackColor = Color.LightBlue;
                    button_Bubble_Sort.Text = "Bubble Sort";
                    button_Bubble_Sort.Size = new Size(250, 30); //+185
                    button_Selection_Sort.Location = new Point(265, 10); //80+185
                    button_Insertion_Sort.Location = new Point(335, 10); //150+185
                    button_Merge_Sort.Location = new Point(405, 10); //220+185
                    break;
                case "Selection Sort":
                    selectedAlgorithmIndex = 1;
                    button_Selection_Sort.BackColor = Color.LightBlue;
                    button_Selection_Sort.Text = "Selection Sort";
                    button_Selection_Sort.Size = new Size(250, 30);
                    button_Insertion_Sort.Location = new Point(335, 10);
                    button_Merge_Sort.Location = new Point(405, 10);
                    break;
                case "Insertion Sort":
                    selectedAlgorithmIndex = 2;
                    button_Insertion_Sort.BackColor = Color.LightBlue;
                    button_Insertion_Sort.Text = "Insertion Sort";
                    button_Insertion_Sort.Size = new Size(250, 30);
                    button_Merge_Sort.Location = new Point(405, 10);
                    break;
                case "Merge Sort":
                    selectedAlgorithmIndex = 3;
                    button_Merge_Sort.BackColor = Color.LightBlue;
                    button_Merge_Sort.Text = "Merge Sort";
                    button_Merge_Sort.Size = new Size(250, 30);
                    break;
                default:
                    selectedAlgorithmIndex = -1;
                    break;
            }
        }
        private void reset_buttons()
        {
            button_Bubble_Sort.BackColor = SystemColors.Control;
            button_Bubble_Sort.Text = "BUB";
            button_Bubble_Sort.Size = new Size(65, 30);

            button_Selection_Sort.BackColor = SystemColors.Control;
            button_Selection_Sort.Text = "SEL";
            button_Selection_Sort.Size = new Size(65, 30);
            button_Selection_Sort.Location = new Point(80, 10);

            button_Insertion_Sort.BackColor = SystemColors.Control;
            button_Insertion_Sort.Text = "SEL";
            button_Insertion_Sort.Size = new Size(65, 30);
            button_Insertion_Sort.Location = new Point(150, 10);

            button_Merge_Sort.BackColor = SystemColors.Control;
            button_Merge_Sort.Text = "MER";
            button_Merge_Sort.Size = new Size(65, 30);
            button_Merge_Sort.Location = new Point(220, 10);
        }

        private void button_Selection_Sort_Click(object sender, EventArgs e)
        {
            reset_buttons();
            method_selected("Selection Sort");
        }

        private void button_Insertion_Sort_Click(object sender, EventArgs e)
        {
            reset_buttons();
            method_selected("Insertion Sort");
        }

        private void button_Merge_Sort_Click(object sender, EventArgs e)
        {
            reset_buttons();
            method_selected("Merge Sort");
        }
    }
}