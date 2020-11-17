using CalculatorAdoApi.Model;
using CalculatorInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorAdoApi.Controllers
{
    public class BodmasController : Controller
    {
        ISimpleCalculator _ISimpleCalculator = null;
        public BodmasController(ISimpleCalculator ISimCardRequestService)
        {
            _ISimpleCalculator = ISimCardRequestService;
        }
        // GET: BodmasController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BodmasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BodmasController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAddition(Bodmas objRequest)
        {
            int num1 = Convert.ToInt32(objRequest.Number1);
            int num2 = Convert.ToInt32(objRequest.Number2);
            
            var objCreateReq = _ISimpleCalculator.Add(num1, num2);
            if (objCreateReq != null)
            {

                return Ok(JsonConvert.SerializeObject(objCreateReq, Formatting.Indented));
            }
            else
            {

                //return NotFound(_ISimpleCalculator.RecordNotFound());
                return NotFound("Error");
            }
        }
        [HttpGet]
        public ActionResult GetMultiplication(Bodmas objRequest)
        {
            int num1 = Convert.ToInt32(objRequest.Number1);
            int num2 = Convert.ToInt32(objRequest.Number2);

            var objCreateReq = _ISimpleCalculator.Multiply(num1, num2);
            if (objCreateReq != null)
            {

                return Ok(JsonConvert.SerializeObject(objCreateReq, Formatting.Indented));
            }
            else
            {

                //return NotFound(_ISimpleCalculator.RecordNotFound());
                return NotFound("Error");
            }
        }

        [HttpGet]
        public ActionResult GetDivison(Bodmas objRequest)
        {
            int num1 = Convert.ToInt32(objRequest.Number1);
            int num2 = Convert.ToInt32(objRequest.Number2);

            var objCreateReq = _ISimpleCalculator.Divide(num1, num2);
            if (objCreateReq == null)
            {

                return Ok(JsonConvert.SerializeObject(objCreateReq, Formatting.Indented));
            }
            else
            {

                //return NotFound(_ISimpleCalculator.RecordNotFound());
                return NotFound("Error");
            }
        }
        [HttpGet]
        public ActionResult GetSubtraction(Bodmas objRequest)
        {
            int num1 = Convert.ToInt32(objRequest.Number1);
            int num2 = Convert.ToInt32(objRequest.Number2);

            var objCreateReq = _ISimpleCalculator.Subtract(num1, num2);
            if (objCreateReq != null)
            {

                return Ok(JsonConvert.SerializeObject(objCreateReq, Formatting.Indented));
            }
            else
            {

                //return NotFound(_ISimpleCalculator.RecordNotFound());
                return NotFound("Error");
            }
        }
        // POST: BodmasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BodmasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BodmasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BodmasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BodmasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
