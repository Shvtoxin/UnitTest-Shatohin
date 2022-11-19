using System.Windows.Forms;

namespace AeroportShatohin
{
    partial class InfoAirFlightes
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
            this.umberFligthes = new System.Windows.Forms.Label();
            this.TypeAir = new System.Windows.Forms.Label();
            this.ColPass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumberFligth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // umberFligthes
            // 
            this.umberFligthes.AutoSize = true;
            this.umberFligthes.Location = new System.Drawing.Point(29, 16);
            this.umberFligthes.Name = "umberFligthes";
            this.umberFligthes.Size = new System.Drawing.Size(92, 16);
            this.umberFligthes.TabIndex = 0;
            this.umberFligthes.Text = "Номер рейса";
            // 
            // TypeAir
            // 
            this.TypeAir.AutoSize = true;
            this.TypeAir.Location = new System.Drawing.Point(29, 62);
            this.TypeAir.Name = "TypeAir";
            this.TypeAir.Size = new System.Drawing.Size(100, 16);
            this.TypeAir.TabIndex = 2;
            this.TypeAir.Text = "Тип Самолёта";
            // 
            // ColPass
            // 
            this.ColPass.AutoSize = true;
            this.ColPass.Location = new System.Drawing.Point(29, 113);
            this.ColPass.Name = "ColPass";
            this.ColPass.Size = new System.Drawing.Size(167, 16);
            this.ColPass.TabIndex = 4;
            this.ColPass.Text = "Количество пассажиров";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Сбор на экипаж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Сбор на пассажира";
            // 
            // NumberFligth
            // 
            this.NumberFligth.AutoSize = true;
            this.NumberFligth.Location = new System.Drawing.Point(29, 165);
            this.NumberFligth.Name = "NumberFligth";
            this.NumberFligth.Size = new System.Drawing.Size(144, 16);
            this.NumberFligth.TabIndex = 6;
            this.NumberFligth.Text = "Количество экипажа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Время прибытия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Процент надбавки за обслуживание";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 366);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // SaveChanges
            // 
            this.SaveChanges.BackColor = System.Drawing.SystemColors.Window;
            this.SaveChanges.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveChanges.Enabled = false;
            this.SaveChanges.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.SaveChanges.Location = new System.Drawing.Point(35, 23);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(155, 43);
            this.SaveChanges.TabIndex = 16;
            this.SaveChanges.Text = "Сохранить";
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.SystemColors.Window;
            this.Cancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.Cancel.Location = new System.Drawing.Point(234, 23);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(155, 43);
            this.Cancel.TabIndex = 17;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.SaveChanges);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Location = new System.Drawing.Point(1, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 91);
            this.panel1.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(131, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 24);
            this.comboBox1.TabIndex = 33;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(131, 16);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(278, 22);
            this.numericUpDown1.TabIndex = 27;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(198, 111);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(211, 22);
            this.numericUpDown2.TabIndex = 28;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(181, 163);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(229, 22);
            this.numericUpDown3.TabIndex = 29;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(167, 213);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(242, 22);
            this.numericUpDown4.TabIndex = 30;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(145, 265);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(264, 22);
            this.numericUpDown5.TabIndex = 31;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(272, 315);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(137, 22);
            this.numericUpDown6.TabIndex = 32;
            // 
            // InfoAirFlightes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 532);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberFligth);
            this.Controls.Add(this.ColPass);
            this.Controls.Add(this.TypeAir);
            this.Controls.Add(this.umberFligthes);
            this.Name = "InfoAirFlightes";
            this.Text = "Информация о рейсе";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label umberFligthes;
        private Label TypeAir;
        private Label ColPass;
        private Label label3;
        private Label label4;
        private Label NumberFligth;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Button SaveChanges;
        private Button Cancel;
        private Panel panel1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
    }
}
