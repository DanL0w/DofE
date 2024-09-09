import re
def top_3_words(text):
    text, words, word,frequency, finalResults, abc = text.lower(), [], "", {}, [], ["'", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"]
    for i in range(len(text)):
        if text[i] in abc:
            word = word +str(text[i])
        elif len(word)>0 and not(set(word).issubset("'")):
            words.append(word)
            word=""
        else:
            word=""
    for item in words:
        if item in frequency:
            frequency[item] += 1
        else:
            frequency[item] = 1
    result = sorted(frequency.items(), key=lambda item: item[1])
    result.reverse()
    result = result[0:3]
    for i in range(len(result)) : 
        finalResults.append( result[i][0])
    return finalResults