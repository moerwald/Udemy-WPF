
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

## Wrappanel

More or less the same as StackPanel. Difference: WrapPanel uses as much space as the content needs, the StackPanel usually streches the content.

## Dockpanel

Allows to dock childelements to certain directions. Directions are:
- Top
- Bottom
- Left 
- Right

Per default DockPanel streches the last added child over the complete Layout. The deactivate it use  `LastChildFill="false"`.

Example:

```
        <DockPanel Margin="10" Background="Yellow" LastChildFill="false">
            <Button DockPanel.Dock="Bottom" 
                    Margin="5">Bottom</Button>
            <Button DockPanel.Dock="Top" 
                    Margin="5">Top</Button>
            <Button DockPanel.Dock="Left" 
                    Margin="5">Left</Button>
            <Button DockPanel.Dock="Right" 
                    Margin="5">Right</Button>
            <Button DockPanel.Dock="Bottom" 
                    Margin="5">Right</Button>
            <Button DockPanel.Dock="Bottom" 
                    Margin="5">Right</Button>
            <Button DockPanel.Dock="Bottom" 
                    Margin="5">Right</Button>
        </DockPanel>

```

---
**NOTE**
 The order of docking is important. First docked element uses most of the area! 
---

# Margin/Padding

- Padding: Space INSIDE an element
- Maring: Space AROUND an element