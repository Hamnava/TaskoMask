﻿
using TaskoMask.Application.Projects.Commands.Validations;
using TaskoMask.Application.Core.Commands;
using System.ComponentModel.DataAnnotations;
using TaskoMask.Application.Core.Resources;

namespace TaskoMask.Application.Projects.Commands.Models
{
   public class UpdateProjectCommand : ProjectCommand
    {
        public UpdateProjectCommand(string id, string name, string description )
        {
            Id = id;
            Name = name;
            Description = description;
        }

        [Required(ErrorMessageResourceName = nameof(ApplicationMetadata.Required), ErrorMessageResourceType = typeof(ApplicationMetadata))]
        public string Id { get; private set; }


    }
}
