# ⚒️ Runedur

**A build-time ORM that inscribes native C# code — like you'd write it yourself. Only better.**

> _“The code you would’ve written by hand — only better.”_  
> — **Runedur, Smith of Native Flame**

![Runedur logo](logo.png)


## 📜 Why “Runedur”?

**Runedur** is named after a mythical dwarven codewright — a silent master of the forge who engraves native code into stone, then vanishes before the fire cools.

Like its namesake, this ORM:

- exists only at **build time** using Roslyn Source Generators,
- leaves **no runtime reflection** or hidden magic,
- produces **clean, native C# code** — fast, predictable, and fully type-safe.

It doesn't *act like* part of your codebase — it **becomes** your codebase.


## ⚒️ Features

- 🪶 **Zero runtime overhead**  
- 🧠 **Full IDE support** – your generated types feel like hand-written C#
- 🔍 **No reflection** – everything is compile-time
- 🧱 **Simple model annotations**
- ⚙️ **Roslyn-powered** – extendable and fast


## 🧪 Quick Example

Define your model:

```csharp
[RunedurEntity]
public class HeroicSword
{
    public required string Name { get; set; }
    public int Strength { get; set; }
}
```

Runedur will generate classes that help you work with the entity. The patterns will vary depending on the database type. For `postgres`/`timescaledb` it will generate code for patterns like the following:

```csharp
// TODO
```

No runtime cost. No surprises. Just clean code, forged for you.

## 📦 Installation

Coming soon via NuGet!

For now, to test locally:

1. Clone this repository.
2. Add a project reference to `Runedur.Generator` as an **analyzer**.
3. Add `[RunedurEntity]` to your data models to help Runedur find them.
4. Build — and let the forge do its work.



## 📁 Project Structure

```
// TODO
```



## 🌄 Roadmap

- [ ] Generate the `RunedurEntity` attribute
- [ ] Add a generator for `postgres`/`timescaledb`
- [ ] Release as a nuget package



## 🧙 About the Smith

> _“He does not walk with heroes. He prepares them.”_

Runedur is more than a utility — it is an ethos: **build tools that vanish at runtime, but leave behind code as strong as dwarven steel.**  
You may never see the smith again… but you’ll wield his work.

[Read the legend →](lore.md)



## 📖 License

MIT — freely forge, remix, and improve. Just don’t forget the rune.


## 🔗 Links

- [GitHub Repository](https://github.com/pingvinen/runedur-orm)
- [Source Generators Overview (Microsoft Docs)](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview)
