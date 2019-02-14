# generate a password with length "passlen" with no duplicate characters in the password

import random
passlen=int(input('How many characters do you want your password to be?'))
s = "abcdefghijklmnopqrstuvwxyz01234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()?"

#join - returns the result as a new string
#random - generates a random variable 
#sample - chooses unique random elements from a set and returns them as a list
#variable p is choosing passlen number of unique random elements from s and returns them as a string
p =  "".join(random.sample(s,passlen))
print(p)