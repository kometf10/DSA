using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using OA.WASM.Shared;
using OA.Domin.DSA;
using OA.Domin;

namespace OA.WASM.Pages.DSA.PersonDonators
{
    public class PersonDonatorsListBase : ListBase<PersonDonator>
    {

        public async Task GetIndexDataEvent(string indexName)
        {
            var indexData = new List<IndexData>();
            if (indexName == nameof(Person))
                indexData = await GetIndexData<Person>();

            GridFilterRef.IndexDatas = indexData;
        }

    }
}
