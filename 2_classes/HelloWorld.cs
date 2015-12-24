using System; // require('System')
using People;

public class HelloWorld {
  public static void Main() {
    var person = new Person(31, "James");
    Console.WriteLine(person.BuildMessage());
  }
}
