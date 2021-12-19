using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace addressbook_tests_autoit.tests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemoval()
        {
            app.Groups.CheckForAtLeastOneGroup();
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Remove();
            Assert.AreEqual(oldGroups.Count - 1, app.Groups.GetGroupCount());
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
