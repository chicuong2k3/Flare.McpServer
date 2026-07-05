# FlareStepper API

> Inherits `FlareComponentBase`  
> Source: [FlareStepper.razor](https://github.com/jrfrigat/Flare/blob/main/src/Flare.Components/Stepper/FlareStepper.razor)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `ChildContent` | `RenderFragment?` | — | `FlareStep` children. |
| `ActiveIndex` | `int` | 0 | Current step. `@bind-ActiveIndex`. |
| `Orientation` | `StepperOrientation` | `Horizontal` | Horizontal or Vertical. |
| `OnStepChanging` | `EventCallback<StepperChange>` | — | Guard: set Cancel to veto step change. |

## Sub-component: FlareStep

| Name | Type | Description |
|------|------|-------------|
| `Title` | `string` | Step label. |
| `Icon` | `string?` | Optional icon. |
| `ChildContent` | `RenderFragment?` | Step body content. |
| `Optional` | `bool` | Mark as optional. |

```razor
<FlareStepper @bind-ActiveIndex="_step">
    <FlareStep Title="Details" Icon="person">Name and email fields</FlareStep>
    <FlareStep Title="Confirm" Icon="check">Review and submit</FlareStep>
</FlareStepper>
```
