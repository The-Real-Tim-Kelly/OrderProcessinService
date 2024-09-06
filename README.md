# OrderProcessinService
This is an application to demonstrate Chain of Responsibility, Factory and Strategy design patterns

Requirements:
Handle the sequence of processing steps for each order.
Ability to create instances of different types of orders based on input data.
Define different shipping algorithms for different types of orders.
The design should allow for new order types and new processing steps to be easily added without changing existing code.

Sample Input:
Order Type: Priority Order
Order Data:
Items: Laptop, Mouse
Shipping Address: 1234 Main St, City, Country
Shipping Speed: Expedited

Sample Output:
Order Validation Result: Passed
Shipping Method: Expedited Shipping
Total Shipping Cost: $15.00
Estimated Delivery: 2 Days
Evaluation Criteria:
Clean and scalable code design.
Flexibility to extend the system (e.g., adding new order types, shipping methods, or processing steps).
Testability of individual components in the design.