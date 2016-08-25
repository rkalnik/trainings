using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionReviewer
{
	public partial class Form1 : Form
	{
		QuizContainer dc = new QuizContainer();

		public Form1()
		{
			

			InitializeComponent();

			UpdateDgvQuestionCard();

			UpdateDgvCategories();

			dgvQuestion.DataSource = dc.QuestionCards.Select(q => new
			{
				Id = q.Id,
				Question = q.Question,
				Category = q.Category.Name
			}).ToArray();

			//dgvQuestion.DataSource = dc.QuestionCards.Select( new { q => Q})

			//dc.QuestionCards.Load();

			//dgvQuestionCard.DataSource = dc.QuestionCards.Local.ToBindingList();
			//dc.QuestionCards.Add(new QuestionCard() { Question ="Tests dasd", Answer1 ="a", Answer2 = "b", Answer3 = "c", CorrectAnswer=1 });

			//Zapisanie powyzszego rekordu do bazy, zawsze bedzie inkremenortwany nowy rekord 
			//dc.SaveChanges();

			//dgvQuestionCard.DataSource = dc.QuestionCards.Local.ToBindingList();
			//dgvQuestionCard.DataSource = dc.QuestionCards.ToList();
			//dgvQuestionCard.DataSource = dc.QuestionCards.Select( q => new { id - q.Id, question - q.Question, category - q.Category.Name }).To
		}

		

		private void dgvQuestion_DoubleClick(object sender, EventArgs e)
		{
			int id = (int)dgvQuestion.SelectedRows[0].Cells[0].Value;

			if (new Edit(id).ShowDialog() == System.Windows.Forms.DialogResult.OK);
			{
				UpdateDgvQuestionCard();
			}
		}

		private void UpdateDgvQuestionCard()
		{
			dgvQuestion.DataSource = dc.QuestionCards.Select(q => new
			{
				Id = q.Id,
				Question = q.Question,
				Category = q.Category.Name
			}).ToArray();
		}

		private void UpdateDgvCategories()
		{
			dgvCategories.DataSource = dc.Categories.Select(c => new { Id = c.Id, Name = c.Name }).ToArray();
		}

		//UZUPELNIC i zrobic add

		private void addQuestionCardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (new Edit(null).ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				UpdateDgvQuestionCard();
			}

			//dgvCategories.DataSource = dc.Categories.Add();
		}



		//private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		//{
		//	dc.SaveChanges();
		//}


	}
}
