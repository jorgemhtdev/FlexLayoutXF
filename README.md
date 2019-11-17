# FlexLayout

To see the examples, [download](https://github.com/jorgemht/FlexLayoutXF/archive/master.zip) the repository and run it! Inside the repository you have a tab view with all the examples explained below. Also in the last tab you have some examples of how to apply it, such as a login.

## Direction

Possibly the most important property is direction, that property contains the following values

- **Row:** Distribute the elements horizontally. From left to right. **main-axis**  **(Default value)**
- **RowReverse:** The same as the previous one, but distributes the elements from right to left
- **Column:** We distribute the elements inside the container in a stack form, from top to bottom. **cross-axis**
- **ColumnReverse:** Same as above, but distribute the items from bottom to top.

<img src="https://github.com/jorgemht/FlexLayoutXF/blob/master/Screenshots/Direction.PNG" height="80">

## Wrap

Indicate if the container adapts to be able to container all the child elements or not

- **NoWrap:** All your elements in the same line.  **(Default value)**
- **Wrap:** Elements in multiple lines from top to bottom.
- **Reverse:** Elements in multiple lines from bottom to top.

<img src="https://github.com/jorgemht/FlexLayoutXF/blob/master/Screenshots/Wrap.PNG" height="400">

## AlignItems

It is a property that helps us align the elements of a view. The AlignItems contains the following values for the properties:

- Center
- End
- Start
- **Stretch (By default)**

## JustifyContent

Define how the elements are organized on the main axis. The JustifyContent contains the following values for the properties:

- **Start (By default)**
- Center
- End
- SpaceAround
- SpaceBetween
- SpaceEvenly

<img src="https://github.com/jorgemht/FlexLayoutXF/blob/master/Screenshots/AlignItems%20and%20JustifyContent.PNG" height="800">

### The example of AlignItems and JustifyContent

By executing the application we can see how AlignItems does its job, the Center value aligns all the elements to the center of the container, End helps us to position the elements inside the container from right to left, Start does the opposite, Stretch gives the functionality to extend the whole element so that it fits the screen.

If you add the following property to each FlexLayout you will see better how the elements in the container are aligned correctly:

BackgroundColor="AntiqueWhite"

```
        <FlexLayout Direction="Column">
            <FlexLayout
                AlignItems="Center"
                Direction="Column"
                FlexLayout.Grow="1"
                JustifyContent="Center">
                <Label BackgroundColor="Chocolate" Text="AlignItems Center y JustifyContent Center" />
            </FlexLayout>
            <FlexLayout
                AlignItems="End"
                Direction="Column"
                FlexLayout.Grow="1"
                JustifyContent="End">
                <Label BackgroundColor="Khaki" Text="AlignItems End JustifyContent End" />
            </FlexLayout>
            <FlexLayout
                AlignItems="Start"
                Direction="Column"
                FlexLayout.Grow="1"
                JustifyContent="Start">
                <Label BackgroundColor="LightPink" Text="AlignItems Start JustifyContent Start" />
            </FlexLayout>
            <FlexLayout
                AlignItems="Stretch"
                Direction="Column"
                FlexLayout.Grow="1"
                JustifyContent="End">
                <Label BackgroundColor="Brown" Text="AlignItems Stretch and JustifyContent End" />
            </FlexLayout>
        </FlexLayout>
```

## Properties of each item

Not only can we change the behavior of the Layout with its main properties, we can also adapt different options using properties of each element.

### FlexLayout.Grow

The FlexLayout.Grow property helps us ensure that our elements occupy the entire screen of the device and that it adjusts to the quantity of elements. This property receives values greater than 0 to indicate that the item will fit the screen size

<img src="https://github.com/jorgemht/FlexLayoutXF/blob/master/Screenshots/Grow.PNG" height="80">

### FlexLayout.Basis

One of the properties that I think is very important is FlexLayout.Basis. This property allows us to maintain a default space for a container, then the following code:

<img src="https://github.com/jorgemht/FlexLayoutXF/blob/master/Screenshots/Basis.PNG" height="80">
