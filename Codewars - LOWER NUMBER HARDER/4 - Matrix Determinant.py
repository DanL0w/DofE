def determinant(matrix):
    N  = len(matrix)
    if N == 1:
        return matrix[0][0]
    elif N == 2:
        return matrix[0][0]*matrix[1][1] - matrix[0][1]*matrix[1][0]
    det = 0
    pn = 1
    for i in range(N):
        det = det + matrix[0][i]*determinant(minor(N, i, matrix))*pn
        pn = pn*-1
    return det

def minor(N, i, matrix):
    minormatrix = []
    for j in range(N-1):
        newline=[]
        for k in range(N-1):
            if k < i:
                newline.append(matrix[j+1][k])
            else:
                newline.append(matrix[j+1][k+1])
        minormatrix.append(newline)

    return minormatrix