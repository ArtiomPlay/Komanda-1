﻿using Projektas.Client.Services;

namespace Projektas.Client.Shared {
	public partial class MainLayout {
		public string? username = null;
		private bool isSidebarCollapsed = false;
		private string? SidebarCssClass => isSidebarCollapsed ? "collapsed" : "";

		private void ToggleSidebar() {
			isSidebarCollapsed = !isSidebarCollapsed;
		}

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
