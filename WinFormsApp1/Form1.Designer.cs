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
            openFileDialog4 = new OpenFileDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabPage_Animation = new TabPage();
            button_Start = new Button();
            panel_Vizualizator = new Panel();
            button_Load_Vector = new Button();
            button_Create_Vector = new Button();
            label_No_of_Elements = new Label();
            textBox_No_of_Elements = new TextBox();
            label_Vector = new Label();
            textBox_Vector = new TextBox();
            button_random_n = new Button();
            button_random_vector = new Button();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage_Animation.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog4
            // 
            openFileDialog4.FileName = "openFileDialog4";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tabPage_Animation
            // 
            tabPage_Animation.Controls.Add(button1);
            tabPage_Animation.Controls.Add(button_random_vector);
            tabPage_Animation.Controls.Add(button_random_n);
            tabPage_Animation.Controls.Add(textBox_Vector);
            tabPage_Animation.Controls.Add(textBox_No_of_Elements);
            tabPage_Animation.Controls.Add(label_Vector);
            tabPage_Animation.Controls.Add(label_No_of_Elements);
            tabPage_Animation.Controls.Add(button_Create_Vector);
            tabPage_Animation.Controls.Add(button_Load_Vector);
            tabPage_Animation.Controls.Add(panel_Vizualizator);
            tabPage_Animation.Controls.Add(button_Start);
            tabPage_Animation.Location = new Point(4, 34);
            tabPage_Animation.Name = "tabPage_Animation";
            tabPage_Animation.Padding = new Padding(3);
            tabPage_Animation.Size = new Size(1403, 733);
            tabPage_Animation.TabIndex = 0;
            tabPage_Animation.Text = "Animation";
            tabPage_Animation.UseVisualStyleBackColor = true;
            tabPage_Animation.Click += tabPage1_Click;
            // 
            // button_Start
            // 
            button_Start.Location = new Point(6, 646);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(160, 35);
            button_Start.TabIndex = 1;
            button_Start.Text = "Start";
            button_Start.UseVisualStyleBackColor = true;
            button_Start.Click += Button_Start_Click;
            // 
            // panel_Vizualizator
            // 
            panel_Vizualizator.Location = new Point(6, 6);
            panel_Vizualizator.Name = "panel_Vizualizator";
            panel_Vizualizator.Size = new Size(1397, 634);
            panel_Vizualizator.TabIndex = 2;
            // 
            // button_Load_Vector
            // 
            button_Load_Vector.Location = new Point(1221, 649);
            button_Load_Vector.Name = "button_Load_Vector";
            button_Load_Vector.Size = new Size(160, 73);
            button_Load_Vector.TabIndex = 0;
            button_Load_Vector.Text = "Load Vector";
            button_Load_Vector.UseVisualStyleBackColor = true;
            button_Load_Vector.Click += Button_Load_Vector_Click;
            // 
            // button_Create_Vector
            // 
            button_Create_Vector.Location = new Point(6, 687);
            button_Create_Vector.Name = "button_Create_Vector";
            button_Create_Vector.Size = new Size(160, 40);
            button_Create_Vector.TabIndex = 3;
            button_Create_Vector.Text = "Create Vector";
            button_Create_Vector.UseVisualStyleBackColor = true;
            button_Create_Vector.Click += button_Create_Vector_Click;
            // 
            // label_No_of_Elements
            // 
            label_No_of_Elements.AutoSize = true;
            label_No_of_Elements.Location = new Point(192, 656);
            label_No_of_Elements.Name = "label_No_of_Elements";
            label_No_of_Elements.Size = new Size(164, 25);
            label_No_of_Elements.TabIndex = 4;
            label_No_of_Elements.Text = "No. of elements =";
            // 
            // textBox_No_of_Elements
            // 
            textBox_No_of_Elements.Location = new Point(362, 653);
            textBox_No_of_Elements.Name = "textBox_No_of_Elements";
            textBox_No_of_Elements.Size = new Size(48, 30);
            textBox_No_of_Elements.TabIndex = 5;
            // 
            // label_Vector
            // 
            label_Vector.AutoSize = true;
            label_Vector.Location = new Point(192, 697);
            label_Vector.Name = "label_Vector";
            label_Vector.Size = new Size(91, 25);
            label_Vector.TabIndex = 6;
            label_Vector.Text = "Vector = ";
            // 
            // textBox_Vector
            // 
            textBox_Vector.Location = new Point(285, 697);
            textBox_Vector.Name = "textBox_Vector";
            textBox_Vector.Size = new Size(125, 30);
            textBox_Vector.TabIndex = 7;
            // 
            // button_random_n
            // 
            button_random_n.Location = new Point(416, 653);
            button_random_n.Name = "button_random_n";
            button_random_n.Size = new Size(112, 30);
            button_random_n.TabIndex = 8;
            button_random_n.Text = "Random";
            button_random_n.UseVisualStyleBackColor = true;
            // 
            // button_random_vector
            // 
            button_random_vector.Location = new Point(416, 697);
            button_random_vector.Name = "button_random_vector";
            button_random_vector.Size = new Size(112, 30);
            button_random_vector.TabIndex = 9;
            button_random_vector.Text = "Random";
            button_random_vector.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(534, 698);
            button1.Name = "button1";
            button1.Size = new Size(104, 29);
            button1.TabIndex = 10;
            button1.Text = "Sorted";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_Animation);
            tabControl1.Location = new Point(-4, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1411, 771);
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1419, 767);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "-";
            Load += Form1_Load;
            tabPage_Animation.ResumeLayout(false);
            tabPage_Animation.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private OpenFileDialog openFileDialog4;
        private ContextMenuStrip contextMenuStrip1;
        private TabPage tabPage_Animation;
        private Button button1;
        private Button button_random_vector;
        private Button button_random_n;
        private TextBox textBox_Vector;
        private TextBox textBox_No_of_Elements;
        private Label label_Vector;
        private Label label_No_of_Elements;
        private Button button_Create_Vector;
        private Button button_Load_Vector;
        private Panel panel_Vizualizator;
        private Button button_Start;
        private TabControl tabControl1;
    }
}