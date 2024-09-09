def land_perimeter(arr):
    sum = 0
    if len(arr) == 1:
        if len(arr[0])==1:
            if arr[0][0] == "X":
                return  f'Total land perimeter: 4'
            else:
                return 0
    else:
        for yIt in range(len(arr)):
            for xIt in range(len(arr[0])):
                if arr[yIt][xIt] == "X":
                    if xIt == 0:
                        sum = sum + 1
                        if yIt == 0:
                            sum = sum + 1
                            if arr[yIt+1][xIt] == "O":
                                sum = sum+1
                            if arr[yIt][xIt+1] == "O":
                                sum = sum+1
                        elif yIt == len(arr)-1:
                            sum = sum + 1
                            if arr[yIt-1][xIt] == "O":
                                sum = sum+1
                            if arr[yIt][xIt+1] == "O":
                                sum = sum+1
                        else:
                            if arr[yIt+1][xIt] == "O":
                                sum = sum+1
                            if arr[yIt-1][xIt] == "O":
                                sum = sum+1
                            if arr[yIt][xIt+1] == "O":
                                sum = sum+1
                    elif xIt == (len(arr[1])-1):
                        sum = sum + 1
                        if yIt == 0:
                            sum = sum + 1
                            if arr[yIt+1][xIt] == "O":
                                sum = sum+1
                            if arr[yIt][xIt-1] == "O":
                                sum = sum+1
                        elif yIt == len(arr)-1:
                            sum = sum + 1
                            if arr[yIt-1][xIt] == "O":
                                sum = sum+1
                            if arr[yIt][xIt-1] == "O":
                                sum = sum+1
                        else:
                            if arr[yIt+1][xIt] == "O":
                                sum = sum+1
                            if arr[yIt-1][xIt] == "O":
                                sum = sum+1
                            if arr[yIt][xIt-1] == "O":
                                sum = sum+1
                    else:
                        if yIt == 0:
                            sum = sum + 1
                            if arr[yIt+1][xIt] == "O":
                                sum = sum+1
                            if arr[yIt][xIt+1] == "O":
                                sum = sum+1
                            if arr[yIt][xIt-1] == "O":
                                sum = sum+1
                        elif yIt == len(arr)-1:
                            sum = sum + 1
                            if arr[yIt-1][xIt] == "O":
                                sum = sum+1
                            if arr[yIt][xIt+1] == "O":
                                sum = sum+1
                            if arr[yIt][xIt-1] == "O":
                                sum = sum+1
                        else:
                            if arr[yIt+1][xIt] == "O":
                                sum = sum+1
                            if arr[yIt-1][xIt] == "O":
                                sum = sum+1
                            if arr[yIt][xIt+1] == "O":
                                sum = sum+1
                            if arr[yIt][xIt-1] == "O":
                                sum = sum+1
    return  f'Total land perimeter: {sum}'
