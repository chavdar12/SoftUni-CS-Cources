﻿namespace HierarchyTests.Correctness;

public class GetCommonElements : BaseTest
{
    [Test]
    public void GetCommonElements_WithHierarchyWithoutCommonElements_ShouldReturnAnEmptyCollection()
    {
        var otherHierarchy = new Hierarchy<int>(1);

        var result = Hierarchy.GetCommonElements(otherHierarchy).ToArray();

        CollectionAssert.AreEquivalent(result, new int[0], "GetCommonElements returned an incorrect collection!");
    }

    [Test]
    public void GetCommonElements_WithHierarchyWithOneCommonElement_ShouldReturnACollectionOfCorrectElement()
    {
        var otherHierarchy = new Hierarchy<int>(1);
        otherHierarchy.Add(1, 13);
        Hierarchy.Add(DefaultRootValue, 13);

        var result = Hierarchy.GetCommonElements(otherHierarchy).ToArray();

        CollectionAssert.AreEquivalent(result, new[] { 13 }, "GetCommonElements returned an incorrect collection!");
    }

    [Test]
    public void GetCommonElements_WithHierarchyWithMultipleCommonElements_ShouldReturnACorrectCollection()
    {
        var otherHierarchy = new Hierarchy<int>(10);
        otherHierarchy.Add(10, -22);
        otherHierarchy.Add(-22, 56);
        otherHierarchy.Add(10, 108);
        otherHierarchy.Add(-22, 34);
        Hierarchy.Add(DefaultRootValue, 100);
        Hierarchy.Add(DefaultRootValue, -22);
        Hierarchy.Add(100, 34);
        Hierarchy.Add(100, 10);

        var result = Hierarchy.GetCommonElements(otherHierarchy).ToArray();

        CollectionAssert.AreEquivalent(result, new[] { -22, 34, 10 },
            "GetCommonElements returned an incorrect collection!");
    }
}