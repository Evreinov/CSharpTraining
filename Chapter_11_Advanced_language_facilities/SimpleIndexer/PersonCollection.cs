﻿using System.Collections;

namespace SimpleIndexer
{
    class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();

        // Специальный индексатор для этого класса.
        public Person this[int index]
        {
            get => (Person)arPeople[index];
            set => arPeople.Insert(index, value);
        }

        // Приведение для вызывающего кода.
        public Person GetPerson(int pos) => (Person)arPeople[pos];

        // Вставка только объектов Person.
        public void AddPerson(Person p)
        {
            arPeople.Add(p);
        }

        public void ClearPeople()
        {
            arPeople.Clear();
        }

        public int Count => arPeople.Count;

        // Поддержка перечисления с помощью foreach.
        public IEnumerator GetEnumerator() => arPeople.GetEnumerator();
    }
}
