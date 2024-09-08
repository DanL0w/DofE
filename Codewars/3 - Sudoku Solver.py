def sudoku(puzzle):
    T = True
    while T:
        T = False
        for yIt in range(9):
            for xIt in range(9):
                if puzzle[yIt][xIt] == 0:
                    T, possible = True, [1,2,3,4,5,6,7,8,9]
                    for horIt in range(9):
                        num = puzzle[yIt][horIt]
                        if num != 0 and num in possible:
                            possible.remove(num)
                    for vertIt in range(9):
                        num = puzzle[vertIt][xIt]
                        if num != 0 and num in possible:
                            possible.remove(num)
                    for sqIt1 in range(3):
                        for sqIt2 in range(3):
                            num = puzzle[(yIt//3)*3+sqIt1][(xIt//3)*3+sqIt2]
                            if num != 0 and num in possible:
                                possible.remove(num)
                    if len(possible) == 1:
                        puzzle[yIt][xIt] = possible[0]
    return puzzle