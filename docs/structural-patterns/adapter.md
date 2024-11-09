---
sidebar_position: 1
tags: [adapter, structural-patterns]
---

# Adapter

:::tip What is it about?

The Adapter Pattern is a structural design pattern that allows objects with incompatible interfaces to work together. It acts as a bridge between two incompatible interfaces by wrapping an existing class with a new interface that clients expect.

:::

## How does it work?

The main purpose of the Adapter Pattern is to convert the interface of a class into another interface that a client expects. This pattern lets classes work together that couldn’t otherwise because of incompatible interfaces.

## Components

* **Target:** This is the interface that the client expects to work with.
* **Adapter:** This is the class that implements the Target interface and translates requests to the Adaptee.
* **Adaptee:** This is the class with the existing interface that needs adapting.
* **Client:** This is the class that uses the Target interface.

> Please refer to the [Adapter Pattern Implementation](/blog/adapter) to understand these components in a more visual representation in code.

## Advantages of the Adapter Pattern

* **Increased Reusability:** Allows existing classes to be used in new ways without modifying their code.
* **Flexibility:** Enables interoperation between systems with incompatible interfaces.
* **Single Responsibility Principle:** Separates the concerns of interface incompatibility and functionality.

## Recomended use cases

* **Legacy Code Integration:** When you have existing legacy code with interfaces that don’t match new classes, you can use the Adapter Pattern to integrate the old code with the new system without modifying the legacy code.

* **Third-Party Libraries:** When using a third-party library with an interface that doesn’t match the rest of your application, an adapter can be created to wrap the library’s interface to make it compatible with your application.

* **Different Data Formats:** If you need to interact with multiple systems that provide data in different formats, you can use an adapter to convert the data into a common format that your application can work with.

* **Multiple Interface Standards:** In applications where you need to support multiple interface standards or protocols, the Adapter Pattern can provide a unified interface to the clients while interacting with different systems or services.

* **Testing and Mocking:** In unit tests, you can use adapters to wrap external systems or services, allowing you to easily create mock implementations that conform to the expected interface.

* **Plug-in Architecture:** When building a plug-in architecture, adapters can be used to allow new plug-ins to interact with the core application even if they have different interfaces.
