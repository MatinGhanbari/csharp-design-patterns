# Factory Pattern
The Factory Pattern is a creational design pattern that provides an interface for creating objects in a superclass but allows subclasses to alter the type of objects that will be created. This pattern is particularly useful when the exact type of the object to be created is determined at runtime, promoting loose coupling and enhancing code maintainability.

## Key Characteristics:
- Encapsulation of Object Creation: The Factory Pattern encapsulates the instantiation logic, allowing the client code to create objects without needing to know the specific classes being instantiated.
- Flexibility: It enables the addition of new product types without modifying existing code, adhering to the Open/Closed Principle.
- Decoupling: By relying on interfaces or abstract classes, the Factory Pattern reduces dependencies between the client code and the concrete implementations of the products.
## Use Cases:
- When the creation process of an object is complex or involves multiple steps.
- When the exact type of the object to be created is determined at runtime based on user input or configuration.
- When you want to provide a simple interface for creating objects while hiding the instantiation logic.
## Example:
In a typical implementation, a factory class is responsible for creating instances of various products (e.g., `shapes`, `vehicles`) based on input parameters. This allows the client code to request a product without needing to know the details of how it is created.