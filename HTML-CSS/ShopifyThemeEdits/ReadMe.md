Inline-style: 
![alt text](https://github.com/adam-p/markdown-here/raw/master/src/common/images/icon48.png "Logo Title Text 1")

Reference-style: 
![alt text][logo]

[logo]: https://github.com/adam-p/markdown-here/raw/master/src/common/images/icon48.png "Logo Title Text 2"

```javascript
var s = "JavaScript syntax highlighting";
alert(s);
```
###Shopify Theme Edits
I wanted to make some changes to a Shopify store that I couldn't do through the built-in user interface, so I learned how to access theme code, 
learned how the liquid templating engine worked, and made some manual edits. 
___
####Objective
Make the following edits to a Shopify store by editing the code directly:
1. Center the website title/logo in the header.
2. Shrink the empty space around the title/logo.
3. Move down the gutter images on the front page so that it doesn't overlap with the front image ("hero image").
4. Add an image to the contact page. 

####Steps Taken
* Tried to make the changes through the built-in interface, but it didn't appear there was a way to do so.
* Found where the theme code was stored to make the changes manually. In the edit themes section, there's a dropdown to edit code.
* Liquid was unfamiliar to me. There are also many theme code files that are many pages long. It was not straightforward to find where the code was that I needed to change. 
The main way I did so was by right-clicking and inspecting elements of the page, to get an idea of what the code looked like and then searcing files with relevant-looking titles. 
* Centering the logo and altering other elements of the header:
    1. Tried changing the css in theme.scss.liquid file in the assets folder in a section under .site-header__logo. 
        * Horizontal aligning attempts: Added ```margin: auto;```, ```textalign: center;```, and changed float to center. 
        * To align vertically, added ```vertical-align: middle;```
        * RESULT: Only the vertical-aligning worked. 
        * By inspecting elements I discovered that the header was in a cell of a grid. 
        The structure of a grid and the horizontal alignment within it could be altered as described below.
    2. Made the following changes in the theme.liquid file, which had a format similar to html:
        * There was a grid table in for the header with 3 grid spaces in that would show up  or respond for different screen sizes, small and medium-up.
        * Centered the hamburger menu that shows up on the left for small screens or window sizes: Changed:```
        <div class="grid__item small--one-quarter medium-up--hide">``` to 
        ```<div class="grid__item small--one-quarter small--text-center medium-up--hide">```
        * To finally center the logo: Changed:```<div class="grid__item small--one-half medium-up--two-thirds small--text-center">``` to
        ```<div class="grid__item small--one-half medium-up--one medium-up--text-center small--text-center">```


  
     
        

####Results
* 

