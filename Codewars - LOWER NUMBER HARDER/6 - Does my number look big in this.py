def narcissistic( value ):
    sum = 0
    for i in range(len(str(value))):
        sum = sum + pow(int(str(value)[i]), len(str(value)))
    if sum == value:
        return True
    else:
        return False
