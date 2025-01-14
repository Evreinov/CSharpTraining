﻿using System;

namespace SimpleFinalize
{
    // Переопределить System.Object.Finalize() посредством синтаксиса финализатора
    class MyResourceWrapper
    {
        // Ошибка на этапе компиляции!
        //protected override void Finalize();

        // Очистить неуправляемые ресурсы.
        // Выдать звуковой сигнал при уничтожении
        // (только в целях тестирования).
        ~MyResourceWrapper() => Console.Beep();
    }
}
