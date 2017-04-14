using System.Collections.Generic;
using Quiz.Core.Quiz;

namespace Quiz.DataAccess.Quiz
{
    public interface IQuizItemQuestionAnswerRepository
    {
        IEnumerable<QuizItemQuestionAnswer> GetAll();
        QuizItemQuestionAnswer Get(int id);
        IEnumerable<QuizItemQuestionAnswer> GetQuestionAnswersForQuizItemQuestion(int quizItemQuestionId);
        void Delete(int id);
        void Add(QuizItemQuestionAnswer model);
    }
}