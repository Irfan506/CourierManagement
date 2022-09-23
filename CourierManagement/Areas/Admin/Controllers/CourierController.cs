using CourierManagement.Areas.Admin.Models;
using CourierManagement.Common.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourierManagement.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourierController : Controller
    {

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<CourierController> _logger;
        private readonly IEmailSender _emailSender;
        private readonly SignInManager<IdentityUser> _userSignIn;
        public CourierController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<CourierController> logger,
            IEmailSender emailSender,
            SignInManager<IdentityUser> userSignIn)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _userSignIn = userSignIn;
        }
        public IActionResult Index()
        {
            return View();
        }


        /*------------------------------------------Admin---------------------*/

        public IActionResult DashBoard()
        {
            return View();
        }


        public IActionResult ManageCustomer()
        {
            ViewBag.SomeData = "Hello From Asp.Net";
            var model = new CustomerListModel();
            return View(model);
        }
        public JsonResult GetCustomerData()
        {
            var dataTablesModel = new DataTablesAjaxRequestModel(Request);
            var model = new CustomerListModel();
            var data = model.GetCustomers(dataTablesModel);
            return Json(data);
        }
        
        public IActionResult EditCustomer(int id)
        {
            var model = new EditCustomerModel();
            model.LoadModelData(id);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditCustomer(EditCustomerModel model)
        {
            if (ModelState.IsValid)
            {
                model.Update();
            }

            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]

        public IActionResult DeleteCustomer(int id)
        {
            var model = new CustomerListModel();
            model.Delete(id);

            return RedirectToAction(nameof(ManageCustomer));

        }


        public IActionResult ManageCourier()
        {
            ViewBag.SomeData = "Hello From Asp.Net";
            var model = new CourierListModel();
            return View(model);
        }
        public JsonResult GetCourierData()
        {
            var dataTablesModel = new DataTablesAjaxRequestModel(Request);
            var model = new CourierListModel();
            var data = model.GetCouriers(dataTablesModel);
            return Json(data);
        }

        public IActionResult EditCourier(int id)
        {
            var model = new EditCourierModel();
            model.LoadModelData(id);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditCourier(EditCourierModel model)
        {
            if (ModelState.IsValid)
            {
                model.Update();
            }

            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]

        public IActionResult DeleteCourier(int id)
        {
            var model = new CourierListModel();
            model.Delete(id);

            return RedirectToAction(nameof(ManageCourier));

        }


        public IActionResult ManageTrack()
        {
            ViewBag.SomeData = "Hello From Asp.Net";
            var model = new TrackListModel();
            return View(model);
        }
        public JsonResult GetTrackData()
        {
            var dataTablesModel = new DataTablesAjaxRequestModel(Request);
            var model = new TrackListModel();
            var data = model.GetTracks(dataTablesModel);
            return Json(data);
        }
        public IActionResult AddTrack()
        {
            var model = new AddTrackModel();
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddTrack(AddTrackModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.AddTrack();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Failed to Add Track");
                    _logger.LogError(ex, "Add Track Failed");
                }

            }
            return View(model);
        }
        public IActionResult EditTrack(int id)
        {
            var model = new EditTrackModel();
            model.LoadModelData(id);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditTrack(EditTrackModel model)
        {
            if (ModelState.IsValid)
            {
                model.Update();
            }

            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]

        public IActionResult DeleteTrack(int id)
        {
            var model = new TrackListModel();
            model.Delete(id);

            return RedirectToAction(nameof(ManageTrack));

        }



        public IActionResult ManagePickup()
        {
            ViewBag.SomeData = "Hello From Asp.Net";
            var model = new PickupListModel();
            return View(model);
        }
        public JsonResult GetPickupData()
        {
            var dataTablesModel = new DataTablesAjaxRequestModel(Request);
            var model = new PickupListModel();
            var data = model.GetPickups(dataTablesModel);
            return Json(data);
        }
        public IActionResult AddPickup()
        {
            var model = new AddPickupModel();
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddPickup(AddPickupModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.AddPickup();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Failed to Add Pickup");
                    _logger.LogError(ex, "Add Pickup Failed");
                }

            }
            return View(model);
        }
        public IActionResult EditPickup(int id)
        {
            var model = new EditPickupModel();
            model.LoadModelData(id);
            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult EditPickup(EditPickupModel model)
        {
            if (ModelState.IsValid)
            {
                model.Update();
            }

            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]

        public IActionResult DeletePickup(int id)
        {
            var model = new PickupListModel();
            model.Delete(id);

            return RedirectToAction(nameof(ManagePickup));

        }
    }
}
