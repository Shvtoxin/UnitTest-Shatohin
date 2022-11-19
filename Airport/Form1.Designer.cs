using System.Windows.Forms;

namespace AeroportShatohin
{
    partial class Aero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aero));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Файл = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgrammMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add = new System.Windows.Forms.ToolStripButton();
            this.Change = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Delete = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Файл,
            this.toolStripMenuItem2,
            this.Tools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1391, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Файл
            // 
            this.Файл.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.Файл.Name = "Файл";
            this.Файл.Size = new System.Drawing.Size(59, 34);
            this.Файл.Text = "Файл";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(136, 26);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenu,
            this.ChangeMenu,
            this.toolStripSeparator1,
            this.DeleteMenu});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(74, 34);
            this.toolStripMenuItem2.Text = "Правка";
            // 
            // AddMenu
            // 
            this.AddMenu.Name = "AddMenu";
            this.AddMenu.Size = new System.Drawing.Size(161, 26);
            this.AddMenu.Text = "Добавить";
            this.AddMenu.Click += new System.EventHandler(this.AddMenu_Click_1);
            // 
            // ChangeMenu
            // 
            this.ChangeMenu.Enabled = false;
            this.ChangeMenu.Name = "ChangeMenu";
            this.ChangeMenu.Size = new System.Drawing.Size(161, 26);
            this.ChangeMenu.Text = "Изменить";
            this.ChangeMenu.Click += new System.EventHandler(this.ChangeMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // DeleteMenu
            // 
            this.DeleteMenu.Enabled = false;
            this.DeleteMenu.Name = "DeleteMenu";
            this.DeleteMenu.Size = new System.Drawing.Size(161, 26);
            this.DeleteMenu.Text = "Удалить";
            this.DeleteMenu.Click += new System.EventHandler(this.DeleteMenu_Click);
            // 
            // Tools
            // 
            this.Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgrammMenu});
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(81, 34);
            this.Tools.Text = "Справка";
            // 
            // AboutProgrammMenu
            // 
            this.AboutProgrammMenu.Name = "AboutProgrammMenu";
            this.AboutProgrammMenu.Size = new System.Drawing.Size(187, 26);
            this.AboutProgrammMenu.Text = "О программе";
            this.AboutProgrammMenu.Click += new System.EventHandler(this.AboutProgrammMenu_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add,
            this.Change,
            this.toolStripSeparator2,
            this.Delete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 48);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1391, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "Кол-во рейсов: 0";
            // 
            // Add
            // 
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 36);
            this.Add.Text = "Добавить";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Change
            // 
            this.Change.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Change.Enabled = false;
            this.Change.Image = ((System.Drawing.Image)(resources.GetObject("Change.Image")));
            this.Change.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(82, 36);
            this.Change.Text = "Изменить";
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // Delete
            // 
            this.Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Delete.Enabled = false;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(69, 36);
            this.Delete.Text = "Удалить";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1113, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(127, 20);
            this.toolStripStatusLabel1.Text = "Кол-во рейсов: 0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(162, 20);
            this.toolStripStatusLabel2.Text = "Кол-во пассажиров: 0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(136, 20);
            this.toolStripStatusLabel3.Text = "Кол-во экипажа: 0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(169, 20);
            this.toolStripStatusLabel4.Text = "Сумма всей выручки: 0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nu,
            this.Type,
            this.Time,
            this.Col,
            this.Pas,
            this.Cob,
            this.Buil,
            this.Perc});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1391, 485);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting_1);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // nu
            // 
            this.nu.DataPropertyName = "numfl";
            this.nu.HeaderText = "Номер рейса";
            this.nu.MinimumWidth = 6;
            this.nu.Name = "nu";
            this.nu.ReadOnly = true;
            this.nu.Width = 125;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "TypeAir";
            this.Type.HeaderText = "Тип самолёта";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "TimeIn";
            this.Time.HeaderText = "Время прибытия";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 125;
            // 
            // Col
            // 
            this.Col.DataPropertyName = "ColPas";
            this.Col.HeaderText = "Количество пассажиров";
            this.Col.MinimumWidth = 6;
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            this.Col.Width = 125;
            // 
            // Pas
            // 
            this.Pas.DataPropertyName = "Pass";
            this.Pas.HeaderText = "Сбор на пассажира";
            this.Pas.MinimumWidth = 6;
            this.Pas.Name = "Pas";
            this.Pas.ReadOnly = true;
            this.Pas.Width = 125;
            // 
            // Cob
            // 
            this.Cob.DataPropertyName = "ColBuil";
            this.Cob.HeaderText = "Количество экипажа";
            this.Cob.MinimumWidth = 6;
            this.Cob.Name = "Cob";
            this.Cob.ReadOnly = true;
            this.Cob.Width = 125;
            // 
            // Buil
            // 
            this.Buil.DataPropertyName = "Build";
            this.Buil.HeaderText = "Сбор на экипаж";
            this.Buil.MinimumWidth = 6;
            this.Buil.Name = "Buil";
            this.Buil.ReadOnly = true;
            this.Buil.Width = 125;
            // 
            // Perc
            // 
            this.Perc.DataPropertyName = "Percent";
            this.Perc.HeaderText = "Процент надбавки за обслуживание";
            this.Perc.MinimumWidth = 6;
            this.Perc.Name = "Perc";
            this.Perc.ReadOnly = true;
            this.Perc.Width = 125;
            // 
            // Aero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Aero";
            this.Text = "Аэропорт";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Файл;
        private ToolStripMenuItem Exit;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem AddMenu;
        private ToolStripMenuItem ChangeMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem DeleteMenu;
        private ToolStripMenuItem Tools;
        private ToolStripMenuItem AboutProgrammMenu;
        private ToolStrip toolStrip1;
        private ToolStripButton Add;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton Delete;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private DataGridView dataGridView1;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripButton Change;
        private DataGridViewTextBoxColumn nu;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Col;
        private DataGridViewTextBoxColumn Pas;
        private DataGridViewTextBoxColumn Cob;
        private DataGridViewTextBoxColumn Buil;
        private DataGridViewTextBoxColumn Perc;
    }
}