namespace DEMOekz
{
    partial class Sponsorship_confirmation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.runnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEMODataSet1 = new DEMOekz.DEMODataSet();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dEMODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEMODataSet = new DEMOekz.DEMODataSet();
            this.runnerTableAdapter = new DEMOekz.DEMODataSetTableAdapters.RunnerTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dEMODataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.runnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMODataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // runnerBindingSource
            // 
            this.runnerBindingSource.DataMember = "Runner";
            this.runnerBindingSource.DataSource = this.dEMODataSet1;
            // 
            // dEMODataSet1
            // 
            this.dEMODataSet1.DataSetName = "DEMODataSet";
            this.dEMODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label15.Location = new System.Drawing.Point(541, 416);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 58);
            this.label15.TabIndex = 112;
            this.label15.Text = "$50";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label14.Location = new System.Drawing.Point(499, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 31);
            this.label14.TabIndex = 111;
            this.label14.Text = "Фонд кошек";
            // 
            // dEMODataSetBindingSource
            // 
            this.dEMODataSetBindingSource.DataSource = this.dEMODataSet;
            this.dEMODataSetBindingSource.Position = 0;
            // 
            // dEMODataSet
            // 
            this.dEMODataSet.DataSetName = "DEMODataSet";
            this.dEMODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // runnerTableAdapter
            // 
            this.runnerTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 42);
            this.button2.TabIndex = 98;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(284, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(654, 50);
            this.label3.TabIndex = 95;
            this.label3.Text = "             Спасибо за поддержку бегуна в Marathon Skills 2016!\r\nВаше пожертвова" +
    "ние пойдет в его благотворительную организацию\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(327, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(557, 31);
            this.label2.TabIndex = 94;
            this.label2.Text = "Спасибо за вашу спонсорскую поддержку!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 93;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 39);
            this.label1.TabIndex = 92;
            this.label1.Text = "MARATHON SKILLS 2017";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1185, 89);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(328, 714);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(570, 29);
            this.label4.TabIndex = 89;
            this.label4.Text = "18 дней 8 часов и 17 минут до старта марафона!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 704);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1185, 50);
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            // 
            // dEMODataSet1BindingSource
            // 
            this.dEMODataSet1BindingSource.DataSource = this.dEMODataSet1;
            this.dEMODataSet1BindingSource.Position = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(463, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 25);
            this.label5.TabIndex = 113;
            this.label5.Text = "Иван Прудов(204) из Russia \r\n";
            // 
            // Sponsorship_confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Sponsorship_confirmation";
            this.Text = "Marathon skills 2017 - Sponsorship confirmation";
            this.Load += new System.EventHandler(this.Sponsorship_confirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.runnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEMODataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource runnerBindingSource;
        private DEMODataSet dEMODataSet1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource dEMODataSetBindingSource;
        private DEMODataSet dEMODataSet;
        private DEMODataSetTableAdapters.RunnerTableAdapter runnerTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource dEMODataSet1BindingSource;
        private System.Windows.Forms.Label label5;
    }
}