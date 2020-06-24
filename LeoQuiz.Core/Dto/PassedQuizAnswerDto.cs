﻿namespace LeoQuiz.Core.Dto
{
    public class PassedQuizAnswerDto : IDto<int>
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public bool IsCorrect { get; set; }

        public bool isChecked { get; set; }

        public int PassedQuestionId { get; set; }
    }
}
