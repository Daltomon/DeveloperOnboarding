using System.Reflection;
using Autofac;
using DeveloperOnboarding.Framework.Config;
using DeveloperOnboarding.Framework.Model;

namespace DeveloperOnboarding.Framework
{
   public class Container
   {
      private static readonly IContainer AutofacContainer;

      static Container()
      {
         var builder = new ContainerBuilder();
         var hiddenConstructorFinder = new BindingFlagsConstructorFinder(BindingFlags.Instance | BindingFlags.NonPublic);

         builder.RegisterInstance(new Chinook("Chinook.sqlite")).SingleInstance();
         //builder.RegisterType<AlbumRepository>().FindConstructorsWith(hiddenConstructorFinder).SingleInstance();

         AutofacContainer = builder.Build();
      }

      public Container()
      {
         Chinook = AutofacContainer.Resolve<Chinook>();
         //AlbumRepository = AutofacContainer.Resolve<AlbumRepository>();
      }

      public Chinook Chinook { get; }

   }
}
