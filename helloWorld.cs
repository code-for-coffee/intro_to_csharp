using System; // require('System')
using System.Collections; // all the collections
using System.Collections.Generic;
using System.IO; // input/output

public class HelloWorld {
  // every class that you want to execute... as an app
  // so imagine this as your app.js or app.rb
  // needs a Main() method
  public static void Main() {
    var person = new Person();
    person.Name = "James";
    person.Age = 31;
    Console.WriteLine(person.BuildMessage()); // console.log.. or puts

    var doctor = new Doctor();
    doctor.Name = "The Doctor";
    doctor.UpdateAge(62);
    Console.WriteLine(doctor.BuildMessage());

    var things = new Dictionary<string, string>();
    things.Add("Marty", "McFly");
    things.Add("Jason", "Thamboy");
    things.Add("Roger", "Pinup-Panella");

    foreach(var item in things) {
      Console.WriteLine(item.Key + ": " + item.Value);
    }

  }
}

public class Person {
  public string BuildMessage() {
    string message = "Hello, friends. I am learning another language. My name is " + this.Name + " and I am " + this.Age + " years old.";
    return message;
  }
  // attributes.. with a built in getter/setter
  public string Name { get; set; }
  public int Age { get; set; }
}

// Doctor inherits from Person
public class Doctor : Person {
  public int UpdateAge(int age) {
    int newAge = age * 10000;
    this.Age = newAge;
    return newAge;
  }
}
