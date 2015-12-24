using System;
using System.Collections; // all the collections
using System.Collections.Generic;
using System.IO; // input/output

public class HelloWorld {

  public static void Main() {
    var person = new Person(31, "James");
    Console.WriteLine(person.BuildMessage());

    var doctor = new Doctor(60, "The Doctor");
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