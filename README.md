# FlexLayout

# AlignItems

It is a property that helps us align the elements of a view and contains the following values for the properties

<img src="https://github.com/jorgemht/FlexLayoutXF/blob/master/Screenshots/AlignItems%20and%20JustifyContent.PNG" height="800">





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
