// See https://aka.ms/new-console-template for more information
using new_Console_app.Exceptions;
using new_Console_app.Models;
using new_Console_app.Services;
using static new_Console_app.Enums.SongGenre;

#region CRUD for song
SongServices songServices = new SongServices();
Song song12 = new Song()
{
    songName = "Song1",
    Duration = 12.11,
    Genre = GenreEnum.Classical
};
Song song13 = new Song()
{
    songName = "Song2",
    Duration = 3.12,
    Genre = GenreEnum.Jazz
};
Song song14 = new Song()
{
    songName = "Song3",
    Duration = 3.12,
    Genre = GenreEnum.Pop
};

Song newSong = new Song()
{
    songName = "Bir sabah gelecek kardan aydinlik",
    Duration = 4.50,
};
songServices.AddSong(song12);
songServices.AddSong(song13);
songServices.AddSong(song14);

#region Mahnilari ekrana cixarmaq
//foreach (Song item in songServices.GetAllSongs())
//{
//    Console.WriteLine($"{item.Id}. mahni adi: {item.songName} janri:{item.Genre}");
//}
#endregion

#region Update hissesi
//try
//{

//    SongServices.UpdateSong(3, newSong);
//    Console.WriteLine("Mahni melumatlari ugurla yenilendi");
//}
//catch (MyExceptions ex)
//{
//    Console.WriteLine(ex.Message);
//}
#endregion

#region Delete hissesi
//try
//{
//    songServices.DeleteSong(2);

//}
//catch (MyExceptions ex)
//{
//    Console.WriteLine(ex.Message);
//}
//Console.WriteLine("AFTER DELETED");
foreach (Song item in songServices.GetAllSongs())
{
    Console.WriteLine($"{item.Id}. mahni adi: {item.songName} janri:{item.Genre}");
}
#endregion
#endregion

#region CRUD for Playlist

PlayList playList1 = new PlayList()
{

    playlistName = "PlayList1",
};
PlayList playList2 = new PlayList()
{
  
    playlistName = "PlayList2",
};

PlayList newPlayList = new PlayList()
{
    playlistName = "new playList name",
};

PlayListServices playListServices = new PlayListServices();
#region CREATE istifadesi
playListServices.AddPlayList(playList1);
playListServices.AddPlayList(playList2);

foreach (var item in playListServices.GetAllPlayLists())
{
    Console.WriteLine($"playlist name: {item.playlistName}");
}
#endregion

#region UPDATE istifadesi
//try
//{
//    playListServices.UpdatePlayList(2, newPlayList);
//}
//catch (MyExceptions ex)
//{
//    Console.WriteLine(ex.Message);
//}
//Console.WriteLine("---updated playlists---");
//foreach (var item in playListServices.GetAllPlayLists())
//{
//    Console.WriteLine($"playlist name: {item.playlistName}");
//}
#endregion

#region DELETE istifadesi
try
{
    playListServices.DeletePlaylist(1);
}
catch (MyExceptions ex)
{
    Console.WriteLine(ex.Message);
}


Console.WriteLine("AFTER DELETED");
foreach (PlayList item in playListServices.GetAllPlayLists())
{
    Console.WriteLine($"{item._id}. mahni adi: {item.playlistName} ");
}
#endregion
#endregion
