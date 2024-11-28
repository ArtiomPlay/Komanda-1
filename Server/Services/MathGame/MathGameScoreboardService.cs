﻿using Projektas.Shared.Models;
using Projektas.Server.Interfaces.MathGame;

namespace Projektas.Server.Services.MathGame {
    public class MathGameScoreboardService : IComparer<int>, IMathGameScoreboardService {
        private readonly IScoreRepository<MathGameM> _scoreRepository;

        public MathGameScoreboardService(IScoreRepository<MathGameM> scoreRepository) {
            _scoreRepository = scoreRepository;
        }

        public async Task AddScoreToDb(UserScoreDto data) {
            await _scoreRepository.AddScoreToUserAsync(data.Username,data.Score, null);
        }

        public async Task<int?> GetUserHighscore(string username) {
            return await _scoreRepository.GetHighscoreFromUserAsync(username);
        }

        public async Task<List<UserScoreDto>> GetTopScores(int topCount) {
            List<UserScoreDto> userScores=await _scoreRepository.GetAllScoresAsync();
            List<UserScoreDto> topScores = userScores
            .OrderByDescending(score => score.Score)
            .Take(topCount)
            .ToList();

            return topScores;
        }

        public int Compare(int a,int b) {
            return b.CompareTo(a);
        }
    }
}
