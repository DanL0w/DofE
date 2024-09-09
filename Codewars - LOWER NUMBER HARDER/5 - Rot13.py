def rot13(message):
    newmessage=[]
    for i in range(len(message)):
        if 64 < ord(message[i]) <= 77:
            newmessage.append(chr(ord(message[i])+13))
        elif 77 < ord(message[i]) < 91:
            newmessage.append(chr(ord(message[i])-13))
        elif 96 < ord(message[i]) <= 109:
             newmessage.append(chr(ord(message[i])+13))
        elif 109 < ord(message[i]) < 123:
             newmessage.append(chr(ord(message[i])-13))
        else:
             newmessage.append(message[i])
    return "".join(newmessage)