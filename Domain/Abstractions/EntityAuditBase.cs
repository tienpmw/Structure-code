using Domain.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
	public abstract class EntityAuditBase<T> : EntityBase<T>, IEntityAuditBase<T>
	{
		public DateTimeOffset CreatedDate { get; set; }
		public DateTimeOffset ModifiedDate { get; set; }
		public string CreatedBy { get; set; }
		public string ModifiedBy { get; set; }
	}
}
