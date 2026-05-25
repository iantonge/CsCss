# CsCss

Pronounced "Scissors", CsCss is an ill-conceived library for writing CSS with C#.

```csharp
Document document = new()
{
    [".my-class"] = new()
    {
        [Height] = 10.Px(),
        [Color] = Red
    }
};
```

```css
.my-class {
    height: 10px;
    color: red;
}
```

## At-rules

Keyframes are defined with the `Keyframes` at-rule token and keyframe selectors:

```csharp
Document document = new()
{
    [Keyframes, "fade-in"] = new()
    {
        [Keyframes.From] = new()
        {
            [Color] = Red
        },
        [50.Percent()] = new()
        {
            [Color] = Blue
        },
        [Keyframes.To] = new()
        {
            [Color] = Red
        }
    }
};
```

Media rules use a typed `MediaQuery` API rather than raw strings:

```csharp
using CsCss.AtRules.Media;

Document document = new()
{
    [Media, Media.Width >= 768.Px()] = new()
    {
        [".card"] = new()
        {
            [Height] = 20.Px()
        }
    }
};
```

Media queries can also be composed:

```csharp
[Media, Media.Screen & Media.Width.Between(768.Px(), 1200.Px()) & Media.Hovered] = new()
{
    [".card"] = new()
    {
        [Height] = 20.Px()
    }
}
```

Font faces use descriptor tokens scoped to `FontFace`:

```csharp
Document document = new()
{
    [FontFace] = new()
    {
        [FontFace.Family] = "Inter",
        [FontFace.Src] = FontFace.Url(Url("/fonts/inter.woff2")).Format("woff2"),
        [FontFace.Weight] = (100, 900),
        [FontFace.Display] = FontFace.Swap
    }
};
```

Registered custom properties use descriptor tokens and syntax helpers scoped to `Property`:

```csharp
Document document = new()
{
    [Property, "--brand-color"] = new()
    {
        [Property.Syntax] = Property.Color,
        [Property.Inherits] = false,
        [Property.InitialValue] = Red
    }
};
```

Imports are document-only and must appear before all non-import rules:

```csharp
Document document = new()
{
    [Import] = Import.Url(Url("/reset.css")),
    [Import] = Import.Url(Url("/theme.css")).Layer("theme"),
    [Import] = Import.Url(Url("/wide.css")).Media(Media.Width >= 768.Px()),
    [".card"] = new()
    {
        [Color] = Red
    }
};
```

Supports rules use typed declaration conditions:

```csharp
Document document = new()
{
    [Supports, Supports.Declaration(new()
    {
        [Color] = Red
    })] = new()
    {
        [".card"] = new()
        {
            [Height] = 10.Px()
        }
    }
};
```

Broader media query grammar, `@layer`, `@container`, `@charset`, and raw escape hatches are not implemented.
