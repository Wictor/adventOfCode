def day01part01(file_input):
    for elf in file_input:
        elf_array = elf.split('\n')
        elf_sum = sum(int(i) for i in elf_array)
        file_input.remove(elf)
        file_input.insert(0, elf_sum)

    file_input.sort(reverse=True)
    return file_input[0]


def day01part02(file_input):
    for elf in file_input:
        elf_array = elf.split('\n')
        elf_sum = sum(int(i) for i in elf_array)
        file_input.remove(elf)
        file_input.insert(0, elf_sum)

    file_input.sort(reverse=True)
    return file_input[0] + file_input[1] + file_input[2]
