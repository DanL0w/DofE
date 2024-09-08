
def return_p_factors(x):
    p_factorised = False
    i = 2
    p_factors = []
    while not p_factorised:
        a = 0
        while x % i == 0:
            a += 1
            x = x/i
        if a != 0:
            p_factors.append([i, a])
        if x == 1:
            p_factorised = True
        i += 1
    return p_factors


if __name__ == "__main__":
    n = 10000
    k = 4
    p_factors_n_factorial = [[1, 1]]
    for iterator_1 in range(2,n + 1):
        print(iterator_1)
        p_factors = return_p_factors(iterator_1)
        print(p_factors)
        if p_factors != [] :
            for p_factor in p_factors:
                found = False
                iterator_2 = 0
                while not found:
                    if iterator_2 != len(p_factors_n_factorial):
                        if p_factor[0] == p_factors_n_factorial[iterator_2][0]:
                            found = True
                            p_factors_n_factorial[iterator_2][1] += p_factor[1]
                        iterator_2 += 1
                    else:
                        break
                if found == False:
                    p_factors_n_factorial.append(p_factor)

    print(p_factors_n_factorial)