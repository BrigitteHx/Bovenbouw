import random
import hashlib

passwordLength = 5
def generate_password():
    return ''.join([chr(random.randint(97, 122)) for _ in range(passwordLength)])

def hash_password(password):
    return hashlib.sha256(password.encode()).hexdigest()

password = generate_password()
hashed_password = hash_password(password)

print("Hashed Password:", password)
print("Hashed Password:", hashed_password)

def checkPassword(possiblePassword):
    if(hashlib.sha256(possiblePassword.encode()).hexdigest() == hashed_password):
        return True
    else:
        return False

# recursion one: (8-9 sec)
# def crackPassword(possiblePassword='', counter=0):
#     if counter == passwordLength:
#         if checkPassword(possiblePassword):
#             print("Ik heb het wachtwoord gekraakt, het gegenereerde wachtwoord moet zijn:", possiblePassword)
#             return True
#         return False
    
#     for char in range(97, 122): 
#         if crackPassword(possiblePassword + chr(char), counter + 1):
#             return True
#     return False

# crackPassword()
    
# final, recursion two: (5-7)
def crackPassword(possiblepassword='', length=5):

    if length == 0:
        if checkPassword(possiblepassword):
            print("Ik heb het wachtwoord gekraakt, het gegenereerde wachtwoord moet zijn:", possiblepassword)
        return

    for char in range(97, 122):
        crackPassword(possiblepassword + chr(char), length - 1)

crackPassword()


