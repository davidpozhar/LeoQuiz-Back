﻿namespace LeoQuiz.Core.Dto
{
    public class PassedQuizAnswerFullDto : IDto<int>
    {
        public int Id { get; set; }

        public int PassedQuizId { get; set; }

        public int AnswerId { get; set; }

        public AnswerDto Answer { get; set; }
    }
}
