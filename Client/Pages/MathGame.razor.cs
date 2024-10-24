﻿namespace Projektas.Client.Pages
{
    using Projektas.Client.Services;
    using Projektas.Shared.Models;

    public partial class MathGame
    {
        private string? question = null;
        private bool isTimesUp = false;
        private List<int>? options;
        private GameState gameState;
        private bool? isCorrect = null;
        private List<int>? topScores;

        protected override async void OnInitialized()
        {
            TimerService.OnTick += OnTimerTick;
            gameState = await GameStateService.GetGameState();
        }


        private async Task StartGame()
        {
            TimerService.Start(60);
            isTimesUp = false;
            gameState.Score = 0;
            await GenerateQuestion();
            await GameStateService.UpdateGameState(gameState);
        }

        private async Task GenerateQuestion()
        {
            isCorrect = null;
            question = await MathGameService.GetQuestionAsync(gameState.Score);
            options = await MathGameService.GetOptionsAsync();
        }

        private async Task CheckAnswer(int option)
        {
            if (question != null)
            {
                isCorrect = await MathGameService.CheckAnswerAsync(option);
                if (isCorrect == false)
                {
                    if (TimerService.RemainingTime > 5)
                    {
                        TimerService.RemainingTime = TimerService.RemainingTime - 5;
                    }
                    else
                    {
                        TimerService.RemainingTime = 0;
                        OnTimerTick();
                        return;
                    }
                }
                else
                {
                    await GameStateService.IncrementScore(gameState);
                }
                await GenerateQuestion();
                StateHasChanged();
            }
        }

        private async void OnTimerTick()
        {
            await InvokeAsync(async () =>
            {
                if (TimerService.RemainingTime == 0)
                {
                    isTimesUp = true;
                    TimerService.Stop();
                    await DataService.SaveDataAsync(gameState.Score);
                    List<int> loadedData = await DataService.LoadDataAsync();
                    topScores = await ScoreboardService.GetTopScoresAsync(loadedData,topCount:5);
                }
                StateHasChanged();
            });
        }

        public void Dispose()
        {
            TimerService.OnTick -= OnTimerTick;
        }
    }
}
