using OA.Domin.DSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OA.WASM.Services.DSA
{
    public class VacanciesService : ServiceBase<Vacancy>
    {
        public VacanciesService(HttpClient client) : base(client, "Vacancies")
        {

        }
    }
}
