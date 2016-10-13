using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemZarzadzaniaUlem
{
	public partial class Form1 : Form
	{
		private Queen queen;
		public Form1()
		{
			InitializeComponent();

			workerBeeJobCB.SelectedIndex = 0;
			Worker[] workers = new Worker[4];
			workers[0] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu" },175);
			workers[1] = new Worker(new string[] { "Pielęgnacja jaj", "Nauczanie pszczółek" }, 114);
			workers[2] = new Worker(new string[] { "Utrzymanie ula", "Patrol z żądłami" }, 149);
			workers[3] = new Worker(new string[] { "Zbieranie nektaru", "Wytwarzanie miodu", "Pielęgnacja jaj", "Nauczanie pszczółek", "Utrzymanie ula", "Patrol z żądłami" }, 155);

			queen = new Queen(workers, 275);
		}

		private void assignJobBt_Click(object sender, EventArgs e)
		{
			if (queen.AssignWork(workerBeeJobCB.Text, (int)shifts.Value) == false)
				MessageBox.Show("Nie ma dostępnych robotnic do wykonania zadania '" + workerBeeJobCB.Text + "'", "Królowa pszczół mówi...");
			else
				MessageBox.Show("Zadanie '" + workerBeeJobCB.Text + "' będzie ukończone za " + shifts.Value + " zmiany", "Królowa pszczół mówi...");
		}

		private void nextShiftBt_Click(object sender, EventArgs e)
		{
			reportTb.Text = queen.WorkTheNextShift();
		}
	}
}
