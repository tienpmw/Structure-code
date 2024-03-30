using Domain.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
	public abstract class EntitySoftDeleteBase<T> : EntityBase<T>, ISoftDelete
	{
		public bool IsDeleted { get; set; }
		public DateTimeOffset DeletedAt { get; set; }
	}
}
