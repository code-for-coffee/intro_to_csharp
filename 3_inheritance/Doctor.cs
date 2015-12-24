// Doctor inherits from Person
public class Doctor : Person {
  public Doctor(int age, string name) {
    this.Name = name;
    this.Age = age;
  }
  public int UpdateAge(int age) {
    int newAge = age * 10000;
    this.Age = newAge;
    return newAge;
  }
}
