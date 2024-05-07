#Function definition "Greeting" that takes input parameter name of type string and returns the value of greeting.
def Greeting(name):
    _name = name
    greeting = "hello " + _name +" its really nice to meet you"

    return greeting

## call the function Greeting() and store the output in a variable _greeting.
_greeting = Greeting("Billy Kimber")
print(_greeting)

## def Average function that takes list as an input and calculates the average of the list
def Average(list):
    sum = 0
    for i in range(len(list)):
        sum = sum + list[i]
    average = sum/len(list)
    return  average
## set up the code to use Aveage, define _list as a list of integers.
## Call the function Average with _list as an input and store in the _average
_list = [3,9,6,33,99,66]
_average = Average(_list)

##print _avergage
print("The Average from the list is: ", round(_average,2) )

if _average >= 10:
    print("Double Digits")
else:
    print("single digits")





