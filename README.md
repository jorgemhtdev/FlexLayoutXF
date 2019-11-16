# FlexLayout

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
