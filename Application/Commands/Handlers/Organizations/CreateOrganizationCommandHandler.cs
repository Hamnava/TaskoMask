﻿using AutoMapper;
using CSharpFunctionalExtensions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaskoMask.Application.Commands.Models.Organizations;
using TaskoMask.Application.Resources;
using TaskoMask.Domain.Data;
using TaskoMask.Domain.Models;

namespace TaskoMask.Application.Commands.Handlers.Organizations
{
    public class CreateOrganizationCommandHandler : IRequestHandler<CreateOrganizationCommand, Result>
    {
        private readonly IOrganizationRepository _organizationRepository;
        private readonly IMapper _mapper;
        public CreateOrganizationCommandHandler(IOrganizationRepository organizationRepository, IMapper mapper)
        {
            _organizationRepository = organizationRepository;
            _mapper = mapper;
        }


        public async Task<Result> Handle(CreateOrganizationCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                //TODO add error to domain notifications
                return Result.Failure(ApplicationMessages.Create_Failed);
            }


            var organization = _mapper.Map<Organization>(request); 
            await _organizationRepository.CreateAsync(organization);

            return Result.Success(ApplicationMessages.Create_Success);
        }
    }
}
