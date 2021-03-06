using ClassLibrary1.Entities;
using PIM_Web.Views.Reserva;
using System;
using System.Web.Mvc;

namespace PIM_Web.Controllers
{
    public class ReservaController : Controller
    {

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ReservaDto modelDto)
        {
            try
            {
                var _reservaService = new ReservaRepository();
                var id = new Random();
                var model = new Reservas
                {
                    Id = id.Next(),
                    ReservaDias = modelDto.ReservaDias,
                    ReservaDt = modelDto.ReservaDt
                };

                var hospModel = new Hospede
                {
                    Cpf = modelDto.HospCpf,
                    Nome = modelDto.HospNome
                };
                _reservaService.InsertReserva(model, hospModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
