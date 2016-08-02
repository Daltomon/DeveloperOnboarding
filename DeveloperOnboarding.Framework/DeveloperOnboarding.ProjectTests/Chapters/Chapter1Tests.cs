
using System;
using DeveloperOnboarding.Project.Container;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeveloperOnboarding.ProjectTests.Chapters
{
   [TestClass]
   public class Chapter1Tests : IChapterTest
   {
      public string ChapterTitle { get; } = @"Chapter 1: Dependency Injection";
      public string ChapterDescription { get; } = @"";

      [TestMethod]
      public void C1_T1_Container_BuildsSuccessfully()
      {
         try
         {
            new Container();
         }
         catch (Exception e)
         {
            throw new Exception("Container cannot be instantiated.", e);
         }
      }

      [TestMethod]
      public void C1_T2_Container_AlbumRepositoryIsRegistered()
      {
         var container = new Container();
         Assert.IsNotNull(container.AlbumRepository);
      }

      [TestMethod]
      public void C1_T3_Container_ArtistRepositoryIsRegistered()
      {
         var container = new Container();
         Assert.IsNotNull(container.ArtistRepository);
      }
   }
}
