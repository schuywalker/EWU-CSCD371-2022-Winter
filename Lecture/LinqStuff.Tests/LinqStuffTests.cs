using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace LinqStuff.Tests;

[TestClass]
public class LinqStuffTests
{
    static public MemberInfo[] GetEnumerbaleMembers()
    {
        MemberInfo[] members = typeof(Enumerable).GetMembers();
        Assert.AreEqual<int>(212, members.Length);
        return members;
    }

    [TestMethod]
    public void GetAllMemberNamesUsingAggregate()
    {
        // Hmmm?  Why did Mark have us look for the Contains() member I wonder?
        IEnumerable<string> memberNames =
            GetEnumerbaleMembers().Select(item => item.Name);
        //(new (string MemberName, bool Exists)[] {
        //    ("Contains", false), ("Aggregate", false), ("Map", false) }).Aggregate(
        //    (item, next) => memberNames.Any(item => item ==item.) == tuple.Exists);
    }

    [TestMethod]
    public void GetAllTheMemberNames()
    {
        // Hmmm?  Why did Mark have us look for the Contains() member I wonder?
        IEnumerable<string> memberNames =
            GetEnumerbaleMembers().Select(item => item.Name);

        // Do This!!!
        Assert.IsTrue(memberNames.Contains("Contains"));
        Assert.IsTrue(memberNames.Contains("Aggregate"));
        Assert.IsFalse(memberNames.Contains("Map"));
        // Map,Aggregate,Contains

        // Mark's Homework
        IEnumerable<string> items = memberNames.Where(
            item => (item == "Contains" || item == "Aggregate"));
        Assert.AreEqual<int>(2, items.Count());
    }

    [TestMethod]
    public void DeferredExecution()
    {
        int countMemberNameIterations = 0;
        int countMemberInfoIterations = 0;
        IEnumerable<MemberInfo> memberInfos =
            GetEnumerbaleMembers().Where(item =>
            {
                countMemberInfoIterations++;
                return item.Name[0] == 'C';
            });
        // Assert.AreEqual(7, memberInfos.Count());
        IEnumerable<string>  memberNames = memberInfos.Select(item => 
            {
                countMemberNameIterations++;
                return item.Name;
            });

        Assert.AreEqual<int>(0, countMemberNameIterations);
        Assert.AreEqual<int>(0, countMemberInfoIterations);
        Assert.AreEqual(7, memberNames.Count());
        Assert.AreEqual<int>(7, countMemberNameIterations);
        Assert.AreEqual<int>(212, countMemberInfoIterations);
        _ = memberNames.Count();
        Assert.AreEqual<int>(14, countMemberNameIterations);
        Assert.AreEqual<int>(424, countMemberInfoIterations);

        int finalCount = memberNames.Count();
        Assert.AreEqual<int>(212*3, countMemberInfoIterations);
    }

    [TestMethod]
    public void AvoidDeferredExecution()
    {
        int countMemberNameIterations = 0;
        int countMemberInfoIterations = 0;
        List<MemberInfo> memberInfos =
            GetEnumerbaleMembers().Where(item =>
            {
                countMemberInfoIterations++;
                return item.Name[0] == 'C';
            }).ToList();
        // Assert.AreEqual(7, memberInfos.Count());
        List<string> memberNames = memberInfos.Select(item =>
        {
            countMemberNameIterations++;
            return item.Name;
        }).ToList();

        Assert.AreEqual<int>(7, countMemberNameIterations);
        Assert.AreEqual<int>(212, countMemberInfoIterations);
        Assert.AreEqual(7, memberNames.Count);
        Assert.AreEqual<int>(7, countMemberNameIterations);
        Assert.AreEqual<int>(212, countMemberInfoIterations);
        _ = memberNames.Count;
        Assert.AreEqual<int>(7, countMemberNameIterations);
        Assert.AreEqual<int>(212, countMemberInfoIterations);

        int finalCount = memberNames.Count;
        Assert.AreEqual<int>(212, countMemberInfoIterations);
    }
}
