## Условие Задачи 

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3.
Первоначальный массив можно ввести с клавиатруы, либо задать на страте выполнения алгоритма. При решениие не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание алгоритма решения 

Сначала объявляем два массива. Второй массив равен длине первого массива. Затем создаем цикл, который равен длине первого массива. В цикле проверяем условие (длина символов элемента меньше либо равна 3). Если это условие верно, то элемент первого массива заносится в count  элемент второго массива. Count нужен для поочередного закидывания элементов первого массива во второй и для пропуска пробелов. После чего count  перещелкивается на 1 и переходим обратно в цикл for, где смотрим уже следующий элемент первого массива.

