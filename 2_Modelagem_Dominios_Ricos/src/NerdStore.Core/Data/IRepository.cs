﻿using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.Data
{
    /// <summary>
    /// Herda do IDisposable para realização do Dispose, onde o tipo T é do tipo
    /// IAggregateRoot. Com isso é possível atender a regra de um único repositório
    /// por agregação.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
