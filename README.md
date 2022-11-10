Design Principles or SOLID Principles
SOLID principles sets some guide lines or golden rules for writing proper code logic for a software program or project. It helps in maintaining the better scalability, less time effort for a developer to fix any bug and easier reusability. As per the word SOLID refers
S – Single responsibility principle.
O – Open closed principle.
L – Liskov substitution principle.
I – Interface segregation principle.
D – Dependency inversion principle.
Single Responsibility Principle: 
	A class or interface should have only one responsibility. It may have single reason to change and encapsulate.
	If a class or interface have more than one responsibility then divide the class or interface into multiple class or interface.
	It keeps the code small and simple.
In the below example, if we observe the interface IProcessData has three methods. Where the InsertProducts and DeleteProducts has responsibility on the class to perform products insert and products delete. Whereas, the CalculatePriceByQantity would need to perform a different responsibilty. Hence, single responsibility principle does not satisfy.
  




We can now divide an interface to multiple interfaces IProducts and ICaluclatePrice, where the responsibility will be single for the classes where implemented. Hence, satisfies the single responsibility principle.
 

Open Closed Principle:
	A class or software entity should be open for extension and closed for modification.
	We can achieve this by abstract class and interface implementation in child classes.
In the below example the class PriceCalculation does only the RevisedProductPrice. 
But, if we required to calculate price as per the location then we need to perform and if codition check which does not satisfy the Open Closed Principle.
  

We can create and abstract class ‘DiscountCalculator’ as below and importantly we can add a abstract method, where the subsequent classes can implement those methods and can change or apply the respective implementations. Hence, the class will be open for extension but closed for modification.
 

Liskov Substitution Principle :
Object in a program should be replaced with sub class instances. There should not be any change in the functionality.
In the below example we are performing the TotalProductsSold and TotalProductsSoldWithinIndia, but here there to perform different calculations we need to call and create different class instances, which does not satisfy Liskov substitution Principle.



 
 
So, what we can do is we can create and abstract class Calculator and inherit that into child sub classes and override the abstract Methods of the base class ‘CalculateTotal’. In this way we do not break the Liskov Substitution principle.  




 
Interface Segregation Principle:
Every class unnecessarily require all the methods of an interface. We can break those interfaces and move the methods as per requirement. Means breaking a  big interfaces into small multiple interfaces
The below example has three methods in the interface, where when implemented by two classes which must have unnecessarily require the all the methods to be implemented( when few are not required).

 
Interface Segregation Principle what it does is we need to create multiple interfaces for different method operations according to the requirement. So, that unnecessary we not need to implement the method which are not required and the class where  requirement we can implement  by inheriting multiple interfaces.  
 

Dependency inversion principle:
Dependency inversion principle states that “high level module” should not depend on low level module and both should depend on abstraction.
Here, we created instance of the DataAccessLayer and where BusinessLogicLayer  “High level module” is dependent on the  DataAccessLAyer “Low level module”. Hence, dependency inversion principle fails.
 

So, what we can do is create an interface ‘IRepsositoryLayer’ with a Save method. And now create an instance of the interface in the Business Layer and here we could call the interface Save method which would call the DataAccessLayer and we are not directly calling the ‘DataAccessLayer’ method ‘SaveData’ directly. This satisfies the Dependency inversion principle.
 
