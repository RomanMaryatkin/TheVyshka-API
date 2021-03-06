﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheVyshka.Data.Dto;
using TheVyshka.Data.Repositories;

namespace TheVyshka.Controllers
{
    public class TagController: Controller
    {
        private readonly ITagRepository _repository;

        public TagController(ITagRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _repository.GetAllAsync());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                return Ok(await _repository.GetByIdAsync(id));
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TagsDto item)
        {
            try
            {
                return Ok(await _repository.CreateAsync(item));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] TagsDto item)
        {
            try
            {
                return Ok(await _repository.UpdateAsync(item));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                return Ok(await _repository.DeleteAsync(id));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}