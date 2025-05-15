using new_Console_app.Exceptions;
using new_Console_app.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_Console_app.Services;

public class SongServices
{
    private static int _counter = 1;

    #region CREATE
    public void AddSong(Song song)
    {
        song.Id = _counter++;
        PlayList._songs.Add(song);
    }
    #endregion

    #region READ
    public List<Song> GetAllSongs()
    { 
        return PlayList._songs;
    }
    #endregion

    #region UPDATE
    public Song GetSongById(int id)
    {
        foreach (Song item in PlayList._songs)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        throw new MyExceptions($"{id} nomreli mahni tapilmadi");
    }
    public static void UpdateSong(int id,Song updatedSong)
    {
        foreach (Song item in PlayList._songs)
        {
            if (item.Id == id)
            {
                item.songName = updatedSong.songName;
                item.Duration = updatedSong.Duration;
                return;
            }
        }
        throw new MyExceptions($"{id} nomreli mahni tapilmadi");
    }
    #endregion

    #region DELETE
    public Song DeleteSong(int id)
    {
        foreach (var item in PlayList._songs)
        {
            if (item.Id == id)
            {
                PlayList._songs.Remove(item);
             return item;
            }
        }
        throw new MyExceptions($"{id} nomreli Mahni tapilmadi");
    }
    #endregion
}
