using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_Console_app.Models;

public class PlayList
{
    public int _id;
    public string playlistName;
    public static List<Song> _songs = new List<Song>();
}
