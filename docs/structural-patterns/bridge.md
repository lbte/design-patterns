---
sidebar_position: 2
---

# Bridge

<div align="center">
  ![GoldenGate](../../static/img/bridge.jpg)
  <p>Image taken from <a href="https://www.history.com/topics/landmarks/golden-gate-bridge">History</a></p>
</div>

## The problem

Imagine you're developing a multimedia application that needs to support various types of rendering devices, such as screens, printers, and projectors. Each rendering device requires different rendering logic and may evolve independently over time. How can you design your application to accommodate these diverse rendering requirements without tightly coupling the rendering logic to the abstraction layer?

Your first alternative might be tempted to implement separate classes or modules for each rendering device, tightly coupling the rendering logic to the abstraction layer. While this approach may work initially, it leads to code duplication, maintenance headaches, and difficulties in accommodating new types of rendering devices in the future.

## How does the Bridge Pattern Solves the Problem?

The Bridge Pattern decouples an abstraction from its implementation, allowing them to vary independently. In our scenario, the abstraction represents the high-level rendering functionality, while the implementation encapsulates the specific rendering logic for each device.

By employing the Bridge Pattern, we create a bridge between the abstraction layer and the implementation layer. This bridge serves as a conduit through which the abstraction can interact with different implementations seamlessly, without being tightly bound to any particular one.

In our multimedia application we can define an abstraction for rendering content without concerning itself with the specifics of each rendering device. Each rendering device, such as a screen, printer, or projector, has its own implementation class encapsulating the device-specific rendering logic.

The beauty of the Bridge Pattern lies in its ability to allow both the abstraction and implementation to evolve independently. If we need to add support for a new rendering device in the future, we can simply create a new implementation class without modifying the existing abstraction or other implementations.

## Components

### Abstraction

The Abstraction is the one that defines the high-level interface for clients to interact with. This interface typically encapsulates the broader functionality or behavior that clients expect from the system. In the multimedia application example, the Abstraction might represent the generic rendering operations, such as displaying an image or playing a video.

### Implementation

Complementing the Abstraction is the Implementation, which represents the concrete implementation details of the functionality defined by the Abstraction. This layer encapsulates the device-specific logic, such as rendering an image to a screen, printing it on paper, or projecting it onto a surface. The Implementation interface provides the necessary methods for the Abstraction to delegate tasks to specific implementations without knowing the implementation details.

### Concrete Implementation

Concrete Implementation classes extend the Implementation interface and provide concrete implementations for specific rendering devices. For instance, we might have ScreenRenderer, PrinterRenderer, and ProjectorRenderer classes, each implementing the rendering logic tailored to its respective device. These classes encapsulate the device-specific details, such as screen resolution, printer DPI settings, or projector projection techniques.

### Refined Implementation (optional)

In some cases, it may be beneficial to introduce a Refined Implementation layer to further refine the behavior of specific implementations. This layer allows for additional customization or optimization without modifying the Abstraction or existing Concrete Implementation classes. For example, we might introduce a HighResolutionScreenRenderer class to handle rendering on high-resolution screens, which extends the functionality of the ScreenRenderer without altering its core behavior.

## Pros

* Decouples Abstraction from Implementation: The Bridge Pattern promotes loose coupling between abstraction and implementation, allowing them to vary independently. This enhances flexibility and simplifies maintenance, as changes in one do not affect the other.

* Promotes Code Reusability: By separating the abstraction and implementation layers, the Bridge Pattern encourages code reuse. Abstractions can be reused with different implementations, reducing duplication and promoting a modular design.

* Facilitates Platform Independence: For projects requiring cross-platform compatibility, the Bridge Pattern is invaluable. It enables the creation of platform-independent abstractions while providing flexibility to implement platform-specific functionality.

* Allows for Evolution and Extension: As requirements evolve or new features are added, the Bridge Pattern accommodates changes gracefully. Adding new implementations or modifying existing ones is straightforward and does not necessitate alterations to the abstraction layer.

* Enhances Testability: The separation of concerns inherent in the Bridge Pattern makes components easier to test in isolation. Abstractions can be mocked or stubbed, facilitating unit testing without the need for complex setup.

## Cons

* While the Bridge Pattern offers benefits in terms of flexibility and maintainability, it can introduce additional complexity and potential overhead, especially in simpler scenarios where the overhead of implementing the pattern may outweigh its benefits.

## References

* [Bridge](https://refactoring.guru/design-patterns/bridge)
* [Design Patterns — A quick guide to Bridge pattern.](https://medium.com/@andreaspoyias/design-patterns-a-quick-guide-to-bridge-pattern-9ebf6a77baed)