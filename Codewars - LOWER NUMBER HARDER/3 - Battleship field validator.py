def validate_battlefield(field):
    ships = [4, 3, 3, 2, 2, 2, 1, 1, 1, 1]
    for yIt in range(10):
        for xIt in range(10):
            if field[yIt][xIt] == 1:
                if crossValidate(field, yIt, xIt) == False:
                    return False
                hshiplen = shiplen(field, yIt, xIt, 0)
                vshiplen = shiplen(field, yIt, xIt, 1)
                if hshiplen == False or vshiplen == False:
                    return False
                if (hshiplen == 1 and vshiplen == 1) or hshiplen > 1:
                    hComparison = compare(field, hshiplen, ships, yIt, xIt, 0)
                    if hComparison == False:
                        return False
                    else:
                        field, ships = hComparison[0], hComparison[1]
                if vshiplen != 1:
                    vComparison = compare(field, vshiplen, ships, yIt, xIt, 1)
                    if vComparison == False:
                        return False
                    else:
                        field, ships = vComparison[0], vComparison[1]
    if ships == []:
        return True
    else:
        return False

def compare(field, shiplen, ships, yIt, xIt, v):
    for ship in ships:
        if shiplen == ship:
            ships.remove(ship)
            for i in range(ship):
                field[yIt + i*v][xIt + i*(1-v)] = 0
            return field, ships
    return False

def shiplen(field, yCord, xCord, v):
    length = 1
    for j in range(-1, 3, 2):
        for i in range(1, 4):
            if onField(yCord + i*j*v, xCord + i*j*(1-v)):
                if field[yCord + i*j*v][xCord + i*j*(1-v)] == 1:
                    if crossValidate(field, yCord + i*j*v, xCord + i*j*(1-v)) == False:
                        print("hey")
                        return False
                if field[yCord + i*j*v][xCord + i*j*(1-v)] == 0:
                    break
                else:
                    length += 1
    return length

def onField(yCord, xCord):
    if 0 <= yCord <= 9 and 0 <= xCord <= 9:
        return True
    return False

def crossValidate(field, yCord, xCord):
    for i in range(-1, 3, 2):
        for j in range(-1, 3, 2):
            if onField(yCord + i, xCord + j):
                if field[yCord + i][xCord + j] == 1:
                    return False
    return True