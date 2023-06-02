**Polymorphism**
*it means many forms. we have two types :*
1. Runtime Polymorphism : achieved by the method overriding , known as late binding or dynamic binding.
 eg:
                
                public class Animal{
                    public virtual Eating(){
                        console.writeline("Eating");
                    }
                }
                public class Dog : Animal {
                    public override Eating(){
                        console.writeLine("eating bread");
                    }
                }
                public class TestRunTimePolymorphism {
                    public static void main(){
                        Animal a = new Dog();
                        a.eat();
                    }
                }

> output: eating bread
*here we instantiate the derived  class and assigned it to the variable to base class , due to the run time poly , animal is invoking a overrided version. Here decision is made at the runtime.*

**Runtime polymorphism cant achieved with the data memebers.the reason is : because when a objcet is instantiated, memeory is allocated to store its data members. And it's define by the class's definition, and this layout can't be changed at runtime.**

2. CompileTime Polymorphism :

early binding. it refers to the ability of compiler to to select the appropriate overloaded function or overloaded operator at compile time based on the static types of arguments involved.
 