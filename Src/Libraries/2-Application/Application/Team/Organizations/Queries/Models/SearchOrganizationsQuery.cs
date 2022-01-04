﻿using TaskoMask.Application.Share.Dtos.Team.Organizations;
using TaskoMask.Application.Share.Helpers;
using TaskoMask.Application.Core.Queries;

namespace TaskoMask.Application.Team.Organizations.Queries.Models
{
    public class SearchOrganizationsQuery : BaseQuery<PaginatedListReturnType<OrganizationOutputDto>>
    {
        public SearchOrganizationsQuery(int page, int recordsPerPage, string term)
        {
            Page = page;
            RecordsPerPage = recordsPerPage;
            Term = term;
        }

        public int Page { get; }
        public int RecordsPerPage { get; }
        public string Term { get; }
    }
}
