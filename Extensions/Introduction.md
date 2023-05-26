# Introduction

The namespace `BRIDGES.McNeel.Rhino.Extensions` contains methods to convert and cast types between `BRIDGES` and `RhinoCommon`. 

## Difference between *CastTo* and *ConvertTo*

In this section some "translation" methods will be named *CastTo* and *ConvertTo*. Their is a semantic difference between the two:
- **CastTo** : It expresses the fact that the "translation" is reciprocal, that no information is lost in the process. Considering the example below, *a* and *aFromCast* will be (programmatically) equal, thus the methods will return the same results.
- **ConvertTo** : It expresses the fact that the "translation" may not produce equal but only equivalent objects. Information may be lost or transformed during the conversion. Considering the example below, *a* and *aFromConversion* may not be programmatically equal, because some properties or the order of elements may have changed. For example, if the object represent geometrical elements, *a* and *aFromConversion* represent the same geometry but in different ways, with a different parametrisation.


```c#
A a = new A();

a.CastTo(out B b);
b.CastTo(out A aFromCast);

a.ConvertTo(out C c);
c.ConvertTo(out A aFromConversion);

a.Equals(aFromCast);          // Return true
b.Equals(aFromConversion);    // Can return true or false

```