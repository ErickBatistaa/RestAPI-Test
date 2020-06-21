using RestAPI_Test.Models;
using System.Collections.Generic;

namespace RestAPI_Test.Services.Interfaces
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
