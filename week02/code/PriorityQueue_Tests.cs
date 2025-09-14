using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{

    [TestMethod]
    // Scenario: Enqueue multiple items with the same priority and Dequeue once.
    // Expected Result: The item closest to the front of the queue will be removed and its value returned
    // Defect(s) Found: It was furthest item with a matching highest priority.
    public void TestPriorityQueue_DequeueTieBreaker()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 3);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 3);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("A", result);
    }

    [TestMethod]
    // Scenario: Enqueue two items, then Dequeue twice.
    // Expected Result: First "B" (Pri:5), then "A" (Pri:1). Queue should then be empty.
    // Defect(s) Found: The Dequeue method does not remove items, so the same item can be dequeued repeatedly.
    public void TestPriorityQueue_DequeueRemovesItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);

        var first = priorityQueue.Dequeue();
        Assert.AreEqual("B", first);

        var second = priorityQueue.Dequeue();
        Assert.AreEqual("A", second);

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}