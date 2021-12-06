import sys

# get input arguments from the javascript spawner
args = sys.argv

# read the first two inputs (two numbers in this case)
number1 = int(args[1])
number2 = int(args[2])

# compute a string/output based on the inputs
output = f"number 1 is {number1}. number 2 is {number2}. the sum is {number1 + number2}"

# send the ouput back to js by printing it
print(output)