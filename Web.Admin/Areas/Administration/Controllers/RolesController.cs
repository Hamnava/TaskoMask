﻿using TaskoMask.Application.Administration.Roles.Commands.Models;
using TaskoMask.Application.Administration.Roles.Queries.Models;
using TaskoMask.Application.Administration.Roles.Services;
using TaskoMask.Application.Administration.Roles.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TaskoMask.Domain.Administration.Entities;
using TaskoMask.Web.Common.Controllers;

namespace TaskoMask.Web.Admin.Areas.Administration.Controllers
{

    [Authorize]
    [Area("Administration")]
    public class RolesController : BaseMvcController
    {
        #region Fields

        private readonly IRoleService _roleService;

        #endregion

        #region Ctor

        public RolesController(IRoleService roleService , IMapper mapper) : base(mapper)
        {
            _roleService = roleService;
        }

        #endregion

        #region Public Methods



        #endregion

        #region Private Methods



        #endregion


    }
}
