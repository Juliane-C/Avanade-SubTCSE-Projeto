using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Services;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Services
{
    public class EmployeeRoleService : IEmployeeRoleService
    {
        public async Task<Entities.EmployeeRole> AddEmployeeRole(Entities.EmployeeRole employeeRole)
        {
            throw new System.NotImplementedException();
        }
    }
}

//A função AddEmployeeRole está com sublinhado diferenciado no VSCode, mas não é erro.
