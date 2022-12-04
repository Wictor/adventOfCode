input_file = open('Input/day01.txt', 'r')
calories = []

for elf in input_file.read().split('\n\n'):
    calories.append(sum(int(i) for i in elf.split('\n') if i != ""))
    # calories.insert(0, elf_sum)

calories.sort(reverse=True)


def day1_solution():
    # Largest calorie source
    print(calories[0])

    # Sum of the three largest calorie sources
    print(calories[0] + calories[1] + calories[2])
