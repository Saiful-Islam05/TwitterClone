using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    
    public abstract class BaseEntity
    {
        
        private Guid _id;
        private DateTime _createdAt;
        private DateTime? _modifiedAt;   
        private Guid _createdBy;
        private Guid? _modifiedBy;      

      
        public Guid Id { get => _id; private set => _id = value; }
        public DateTime CreatedAt { get => _createdAt; private set => _createdAt = value; }
        public DateTime? ModifiedAt { get => _modifiedAt; private set => _modifiedAt = value; }
        public Guid CreatedBy { get => _createdBy; private set => _createdBy = value; }
        public Guid? ModifiedBy { get => _modifiedBy; private set => _modifiedBy = value; }

        
        protected BaseEntity() { }

        
        protected BaseEntity(Guid createdBy)
        {
            _id = Guid.NewGuid();            
            _createdAt = DateTime.UtcNow;    
            _createdBy = createdBy;          
        }

       
        public void MarkAsModified(Guid? modifiedBy = null)
        {
            _modifiedAt = DateTime.UtcNow;   
            _modifiedBy = modifiedBy;        
        }

        
        public virtual string DescribeRecord()
        {
            return $"From Base Class! Id: {Id}, CreatedAt: {CreatedAt}, " +
                   $"ModifiedAt: {ModifiedAt}, CreatedBy: {CreatedBy}, ModifiedBy: {ModifiedBy}";
        }
    }
}
