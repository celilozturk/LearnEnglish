﻿using LearnEnglish.Base;
using LearnEnglish.Migrations;
using LearnEnglish.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnEnglish.Controllers
{
    public class InstructionController : Controller
    {
        private readonly LearnEnglishContext _db;

        public InstructionController(LearnEnglishContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            Instruction model = JsonConvert.DeserializeObject<Instruction>(TempData["instruction"].ToString());
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(string RichText, int Id)
        {
            var ajaxResponse = new AjaxResponse();
            try
            {
                var instructionDetail = new InstructionDetail();
                instructionDetail.Info = RichText;
                instructionDetail.InstructionId = Id;
                instructionDetail.CreatedDate = DateTime.Now;
                instructionDetail.Rank = byte.MinValue;
                _db.InstructionDetails.Add(instructionDetail);
                _db.SaveChanges();
                ajaxResponse.Result = true;
                ajaxResponse.Message = "RichText added successfully";

            }
            catch (Exception e)
            {
                ajaxResponse.Result = false;
                ajaxResponse.Message = "Something went wrong.";
                ajaxResponse.DetailMessage = e.InnerException.Message;
            }
            return Json(ajaxResponse);
        }
        [HttpPost]
        public IActionResult GetDetails(int Id)
        {
            var ajaxResponse = new AjaxResponse();
           var details= _db.InstructionDetails.Where(x=>x.InstructionId==Id).ToList();
            ajaxResponse.Data = details;
            ajaxResponse.Message = "test";
            ajaxResponse.Result=true;
            return Json(ajaxResponse);
        }
    }
}