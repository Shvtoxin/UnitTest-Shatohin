using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;
using AeroportShatohin.Classes;

namespace AeroportShatohin
{
    public partial class Aero : Form
    {
        private readonly List<Flight> flight;
        private readonly BindingSource bindingSource;
        private decimal sum = 0;
        public Aero()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            flight = new List<Flight>();
            bindingSource = new BindingSource();
            bindingSource.DataSource = flight;
            dataGridView1.DataSource = bindingSource;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ChangeMenu.Enabled = DeleteMenu.Enabled = Change.Enabled = Delete.Enabled = dataGridView1.SelectedRows.Count > 0;
        }
        public void CalculateStats()
        {
            var count = flight.Count;
            var Res = 0.0m;
            var Pass = 0.0m;
            var ColB = 0.0m;
            toolStripStatusLabel1.Text = $"���������� ������: " + count;
            foreach (var plane in flight)
            {
                Pass += plane.ColPas;
                ColB += plane.ColBuil;
                Res += (plane.ColPas * plane.Pass + plane.ColBuil * plane.Build) * ((100.0m + plane.Percent) / 100.0m);
            }
            toolStripStatusLabel2.Text = $"����� �����: " + Res;
            toolStripStatusLabel3.Text = $"���������� ����������: " + Pass;
            toolStripStatusLabel4.Text = $"���������� �������:" + ColB;
        }

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "���������")
            {
                var data = (Flight)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                sum += (data.ColPas * data.Pass + data.ColBuil * data.Build) * ((100.0m + data.Percent) / 100.0m);
                e.Value = sum;
                sum = 0;
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            var infoForm = new InfoAirFlightes();
            infoForm.Text = "���������� � �����";
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                flight.Add(infoForm.Flight);
                bindingSource.ResetBindings(false);
                CalculateStats();
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            var data = (Flight)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            var infoForm = new InfoAirFlightes(data);
            infoForm.Text = "���������� � �����";
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                data.numfl = infoForm.Flight.numfl;
                data.TypeAir = infoForm.Flight.TypeAir;
                data.ColPas = infoForm.Flight.ColPas;
                data.ColBuil = infoForm.Flight.ColBuil;
                data.Pass = infoForm.Flight.Pass;
                data.Build = infoForm.Flight.Build;
                data.Percent = infoForm.Flight.Percent;
                data.TimeIn = infoForm.Flight.TimeIn;

                bindingSource.ResetBindings(false);
                CalculateStats();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var data = (Flight)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"�� ������������� ������ ������� ����� ����� '{data.numfl}'?",
                "�������",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                flight.Remove(data);
                bindingSource.ResetBindings(false);
                CalculateStats();
            }
        }

        private void AddMenu_Click_1(object sender, EventArgs e)
        {
            Add_Click(sender, e);
        }

        private void ChangeMenu_Click(object sender, EventArgs e)
        {
            Change_Click(sender, e);
        }

        private void DeleteMenu_Click(object sender, EventArgs e)
        {
            Delete_Click(sender, e);
        }

        private void AboutProgrammMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������� ��", "Airport",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
