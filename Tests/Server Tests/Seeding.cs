﻿using Projektas.Server.Database;
using Projektas.Shared.Models;

namespace Projektas.Tests.Server_Tests {
	public class Seeding {
		public static void InitializeTestDB(UserDbContext db) {
			db.Database.EnsureDeleted();
			db.Database.EnsureCreated();

			db.Users.RemoveRange(db.Users);
			db.SaveChanges();

			var users = GetUsers();
			db.Users.AddRange(users);
			db.SaveChanges();

			var mathGameScores = GetMathGameScores(users);
			db.MathGameScores.AddRange(mathGameScores);
			db.SaveChanges();
		}

		private static List<User> GetUsers() {
			return new List<User>() {
				new User() {Id = 1, Name = "John", Surname = "Doe", Username = "johndoe", Password = "password123"},
				new User() {Id = 2, Name = "Jane", Surname = "Doe", Username = "janedoe", Password = "password456"},
				new User() {Id = 3, Name = "Jake", Surname = "Doe", Username = "jakedoe", Password = "password789"}
			};

		}

		private static List<Score<MathGameData>> GetMathGameScores(List<User> users) {
			return new List<Score<MathGameData>>() {
				new Score<MathGameData>() {Id=1,UserId=users[0].Id,GameData=new MathGameData{Scores=12},User=users[0]},
				new Score<MathGameData>() {Id=2,UserId=users[1].Id,GameData=new MathGameData{Scores=15},User=users[1]},
				new Score<MathGameData>() {Id=3,UserId=users[2].Id,GameData=new MathGameData{Scores=20},User=users[2]}
			};
		}
	}
}
