﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskoMask.Application.Projects.Services;
using TaskoMask.Application.Core.Dtos.Projects;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using TaskoMask.Application.Projects.Commands.Models;
using TaskoMask.Application.Projects.Queries.Models;

namespace TaskoMask.web.Area.Admin.Controllers
{
    [Authorize]
    [Area("admin")]
    public class ProjectsController : BaseController
    {
        #region Fields

        private readonly IProjectService _projectService;

        #endregion

        #region Ctor

        public ProjectsController(IProjectService projectService, IMapper mapper) : base(mapper)
        {
            _projectService = projectService;
        }

        #endregion

        #region Public Methods




        /// <summary>
        /// 
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Index(string id)
        {
            var projectDetailQueryResult = await _projectService.GetDetailAsync(id);
            return View(projectDetailQueryResult);

        }



        /// <summary>
        /// 
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Create(string organizationId)
        {
            var model = new ProjectInputDto
            {
                OrganizationId = organizationId,
            };
            return View(model);
        }



        /// <summary>
        /// 
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Create(ProjectInputDto input)
        {
            if (!ModelState.IsValid)
                return View(input);

            var cmdResult = await _projectService.CreateAsync(input);
            return View(cmdResult, input);
        }




        /// <summary>
        /// 
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            var projectQueryResult = await _projectService.GetAsync(id);
            return View<ProjectBasicInfoDto, ProjectInputDto>(projectQueryResult);
        }


        /// <summary>
        /// 
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Update(ProjectInputDto input)
        {
            if (!ModelState.IsValid)
                return View(input);

            var cmdResult = await _projectService.UpdateAsync(input);
            return View(cmdResult, input);
        }



        #endregion

    }
}
