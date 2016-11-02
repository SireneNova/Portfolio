##Python - Version34
___

The work here was made for assignments from The Tech Academy.


### Range Drill
---
46-RangeDrill is an exercise in the range function. The questions, commented throughout the file, ask to display specific ranges, and the code that achieves it follows each. What can be confusing at first about forward-stepping ranges is that the endpoint is always counted from a start of 0, so the range ends at a number behind the specified endpoint. Similar logic applies to backward-stepping ranges, only counting down. This can also be confusing. The starting point is displayed as specified, and the range ends at a number larger than the specified endpoint.

### Spring Game
---
50-SpringGame is a story-driven Python game. It contains various while loops, if functions, and input functions. The conditional functions are designed to give points (Easter Eggs) for correct answers to riddles. I learned that pressing enter is enough input to move an input function to the next function, so these are aligned to move the story along. It was March when I made it, so I themed it after the month's holidays. Sources for 2 riddles and a comedic Irish dialect translator are listed below: </br>
http://www.primarygames.com/holidays/easter/jokes.php </br>
http://www.bethanyroberts.com/EasterJokesAndRiddles.htm </br>
http://www.whoohoo.co.uk/irish-translator.asp

### Web Page Drills
---
P70Drill-webPage generates an HTML page when executed.

P71Drill-webPageGUI  builds off the last drill. It creates a web page based on text the user enters into an entry box in a GUI. Tkinter is the GUI package used.

P73Drill-webPageGUIdb builds off the last drill. It has options to either create a new page with entered text or to to select from previous text entered to create the page. The data is stored using sqlite, and selections are displayed as checkboxes. Also, the entry box has been replaced with a text box so that the height could be adjusted to create more room to view input text. With a textbox, the "get" function now requires arguments to determine how much text to retrieve. It doesn't automatically retrieve all text, like with the entry box. 

### GUI Drill
---
P71Drill-dbftGuiDate is functionally the same as drillP69dbftGuiDate in the [Version 2.7 folder]. </br>
The only difference is that all print functions have parentheses around them because it is formatted for Version 3.4.
[Version 2.7 folder]: https://github.com/rebeccapizano/Portfolio/tree/master/Python/Version27/DbFileTransferGuiDate
