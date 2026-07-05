# FlareStepper

Multi-step wizard with linear/non-linear progression.

```razor
<FlareStepper @bind-ActiveStep="_step" Linear="true">
    <FlareStep Title="Personal">Name and email</FlareStep>
    <FlareStep Title="Details">Address info</FlareStep>
    <FlareStep Title="Confirm">Review and submit</FlareStep>
</FlareStepper>
```

## Key Parameters
- `ActiveStep` / `@bind-ActiveStep` - current step index
- `Linear` - force sequential progression
- `Color` - `FlareColor` for step indicators
