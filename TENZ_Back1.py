def even_odd_sum(number):
    num_str = str(number)
    even_sum = 0
    odd_sum = 0
    for digit in num_str:
        if int(digit) % 2 == 0:
            even_sum += int(digit)
        else:
            odd_sum += int(digit)
    return f"{odd_sum} {even_sum}"
while True:
    input_number = int(input("Введите число от 0 до 10²⁰: "))
    if (0 <= input_number <= pow(10,20)):
        result = even_odd_sum(input_number)
        print("Сумма четных и нечетных чисел:", result)
    else:
        print("Число не входит в допустимый диапазон.")
