import random

# Function to generate a random word from a predefined list
def generate_word():
    word_list = ["apple", "lyche", "lemon", "grape", "melon", "peach", "mango", "quand", "olive", "cherry",
                 "straw", "berry", "pears", "apric", "plumy", "guava", "prune", "dates", "figgy", "papaw"]
    return random.choice(word_list)

# Function to check the guessed word against the secret word and provide feedback
def check_word(secret_word, guessed_word):
    feedback = ""
    checked_letters = set()  # Set to keep track of checked letters to avoid duplication
    for i in range(len(secret_word)):
        if guessed_word[i] == secret_word[i]:  # If the guessed letter matches the letter in the same position in the secret word
            feedback += "♡"
            checked_letters.add(secret_word[i])  # Add the checked letter to the set
        elif guessed_word[i] in secret_word and guessed_word[i] not in checked_letters:
            # If the guessed letter is in the secret word but not in the same position
            feedback += "-"
            checked_letters.add(guessed_word[i])
        else:
            feedback += "☆"  # If the guessed letter is incorrect, add a star symbol
    return feedback

# Function to start and control the game
def play_game():
    secret_word = generate_word()  # Generate a secret word
    print("Welkom! Raad een woord van 5 letters.")

    attempts = 0
    while attempts < 5:
        guessed_word = input("Poging {}: ".format(attempts + 1)).lower()
        if len(guessed_word) != len(secret_word):
            print("Het woord moet precies 5 letters lang zijn.")
            continue  # Skip the rest of the loop and start from the beginning

        feedback = check_word(secret_word, guessed_word)
        print("Feedback: ", feedback)
        if feedback == "♡♡♡♡♡":  # If all letters are correctly guessed in correct positions
            print(f"Gefeliciteerd! Je hebt het woord geraden in {attempts+1} keer.")
            break
        attempts += 1
    else:
        print("Helaas! Het woord was '{}'. Volgende keer beter!".format(secret_word))

# Calling the function to start the game
play_game()
