﻿using kns.TourLand.EntityFrameworkCore;

namespace kns.TourLand.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly TourLandDbContext _context;

        public InitialHostDbBuilder(TourLandDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
