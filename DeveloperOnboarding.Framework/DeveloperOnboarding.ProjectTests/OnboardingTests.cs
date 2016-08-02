using System;
using DeveloperOnboarding.Framework.Extensions;
using DeveloperOnboarding.ProjectTests.Chapters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeveloperOnboarding.ProjectTests
{
   [TestClass]
   public class OnboardingTests
   {
      private const string Instructions =
@"Developer Onboarding Instructions:

The goal of this project is to train new developers in the coding standards and methodologies used by our company. Chapters and individual tests should be completed in order. Tests build upon previous sections so each earlier test should appear green before continuing on. When all tests are completed, please submit the results for a code review. Good luck.";

      private static readonly IChapterTest[] Tests =
      {
         new Chapter1Tests()
      };

      [TestMethod]
      [Description("Developer Onboarding")]
      public void Welcome()
      {
         Console.WriteLine(Instructions + Environment.NewLine);
         Tests.ForEach(t => Console.WriteLine(t.ChapterTitle));
      }
   }
}
