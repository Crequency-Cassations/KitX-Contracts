# About

This repo contains contracts projects for `KitX Project`.

# Usage

## KitX.Contract.CSharp

### Install

```shell
dotnet add package KitX.Contract.CSharp
```

### Use

Define two classes, `Identity.cs` and `Controller` for example, and inherited from `IIdentityInterface` and `IController`.

```csharp
using KitX.Contract.CSharp;

public class Identity : IIdentityInterface
...
```

```csharp
using KitX.Contract.CSharp;

public class Controller : IController
...
```

Then realize all methods.

