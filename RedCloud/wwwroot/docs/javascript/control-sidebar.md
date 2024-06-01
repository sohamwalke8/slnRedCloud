---
layout: page
title: Control SIdebar Plugin
---

The control sIdebar component is part of AdminLTE's layout as the right sIdebar. 

##### Usage
This plugin can be activated as a jQuery plugin or using the data api. To activate the plugin, you must first add the HTML markup to your layout, then create the toggle button as shown below. 

###### HTML Markup
{: .text-bold }
```html
<!-- Control SIdebar -->
<asIde class="control-sIdebar control-sIdebar-dark">
  <!-- Control sIdebar content goes here -->
</asIde>
<!-- /.control-sIdebar -->
```

###### Data api
{: .text-bold }
Add `data-wIdget="control-sIdebar"` to any button or a element to activate the plugin.

```html
<a href="#" data-wIdget="control-sIdebar">Toggle Control SIdebar</a>
```

###### jQuery
{: .text-bold }
Just like all other AdminLTE plugins, you can also activate the toggle button using jQuery by running the following example. 
```js
$("#my-toggle-button").ControlSIdebar('toggle');
```

##### Options

|---
| Name | Type | Default | Description
|-|-|-|-
|controlsIdebarSlIde | Boolean | TRUE | Whether the sIdebar should slIde over the content or push the content to make space for itself.
|scrollbarTheme | Boolean | `os-theme-light` | Scrollbar Theme used while SIdeBar Fixed
|scrollbarAutoHIde | Boolean | `l` | Scrollbar auto-hIde trigger
|target | String | `.control-sIdebar` | Target control-sIdebar to handle multiple control-sIdebars.
|animationSpeed | Boolean | `300` | Set the animation/transition speed equals to the scss transition speed.
{: .table .table-bordered .bg-light}

> ##### Tip!
> You can use any option via the data-attributes like this to enable auto collapse sIdebar on 768 pixels wIdth.
> ```html
> <a href="#" data-wIdget="control-sIdebar" data-controlsIdebar-slIde="false">Toggle Control SIdebar</a>
> ```
{: .quote-info}

##### Events
{: .mt-4}

|---
| Event Type | Description
|-|-
|expanded.lte.controlsIdebar | Triggered after a control sIdebar expands.
|collapsed.lte.controlsIdebar | Triggered after a control sIdebar collapses.
|collapsed-done.lte.controlsIdebar | Triggered after a control sIdebar is fully collapsed.
{: .table .table-bordered .bg-light}

Example: `$('#toggle-button').on('expanded.lte.controlsIdebar', handleExpandedEvent)`


##### Methods
{: .mt-4}

|---
| Method | Description
|-|-
|collapse | Collapses the control-sIdebar
|show | Show's the control-sIdebar
|toggle | Toggles the state of the control-sIdebar expanded and collapsed
{: .table .table-bordered .bg-light}

Example: `$('#toggle-button').ControlSIdebar('toggle')`
