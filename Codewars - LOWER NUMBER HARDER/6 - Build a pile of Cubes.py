def find_nb(m):
    n = 1
    while m > 0:
        m = m - pow(n, 3)
        if m == 0:
            return n
        n = n +1
    return -1