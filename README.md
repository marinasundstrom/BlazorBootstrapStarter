# Blazor Starter with Bootstrap SCSS

Simple Bootstrap app.

Attempt at making a modern-looking Blazor  template with Bootstrap 5.3.0. Supporting color scheme switching (Dark mode). 

Based on the Bootstrap template using Bootstrap SCSS and PostCSS. So there is a dependency on NodeJS.

![Home](/Screenshots/Home.png)

[More screenshots](/Screenshots)

## Contents
* PostCSS
* Bootstrap SCSS 
* Blazor
    * Using JS interop for Bootstrap interop.

## Requirements
* .NET 7 SDK
* NodeJS (Latest)

## Todo
* Fix bundling of font files. 
    * Copy fonts used by Bootstrap Icons from ``node_modules``.
* Make custom Blazor components and JS interop pretties.

## Notes
Currently, some of the assets used by the app have been manually copied to ``wwwroot``:
* js/bootstrap.bundle.min.js (.map)
* fonts/bootstrap-icons.woff[2]