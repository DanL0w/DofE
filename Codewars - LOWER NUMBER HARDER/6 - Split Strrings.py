import numpy as np
def solution(s):
    result = []
    for i in range(int(np.ceil(len(s)/2))):
        try:
            result.append(s[2*i] + s[2*i+1])
        except:
            result.append(s[2*i] + "_")
    return result