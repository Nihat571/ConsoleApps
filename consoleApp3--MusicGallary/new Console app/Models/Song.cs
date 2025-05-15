using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static new_Console_app.Enums.SongGenre;

namespace new_Console_app.Models;

public class Song
{
    public int Id;
    public string songName;
    public double Duration;
    public GenreEnum Genre;
}
