using OA.Domin.DSA.Indexes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OA.WASM.Services.DSA.Indexes
{
    public class JobTypesService : ServiceBase<JobType>
    {

        public JobTypesService(HttpClient client) : base(client, "JobTypes")
        {

        }

    }
}
