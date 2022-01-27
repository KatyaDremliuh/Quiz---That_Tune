using System;
using System.Collections.Generic;
using System.IO;

namespace Quiz_That_Tune
{
  static  class Quiz
  {
       public static List<string> TrackList = new List<string>();

       public static int GameDuration = 60; // продолжительность игры
       public static int MusicDuration = 10; // сколько звучит песня
       public static bool RandomStart = false; // начинать песню с начала или со случайного места
       public static string TheLastFolder = string.Empty; // папка, которую задаем при выборе музыки
       public static bool AllDirectories = false; // обрабатывать ли внутрненние директории

       public static void ReadMusic()
       {
           string[] musicFiles =
               Directory.GetFiles(TheLastFolder, "*.mp3", 
                   AllDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

           TrackList.Clear();
           TrackList.AddRange(musicFiles);
       }
  }
}
