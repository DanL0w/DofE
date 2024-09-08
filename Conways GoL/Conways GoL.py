def Neighbours(Grid, a, b, x, y):
    NumNeighbours = 0
    if a == 0:
        xcords = [x-1, a, (a + 1)]
    elif a == x-1:
        xcords = [(a - 1), a, 0]
    else:
        xcords = [(a - 1), a, (a + 1)]
    if b == 0:
        ycords = [y-1, b, (b + 1)]
    elif b == y-1:
        ycords = [(b - 1), b, 0]
    else:
        ycords = [(b - 1), b, (b + 1)]
    for i in range(3):
        for j in range(3):
            xcord = xcords[i]
            ycord = ycords[j]
            if Grid[xcord][ycord] == "#":
                NumNeighbours = NumNeighbours + 1
    if Grid[a][b] == "#":
        NumNeighbours = NumNeighbours - 1
    return NumNeighbours


def GetInput():
    DatalineStr = input()
    Grid = []
    DatalineArray = DatalineStr.split(" ")
    N = int(DatalineArray[0])
    x = int(DatalineArray[1])
    y = int(DatalineArray[2])
    for i in range(y):
        GridLine = str(input())
        Grid.append(GridLine)
    return Grid, N, x, y


def OutputGrid(Grid, x, y):
    for i in range(x):
        for j in range(y):
            print(Grid[i][j], end="")
        print()
    print()


if __name__ == "__main__":
    inputs = GetInput()

    #
    Grid = inputs[0]

    # Number of cycles before result printed
    N = inputs[1]

    # x and y dimensions of the grid
    x = inputs[2]
    y = inputs[3]

    if N != 0:
        for i in range(N):
            NewGrid = []
            for a in range(x):
                NewLine = []
                for b in range(y):
                    NeighboursOn = Neighbours(Grid, a, b, x, y)
                    if Grid[a][b] == ".":
                        if NeighboursOn == 3:
                            NewLine.append("#")
                        else:
                            NewLine.append(".")
                    elif Grid[a][b] == "#":
                        if NeighboursOn < 2:
                            NewLine.append(".")
                        elif NeighboursOn > 3:
                            NewLine.append(".")
                        else:
                            NewLine.append("#")
                NewGrid.append(NewLine)
            Grid = NewGrid
            OutputGrid(Grid, x, y)
        OutputGrid(Grid, x, y)
