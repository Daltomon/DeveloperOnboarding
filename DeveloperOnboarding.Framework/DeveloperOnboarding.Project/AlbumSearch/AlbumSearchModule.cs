using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperOnboarding.Framework.Model;
using DeveloperOnboarding.Framework.Repositories;

namespace DeveloperOnboarding.Project.AlbumSearch
{
   public class AlbumSearchModule
   {
      private readonly AlbumRepository _albumRepository;
      private readonly ArtistRepository _artistRepository;

      public AlbumSearchModule(AlbumRepository albumRepository, ArtistRepository artistRepository)
      {
         _albumRepository = albumRepository;
         _artistRepository = artistRepository;
      }

      public IReadOnlyCollection<Album> SearchAlbumsByArtist(string searchString)
      {
         throw new NotImplementedException();
      }
   }
}
