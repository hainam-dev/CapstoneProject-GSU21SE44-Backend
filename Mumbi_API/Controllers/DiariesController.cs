﻿using Microsoft.AspNetCore.Mvc;
using Mumbi.Application.Dtos.Diaries;
using Mumbi.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mumbi_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiariesController : ControllerBase
    {
        private readonly IDiaryService _diaryService;

        public DiariesController(IDiaryService diaryService)
        {
            _diaryService = diaryService;
        }
        [HttpPost("AddDiary")]
        public async Task<IActionResult> AddDiary(CreateDiaryRequest request)
        {
            return Ok(await _diaryService.AddDiary(request));
        }

        [HttpGet("GetDiaryOfChildren/{childId}")]
        public async Task<IActionResult> GetDiaryOfChildren(string childId)
        {
            return Ok(await _diaryService.GetDiaryOfChildren(childId));

        }
        [HttpPut("UpdateDad/{Id}")]
        public async Task<IActionResult> UpdateDiary(string childID, int Id, UpdateDiaryRequest request)
        {
            if(childID != request.ChildId)
            {
                return BadRequest();
            }
            if (Id != request.Id)
            {
                return BadRequest();
            }

            return Ok(await _diaryService.UpdateDiaryRequest(request));
       }

        [HttpPut("DeleteDiary/{Id}")]
        public async Task<IActionResult> DeleteDiary(string childId, int Id)
        {
            return Ok(await _diaryService.DeleteDiary(childId, Id));
        }
    }
}
