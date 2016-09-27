using System.Data.Entity.ModelConfiguration;
using DataLayer.Models;

namespace DataLayer.Configurations
{
	public class AnswerConfiguration:EntityTypeConfiguration<Answer>
	{
		public AnswerConfiguration()
		{
			this.HasKey(a => a.AnswerId);
			this.Property(a => a.AnswerText).HasMaxLength(200).IsRequired().HasColumnName("AnswerNewColumnName");
			this.HasOptional(p => p.Question).
				WithMany(q => q.Answers).
				HasForeignKey(a => a.QuestionId).
				WillCascadeOnDelete();
		}

	}
}
