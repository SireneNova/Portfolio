##Start  IDLE  and  use  the Python  range()  function  with  one  parameter  to 
##display  the following:
##0
##1
##2
##3

print('Drill 1:')
for i in range(4):
    print(i) 

##Use the Python range() function with 3 parameters to display the following:
##3
##2
##1
##0

print('')
print('Drill 2:')
for i in range(3,-1,-1):
    print(i) 

##Use the Python range() function with 3 parameters to display the following:
##8
##6
##4
##2

print('')
print('Drill 3:')
for i in range(8,1,-2):
    print(i) 

print('')
print('Extra:')
tuple1=(3,2,1,0)
for i in range(4):
    print(tuple1[i])
