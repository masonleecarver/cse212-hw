using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: simple priority que with three items having different priorities.
    // Expected Result: [ice cream, chestnuts, peanut butter]
    // Defect(s) Found: chestnuts was dequeued before ice cream
    public void TestPriorityQueue_1()
    {

        string[] expectedResult = ["ice cream", "chestnuts", "peanut butter"];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("chestnuts", 1);
        priorityQueue.Enqueue("ice cream", 2);
        priorityQueue.Enqueue("peanut butter", 0);

        for (int i = 0; i < priorityQueue.Length; i++)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], value);
        }
    }

    [TestMethod]
    // Scenario: throw exception when dequeueing from an empty queue
    // Expected Result: "the queue is empty"
    // Defect(s) Found: it worked :thumbs-up:
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }


    [TestMethod]
    // Scenario: handle a queue with items having the same priority
    // Expected Result: [ice cream, candy cane, chestnuts, peanut butter]
    // Defect(s) Found: candy cane was dequeued before ice cream.
    public void TestPriorityQueue_3()
    {

        string[] expectedResult = ["ice cream", "candy cane", "chestnuts", "peanut butter"];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("chestnuts", 1);
        priorityQueue.Enqueue("ice cream", 2);
        priorityQueue.Enqueue("peanut butter", 0);
        priorityQueue.Enqueue("candy cane", 2);

        for (int i = 0; i < priorityQueue.Length; i++)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], value);
        }
    }

    // Add more test cases as needed below.
}