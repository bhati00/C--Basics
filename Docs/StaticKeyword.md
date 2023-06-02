*--static is a keyword or modifier that belongs to the type not instance. So instance is not required to access the static members. In C#, static can be field, method, constructor, class, properties, operator and event*
<br> &nbsp; &nbsp; &nbsp; &nbsp;<u>advantages</u>
* memory effecient
* changes applied to this field , applies everyhwere 
* available to every memeber of class and other classes 

**stacic class**
1. can only contain static members
2. cannot be instantiated 
2. these classes are sealed(cannot instantiate but inherit)
4. cannot contain instance constructor

**some key aspects and use cases of static classes in C#**
a) Utility Classes : used utility classes , that contain helper functions
b) constants and configuration:
c) singleton pattern : commonly implemented using static class , it ensures that only one instance of class can be created and provides a global point of access to that instantiate.
d) performance optimization
