# 안전교육 시험 웹앱 (Blazor WebAssembly / .NET 8)

## 실행
Visual Studio 2022에서 SafetyExamBlazor.csproj를 열어 실행하거나 .NET 8 SDK 설치 후 `dotnet run`.

## 기능
- BANK 문제은행 145문제, 정답과 기존 짧은 해설
- 랜덤 20문제, 이전/다음/번호별 이동, 체크
- 시험 채점, 정답·오답·미응답, 해설
- 체크/오답/합집합 재시험
- 전체 문제 학습, 정답 숨기기/보기
- PC/모바일 반응형

## 무료 배포 (GitHub Pages)
1. GitHub에서 새 공개 저장소 생성 (예: `safety-exam`).
2. 이 폴더의 **내용 전체**를 저장소 최상위에 업로드 후 main 브랜치에 커밋.
3. 저장소 Settings > Pages > Build and deployment > Source를 **GitHub Actions**로 설정.
4. Actions 탭에서 `Deploy Blazor to GitHub Pages` 작업이 성공하는지 확인.
5. `https://사용자명.github.io/safety-exam/` 접속.

GitHub Pages는 공개 사이트입니다. questions.json에 문제와 정답이 포함되어 브라우저에서 확인할 수 있습니다. 기밀 교육자료에는 사용하지 마세요.

## Cloudflare Pages 대안
`dotnet publish -c Release` 후 `bin/Release/net8.0/publish/wwwroot` 폴더의 **내용**을 Cloudflare Pages Direct Upload로 배포합니다. 정적 Blazor WASM만 가능하며 ASP.NET Core 서버 실행은 불필요합니다.

## 주의
- 브라우저 새로고침/종료 시 기록은 초기화됩니다.
- 해설은 이전 프로젝트에서 제공된 요약을 그대로 포함했으며, 모든 문항을 개별 검증한 것은 아닙니다.
- 현재 작업 환경에는 dotnet SDK가 없어 빌드 테스트는 수행하지 못했습니다.
