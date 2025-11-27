using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIA_FINALS_SAKILA_GROUP.Models;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Payment;
using SIA_FINALS_SAKILA_GROUP.Models.Repositories;

namespace SIA_FINALS_SAKILA_GROUP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : BaseController <Payment, PaymentReadDTO, PaymentCreateDTO, PaymentUpdateDTO>
    {
        private readonly IPaymentRepository _paymentRepo;

        public PaymentsController(IPaymentRepository repo, IMapper mapper) : base (repo, mapper)
        {
            _paymentRepo = repo;
        }
    }
}
