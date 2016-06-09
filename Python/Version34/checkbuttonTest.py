from tkinter import *

#master = Tk()

#var = BooleanVar()


#c = Checkbutton(master, text="Press me", variable=var, command=cb)
#c.pack()

#def cb():
#    print("variable is {}".format(text.get()))

#mainloop()

root = Tk()

global j
j = []

x = ['hello', 'this', 'is', 'a', 'list']

def chkbox_checked(text):
    return lambda : j.append(text)

for i in x:
    c = Checkbutton(root, text=i, command=chkbox_checked(i))
    c.grid(sticky=W)

mainloop()

print(j)




