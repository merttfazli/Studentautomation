using EntityLayer.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Student : BaseEntity, IAudiEntity
    {
        public string Class { get; set; }
        public List<Lesson> lesson { get; set; }

        public int CreatedUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int UpdatedUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
