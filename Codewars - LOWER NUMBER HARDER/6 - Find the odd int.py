def find_it(seq):
    ans = []
    for i in range(len(seq)):
        if len(ans) == 0:
            ans.append(seq[i])
        else:
            Found = False
            for j in range(len(ans)):
                if seq[i] == ans[j]:
                    Found = True
            if Found == True:
                ans.remove(seq[i])
            else:
                ans.append(seq[i])
    return ans[0]