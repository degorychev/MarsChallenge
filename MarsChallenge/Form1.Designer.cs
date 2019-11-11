namespace MarsChallenge
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RandomPole = new System.Windows.Forms.Button();
            this.CatStart = new System.Windows.Forms.Button();
            this.VampusStart = new System.Windows.Forms.Button();
            this.PrivedenieStart = new System.Windows.Forms.Button();
            this.TailClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 353);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // RandomPole
            // 
            this.RandomPole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RandomPole.Location = new System.Drawing.Point(12, 400);
            this.RandomPole.Name = "RandomPole";
            this.RandomPole.Size = new System.Drawing.Size(380, 23);
            this.RandomPole.TabIndex = 1;
            this.RandomPole.Text = "Перетасовать ловушки";
            this.RandomPole.UseVisualStyleBackColor = true;
            this.RandomPole.Click += new System.EventHandler(this.button1_Click);
            // 
            // CatStart
            // 
            this.CatStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CatStart.Location = new System.Drawing.Point(12, 462);
            this.CatStart.Name = "CatStart";
            this.CatStart.Size = new System.Drawing.Size(380, 23);
            this.CatStart.TabIndex = 2;
            this.CatStart.Text = "Запустить кошку";
            this.CatStart.UseVisualStyleBackColor = true;
            this.CatStart.Click += new System.EventHandler(this.CatStart_Click);
            // 
            // VampusStart
            // 
            this.VampusStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VampusStart.Location = new System.Drawing.Point(12, 491);
            this.VampusStart.Name = "VampusStart";
            this.VampusStart.Size = new System.Drawing.Size(380, 23);
            this.VampusStart.TabIndex = 3;
            this.VampusStart.Text = "Запустить вампуса";
            this.VampusStart.UseVisualStyleBackColor = true;
            this.VampusStart.Click += new System.EventHandler(this.VampusStart_Click);
            // 
            // PrivedenieStart
            // 
            this.PrivedenieStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrivedenieStart.Location = new System.Drawing.Point(12, 520);
            this.PrivedenieStart.Name = "PrivedenieStart";
            this.PrivedenieStart.Size = new System.Drawing.Size(380, 23);
            this.PrivedenieStart.TabIndex = 4;
            this.PrivedenieStart.Text = "Запустить приведение";
            this.PrivedenieStart.UseVisualStyleBackColor = true;
            this.PrivedenieStart.Click += new System.EventHandler(this.PrivedenieStart_Click);
            // 
            // TailClear
            // 
            this.TailClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TailClear.Location = new System.Drawing.Point(12, 371);
            this.TailClear.Name = "TailClear";
            this.TailClear.Size = new System.Drawing.Size(380, 23);
            this.TailClear.TabIndex = 5;
            this.TailClear.Text = "Стереть траектории";
            this.TailClear.UseVisualStyleBackColor = true;
            this.TailClear.Click += new System.EventHandler(this.TailClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 554);
            this.Controls.Add(this.TailClear);
            this.Controls.Add(this.PrivedenieStart);
            this.Controls.Add(this.VampusStart);
            this.Controls.Add(this.CatStart);
            this.Controls.Add(this.RandomPole);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Задание";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RandomPole;
        private System.Windows.Forms.Button CatStart;
        private System.Windows.Forms.Button VampusStart;
        private System.Windows.Forms.Button PrivedenieStart;
        private System.Windows.Forms.Button TailClear;
    }
}

