using System;

public class Person {
  // constructor
  public Person(int age, string name) {
    this.Name = name;
    this.Age = age;
  }
  public Person() {
    // empty constructor with arguments
  }
  public string BuildMessage() {
    string message = "Hello, friends. I am learning another language. My name is " + this.Name + " and I am " + this.Age + " years old.";
    return message;
  }
  // attributes.. with a built in getter/setter
  public string Name { get; set; }
  public int Age { get; set; }
}

