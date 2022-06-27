# Return an array (list in python) of counters that tracks the occurence of values in another array A, containing values 1 to N+1. 
# If a value of A[k] is between 1 and N inclusive, increase the counter for that value. 
# If the value of A[k] is N+1, set all values in the counter array to the existing max count value within the counter array.

# In each of my answers, I summarize the prompts as above, but the original question is poorly-written, as usual.
# The question made it seem like the counter values should be set to k on A[k] = N+1, rather than the max count. 

# This solution got 88%. It is correct, but gives O(N+M) performance, so I got dinged on a high input timeout. 
# I tried to improve the efficiency over an earlier version by tracking the max count in a variable rather than calling max(list).
# This helped, but there is still room for improvement. 
# My guess is that it is not fast to do it this way in Python because the language uses arraylists and not real arrays.
# I usually use numpy for real arrays, but I don't think I can import that for these tests. I'll try another way later:


def solution(N, A):
    counter = [0] * N
    nup = N + 1
    MC = 0
    counterValue = 0
    
    for k in range(len(A)):
        X = A[k]    

        if X == nup:
            counter = [MC] * N

        else:
            counter[X-1] += 1
            counterValue = counter[X-1]
            if counterValue > MC:
                MC = counterValue
    
    return counter

#Later attempted with numpy arrays, which seems to be faster. However, codility deosn't provide numpy:

#import numpy as np

#def solution(N, A):
#    # counter = [0] * N
#    counter = np.zeros(N) # numpy array of zeros of length N
#    nup = N + 1
#    MC = 0
#    counterValue = 0
    
#    for k in range(len(A)):
#        X = A[k]

#        if X == nup:
#            #counter = [MC] * N
#            counter = np.full(N, MC)            

#        else:
#            counter[X-1] += 1
#            counterValue = counter[X-1]
#            if counterValue > MC:
#                MC = counterValue
    
#    return counter


#Later attempted this answer using dictionaries and it was slower. It is not very practical either:

#def increase(f, X):
#    if X not in f:
#        f[X]=1
#    else:
#        f[X]+=1
#    return f

#def maxCounter(f, mc):
#    f=f.fromkeys(f, mc)
#    return f


#def initializef(N):
#    f = {}
#    for k in range(N):        
#        f[k+1] = 0
#    print ('f: ' + str(f))
#    return f

#def solution(N, A):
    
#    f = initializef(N)    
#    nup = N + 1    
    
#    for k in range(len(A)):
        
#        X = A[k]

#        if X == nup:
#            f = maxCounter(f, max(f.values()))
#            print(max(f.values()))
#            print('result max counter: ' + str(f))
#        else:
#            f = increase(f, X)
    
#    ans = list(f.values())

#    return ans
