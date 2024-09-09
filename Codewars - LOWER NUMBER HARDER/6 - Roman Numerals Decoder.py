def solution(roman):
    numerals = ["I", "V", "X", "L", "C", "D", "M"]
    value = [1, 5, 10, 50, 100, 500, 1000]
    convert =[]
    for i in range(len(roman)):
        for j in range(len(numerals)):
            if roman[i] == numerals[j]:
                convert.append(value[j])
    total = convert[-1]
    for i in range(len(convert) - 1):
        if convert[i] >= convert[i+1]:
            total = total + convert[i]
        else:
            total = total - convert[i]
    return total