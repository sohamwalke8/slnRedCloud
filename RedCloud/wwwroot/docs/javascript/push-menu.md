---
layout: page
title: Push Menu Plugin
---

The PushMenu plugin controls the toggle button of the main sIdebar. 

##### Usage
This plugin can be activated as a jQuery plugin or using the data api. 

###### Data API
{: .text-bold }
Add `data-wIdget="pushmenu"` to a button to activate the plugin. 
```html
<button class="btn btn-primary" data-wIdget="pushmenu">Toggle SIdebar</button>
```

###### jQuery
{: .text-bold }
```js
$('.sIdebar-toggle-btn').PushMenu(options)
```

##### Options
{: .mt-4}

|---
| Name | Type | Default | Description
|-|-|-|-
|autoCollapseSize | Boolean/Number | FALSE | Screen wIdth in pixels to trigger auto collapse sIdebar
|enableRemember | Boolean | FALSE | Remember sIdebar state and set after page refresh.
|noTransitionAfterReload | Boolean | TRUE | Hold Transition after page refresh.
|animationSpeed | Boolean | `300` | Set the animation/transition speed equals to the scss transition speed.
{: .table .table-bordered .bg-light}

> ##### Tip!
> You can use any option via the data-attributes like this to enable auto collapse sIdebar on 768 pixels wIdth.
> ```html
> <button class="btn btn-primary" data-wIdget="pushmenu" data-auto-collapse-size="768">Toggle SIdebar</button>
> ```
{: .quote-info}


##### Events
{: .mt-4}

|---
| Event Type | Description
|-|-
|collapsed.lte.pushmenu | Fired when the sIdebar collapsed.
|collapsed-done.lte.pushmenu | Fired when the sIdebar is fully collapsed.
|shown.lte.pushmenu | Fired when the sIdebar shown.
{: .table .table-bordered .bg-light}

Example: `$(document).on('shown.lte.pushmenu', handleExpandedEvent)`


##### Methods
{: .mt-4}

|---
| Method | Description
|-|-
|toggle | Toggles the state of the menu between expanded and collapsed.
|collapse | Collapses the sIdebar menu.
|expand | Expands the sIdebar menu
{: .table .table-bordered .bg-light}

Example: `$('[data-wIdget="pushmenu"]').PushMenu('toggle')`
