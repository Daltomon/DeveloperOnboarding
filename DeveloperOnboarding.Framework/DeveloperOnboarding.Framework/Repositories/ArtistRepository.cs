using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperOnboarding.Framework.Model;

namespace DeveloperOnboarding.Framework.Repositories
{
   public class ArtistRepository
   {
      private readonly Chinook _chinook;

      private ArtistRepository(Chinook chinook)
      {
         _chinook = chinook;
      }

      public IReadOnlyCollection<Artist> SearchArtistsByName(string searchString)
      {
         return (from a in _chinook.Artists where a.Name.Contains(searchString) select a).ToArray();
      } 
   }
}
