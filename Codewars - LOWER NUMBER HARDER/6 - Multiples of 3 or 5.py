def solution(number):
    if number <=0:
        return 0
    sum = 0
    for i in range(number):
        if i%5 == 0:
            sum = sum + i
        elif i%3 == 0:
            sum = sum + i
    return sum
