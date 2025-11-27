using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIA_FINALS_SAKILA_GROUP.Models;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Staff;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : BaseController<Staff, StaffReadDTO, StaffCreateDTO, StaffUpdateDTO>
    {
        private readonly IStaffRepository _staffRepo;
        public StaffsController(IStaffRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _staffRepo = repo;
        }
    }
}
