---
sidebar_position: 4
tags: [prototype, creational-patterns]

---

# Prototype

Let's suppose that you have a car object that has some attributes like color, license, model, etc. in this case you have a red car with the license plate `MMX502` and you need to create the same car in another object like a copy `car2` because you need the exact same attributes and to change some other attributes like the license plate.

You consider to do something like this:

```csharp
Car original = new Car();
var copy = original;
copy.SetLicensePlate("MRX536")
```

This is not the expected solution because you don't have a copy of the car, you are using the same car object.

<div align="center">
  ![Panik](./media/pointers.png)
  <p>Image taken from <a href="https://www.reddit.com/media?url=https%3A%2F%2Fi.redd.it%2Fr01sq96mnz691.jpg">Reddit</a></p>
</div>

Your next proposal is to make a direct copy of your object creating a new one like this:

```csharp
var original = GetRoadsterCar();
var copy = new Car();
copy.SetLicensePlate("MRX536")
    .SetSerie(original.Serie)
    .SetRadioUnblockCode(original.RadioUnblockCode)
```
but what happens if the `RadioUnblockCode` is a private attribute that is not possible to be accessed? 
or what happens if the car has too many attributes making the code less maintainable or less easy to understand?

<div align="center">
  ![BadPrototype](./media/badprototype.jpg)
  <p>When you don't implement the prototype pattern and you have private values</p>
</div>

## Definition

The prototype's pattern main purpose is to create new objects by copying existing ones, known as prototypes, 
rather than creating them from scratch. This pattern is particularly useful when the construction of a 
new object is more efficient by duplicating an existing object's state.

The Prototype pattern simplifies the cloning process by assigning it to the objects themselves. 
It defines a universal interface for all objects capable of cloning, enabling cloning without 
directly tying code to the object's class. This interface typically consists of a single `clone` method.

The `clone` method's implementation is usually uniform across classes. It instantiates an object 
of the same class and transfers all field values from the original object to the new one. 
Private fields can also be copied since many programming languages allow objects to access 
private fields of others in the same class.

An object supporting cloning is referred to as a `prototype`. When dealing with objects containing numerous fields
and numerous configurations, cloning can be a preferable alternative to subclassing.

## Structure

### Interface Prototype

* This component defines the interface for cloning objects. It usually consists of a single method, typically named `clone()`.
* The purpose of this interface is to declare a common method that enables objects to be cloned without being coupled to their specific classes.
* The `clone()` method defined in this interface is implemented by concrete prototype classes.

### Concrete Prototype

* These are the actual objects that implement the Prototype interface.
* Each concrete prototype class provides its own implementation of the clone() method, tailored to clone instances of that specific class.
* Concrete prototypes encapsulate the logic for creating new instances by copying the state of existing instances.
* Clients interact with concrete prototypes through the Prototype interface, unaware of the specific class being cloned.

## Applicability

* The Prototype Pattern is suitable when object creation involves complex initialization logic, such as querying a database, 
setting up configurations, or loading resources. In such cases, cloning an existing object can be more efficient than creating a new one from scratch.

* If you have a class hierarchy where new subclasses can be introduced dynamically or at runtime, the Prototype Pattern provides 
a flexible way to clone objects without relying on their concrete classes.

* The Prototype Pattern helps decouple client code from the concrete classes of objects being cloned. Clients interact with 
prototypes through a common interface, promoting flexibility and easier maintenance.

## Pros

* Cloning objects is often more efficient than creating them from scratch, especially when initialization logic is complex or resource-intensive.

* The Prototype Pattern supports dynamic creation of objects and allows for easy introduction of new subclasses without modifying client code.

* The cloning logic is encapsulated within concrete prototype classes, promoting better organization and separation of concerns.

## Cons

* If an object contains nested objects or references, implementing a proper deep cloning mechanism can be challenging and error-prone.

* Cloning large object graphs can lead to memory and performance overhead, especially if deep cloning is required.

* The Prototype Pattern is most effective with mutable objects where cloning results in independent instances. 
It's less useful for immutable objects where state cannot be changed after creation.

# References

* [Prototype Pattern](https://refactoring.guru/design-patterns/prototype)

* [Prototype Design Pattern](https://www.geeksforgeeks.org/prototype-design-pattern/)