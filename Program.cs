using InterfaceExample;


//brug af  : https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1?view=net-9.0

Console.WriteLine("Hello, World!");

//MyContacts contacts = new MyContacts(new List<Contact>());
MyContacts contacts = new MyContacts(new LinkedList<Contact>());
//MyContacts contacts = new MyContacts(new HashSet<Contact>());



var hans = new Contact(name: "hans hansen", "hansenvej 2", "1234");
var jens = new Contact(name: "jens jensen", "jensenvej 4", "5678");
contacts.AddContact(hans);
contacts.AddContact(jens);

Console.WriteLine("Antal kontakter: " + contacts.CountContacts);
Console.ReadLine(); //end when key pressed

