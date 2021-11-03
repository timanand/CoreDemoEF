using CoreDemoEF.Data;
using CoreDemoEF.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemoApplication.Controllers
{
    public class EmployeesController : Controller
    {

        private readonly IUow _uow;

        public EmployeesController(IUow uow)
        {
            _uow = uow;
        }


        [HttpGet]
        public IActionResult ListEmployees()
        {
            var employees = _uow.StaffRepository.GetAll();
            return View(employees);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(StaffMember staffMember)
        {
            if(ModelState.IsValid)
            {
                _uow.StaffRepository.Add(staffMember);
                _uow.Commit();

                return RedirectToAction(nameof(ListEmployees));
            }

            return View(staffMember);
        }


        // Added 21/10/2021
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var employeeModel = _uow.StaffRepository.GetById(id);

            if (employeeModel == null)
            {
                // Redirect user to error view
            }

            return View(employeeModel);
        }


        // Added 21/10/2021
        [HttpPost]
        public ActionResult Edit(StaffMember staffMember)
        {
            if (ModelState.IsValid)
            {
                _uow.StaffRepository.Edit(staffMember);
                _uow.Commit();

                return RedirectToAction(nameof(ListEmployees));
            }

            return View(staffMember);
        }



        // 22/10/2021
        // Delete TODO !!!
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var employee = _uow.StaffRepository.GetById(id);
            return View(employee);
        }


        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            _uow.StaffRepository.Delete(id);
            _uow.Commit();

            return RedirectToAction(nameof(ListEmployees));
        }


    }
}
