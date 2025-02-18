﻿using System;

namespace FinalizableDisposableClass
{
    // Усовершенствованная оболочка для ресурсов.
    public class MyResourceWrapper : IDisposable
    {
        //// Сборщик мусора будет вызывать этот метод, если
        //// пользователь объекта забыл вызвать Dispose().
        //~MyResourceWrapper() 
        //{
        //    // Очистить любые внутренние неуправляемые ресурсы.
        //    // **Не** вызывать Dispose() на управляемых объектах.
        //}

        //// Пользователь объекта будет вызывать этот метод
        //// для как можно более скорой очистки ресурсов.
        //public void Dispose()
        //{
        //    // Очистить неуправляемые ресурсы.
        //    // Вызвать Dispose() для других освобождаемых объектов,
        //    // содержащихся внутри.
        //    // Если пользователь вызвал Dispose(), то финидизация
        //    // не нужна, поэтому подавить ее.
        //    GC.SuppressFinalize(this);
        //}

        /***** Формальный шаблон освобождения, определенный в Microsoft *****/
        
        // Используется для выяснения, вызывался ли метод Dispose().
        private bool disposed = false;

        public void Dispose()
        {
            // Вызвать вспомогательный метод.
            // Указание true означает, что очистку
            // запустил пользователь объекта.
            CleanUp(true);

            // Подавить финализацию.
            GC.SuppressFinalize(this);
        }

        private void CleanUp(bool disposing)
        {
            // Удостовериться, не выполнялось ли уже освобождение.
            if (!this.disposed)
            {
                // Если dispoding равно true, тогда
                // освободить все управляемые ресурсы.
                if (disposing)
                {
                    // Освободить управляемые ресурсы.
                }
                // очистить неуправляемые ресурсы.
            }
            disposed = true;
        }

        ~MyResourceWrapper()
        {
            Console.Beep();
            // Вызвать вспомогательный метод.
            // Указание false означает, что
            // очистку запустил сборщик мусора.
            CleanUp(false);
        }
    }
}
