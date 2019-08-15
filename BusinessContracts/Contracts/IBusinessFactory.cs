using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessContracts.Contracts
{
    public interface IBusinessFactory
    {
        T GetBusinessClass<T>() where T : IBaseBusinessFactory;
    }

    public interface IBaseBusinessFactory
    {
    }
}
