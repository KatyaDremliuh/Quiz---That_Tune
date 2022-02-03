using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;

namespace Quiz_That_Tune
{
    public static class Quiz
    {
        public static List<string> TrackList = new List<string>(); // список песен
        public static int GameDuration { get; set; } // продолжительность игры
        public static int MusicDuration { get; set; } // сколько звучит песня
        public static bool RandomStart = false; // начинать песню с начала или со случайного места
        public static string LastFolder = string.Empty; // папка, которую задаем при выборе музыки
        public static bool AllDirectories = false; // обрабатывать ли внутрненние директории
        public static string CorrectAnswer = string.Empty;

        /// <summary>
        /// Allows to read and to save music to the TrackList.
        /// </summary>
        public static void ReadMusic()
        {
            try
            {
                string[] musicFiles =
                          Directory.GetFiles(LastFolder, "*.mp3",
                              AllDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                TrackList.Clear();
                TrackList.AddRange(musicFiles);
            }
            catch
            {
                // ignored
            }
        }

        private static string regKeyName = "SOFTWARE\\MyMusicProject\\ThatTune"; // ключ в реестре

        /// <summary>
        /// Allows to work with the registry. To write data to the registry.
        /// </summary>
        public static void WriteParams()
        {
            RegistryKey registryKey = null;

            try
            {
                registryKey =
                    Registry.CurrentUser.CreateSubKey(regKeyName); // создаем новый вложенный раздел или открываем существующий
                                                                   // вложенный раздел

                if (registryKey == null) // если не получилось открыть
                {
                    return;
                }

                // если все получилось
                registryKey.SetValue("LastFolder", LastFolder);
                registryKey.SetValue("GameDuration", GameDuration);
                registryKey.SetValue("MusicDuration", MusicDuration);
                registryKey.SetValue("RandomStart", RandomStart);
                registryKey.SetValue("AllDirectories", AllDirectories);
            }
            finally // если реестр (regedit) создался, то закрываем ключ
            {
                if (registryKey != null)
                {
                    registryKey.Close();
                }
            }
        }

        /// <summary>
        /// Allows to work with the registry. To reat data from the registry.
        /// </summary>
        public static void ReadParams()
        {
            RegistryKey registryKey = null;

            try
            {
                registryKey =
                    Registry.CurrentUser.OpenSubKey(regKeyName);

                if (registryKey != null)
                {
                    LastFolder = Convert.ToString(registryKey.GetValue("LastFolder"));
                    GameDuration = Convert.ToInt32(registryKey.GetValue("GameDuration"));
                    MusicDuration = Convert.ToInt32(registryKey.GetValue("MusicDuration"));
                    RandomStart = Convert.ToBoolean(registryKey.GetValue("RandomStart", false));
                    AllDirectories = Convert.ToBoolean(registryKey.GetValue("AllDirectories", false));
                }
            }
            finally
            {
                if (registryKey != null)
                {
                    registryKey.Close();
                }
            }
        }
    }
}
