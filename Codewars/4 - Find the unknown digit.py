def solve_runes(runes):
    opin = max([runes.find("+"), runes.find("*"), ])
    if opin == -1:
        opin = runes[1:].find("-") + 1
    op = runes[opin]
    eqin = runes.find("=")
    num1 = runes[0:opin]
    num2 = runes[opin + 1:eqin]
    ans = runes[eqin + 1:]
    for i in range(10):
        if validate(i, op, num1, num2, ans, runes):
            return i

    return -1


def validate(i, op, num1, num2, ans, runes):
    for j in range(len(runes)):
        if str(i) == runes[j]:
            return False
    if i == 0 and (
            len(num1) > 1 and num1[0] == "?" or len(num2) > 1 and num2[0] == "?" or len(ans) > 1 and ans[0] == "?" or
            num1[0] == "-" and num1[1] == "?" or num2[0] == "-" and num2[0] == "?" or ans[0] == "-" and ans[0] == "?"):
        return False
    new1 = int(num1.replace('?', str(i)))
    new2 = int(num2.replace('?', str(i)))
    newans = int(ans.replace('?', str(i)))
    if op == "+":
        if new1 + new2 == newans:
            return True
    if op == "-":
        if new1 - new2 == newans:
            return True
    if op == "*":
        if new1 * new2 == newans:
            return True
    return False