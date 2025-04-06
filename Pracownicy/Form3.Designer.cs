namespace Pracownicy
{
    partial class Form3
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button52 = new Button();
            button62 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(857, 59);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(857, 177);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Usun";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(159, 345);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "Zapisz";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(564, 345);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 3;
            button4.Text = "Oczytaj z csv";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button52
            // 
            button52.Location = new Point(121, 305);
            button52.Name = "button52";
            button52.Size = new Size(150, 34);
            button52.TabIndex = 4;
            button52.Text = "Zapisz do JSON";
            button52.UseVisualStyleBackColor = true;
            button52.Click += button52_Click;
            // 
            // button62
            // 
            button62.Location = new Point(564, 305);
            button62.Name = "button62";
            button62.Size = new Size(150, 34);
            button62.TabIndex = 5;
            button62.Text = "Odczyt JSON";
            button62.UseVisualStyleBackColor = true;
            button62.Click += button6_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 450);
            Controls.Add(button62);
            Controls.Add(button52);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form1";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button52;
        private Button button62;
    }
}
