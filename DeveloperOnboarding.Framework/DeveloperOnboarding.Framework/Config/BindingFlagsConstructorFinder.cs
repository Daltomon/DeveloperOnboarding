using System;

using System.Reflection;
using Autofac.Core.Activators.Reflection;

namespace DeveloperOnboarding.Framework.Config
{
   public class BindingFlagsConstructorFinder : IConstructorFinder
   {
      private readonly BindingFlags _flags;

      public BindingFlagsConstructorFinder(BindingFlags flags)
      {
         _flags = flags;
      }


      public ConstructorInfo[] FindConstructors(Type targetType)
      {
         var results = targetType.GetConstructors(_flags);
         return results;
      }
   }
}
