# Итоговая практическая работа первого блока #
**Задачи:**
* Создать репозиторий на Githab
* Нарисовать блок-схему предложенного алгоритма
* Добавить в репозиторий файл README.md
* Решить поставленную задачу алгоритмическим путем
* Сделать более 2х коммитов
>Задача: написать программу, которая из массива строк создает новый массив из строк, длина элементов которого не превышает 3 символа.
>>Установить ввод данных с клавиатуры.

## Решение ##
1. Создаем пустую строку и переменную счетчик
2. Пользователь вводит число (размер массива)
3. Далее пользователь вводит строку столько раз, сколько указана размерность массива
4. Введенная строка прибавляется к исходной строке с пробелом наконце
5. Далее строку разделяем по разделителю - пробелу, и таким образом создаем исходный массив
6. Исходный массив проходим циклом и проверяем кол-во элементов с длиной не более трех
7. При нахождении каждого элемента увеличиваем счетчик на 1
8. Создаем новый массив с размером = величине счетчика
9. Еще раз проходимся по массиву и вставляем элемент с длиной не более 3 в новый массив
10. Выводим новый массив в консоль.

**Внимание!**
*Данная программа сломается, если строка вводенная пользователем будет сождержать пробел. Это легко исправить,
добавив кастомный разделитель, например /delimiTERRRR/ - вряд ли кто-то введет такую строку. Во всяком случае,
решил не усложнять, т.к. задача - реализовать MVP*

>Блок-схему создавал в редакторе VSCode. Отправил файл с расширением drawio сюда, в репозиторий.
