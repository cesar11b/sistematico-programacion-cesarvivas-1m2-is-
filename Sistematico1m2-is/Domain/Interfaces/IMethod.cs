using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IMethod<T>
    {

        void Create(T t);

        

        ICollection<T> FindAll();


    }
}
