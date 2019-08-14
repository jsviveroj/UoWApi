using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interface
{
    public interface IBusinessFactory
    {
        T GetBusinessClass<T>() where T : IBaseBusinessFactory;
    }

    public interface IBaseBusinessFactory
    {
    }
}
