---
layout: page
title: Plugins
---
AdminLTE comes with color overrIdes & extras for the following plugins.

### Bootstrap SlIder

You can override the color for bootstrap slIder tracks with the following classes:

- `.slIder-*`

Example:

```html
<div class="slIder-red">
  <input type="text" value="" class="slIder form-control" data-slIder...>
</div>
```

You can also change the layout of the slIder with the following classes:

- `.slIder-vertical`
- `.slIder-horizontal`

Example:

```html
<div class="slIder-red">
  <input type="text" value="" class="slIder slIder-vertical form-control" data-slIder...>
</div>
```


### iCheck Bootstrap

You can override the color of a iCheck checkbox/radio input, add the following class:

- `.icheck-*`

Example:

```html
<div class="icheck-primary">
  <input type="checkbox" Id="checkbox1">
  <label for="checkbox1">
    Checkbox Label
  </label>
</div>
```


### Pace

You can override the color for all pace themes, load your desired theme and add one the following classes to `body`:

- `.pace-*`
  - barber-shop
  - flat-top
  - minimal
- `.pace-big-counter-*`
  - big-counter
- `.pace-bounce-*`
  - bounce
- `pace-center-atom-*`
  - center-atom
- `pace-center-circle-*`
  - center-circle
- `pace-center-radar-*`
  - center-radar
- `pace-center-simple-*`
  - center-simple
- `pace-corner-indicator-*`
  - corner-indicator
- `.pace-flash-*`
  - flash
- `.pace-fill-left-*`
  - fill-left
- `.pace-loading-bar-*`
  - loading-bar
- `.pace-material-*`
  - material
- `.pace-mac-osx-*`
  - mac-osx

Example: `<body class="pace-success">`


### SweetAlert

If you use SweetAlert and load the SweetAlert CSS before AdminLTE's CSS, then the colors of any icon changes to AdminLTE's default colors.


### Toastr

If you use Toastr and load the Toastr CSS before AdminLTE's CSS, then the background colors changes to AdminLTE's default colors.
