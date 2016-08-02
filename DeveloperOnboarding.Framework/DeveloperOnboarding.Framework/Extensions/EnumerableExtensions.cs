using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperOnboarding.Framework.Extensions
{
   public static class EnumerableExtensions
   {
      public static void ForEach<T>(this IEnumerable<T> values, Action<T> action)
      {
         foreach (var value in values)
         {
            action.Invoke(value);
         }
      }
   }
}
