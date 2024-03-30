using Domain.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
	public abstract class EntityBase<T> : IEntityBase<T>
	{
		public T Id { get ; set ; }
	}
}
