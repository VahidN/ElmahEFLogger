ElmahEFLogger
=======
Global exceptions logger for Entity Framework 6.x using ELMAH.



Install via NuGet
-----------------
To install ElmahEFLogger, run the following command in the Package Manager Console:

```
PM> Install-Package ElmahEFLogger
```

You can also view the [package page](http://www.nuget.org/packages/ElmahEFLogger/) on NuGet.



Usage:
-----------------
Add The following line to the `Application_Start` method of the `Global.asax.cs` file:

```csharp
DbInterception.Add(new ElmahEfInterceptor());
```


**Screenshots:**

![ElmahEFLogger](https://raw.githubusercontent.com/VahidN/ElmahEFLogger/master/Images/elmahef01.png)
![ElmahEFLogger](https://raw.githubusercontent.com/VahidN/ElmahEFLogger/master/Images/elmahef02.png)
