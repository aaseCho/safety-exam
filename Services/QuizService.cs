using System.Net.Http.Json;
using SafetyExamBlazor.Models;

namespace SafetyExamBlazor.Services;

/// <summary>문제은행을 읽고 무작위 시험을 구성하는 서비스입니다.</summary>
public sealed class QuizService
{
    private readonly HttpClient _http;
    private List<Question>? _questions;

    public QuizService(HttpClient http) => _http = http;

    /// <summary>웹 서버의 정적 JSON 문제은행을 최초 한 번 읽습니다.</summary>
    public async Task<IReadOnlyList<Question>> LoadAsync()
    {
        _questions ??= await _http.GetFromJsonAsync<List<Question>>("questions.json") ?? new();
        return _questions;
    }

    /// <summary>후보 문제를 섞고 지정한 개수만큼 새 시험을 만듭니다.</summary>
    public static List<QuestionAttempt> Create(IEnumerable<Question> source, int count = 20)
    {
        return source.OrderBy(_ => Random.Shared.Next()).Take(count)
            .Select(q => new QuestionAttempt { Question = q }).ToList();
    }
}
