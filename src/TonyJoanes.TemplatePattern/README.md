# Template Pattern

The Template Pattern is a behavioral design pattern that defines the skeleton of an algorithm in a base class, allowing subclasses to provide specific implementations for individual steps of the algorithm. It promotes code reuse, flexibility, and extensibility by encapsulating the invariant parts of the algorithm in the base class and allowing the varying parts to be customized by subclasses.  

The main idea behind the Template Pattern is to create an abstract base class (often called the "template") that contains a template method. The template method defines the algorithm's overall structure and calls several abstract or hook methods. The abstract methods represent steps that must be implemented by concrete subclasses, while hook methods have default implementations that can be optionally overridden.  

The Template Pattern is used in scenarios where you have a common algorithm with variations in certain steps. It helps to avoid code duplication and allows you to define a high-level structure while providing flexibility for specific implementations. It is commonly used when you want to provide a framework for a process but allow subclasses to customize parts of that process.

Benefits of using the Template Pattern include:

1. Code Reusability: The common parts of the algorithm are implemented once in the base class, promoting code reuse across multiple subclasses.
2. Flexibility: Subclasses can override specific steps of the algorithm to customize the behavior without affecting the overall structure.
3. Encapsulation: The Template Pattern encapsulates the algorithm's structure in the base class, keeping it separate from the details of individual steps.
4. Extensibility: New subclasses can be easily added to introduce additional variations without modifying the existing code.
5. Simplification: It provides a higher-level view of the algorithm by abstracting away the common parts and focusing on the varying steps.

Common use cases for the Template Pattern include:

- Frameworks and libraries where the core logic is fixed, but certain parts need customization.
- Report generation with different formats or layouts.
- Database access with common connection and error handling but different query implementations.
- Workflow processes with standardized steps but variations in individual actions.

By applying the Template Pattern, you can create more maintainable and flexible code that accommodates varying requirements while preserving a consistent structure.

## Invoice Example

In the invoice example, the Template Pattern is applied to generate invoices for different customers with varying header, item, calculation, and footer requirements. 

The abstract base class `InvoiceGenerator` defines the overall invoice generation algorithm using the template method `GenerateInvoice()`. It outlines the common steps such as adding the invoice header, invoice items, calculating the total amount, and adding the invoice footer.

Two concrete classes, `CustomerAInvoiceGenerator` and `CustomerBInvoiceGenerator`, derive from the base class and provide their own implementations for the abstract methods. Each implementation customizes the invoice generation process to meet the specific needs of the respective customer.

The `GenerateInvoice()` method in the base class is responsible for executing the invoice generation algorithm in the predefined order. It calls the overridden methods in the derived classes to perform the customer-specific steps.

By utilizing the Template Pattern, the invoice example demonstrates how you can reuse the common parts of the invoice generation process while allowing for customization and extensibility based on the needs of different customers.