def decode(s):
    newS = ""
    for i in range(1, (len(s)+1)):
        character = s[i-1]
        newcharacter = decodeletter(character, i)
        newS = newS + newcharacter
    return newS;

def decodeletter(character, i):
    list = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.,? "
    if character in list:
        reordlist = ""
        powerOf2 = 2 ** i
        for j in range(1, 67):
            reordlist = reordlist + list[(powerOf2 * j)%67-1]
        placeInList = reordlist.index(character)
        character = list[placeInList]
    return character