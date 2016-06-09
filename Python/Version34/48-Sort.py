lista=[67, 45, 2, 13, 1, 998]
print('Before:',lista)

#insertion sort, part of shell sort
def gapInsertionSort(lista,start,gap): 
                    #list,start in slc range,slc range
    for i in range(start+gap,len(lista),gap): #start, stop, step
        while i>=gap and lista[i-gap]>lista[i]:
            #i is position, lista[i] is currentvalue
            lista[i]=lista[i-gap]
            i = i-gap
        lista[i]=lista[i]
        
def shellSort(lista): #shell sort
    sublistcount = len(lista)//2 #gap
    while sublistcount > 0:
        for startpos in range(sublistcount): #i in range half list length
            gapInsertionSort(lista,startpos,sublistcount) #call other function
        sublistcount = sublistcount // 2 #shrink sublist


shellSort(lista)
print('After:',lista)

