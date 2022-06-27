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
            counterValue = counter[N-1]
            MC = counterValue

        else:
            counter[X-1] += 1
            counterValue = counter[X-1]
            if counterValue > MC:
                MC = counterValue
    
    return counter
