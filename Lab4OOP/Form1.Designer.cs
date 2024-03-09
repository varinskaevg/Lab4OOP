namespace Lab4OOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            btnOK = new Button();
            lblResult3 = new Label();
            lblResult2 = new Label();
            lblResult1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtN = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            lblResult6 = new Label();
            lblResult5 = new Label();
            lblResult4 = new Label();
            txtArray = new TextBox();
            btnOK2 = new Button();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(5, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(792, 444);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(btnOK);
            tabPage1.Controls.Add(lblResult3);
            tabPage1.Controls.Add(lblResult2);
            tabPage1.Controls.Add(lblResult1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtN);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(784, 411);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Завдання 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(780, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(607, 341);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(146, 45);
            btnOK.TabIndex = 10;
            btnOK.Text = "button1";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblResult3
            // 
            lblResult3.AutoSize = true;
            lblResult3.Location = new Point(273, 331);
            lblResult3.Name = "lblResult3";
            lblResult3.Size = new Size(50, 20);
            lblResult3.TabIndex = 9;
            lblResult3.Text = "label8";
            // 
            // lblResult2
            // 
            lblResult2.AutoSize = true;
            lblResult2.Location = new Point(273, 279);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(50, 20);
            lblResult2.TabIndex = 8;
            lblResult2.Text = "label7";
            // 
            // lblResult1
            // 
            lblResult1.AutoSize = true;
            lblResult1.Location = new Point(273, 227);
            lblResult1.Name = "lblResult1";
            lblResult1.Size = new Size(50, 20);
            lblResult1.TabIndex = 7;
            lblResult1.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 331);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 279);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 227);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // txtN
            // 
            txtN.Location = new Point(240, 165);
            txtN.Name = "txtN";
            txtN.Size = new Size(228, 27);
            txtN.TabIndex = 2;
            txtN.KeyPress += txtN_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 172);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblResult6);
            tabPage2.Controls.Add(lblResult5);
            tabPage2.Controls.Add(lblResult4);
            tabPage2.Controls.Add(txtArray);
            tabPage2.Controls.Add(btnOK2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(784, 411);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Завдання 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblResult6
            // 
            lblResult6.AutoSize = true;
            lblResult6.Location = new Point(374, 269);
            lblResult6.Name = "lblResult6";
            lblResult6.Size = new Size(50, 20);
            lblResult6.TabIndex = 10;
            lblResult6.Text = "label8";
            // 
            // lblResult5
            // 
            lblResult5.AutoSize = true;
            lblResult5.Location = new Point(374, 207);
            lblResult5.Name = "lblResult5";
            lblResult5.Size = new Size(50, 20);
            lblResult5.TabIndex = 9;
            lblResult5.Text = "label7";
            // 
            // lblResult4
            // 
            lblResult4.AutoSize = true;
            lblResult4.Location = new Point(158, 207);
            lblResult4.Name = "lblResult4";
            lblResult4.Size = new Size(50, 20);
            lblResult4.TabIndex = 8;
            lblResult4.Text = "label2";
            // 
            // txtArray
            // 
            txtArray.Location = new Point(295, 147);
            txtArray.Name = "txtArray";
            txtArray.Size = new Size(235, 27);
            txtArray.TabIndex = 7;
            txtArray.KeyPress += txtArray_KeyPress;
            // 
            // btnOK2
            // 
            btnOK2.Location = new Point(317, 347);
            btnOK2.Name = "btnOK2";
            btnOK2.Size = new Size(167, 44);
            btnOK2.TabIndex = 6;
            btnOK2.Text = "button1";
            btnOK2.UseVisualStyleBackColor = true;
            btnOK2.Click += btnOK2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(154, 147);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 2;
            label6.Text = "label6";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(771, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "ЛБ4";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox2;
        private TextBox txtN;
        private Label lblResult4;
        private Label label1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private Button btnOK;
        private Label lblResult3;
        private Label lblResult2;
        private Label lblResult1;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox2;
        private Button btnOK2;
        private Label label6;
        private TextBox txtArray;
        private Label lblResult6;
        private Label lblResult5;
    }
}
