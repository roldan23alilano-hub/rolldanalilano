import tkinter as tk

root = tk.Tk()
root.title("CGP Assignment")

canvas = tk.Canvas(root, width=600, height=400, bg="lightblue")
canvas.pack()

# Road
canvas.create_rectangle(0, 300, 600, 400, fill="gray")

# Car body
canvas.create_rectangle(150, 220, 400, 280, fill="blue")

# Car top
canvas.create_polygon(200, 220, 260, 180, 340, 180, 380, 220, fill="blue")

# Wheels
canvas.create_oval(180, 260, 230, 310, fill="black")
canvas.create_oval(320, 260, 370, 310, fill="black")

# Wheel inner
canvas.create_oval(195, 275, 215, 295, fill="white")
canvas.create_oval(335, 275, 355, 295, fill="white")

# Windows
canvas.create_rectangle(270, 190, 330, 220, fill="white")

# Text
canvas.create_text(300, 350, text="Alilano Roldan Q.", font=("Arial", 16))

root.mainloop()
