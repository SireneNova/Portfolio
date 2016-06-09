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
    #precursor to display entries in database
    conn = sqlite3.connect('entries.db')
    cursor = conn.execute("SELECT theEntry FROM entrytable")
    words = cursor.fetchall()
    conn.commit()

    #make dialogue that displays entries as selections
    savedEntry = tk.StringVar()
    combobox = tk.ttk.Combobox(root, textvariable = savedEntry) #box with selections and down arrow
    combobox.pack()
    combobox.config(values = (words))
    print(savedEntry.get())

    ##for loop that displays entries in grid in gui
    #for word in words:
    #    count=0
    #    tk.ttk.Label(root, text = word).grid(row = count, column = 0, columnspan = 2, sticky = 'nsew')
    #    count+=1


selectButton.config(command = callSelectButton)

root.mainloop()