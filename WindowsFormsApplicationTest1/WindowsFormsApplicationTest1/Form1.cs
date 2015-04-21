using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationTest1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//  tworzenie nowej instancji klasy
			Random RandomObj = new Random();
			// pobieranie rozmiarow formularza
			Point StartPoint = new Point(this.Size);

			// wylosowanie nowej pozycji
			int X = RandomObj.Next(1, StartPoint.X - 75);
			int Y = RandomObj.Next(1, StartPoint.X - 23);

			this.button1.Location = new Point(X, Y);

			// wyswietlenie komunikatu po kliknieciu buttona
			// MessageBox.Show("Hello World");
		}

		private void button1_Move(object sender, EventArgs e)
		{
			this.Text = String.Format("Aktualna pozycja: {0} - {1}", this.button1.Location.X, this.button1.Location.Y);
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
