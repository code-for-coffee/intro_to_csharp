# Introduction to C Sharp

* Download Mono for Mac: http://www.mono-project.com/download/
* There is a Xamarin IDE: https://xamarin.com/download/
* You can also `brew install mono`

## 1. How to Compile

* To compile an application, we need to run `mcs MyClass.cs`
* This stands for **make c sharp** + `MyClass.cs`
* This will compile `MyClass.cs` into a new executable called `MyClass.exe`

## 2. How to Run

* `mono myClass.exe`

## 3. Building with multiple files

* If you need to include multiple files when compiling, include them all as arguments.
* For example: 
* `mcs MyClass.cs MyThing.cs MyOtherThing.cs`
* This will include all of the files together for compilation!