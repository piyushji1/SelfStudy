using Observer;

Console.WriteLine("Enter your list, press ctrl-c to quit");
var reader = new ListReader();
reader.ListUpdated += (listItem) => Console.WriteLine(listItem);
reader.ReadList();
