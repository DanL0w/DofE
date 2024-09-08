from tkinter import *
from tkinter import ttk

def GetInput():
    XandY = input()
    Grid = []
    XandYArray = XandY.split(" ")
    x = int(XandYArray[1])
    y = int(XandYArray[2])
    for yIt in range(y):
        GridLine = str(input())
        Grid.append(GridLine)
    return Grid, x, y

def Neighbours(Grid, xIt, yIt, x, y):
    NumNeighbours = 0
    if xIt == 0:
        xcords = [x-1, 0, 1]
    elif xIt == x-1:
        xcords = [(xIt - 1), xIt, 0]
    else:
        xcords = [(xIt - 1), xIt, (xIt + 1)]
    if yIt == 0:
        ycords = [y-1, 0, 1]
    elif yIt == y-1:
        ycords = [(yIt - 1), yIt, 0]
    else:
        ycords = [(yIt - 1), yIt, (yIt + 1)]
    for i in range(3):
        for j in range(3):
            xcord = xcords[i]
            ycord = ycords[j]
            if Grid[ycord][xcord] == "#":
                NumNeighbours = NumNeighbours + 1
    if Grid[yIt][xIt] == "#":
        NumNeighbours = NumNeighbours - 1
    return NumNeighbours


def iterate(OldGrid,x,y):
    NewGrid = []
    for yIt in range(y):
        NewLine = []
        for xIt in range(x):
            NeighboursOn = Neighbours(OldGrid, xIt, yIt, x, y)
            if OldGrid[yIt][xIt] == ".":
                if NeighboursOn == 3:
                    NewLine.append("#")
                else:
                    NewLine.append(".")
            elif OldGrid[yIt][xIt] == "#":
                if (NeighboursOn == 2) or (NeighboursOn == 3):
                    NewLine.append("#")
                else:
                    NewLine.append(".")
        NewGrid.append(NewLine)
    Grid = NewGrid
    for yIt in range(y):
        for xIt in range(x):
            ttk.Label(content, text=Grid[yIt][xIt]).grid(column=xIt, row=yIt)
    content.grid(column = 0, row = 0)
    ttk.Button(root, text = "Next Generation", command=lambda: iterate(Grid,x,y)).grid(column = 0, row = 1)

if __name__ == "__main__":
    inputs = GetInput()
    Grid = inputs[0]
    x = inputs[1]
    y = inputs[2]
    root = Tk()
    content = ttk.Frame(root)

    for yIt in range(y):
        for xIt in range(x):
            ttk.Label(content, text=Grid[yIt][xIt]).grid(column=xIt, row=yIt)
    content.grid(column = 0, row = 0)
    ttk.Button(root, text = "Next Generation", command=lambda: iterate(Grid,x,y)).grid(column = 0, row = 1)

    root.mainloop()
