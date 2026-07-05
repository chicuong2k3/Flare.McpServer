# Flare - Component Code Conventions

A single code style for **all** components. The canonical reference is **`FlareButton`**.

---

## 1. CSS architecture - one global bundle

CSS lives in `wwwroot/css/` (a global bundle), NOT in scoped `*.razor.css`.

- One component (or a related group) = one CSS file in `wwwroot/css/`
- Import via `flare-components.css`
- Theme-specific tweaks go in `src/Flare.Theme.*/wwwroot/css/components/*.css`

---

## 2. Tokens - through the token system

No hardcoded values in CSS - only `var(--flare-*)`.

### Full path for adding a component token

| What | Where |
|------|-------|
| Token values (per-theme) | `src/Flare.Abstractions/Tokens/Components/<Comp>Tokens.cs` |
| CSS variable names | `src/Flare.Abstractions/Css/Tokens/<Comp>Tokens.cs` |
| Variable emission | `src/Flare.Theming/Services/CssVarMap.cs` |
| MD3 values | `src/Flare.Theme.MaterialDesign3Expressive/MaterialDesignTokens.cs` |
| Fluent values | `src/Flare.Theme.FluentUI2/FluentUI2Tokens.cs` |
| CSS classes | `src/Flare.Abstractions/Css/Classes/<Comp>.cs` |

Two token systems linked by `[CssVar]` attribute: variable NAME constants in `Css/Tokens/*`, per-theme VALUES in `Tokens/*`.

### One color system - `FlareColor`

Any public color-choice parameter is **only** `FlareColor` (one name: `Color`). No separate color enums.

`FlareColor` holds either a semantic role or a custom CSS string. Roles map to cached `flare-color-{role}` classes; custom values produce inline `--fc-*` CSS variables.

Local role variables: `--fc-main`, `--fc-on`, `--fc-container`, `--fc-on-container`.

---

## 3. Minimal JS

- Effects (ripple, shape morphing, animations) done with CSS only
- Do not use JS for animations

---

## 4. XML documentation

- Mandatory on every public type, `[Parameter]`, method, and enum
- Minimum: `<summary>` on every public member
- Feeds the auto-generated API site

---

## 5. Other

- Build and tests must pass; verify visually in `Flare.Gallery`
- Remove stale code (dead enums/classes)

---

_Source: https://jrfrigat.github.io/Flare/docs/en/component-conventions.html_
