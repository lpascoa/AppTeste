
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoTeste.Application.Interface;
using ProjetoTeste.Domain.Entities;
using ProjetoTeste.MVC.ViewModels;

namespace ProjetoTeste.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        private readonly IEmployeeAppService _employeeApp;

        public EmployeeController(IEmployeeAppService employeeApp)
        {
            _employeeApp = employeeApp;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            var EmployeeViewModel = Mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(_employeeApp.GetAll());

            return View(EmployeeViewModel);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            var Employee = _employeeApp.GetById(id);
            var EmployeeViewModel = Mapper.Map<Employee, EmployeeViewModel>(Employee);

            return View(EmployeeViewModel);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeViewModel Employee)
        {
            if (ModelState.IsValid)
            {
                var EmployeeDomain = Mapper.Map<EmployeeViewModel, Employee>(Employee);
                _employeeApp.Add(EmployeeDomain);

                return RedirectToAction("Index");
            }
            return View(Employee);
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            var Employee = _employeeApp.GetById(id);
            var EmployeeViewModel = Mapper.Map<Employee, EmployeeViewModel>(Employee);

            return View(EmployeeViewModel);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmployeeViewModel Employee)
        {
            if (ModelState.IsValid)
            {
                var EmployeeDomain = Mapper.Map<EmployeeViewModel, Employee>(Employee);
                _employeeApp.Update(EmployeeDomain);

                return RedirectToAction("Index");
            }

            return View(Employee);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            var Employee = _employeeApp.GetById(id);
            var EmployeeViewModel = Mapper.Map<Employee, EmployeeViewModel>(Employee);

            return View(EmployeeViewModel);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var Employee = _employeeApp.GetById(id);
            _employeeApp.Remove(Employee);

            return RedirectToAction("Index");
        }
    }
}