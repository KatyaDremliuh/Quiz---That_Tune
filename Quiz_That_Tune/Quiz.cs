using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;

namespace Quiz_That_Tune
{
    static class Quiz
    {
        public static List<string> TrackList = new List<string>();

        public static int GameDuration = 60; // продолжительность игры
        public static int MusicDuration = 10; // сколько звучит песня
        public static bool RandomStart = false; // начинать песню с начала или со случайного места
        public static string LastFolder = string.Empty; // папка, которую задаем при выборе музыки
        public static bool AllDirectories = false; // обрабатывать ли внутрненние директории

        public static void ReadMusic()
        {
            string[] musicFiles =
                Directory.GetFiles(LastFolder, "*.mp3",
                    AllDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

            TrackList.Clear();
            TrackList.AddRange(musicFiles);
        }

        static string regKeyName = "SOFTWARE\\MyMusicProject\\ThatTune"; // ключ в реестре

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
                registryKey.SetValue("RandomStart", RandomStart);
                registryKey.SetValue("GameDuration", GameDuration);
                registryKey.SetValue("MusicDuration", MusicDuration);
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

        public static void ReadParams()
        {
            RegistryKey registryKey = null;

            try
            {
                registryKey =
                    Registry.CurrentUser.OpenSubKey(regKeyName);

                if (registryKey != null)
                {
                    LastFolder = (string)registryKey.GetValue("LastFolder", LastFolder);
                    RandomStart = Convert.ToBoolean(registryKey.GetValue("Random", false));
                    GameDuration = (int)registryKey.GetValue("GameDuration", GameDuration);
                    MusicDuration = (int)registryKey.GetValue("MusicDuration", MusicDuration);
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
