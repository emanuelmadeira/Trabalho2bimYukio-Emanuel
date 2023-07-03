namespace Trabalho2bim
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Atributo1 = new RadioButton();
            Atributo2 = new RadioButton();
            Atributo3 = new RadioButton();
            Atributo4 = new RadioButton();
            comparar = new Button();
            sortear = new Button();
            comecar = new Button();
            label1 = new Label();
            label2 = new Label();
            numcartjog = new Label();
            numcartamaqui = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(466, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(249, 232);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Atributo1
            // 
            Atributo1.AutoSize = true;
            Atributo1.BackColor = SystemColors.Control;
            Atributo1.ForeColor = SystemColors.ControlText;
            Atributo1.Location = new Point(30, 276);
            Atributo1.Name = "Atributo1";
            Atributo1.Size = new Size(82, 19);
            Atributo1.TabIndex = 2;
            Atributo1.TabStop = true;
            Atributo1.Text = "Velocidade";
            Atributo1.UseVisualStyleBackColor = false;
            // 
            // Atributo2
            // 
            Atributo2.AutoSize = true;
            Atributo2.Location = new Point(30, 301);
            Atributo2.Name = "Atributo2";
            Atributo2.Size = new Size(57, 19);
            Atributo2.TabIndex = 3;
            Atributo2.TabStop = true;
            Atributo2.Text = "Chute";
            Atributo2.UseVisualStyleBackColor = true;
            // 
            // Atributo3
            // 
            Atributo3.AutoSize = true;
            Atributo3.Location = new Point(30, 326);
            Atributo3.Name = "Atributo3";
            Atributo3.Size = new Size(54, 19);
            Atributo3.TabIndex = 4;
            Atributo3.TabStop = true;
            Atributo3.Text = "Passe";
            Atributo3.UseVisualStyleBackColor = true;
            // 
            // Atributo4
            // 
            Atributo4.AutoSize = true;
            Atributo4.Location = new Point(30, 351);
            Atributo4.Name = "Atributo4";
            Atributo4.Size = new Size(60, 19);
            Atributo4.TabIndex = 5;
            Atributo4.TabStop = true;
            Atributo4.Text = "Defesa";
            Atributo4.UseVisualStyleBackColor = true;
            // 
            // comparar
            // 
            comparar.BackColor = Color.Green;
            comparar.Location = new Point(225, 370);
            comparar.Name = "comparar";
            comparar.Size = new Size(109, 43);
            comparar.TabIndex = 6;
            comparar.Text = "Comparar";
            comparar.UseVisualStyleBackColor = false;
            comparar.Click += comparar_Click;
            // 
            // sortear
            // 
            sortear.BackColor = Color.FromArgb(255, 128, 0);
            sortear.Location = new Point(359, 370);
            sortear.Name = "sortear";
            sortear.Size = new Size(123, 43);
            sortear.TabIndex = 7;
            sortear.Text = "Sortear Cartas";
            sortear.UseVisualStyleBackColor = false;
            sortear.Click += sortear_Click;
            // 
            // comecar
            // 
            comecar.BackColor = Color.IndianRed;
            comecar.Location = new Point(508, 370);
            comecar.Name = "comecar";
            comecar.Size = new Size(121, 43);
            comecar.TabIndex = 8;
            comecar.Text = "Começar Rodada";
            comecar.UseVisualStyleBackColor = false;
            comecar.Click += comecar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 5);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 9;
            label1.Text = "Jogador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(618, 5);
            label2.Name = "label2";
            label2.Size = new Size(97, 30);
            label2.TabIndex = 10;
            label2.Text = "Maquina";
            // 
            // numcartjog
            // 
            numcartjog.AutoSize = true;
            numcartjog.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numcartjog.Location = new Point(138, 5);
            numcartjog.Name = "numcartjog";
            numcartjog.Size = new Size(129, 20);
            numcartjog.TabIndex = 11;
            numcartjog.Text = "Numero de Cartas";
            // 
            // numcartamaqui
            // 
            numcartamaqui.AutoSize = true;
            numcartamaqui.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numcartamaqui.Location = new Point(466, 5);
            numcartamaqui.Name = "numcartamaqui";
            numcartamaqui.Size = new Size(129, 20);
            numcartamaqui.TabIndex = 12;
            numcartamaqui.Text = "Numero de Cartas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(numcartamaqui);
            Controls.Add(numcartjog);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comecar);
            Controls.Add(sortear);
            Controls.Add(comparar);
            Controls.Add(Atributo4);
            Controls.Add(Atributo3);
            Controls.Add(Atributo2);
            Controls.Add(Atributo1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RadioButton Atributo1;
        private RadioButton Atributo2;
        private RadioButton Atributo3;
        private RadioButton Atributo4;
        private Button comparar;
        private Button sortear;
        private Button comecar;
        private Label label1;
        private Label label2;
        private Label numcartjog;
        private Label numcartamaqui;
    }
}