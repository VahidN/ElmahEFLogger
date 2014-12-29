ElmahEFLogger
=======
Global exceptions logger for Entity Framework 6.x using ELMAH.


**Usage:**

Add The following line to the `Application_Start` method of the `Global.asax.cs` file:

```csharp
DbInterception.Add(new ElmahEfInterceptor());
```


**Screenshots:**

![ElmahEFLogger](https://raw.githubusercontent.com/VahidN/ElmahEFLogger/Images/elmahef01.png)
![ElmahEFLogger](https://raw.githubusercontent.com/VahidN/ElmahEFLogger/Images/elmahef02.png)
