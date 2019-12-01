using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravity_System
{
    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }

    public interface IEnumerator
    {
        bool MoveNext(); // перемещение на одну позицию вперед в контейнере элементов
        object Current { get; }  // текущий элемент в контейнере
        void Reset(); // перемещение в начало контейнера
    }
}
