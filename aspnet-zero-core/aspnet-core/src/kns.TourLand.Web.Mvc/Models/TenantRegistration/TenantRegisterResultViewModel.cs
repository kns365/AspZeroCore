﻿using Abp.AutoMapper;
using kns.TourLand.MultiTenancy.Dto;

namespace kns.TourLand.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}