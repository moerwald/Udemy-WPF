
# XAML Namespace

A XAML namespace creates a link to include other .NET namespaces.
Based on the given XAML namespace the compiler knows which objects shall be created.


# XAML and Codebehind

The linke between XAML and codebehind is created via the `xmlns:x` namespace construct.

- `x:Class` : Binds the XAML markup with code behind. Example `<Window x:Class="Sample.MainWindow">

- `x:Name` : Attribut allowing the refer to the XAML element in code behind.

# XAML Type Converter

Attribute values of a XAML object are always `strings`. These attributes are converted to the specialized data type.

```
<Button Width="140" Background="Green">
Click Me!
</Button>
```

`Background` is converted to type `Brush` via a type converter!


# XAML Markup Extensions

- Markup extensions are able to assign a value to an attribute which is not a XAML nor a primitive data type.
- With markup extensions an attribute of an .NET object can by bound to XAML during runtime.
- In comparison to type converters we can assign a value to an ALREADY EXISTING .NET object.

Markup extension need to inherit from `MarkupExentsion`. We need to implement `ProvideValue()` which is bound to XAML.

```
<StackPanel>
    <Button Content="{Binding ElementName=slider_test, Path=Value}">
    <Slider x:Name="slider_test" Value="0">
</StackPanel>
```

Here `Binding` is an already existing markup extension. `Binding` allows to bind the Button content to the slider value.

## Popular Markup Extensions (include in x:Namespace)

- x:Static: Allows us to refer to static variables, attributes and consts of classes.
- x:Null: Allows to null an attribute.
- x:Type: Equivalent to `typeof`
- x:Reference: Creates an object reference to another XAML object, which has a set `x:Name` attribute.

