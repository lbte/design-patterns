---
sidebar_position: 3
---

# Builder

Imagine you're a developer building a character creation system for a role-playing game. This character can have various attributes like strength, agility, intelligence, and can be equipped with different weapons and armor. Now, let's say you create a Character class with a constructor that takes all these attributes and equipment as individual arguments.

Imagine dealing with this kind of constructors that has too many parameters, making the code no cleaner also not extensible, you will face with a bad code practice called [Long parameter list](https://refactoring.guru/smells/long-parameter-list)

<div align="center">
  ![Panik](../../static/img/panik.png)
  <p>Your face when you need to add a new attribute</p>
</div>

## How does this pattern fix the problem

The Builder pattern is a technique in object-oriented programming that provides a flexible approach to constructing complex objects step by step. It separates the object creation process from its representation, allowing you to create different variations of the same object type.

Instead of having a massive constructor with many optional parameters, the Builder pattern provides a series of methods for setting each attribute individually. You only call the methods for the attributes you want to set.

```csharp
Character basicCharacter = new CharacterBuilder()
                              .setName("Kazuma Sato")
                              .setStrength(15)
                              .setAgility(10)
                              .build();
```

instead of having 

```csharp
Character hero = new Character("Kazuma Sato", 15, 12, 10, "Sword", "Chainmail", null, 15, "Eris", "Axel"); 
```

## Builder

Defines the core interface for creating different parts of a complex object. It's like a step-by-step recipe for building something – the interface provides the necessary steps that can be implemented differently. Each method in the Builder interface usually represents a single component or feature of the final product. Methods like setName(), setStrength(), setAgility()

## Concrete Builder

Concrete Builders are subclasses of the Builder interface. They provide concrete, specific implementations for the methods defined in the general Builder. Think of them as builders who specialize in different construction materials or methods, for example a character that is a Adventurer, Cleric, Sorcerer, Paladin, etc

## Director

The Director acts as an orchestrator. It knows the overall process required to create different variations of the complex object. It holds a reference to a Builder and tells it which methods to call and in what order. It's like the order of operations in a recipe, guiding how the builder constructs the final product.

## References

* [Builder](https://refactoring.guru/design-patterns/builder)
* [Builder Design Pattern](https://www.geeksforgeeks.org/builder-design-pattern/)
