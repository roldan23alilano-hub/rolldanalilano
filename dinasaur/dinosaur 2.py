import tkinter as tk
import winsound
import random

WIDTH = 850
HEIGHT = 300
GROUND = 235

root = tk.Tk()
root.title("Dinosaur.py")
root.resizable(False, False)

canvas = tk.Canvas(root, width=WIDTH, height=HEIGHT, bg="white")
canvas.pack()

running = True
jumping = False
jump_speed = 0
score = 0
walk = 0

clouds = []  # ☁️ cloud list


# ---------------- SOUND ----------------
def sound_jump():
    winsound.Beep(900, 80)


def sound_game_over():
    winsound.Beep(200, 600)


# ---------------- CLOUDS ----------------
def create_cloud():
    x = random.randint(0, WIDTH)
    y = random.randint(20, 100)

    cloud = [
        canvas.create_oval(x, y, x+40, y+25, fill="lightgray", outline=""),
        canvas.create_oval(x+20, y-10, x+60, y+25, fill="lightgray", outline=""),
        canvas.create_oval(x+40, y, x+80, y+25, fill="lightgray", outline="")
    ]

    clouds.append(cloud)


def move_clouds():
    for cloud in clouds:
        for part in cloud:
            canvas.move(part, -1, 0)

    # recycle clouds
    for cloud in clouds:
        x1 = canvas.coords(cloud[0])[0]
        if x1 < -100:
            for part in cloud:
                canvas.move(part, WIDTH + 120, 0)

    root.after(50, move_clouds)


# ---------------- DINO ----------------
def create_dino():
    global parts, leg1, leg2

    tail = canvas.create_polygon(55,195, 35,188, 52,210, fill="black")

    body = canvas.create_polygon(
        55,185, 100,175, 125,180, 130,195, 130,210, 55,210,
        fill="black"
    )

    neck = canvas.create_rectangle(100,160, 118,185, fill="black", outline="")

    head = canvas.create_polygon(
        118,160, 150,160, 160,175, 160,190, 125,190,
        fill="black"
    )

    eye = canvas.create_oval(140,168, 143,171, fill="white")

    mouth = canvas.create_line(142,182, 160,184, fill="white", width=2)

    arm = canvas.create_line(95,190, 110,195, width=4)

    leg1 = canvas.create_line(75,210,75,235, width=5)
    leg2 = canvas.create_line(105,210,105,235, width=5)

    parts = [tail, body, neck, head, eye, mouth, arm, leg1, leg2]


def move_dino(y):
    for p in parts:
        canvas.move(p, 0, y)


def dino_box():
    return canvas.bbox(parts[1])


# ---------------- RESET ----------------
def reset():
    global cactus, score_text, score, running, jumping

    canvas.delete("all")

    canvas.create_line(0, GROUND, WIDTH, GROUND, width=2)

    create_dino()

    # ☁️ create clouds
    clouds.clear()
    for _ in range(4):
        create_cloud()

    cactus = canvas.create_polygon(
        WIDTH,235, WIDTH,190, WIDTH+10,190,
        WIDTH+10,210, WIDTH+25,210, WIDTH+25,190,
        WIDTH+35,190, WIDTH+35,235,
        fill="green"
    )

    score = 0

    score_text = canvas.create_text(
        740,25,
        text="Score: 0",
        font=("Arial",14)
    )

    running = True
    jumping = False


# ---------------- WALK ANIMATION ----------------
def walk_anim():
    global walk

    if running and not jumping:
        walk += 1

        if walk % 2 == 0:
            canvas.coords(leg1, 75,210, 70,235)
            canvas.coords(leg2, 105,210, 110,235)
        else:
            canvas.coords(leg1, 75,210, 80,235)
            canvas.coords(leg2, 105,210, 100,235)

    root.after(120, walk_anim)


# ---------------- CONTROLS ----------------
def jump(event):
    global jumping, jump_speed

    if running and not jumping:
        jumping = True
        jump_speed = -13
        sound_jump()   # 🔊 SOUND


def restart(event):
    reset()
    game()


root.bind("<space>", jump)
root.bind("r", restart)


# ---------------- GAME LOOP ----------------
def game():
    global jump_speed, jumping, running, score

    if not running:
        return

    # jump physics
    if jumping:
        move_dino(jump_speed)
        jump_speed += 1

        x1, y1, x2, y2 = dino_box()

        if y2 >= 210:
            move_dino(210 - y2)
            jumping = False

    # cactus movement
    canvas.move(cactus, -9, 0)

    c = canvas.coords(cactus)

    if max(c[::2]) < 0:
        canvas.move(cactus, WIDTH + 80, 0)
        score += 1
        canvas.itemconfig(score_text, text=f"Score: {score}")

    # collision
    dx1, dy1, dx2, dy2 = dino_box()

    cx1 = min(c[::2])
    cx2 = max(c[::2])
    cy1 = min(c[1::2])

    if dx2 > cx1 and dx1 < cx2 and dy2 > cy1:
        running = False

        sound_game_over()  # 💥 SOUND

        canvas.create_text(
            420,100,
            text="GAME OVER\nPress R",
            fill="red",
            font=("Arial",22)
        )
        return

    root.after(25, game)


# START
reset()
walk_anim()
move_clouds()   # ☁️ CLOUD ANIMATION START
game()
root.mainloop()