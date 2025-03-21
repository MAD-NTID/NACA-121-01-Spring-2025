// // First include the generic collection which includes stack and queueu
// using System.Collections.Generic;

// // Let's create a stack of BrowserTabs (unrealistic example)
// Stack<BrowserTabs> browserTabs = new Stack<BrowserTabs>();

// browserTabs.Push(new BrowserTabs(0, "myCourses"));
// browserTabs.Push(new BrowserTabs(1, "fps reviews"));
// browserTabs.Push(new BrowserTabs(2, "myspace"));
// browserTabs.Push(new BrowserTabs(3, "google"));

// Console.WriteLine($"The top element is {browserTabs.First()}");

// // Now let's remove using pop
// BrowserTabs removedTab = browserTabs.Pop();
// Console.WriteLine($"BrowserTab Removed: {removedTab}");

// // Now what's the last tab after popping?
// Console.WriteLine($"The top element is {browserTabs.First()}");

// Now let's build a queue
Queue<BrowserTabs> browserTabsQueue = new();
browserTabsQueue.Enqueue(new BrowserTabs(0, "myCourses"));
browserTabsQueue.Enqueue(new BrowserTabs(1, "fps reviews"));
browserTabsQueue.Enqueue(new BrowserTabs(2, "myspace"));
browserTabsQueue.Enqueue(new BrowserTabs(3, "google"));

Console.WriteLine($"The first element is {browserTabsQueue.First()}");

// Dequeue
BrowserTabs dequeuedTab = browserTabsQueue.Dequeue();
Console.WriteLine($"Browser Tab Dequeued: {dequeuedTab}");

// How's first now?
Console.WriteLine($"The first element is {browserTabsQueue.First()}");