def part_1(plays):
    """
    A / X = Rock: 1
    B / Y = Paper: 2
    C / Z = Scissors: 3

    Lose: 0
    Draw: 3
    Win: 6
    """

    results = {
        'A X': 1 + 3, 'A Y': 2 + 6, 'A Z': 3 + 0,
        'B X': 1 + 0, 'B Y': 2 + 3, 'B Z': 3 + 6,
        'C X': 1 + 6, 'C Y': 2 + 0, 'C Z': 3 + 3,
    }

    return sum(results[play] for play in plays)


def part_2(plays):
    """
    A = Rock: 1
    B = Paper: 2
    C = Scissors: 3

    X: Lose: 0
    Y: Draw: 3
    Z: Win: 6
    """

    results = {
        'A X': 3 + 0, 'A Y': 1 + 3, 'A Z': 2 + 6,
        'B X': 1 + 0, 'B Y': 2 + 3, 'B Z': 3 + 6,
        'C X': 2 + 0, 'C Y': 3 + 3, 'C Z': 1 + 6,
    }

    return sum(results[play] for play in plays)


def day2_solution():
    input_file = open('Input/day02.txt', 'r')
    input = input_file.read().split('\n')
    # Largest calorie source
    print(part_1(input))

    # Sum of the three largest calorie sources
    print(part_2(input))