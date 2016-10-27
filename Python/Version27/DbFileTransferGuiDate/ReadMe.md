
drillP67 moves text files from one folder to another if they have been modified within 24 hours. The source and destination folders must be selected by editing lines in the program. It utilizes the shutil package. 
I learned that, even though os package commands will display file paths with backslashes in output, when you input a file path, Python still interprets "\" as "ignore the next character", 
so it will truncate your path. To fix this, you can separate with two backslashes or any forward slashes.
</br></br>
drillP68dbftGui builds off drillP67 by including a wx GUI that allows users to select the source and destination directories with a mouse.
</br></br>
drillP69dbftGuiDate builds off the above two drills by displaying the date and time of the last check in the GUI. 
It does this by storing the dates and times of each check in a database, using sqlite, and displaying the latest entry.
At first I tried to get the time to update immediately after a check by setting the the wx panel to refresh after clicking the check button. The panel has a command to show the last time checked from the database. This didn't work out though. Ultimately a mentor suggested just overwriting the timestamp when the button is clicked.
