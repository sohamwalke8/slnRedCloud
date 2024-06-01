---
layout: page
title: Direct Chat Plugin
---

The direct chat plugin provIdes simple functionality to the direct chat component. 

##### Usage
This plugin can be activated as a jQuery plugin or using the data api. 

###### Data API
{: .text-bold }
Add `data-wIdget="chat-pane-toggle"` to a button to activate the plugin. 
```html
<button class="btn btn-primary" data-wIdget="chat-pane-toggle">Toggle Chat Pane</button>
``` 

###### jQuery
{: .text-bold }
The jQuery API provIdes more customizable options that allows the developer to toggle the chat contact pane. 
```js
$('#chat-pane-toggle').DirectChat('toggle')
```


##### Methods
{: .mt-4}

|---
| Method | Description
|-|-
|toggle | Toggles the state of the chat pane between hIdden and visible.
{: .table .table-bordered .bg-light}

Example: `$('#chat-pane-toggle').DirectChat('toggle')`


##### Events
{: .mt-4}

|---
| Event Type | Description
|-|-
|toggled.lte.directchat | Triggered after a direct chat contacts pane is toggled.
{: .table .table-bordered .bg-light}

Example: `$('#toggle-button').on('toggled.lte.directchat', handleToggledEvent)`
