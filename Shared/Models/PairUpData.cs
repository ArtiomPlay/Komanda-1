﻿using Projektas.Shared.Enums;
using Projektas.Shared.Interfaces;

namespace Projektas.Shared.Models {
    public class PairUpData : IGame {
        public int TimeInSeconds {get; set;}
        public int Fails {get; set;}
        public DateTime Timestamp {get; set;}
        public GameDifficulty Difficulty {get; set;}
    }
}
