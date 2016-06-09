import tkinter as tk
from tkinter import ttk 
import sqlite3

conn = sqlite3.connect('entries.db')
cursor = conn.execute("SELECT theEntry FROM entrytable")
words = cursor.fetchall()
conn.commit()
print(words)

root = tk.Tk()

#Select Old Entries
selectButton = tk.ttk.Button(root, text = "Select Previous Entries")
selectButton.pack()

def callSelectButton():
    window2 = tk.Toplevel(root)
    window2.title('Select Previous Entry')
    #window.focus_set()

    #precursor to display entries in database
    conn = sqlite3.connect('entries.db')
    cursor = conn.execute("SELECT theEntry FROM entrytable")
    words = cursor.fetchall()
    conn.commit()


    #for loop that displays entries in grid in gui
    count=0
    for word in words:
        entryLabel=tk.ttk.Label(window2, text = word)
        entryLabel.grid(row = count, column = 0, columnspan = 2, sticky = 'nsew')
        global _text
        entryLabel.bind('<ButtonPress>', _event)
        #print(entryLabel)
        count+=1

def _event:


    ##make dialogue that displays entries as selections
    #savedEntry = tk.StringVar()
    #combobox = tk.ttk.Combobox(root, textvariable = savedEntry) #box with selections and down arrow
    #combobox.pack()
    #combobox.config(values = (words))
    #print(savedEntry.get())

selectButton.config(command = callSelectButton)

root.mainloop()