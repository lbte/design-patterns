---
sidebar_position: 1
---

# Factory method

:::tip What is it about?

It provides an interface for creating objects in a superclass dynamically, while allowing subclasses to customize the creation process.

:::

## How does it work?

Imagine you need to create objects, but the exact class of the object isn’t known in advance. How can you achieve this flexibility?

So in order to achieve that you should:

1. Define an interface (or an abstract base class) with a method called the factory method. This method is responsible for creating objects.
2. Define subclasses (concrete implementations) which override the factory method to produce specific types of objects.
3. Instead of directly calling constructors, clients use the factory method to create instances.

## What are its benefits?

* **Flexibility**: Subclasses can redefine the type of objects they create.
* **Deferred Instantiation**: The actual object creation is deferred to subclasses.
* **Reuse and Abstraction**: The factory method isolates object creation logic, promoting code reuse and abstraction.

## Example

1. Consider a ``VehicleFactory`` class with a factory method called ``CreateVehicle()``.
2. Subclasses like ``CarFactory`` and ``BikeFactory`` override ``CreateVehicle()`` to produce specific vehicles.
3. Clients use ``CreateVehicle()`` to obtain instances of cars or bikes.