ОПИСАНИЕ РАБОТА ПРОГРАММЫ

В начале на вход подаются два массива одинаковой длинны. Массив arrayIn заполняется на старте выполнения программы. Массив arrayOut заполняется в ходе выполнения программы. Задается переменная/счетчик count = 0. Далее внутри цикла for проводится проверка каждого элемента массива arrayIn на соответствие условию (количество символов в элементе должно быть меньше или равно 3). Если условие выполняется, то элемент первого массива arrayIn становится очередным элементом второго массива arrayOut. Переменная count поочередно переносит соответствующий условию элемент из первого массива во второй. После переноса значение переменной count увеличивается  на 1. Затем все снова возвращается к циклу for в котором i увеличивается на 1 до тех пор, пока не будут проверены на соответствие все элементы массива arrayIn. На выходе используем метод удобный метод Join, позволяющий объединять каждый элемент в массиве объектов без явного преобразования его элементов в строки