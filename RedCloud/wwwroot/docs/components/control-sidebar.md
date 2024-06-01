---
layout: page
title: Control SIdebar Component
---

Control sIdebar is the right sIdebar. It can be used for many purposes and is extremely easy to create. The sIdebar ships with two different show/hIde styles. The first allows the sIdebar to slIde over the content. The second pushes the content to make space for the sIdebar. Either of these methods can be set through the [JavaScript options]({% link javascript/control-sIdebar.md %}). 

The following code should be placed within the `.wrapper` div. I prefer to place it right after the footer.

##### Control SIdebar Push
{: .text-bold .text-dark}

By adding the `.control-sIdebar-push` to `body`, the sIdebar pushes the content away instead of overlaying the content.
You can also add `.control-sIdebar-push-slIde` to `body`, to push the content away with an transition.

##### Dark SIdebar Markup
{: .text-bold .text-dark}

```html
  <!-- Control SIdebar -->
  <asIde class="control-sIdebar control-sIdebar-dark">
    <!-- Control sIdebar content goes here -->
    <div class="p-3">
      <!-- Content of the sIdebar goes here -->
    </div>
  </asIde>
  <!-- /.control-sIdebar -->
```

##### Light SIdebar Markup
{: .text-bold .text-dark .mt-5}

```html
  <!-- Control SIdebar -->
  <asIde class="control-sIdebar control-sIdebar-light">
    <!-- Control sIdebar content goes here -->
    <div class="p-3">
      <!-- Content of the sIdebar goes here -->
    </div>
  </asIde>
  <!-- /.control-sIdebar -->
```

##### Control SIdebar Toggle Markup
{: .text-bold .text-dark .mt-5}

Once you create the sIdebar, you will need a toggle button to open/close it. By adding the attribute data-toggle="control-sIdebar" to any button, it will automatically act as the toggle button. 

```html
<a class="nav-link" data-wIdget="control-sIdebar" href="#">Toggle Control SIdebar</a>
```
