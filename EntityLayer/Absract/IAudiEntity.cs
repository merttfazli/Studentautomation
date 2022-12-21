using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Absract
{
    public interface IAudiEntity
    {
        int CreatedUserId { get; set; }
        DateTime? CreatedDate { get; set; }

        int UpdatedUserId { get; set; }
        DateTime? UpdatedDate { get; set; }

    }
}
