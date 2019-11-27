import random

class Card_Deck:
    def __init__(self):
        self.cards = [(color, value) for color in ['Hearts', 'Diamond', 'Clover', 'Spades'] for value in range(1,14)]
    def show(self):
        for card in self.cards:
            print(f'{card[1]} of {card[0]}')
    def shuffle(self):
        random.shuffle(self.cards)
    def draw(self):
        card = self.cards.pop()
        print(f'{card[1]} of {card[0]}')
    def sort(self):
        return sorted(self.cards, key=lambda val: (val[0], val[1]))


while(True):
    option = int(input("Enter the option: 1: New Game, 2: Show Cards, 3: Draw, \n 4: Shuffle, 5: Sort, 6: Quit \n"))
    game = Card_Deck()
    if option == 1:
        game = Card_Deck()
    elif option == 2:
        game.show()
    elif option == 3:
        game.draw()
    elif option == 4:
        game.shuffle()
    elif option == 5:
        game.sort()
    elif option == 6:
        break
    else:
        print('you enter a wrong number')
        break

