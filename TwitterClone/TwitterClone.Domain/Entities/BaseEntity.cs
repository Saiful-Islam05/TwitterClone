using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class BaseEntity
    {
        private Guid _id;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        private Guid _createdBy;
        private Guid _modifiedBy;


        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? ModifiedAt { get; private set; }
        public Guid CreatedBy { get; private set; }
        public Guid? ModifiedBy { get; private set; }

        public BaseEntity(Guid id)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
        }

        public virtual string DescribeRecord()
        {
            return $"From Base Class! Id: {Id}, CreatedAt: {CreatedAt},ModifiedAt: {ModifiedAt}, CreatedBy: {CreatedBy},ModifiedBy: {ModifiedBy}";
        }
    }
}
