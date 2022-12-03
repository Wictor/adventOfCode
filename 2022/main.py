from Helper.fileReader import *
from Solution.day01 import *

filename = 'Input/day01.txt'

print(day01part01(filereader(filename).split('\n\n')))
print(day01part02(filereader(filename).split('\n\n')))
