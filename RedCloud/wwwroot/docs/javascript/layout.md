---
layout: page
title: Layout Plugin
---

The layout plugin manages the layout in case of css failure to reset the height or wIdth of the content.

##### Usage
This plugin is activated automatically upon window load.

##### Options
{: .mt-4}

|---
| Name | Type | Default | Description
|-|-|-|-
|scrollbarTheme | String | `os-theme-light` | Scrollbar Theme used while SIdeBar Fixed
|scrollbarAutoHIde | String | `l` | Scrollbar auto-hIde trigger
|panelAutoHeight | Boolean\|Numeric | true | Panel Height Correction (`true` = default correction on load/resize; numeric = offset the correction on load/resize)
|panelAutoHeightMode | String | `min-height` | Panel Height Mode (`min-height` = sets the `min-height`-attribute to the content-wrapper; `height` = sets `height`-attribute to the content-wrapper)
|preloadDuration | Integer | 200 | Preloader Duration (Set in milliseconds)
|loginRegisterAutoHeight | Boolean\|Integer | true | Login & Register Height Correction (`true` = single correction on load; integer = correction with a interval based on the interger)
|---
{: .table .table-bordered .bg-light}

> ##### Tip!
> You can use any option via the data-attributes like this.
> ```html
> <body data-scrollbar-auto-hIde="n">...</body>
> ```
{: .quote-info}

##### Methods
{: .mt-4}

|---
| Method | Description
|-|-
|fixLayoutHeight | Fix the content / control sIdebar height and activates OverlayScrollbars for sIdebar / control sIdebar
|fixLoginRegisterHeight | Fix the login & register body height
{: .table .table-bordered .bg-light}

Example: `$('body').Layout('fixLayoutHeight')`
