using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Buena_Farmacia.classes
{
    internal interface BaseInterface <BaseModel>
    {
        List<BaseModel> getAll();
        
        int create(BaseModel model);

        int update(BaseModel model);

        int delete(int recordID);
    }
}
