The drills here are assignments from The Tech Academy. 
</br></br>
drill40 is an assignment in sqlite where I created and queried a database of aliens and people in Python. The assignment questions are commented within the document. 
</br></br>
drillp65datetime is an exercise in using the time and datetime packages. The program displays when a fictional store chain was open in different cities throughout the world based on the actual times there.
</br></br>
drillP67 moves text files from one folder to another if they have been modified within 24 hours. The source and sestination folders must be selected by editing lines in the program. It utilized the shutil package. 
I learned that, even though os package commands will display file paths with backslashes in output, when you input a file path, Python still interprets "\" as "ignore the next character", 
so it will truncate your path. To fix this, you can separate with two backslashes "\\" or forward slash(es) "/".
</br></br>
drillP68dbftGui builds off drillP67 by including a wx GUI that allows users to select the source and destination directories with a mouse.
</br></br>
drillP69dbftGuiDate builds off the above two drills by displaying the date and time of the last check in the GUI. 
It does this by storing the dates and times of each check in a database, using sqlite, and displaying the latest entry.
At first I tried to get the time to update by refreshing the wx panel after a check, but it didn't work out. 
Ultimately a mentor suggested just setting the timestamp again.
