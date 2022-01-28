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
