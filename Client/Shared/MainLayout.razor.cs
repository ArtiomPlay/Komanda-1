﻿using Projektas.Client.Services;

namespace Projektas.Client.Shared {
	public partial class MainLayout {
		public string? username = null;

		protected override async Task OnInitializedAsync() {
			AuthStateProvider.AuthenticationStateChanged += OnAuthenticationStateChangedAsync;

			await LoadUsernameAsync();
		}

		private async Task LoadUsernameAsync() {
			username = await ((AccountAuthStateProvider)AuthStateProvider).GetUsernameAsync();
			StateHasChanged();
		}

		private async void OnAuthenticationStateChangedAsync(Task<AuthenticationState> task) {
			await InvokeAsync(LoadUsernameAsync);
			StateHasChanged();
		}

		public void Dispose() {
			AuthStateProvider.AuthenticationStateChanged -= OnAuthenticationStateChangedAsync;
		}
	}
}
