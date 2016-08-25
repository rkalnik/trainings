using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionReviewer
{
	
	public partial class Edit : Form
	{
		private QuizContainer dc = new QuizContainer();
		private QuestionCard currentQuestion;

		public Edit(int? questionCardId)
		{
			InitializeComponent();
					
			

			cbCategory.Items.AddRange(dc.Categories.Select(c => c.Name).ToArray());
			cbCategory.SelectedIndex = 0;

			if (questionCardId != null)
			{
				currentQuestion = dc.QuestionCards.SingleOrDefault(q => q.Id == questionCardId);

				tbQuestion.Text = currentQuestion.Question;
				tbAnswer1.Text = currentQuestion.Answer1;
				tbAnswer2.Text = currentQuestion.Answer2;
				tbAnswer3.Text = currentQuestion.Answer3;

				switch (currentQuestion.CorrectAnswer)
				{
					case 1:
						rb1.Checked = true;
						break;
					case 2:
						rb2.Checked = true;
						break;
					case 3:
						rb3.Checked = true;
						break;
				}

				cbCategory.SelectedItem = currentQuestion.Category.Name;
			}
			else
			{
				btnDelete.Enabled = false;
				currentQuestion = new QuestionCard();
				dc.QuestionCards.Add(currentQuestion);
			}
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			currentQuestion.Question = tbQuestion.Text;
			currentQuestion.Answer1 = tbAnswer1.Text;
			currentQuestion.Answer2 = tbAnswer2.Text;
			currentQuestion.Answer3 = tbAnswer3.Text;

			currentQuestion.CorrectAnswer = Convert.ToInt32(this.Controls.OfType<RadioButton>().First(r => r.Checked = true).Tag);

			currentQuestion.Category = dc.Categories.Single(c => c.Name ==cbCategory.SelectedItem);

			dc.SaveChanges();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			dc.QuestionCards.Remove(currentQuestion);
			dc.SaveChanges();
		}
	}
}
