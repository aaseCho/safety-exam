namespace SafetyExamBlazor.Models;

/// <summary>엑셀 BANK 시트에서 추출한 객관식 문제입니다. Answer는 0부터 시작합니다.</summary>
public sealed class Question
{
    public int Id { get; set; }
    public string Text { get; set; } = "";
    public List<string> Options { get; set; } = new();
    public int Answer { get; set; }
    public string Explanation { get; set; } = "";
    public string SourceUrl { get; set; } = "";
}

/// <summary>시험 응시 중 선택한 답과 복습 체크 상태를 저장합니다.</summary>
public sealed class QuestionAttempt
{
    public Question Question { get; set; } = new();
    public int? Selected { get; set; }
    public bool Marked { get; set; }
    public bool IsWrong => Selected != Question.Answer;
}
