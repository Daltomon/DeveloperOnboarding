using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperOnboarding.Framework.Model;

namespace DeveloperOnboarding.Framework.Repositories
{
   public class AlbumRepository
   {
      private readonly Chinook _chinook;

      private AlbumRepository(Chinook chinook)
      {
         _chinook = chinook;
      }

      public IReadOnlyCollection<Album> GetAllAlbums()
      {
         return (from a in _chinook.Albums select a).ToArray();
      }

      public IReadOnlyCollection<Album> GeAlbumsByArtistId(int artistId)
      {
         return (from a in _chinook.Albums where a.ArtistId == artistId select a).ToArray();
      }
   }
}
