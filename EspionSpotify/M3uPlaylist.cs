using System.IO;
using EspionSpotify.Properties;
namespace EspionSpotify { internal static class M3uPlaylist { public static void Append(string path) { if (Settings.Default.settings_playlist_generation_enabled) File.AppendAllText(Path.Combine(Settings.Default.settings_playlist_output_path, Settings.Default.settings_playlist_filename), path + System.Environment.NewLine); } } }
