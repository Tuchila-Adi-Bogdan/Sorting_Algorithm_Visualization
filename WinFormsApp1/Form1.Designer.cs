namespace Sorting_Algorithm_Visualizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button_Sorted = new Button();
            button_random_n = new Button();
            textBox_Vector = new TextBox();
            textBox_No_of_Elements = new TextBox();
            label_Vector = new Label();
            label_No_of_Elements = new Label();
            button_Load_Vector = new Button();
            button_Start = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            openFileDialog4 = new OpenFileDialog();
            button_Bubble_Sort = new Button();
            button_Selection_Sort = new Button();
            button_Insertion_Sort = new Button();
            button_Merge_Sort = new Button();
            button_Go = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_Sorted
            // 
            button_Sorted.Location = new Point(523, 681);
            button_Sorted.Name = "button_Sorted";
            button_Sorted.Size = new Size(128, 31);
            button_Sorted.TabIndex = 10;
            button_Sorted.Text = "Sorted";
            button_Sorted.UseVisualStyleBackColor = true;
            // 
            // button_random_n
            // 
            button_random_n.Location = new Point(395, 679);
            button_random_n.Name = "button_random_n";
            button_random_n.Size = new Size(122, 33);
            button_random_n.TabIndex = 8;
            button_random_n.Text = "Random";
            button_random_n.UseVisualStyleBackColor = true;
            // 
            // textBox_Vector
            // 
            textBox_Vector.Location = new Point(264, 725);
            textBox_Vector.Name = "textBox_Vector";
            textBox_Vector.Size = new Size(243, 30);
            textBox_Vector.TabIndex = 7;
            // 
            // textBox_No_of_Elements
            // 
            textBox_No_of_Elements.Location = new Point(341, 679);
            textBox_No_of_Elements.Name = "textBox_No_of_Elements";
            textBox_No_of_Elements.Size = new Size(48, 30);
            textBox_No_of_Elements.TabIndex = 5;
            // 
            // label_Vector
            // 
            label_Vector.AutoSize = true;
            label_Vector.Location = new Point(178, 730);
            label_Vector.Name = "label_Vector";
            label_Vector.Size = new Size(91, 25);
            label_Vector.TabIndex = 6;
            label_Vector.Text = "Vector = ";
            // 
            // label_No_of_Elements
            // 
            label_No_of_Elements.AutoSize = true;
            label_No_of_Elements.Location = new Point(178, 682);
            label_No_of_Elements.Name = "label_No_of_Elements";
            label_No_of_Elements.Size = new Size(164, 25);
            label_No_of_Elements.TabIndex = 4;
            label_No_of_Elements.Text = "No. of elements =";
            // 
            // button_Load_Vector
            // 
            button_Load_Vector.Location = new Point(1249, 682);
            button_Load_Vector.Name = "button_Load_Vector";
            button_Load_Vector.Size = new Size(160, 73);
            button_Load_Vector.TabIndex = 0;
            button_Load_Vector.Text = "Load Vector";
            button_Load_Vector.UseVisualStyleBackColor = true;
            // 
            // button_Start
            // 
            button_Start.Location = new Point(12, 679);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(160, 76);
            button_Start.TabIndex = 1;
            button_Start.Text = "Start";
            button_Start.UseVisualStyleBackColor = true;
            button_Start.Click += Button_Start_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // openFileDialog4
            // 
            openFileDialog4.FileName = "openFileDialog4";
            // 
            // button_Bubble_Sort
            // 
            button_Bubble_Sort.Location = new Point(10, 10);
            button_Bubble_Sort.Name = "button_Bubble_Sort";
            button_Bubble_Sort.Size = new Size(65, 30);
            button_Bubble_Sort.TabIndex = 11;
            button_Bubble_Sort.Text = "BUB";
            button_Bubble_Sort.UseVisualStyleBackColor = true;
            button_Bubble_Sort.Click += button_Bubble_Sort_Click;
            // 
            // button_Selection_Sort
            // 
            button_Selection_Sort.Location = new Point(80, 10);
            button_Selection_Sort.Name = "button_Selection_Sort";
            button_Selection_Sort.Size = new Size(65, 30);
            button_Selection_Sort.TabIndex = 12;
            button_Selection_Sort.Text = "SEL";
            button_Selection_Sort.UseVisualStyleBackColor = true;
            button_Selection_Sort.Click += button_Selection_Sort_Click;
            // 
            // button_Insertion_Sort
            // 
            button_Insertion_Sort.Location = new Point(150, 10);
            button_Insertion_Sort.Name = "button_Insertion_Sort";
            button_Insertion_Sort.Size = new Size(65, 30);
            button_Insertion_Sort.TabIndex = 13;
            button_Insertion_Sort.Text = "INS";
            button_Insertion_Sort.UseVisualStyleBackColor = true;
            button_Insertion_Sort.Click += button_Insertion_Sort_Click;
            // 
            // button_Merge_Sort
            // 
            button_Merge_Sort.Location = new Point(220, 10);
            button_Merge_Sort.Name = "button_Merge_Sort";
            button_Merge_Sort.Size = new Size(65, 30);
            button_Merge_Sort.TabIndex = 0;
            button_Merge_Sort.Text = "MER";
            button_Merge_Sort.UseVisualStyleBackColor = true;
            button_Merge_Sort.Click += button_Merge_Sort_Click;
            // 
            // button_Go
            // 
            button_Go.Location = new Point(519, 725);
            button_Go.Name = "button_Go";
            button_Go.Size = new Size(94, 29);
            button_Go.TabIndex = 14;
            button_Go.Text = "Go";
            button_Go.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1397, 626);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 767);
            Controls.Add(pictureBox1);
            Controls.Add(button_Go);
            Controls.Add(button_Merge_Sort);
            Controls.Add(button_Insertion_Sort);
            Controls.Add(button_Selection_Sort);
            Controls.Add(button_Bubble_Sort);
            Controls.Add(button_Start);
            Controls.Add(button_random_n);
            Controls.Add(textBox_Vector);
            Controls.Add(textBox_No_of_Elements);
            Controls.Add(label_No_of_Elements);
            Controls.Add(label_Vector);
            Controls.Add(button_Sorted);
            Controls.Add(button_Load_Vector);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Sorting Visualizer 2.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private Button button_Sorted;
        private Button button_random_n;
        private TextBox textBox_Vector;
        private TextBox textBox_No_of_Elements;
        private Label label_Vector;
        private Label label_No_of_Elements;
        private Button button_Load_Vector;
        private Button button_Start;
        private ContextMenuStrip contextMenuStrip1;
        private OpenFileDialog openFileDialog4;
        private Button button_Bubble_Sort;
        private Button button_Selection_Sort;
        private Button button_Insertion_Sort;
        private Button button_Merge_Sort;
        private Button button_Go;
        private PictureBox pictureBox1;
    }
}