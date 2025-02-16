from time import sleep
import keyboard as k
import pyautogui as pg

def s(t=0.25):
    sleep(t)
def pr(t):
    k.press_and_release(t)
    s()
def w(t):
    k.write(t)
    s()

n = 7
lista = "lista 4"
screen = pg.size()
screen = [screen.width, screen.height]

# pr("alt+tab")
# while n<26:
#     url = f"https://replit.com/@gdoria/4{ n if n > 9 else "0"+str(n) }"
#     pr("ctrl+t")
#     w(url)
#     pr("enter")
#     n+=1
#     s(1)

pr("alt+tab")
while n<27:
    pg.click(screen[0]/2, screen[1]/2)
    pr("ctrl+a")
    pr("ctrl+c")
    pr("alt+tab")
    pr("ctrl+t")
    pr("ctrl+a")
    pr("BackSpace")
    w(f"{lista}/e{ n if n > 9 else "0"+str(n)}.cs")
    pr("Enter")
    pr("ctrl+a")
    pr("ctrl+v")
    pr("alt+tab")
    pr("ctrl+Page_Down")
    n+=1