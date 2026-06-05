Stack<string> undoHistory = new();
undoHistory.Push("Write title");
undoHistory.Push("Add paragraph");
Console.WriteLine($"Undo (last in, first out): {undoHistory.Pop()}");

Queue<string> supportTickets = new();
supportTickets.Enqueue("Ticket A");
supportTickets.Enqueue("Ticket B");
Console.WriteLine($"Serve (first in, first out): {supportTickets.Dequeue()}");

HashSet<string> attendees = new(StringComparer.OrdinalIgnoreCase);
Console.WriteLine($"Add Samir: {attendees.Add("Samir")}");
Console.WriteLine($"Add samir again: {attendees.Add("samir")}");
Console.WriteLine($"Unique attendees: {attendees.Count}");
