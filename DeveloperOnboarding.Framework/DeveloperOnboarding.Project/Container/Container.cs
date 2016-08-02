using System.Reflection;
using Autofac;
using DeveloperOnboarding.Framework.Config;
using DeveloperOnboarding.Framework.Repositories;

namespace DeveloperOnboarding.Project.Container
{
   public class Container
   {
      private static readonly IContainer AutofacContainer;

      static Container()
      {
         var builder = new ContainerBuilder();
         var constructorFinder = new BindingFlagsConstructorFinder(BindingFlags.Instance | BindingFlags.NonPublic);

         var frameworkContainer = new Framework.Container();
         builder.RegisterInstance(frameworkContainer.Chinook).SingleInstance();
         //builder.RegisterType<AlbumRepository>().FindConstructorsWith(constructorFinder).SingleInstance();
         builder.RegisterType<ArtistRepository>().FindConstructorsWith(constructorFinder).SingleInstance();

         AutofacContainer = builder.Build();
      }

      public Container()
      {
         //AlbumRepository = AutofacContainer.Resolve<AlbumRepository>();
         ArtistRepository = AutofacContainer.Resolve<ArtistRepository>();
      }

      public ArtistRepository ArtistRepository { get; }
      public AlbumRepository AlbumRepository { get; }
   }
}
