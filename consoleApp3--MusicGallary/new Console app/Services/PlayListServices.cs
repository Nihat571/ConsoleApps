using new_Console_app.Exceptions;
using new_Console_app.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_Console_app.Services;

public class PlayListServices
{
    List<PlayList> _playLists = new List<PlayList>();
    public int _counter = 1;

    #region CREATE
    public void AddPlayList(PlayList playList)
    {
        playList._id = _counter++;
        _playLists.Add(playList);
    }
    #endregion
    #region READ
    public List<PlayList> GetAllPlayLists()
    {
        return _playLists;
    }
    #endregion
    #region UPDATE
    public PlayList UpdatePlayList(int id, PlayList updatedPlaylist)
    {
        foreach (var item in _playLists)
        {
            if (item._id == id)
            {
                item.playlistName = updatedPlaylist.playlistName;
                return item;
            }
        }
        throw new MyExceptions($"{id} nomreli playlist tapilmadi");
    }

#endregion
    #region DELETE
public void DeletePlaylist(int id)
    {
        foreach (var item in _playLists)
        {
            if (item._id == id)
            {
                _playLists.Remove(item);
                return;
            }
        }
        throw new MyExceptions($"{id} nomreli playlist tapilmadi");
    }
    #endregion

}

