using System; // require('System')

// Doctor inherits from Person
public class Doctor : Person {
  public int UpdateAge(int age) {
    int newAge = age * 10000;
    this.Age = newAge;
    return newAge;
  }
}
