using System.Collections.Generic;
using Quiz.Core.Quiz;

namespace Quiz.DataAccess.Abstractions.Quiz
{
    public interface IQuizItemQuestionRepository
    {
        IEnumerable<QuizItemQuestion> GetAll();
        QuizItemQuestion Get(int id);
        IEnumerable<QuizItemQuestion> GetQuestionsForQuizItem(int quizItemId);
        int Add(QuizItemQuestion model);
        void Update(QuizItemQuestion model);
        void Delete(int id);
    }
}