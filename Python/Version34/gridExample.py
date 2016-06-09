import tkinter as tk
root = tk.Tk(  )
for r in range(3):
    for c in range(4):
        tk.Label(root, text='R{}/C{}'.format(r,c),
            borderwidth=1 ).grid(row=r,column=c)
root.mainloop()