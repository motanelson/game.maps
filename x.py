import tkinter as tk





class myapps:
    def __init__(self,root:tk.Tk):
        self.root=root
        self.root.title("x")
        self.root.geometry("640x480")
        self.root.configure(background="black")
        self.label=tk.Label(background="black",foreground="white",text="click me")
        self.label.pack(padx=10,pady=10)
        self.canvas1=tk.Canvas(background="black",width=50,height=50)
        self.canvas1.pack(padx=10,pady=10)
        self.c1=self.canvas1.create_line(0,0,50,50,fill="white")
        self.c2=self.canvas1.create_line(50,0,0,50,fill="white")
        self.canvas1.bind("<Button-1>",self.clicks)
    def clicks(self,event):
        if self.c1!=None:
            self.canvas1.delete(self.c1)
            self.canvas1.delete(self.c2)
            self.c1=None
            self.c1=None
        else:
            self.c1=self.canvas1.create_line(0,0,50,50,fill="white")
            self.c2=self.canvas1.create_line(50,0,0,50,fill="white")





root = tk.Tk()
apps=myapps(root)
root.mainloop()