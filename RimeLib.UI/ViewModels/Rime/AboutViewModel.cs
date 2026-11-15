using Avalonia;
using Avalonia.Input.Platform;
using Avalonia.Platform.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RimeLib.UI.Models.Rime;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.UI.ViewModels.Rime
{
    public partial class AboutViewModel(ILauncher p_Launcher, IClipboard p_Clipboard) : ObservableObject
    {
        public string ProductName => Application.NameProperty.Name;

        public string WebsiteUrl => "https://modders.link/rime";
        public string GitHubUrl => "https://github.com/modderslink/rime";
        public string DiscordUrl => "https://discord.gg/69FKAf8";
        public string ReleaseNotesUrl => "https://github.com/ModdersLink/Rime/releases";
        public string CurrentVersion => $"{Assembly.GetEntryAssembly()?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion.Split('+')[0] ?? string.Empty}";

        /// <summary>
        /// Available update channels
        /// </summary>
        public IReadOnlyList<UpdateChannel> UpdateChannels => Enum.GetValues<UpdateChannel>();

        /// <summary>
        /// Current selected update channel
        /// </summary>
        [ObservableProperty]
        public partial UpdateChannel SelectedUpdateChannel { get; set; } = UpdateChannel.None;

        [ObservableProperty]
        public partial bool AutoCheckForUpdates { get; set; } = false;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(NewVersionText), nameof(UpdateButtonText))]
        [NotifyCanExecuteChangedFor(nameof(CheckForUpdatesCommand))]
        public partial string? NewVersion { get; set; }

        public string NewVersionText => IsUpToDate ? ":)" : NewVersion ?? "—";

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(UpdateButtonText))]
        [NotifyCanExecuteChangedFor(nameof(CheckForUpdatesCommand))]
        public partial bool IsUpToDate { get; set; } = true;

        public string UpdateButtonText => IsUpToDate ? "Up to date" : NewVersion is null ? "Check for updates" : $"Download {NewVersion}";

        private bool CanCheckForUpdates() => !IsUpToDate;

        [RelayCommand]
        private async Task OpenUrlAsync(string? p_Url)
        {
            if (!Uri.TryCreate(p_Url, UriKind.Absolute, out var s_Uri))
                return;

            await p_Launcher.LaunchUriAsync(s_Uri);
        }

        [RelayCommand(CanExecute = nameof(CanCheckForUpdates))]
        private async Task CheckForUpdatesAsync()
        {
            // TODO: Implement checking for updates
            await Task.CompletedTask;
        }

        partial void OnSelectedUpdateChannelChanged(UpdateChannel value)
        {
            // TODO: Persist the setting, then re-check for updates
        }

        [RelayCommand]
        private void ShowLicenses()
        {
            // TODO: open your licenses window/dialog.
        }

        [RelayCommand]
        private async Task CopyVersionAsync() => await p_Clipboard.SetTextAsync(CurrentVersion);
    }
}
