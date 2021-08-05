
# Layouts

User defines a layout to organize GUI elements, so a layout is container for child elements. Layout drawing is done in a two step way.

1. User defines a layout, tells the runtime the rules how to adjust several GUI controls.
2. Runtime interprets the layout definition and tries to arrange the controls based on the layout definition.


# Layout types

## Stackpanel

Layout takes care about stack controls in stack-like manner. A Stackpanel can stack the controls vertically or horizontally.

The size of the child elements can be adjusted via the `Orientation`-Attribut.

```
<StackpPanel>
    <Button Content="Button1"/>
    <Button Content="Button2"/>
    <Button Content="Button3"/>
    <Button Content="Button4"/>
</StackpPanel>
```