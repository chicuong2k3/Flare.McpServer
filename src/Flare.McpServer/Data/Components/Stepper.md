# FlareStepper (Stepper)

**Category**: Navigation
**Tags**: stepper, wizard, steps, workflow, multi-step
**API Reference**: [https://jrfrigat.github.io/Flare/api/FlareStepper.html](https://jrfrigat.github.io/Flare/api/FlareStepper.html)
**Documentation**: [https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md](https://github.com/jrfrigat/Flare/blob/main/docs/en/ai-agents.md)

## Description

Stepper wizard component for multi-step processes with linear/non-linear modes.

## Parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| `ChildContent` | `RenderFragment` | Yes | `` | Step children |
| `ActiveStep` | `int` | No | `0` | Current active step index |
| `ActiveStepChanged` | `EventCallback<int>` | No | `` | Callback when step changes |
| `Linear` | `bool` | No | `true` | Force sequential step progression |
| `Color` | `FlareColor` | No | `Default` | Step indicator color |

## Sub-Components

- `FlareStep`

## Examples

```razor
<FlareStepper @bind-ActiveStep="_step" Linear="true">
    <FlareStep Title="Personal">Name and email</FlareStep>
    <FlareStep Title="Details">Address info</FlareStep>
    <FlareStep Title="Confirm">Review and submit</FlareStep>
</FlareStepper>
```

---

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
