﻿using Abp.AutoMapper;
using Abp.Organizations;

namespace kns.TourLand.Dto
{
    [AutoMapFrom(typeof(OrganizationUnit))]
    public class OrganizationUnitDto
    {
        public long Id { get; set; }

        public string Code { get; set; }

        public string DisplayName { get; set; }

        public int? TenantId { get; set; }
    }
}