﻿using Projektas.Shared.Enums;
using Projektas.Shared.Models;

namespace Projektas.Client.Interfaces {
    public interface IAimTrainerService {
        public Task SaveScoreAsync(string username, int score, GameDifficulty difficulty);
        public Task<UserScoreDto<AimTrainerData>> GetUserHighscoreAsync(string username);
        public Task<List<UserScoreDto<AimTrainerData>>> GetTopScoresAsync(int topCount);
    }
}