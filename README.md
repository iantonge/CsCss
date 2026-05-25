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
        [From] = new()
        {
            [Color] = Red
        },
        [50.Percent()] = new()
        {
            [Color] = Blue
        },
        [To] = new()
        {
            [Color] = Red
        }
    }
};
```

Media rules use a typed `MediaQuery` API rather than raw strings:

```csharp
Document document = new()
{
    [Media, MediaQuery.Width >= 768.Px()] = new()
    {
        [".card"] = new()
        {
            [Height] = 20.Px()
        }
    }
};
```

Broader media query grammar, descriptor rules such as `@font-face`, `@layer`, `@supports`, `@container`, and raw escape hatches are not implemented yet.
