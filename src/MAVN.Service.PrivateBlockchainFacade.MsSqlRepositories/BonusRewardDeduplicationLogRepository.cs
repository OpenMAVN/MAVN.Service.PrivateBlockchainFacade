﻿using System;
using System.Threading.Tasks;
using MAVN.Persistence.PostgreSQL.Legacy;
using MAVN.Service.PrivateBlockchainFacade.Domain.Deduplication;
using MAVN.Service.PrivateBlockchainFacade.MsSqlRepositories.Contexts;
using MAVN.Service.PrivateBlockchainFacade.MsSqlRepositories.Entities.Deduplication;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace MAVN.Service.PrivateBlockchainFacade.MsSqlRepositories
{
    public class BonusRewardDeduplicationLogRepository : IDeduplicationLogRepository<BonusRewardDeduplicationLogEntity>
    {
        private readonly PostgreSQLContextFactory<PbfContext> _contextFactory;

        public BonusRewardDeduplicationLogRepository(PostgreSQLContextFactory<PbfContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<bool> IsDuplicateAsync(string key)
        {
            using (var context = _contextFactory.CreateDataContext())
            {
                var deduplicationEntry = BonusRewardDeduplicationLogEntity.Create(key, DateTime.UtcNow);

                try
                {
                    await context.BonusRewardDeduplicationLog.AddAsync(deduplicationEntry);

                    await context.SaveChangesAsync();
                }
                catch (DbUpdateException e)
                {
                    if (e.InnerException is PostgresException sqlException &&
                        sqlException.SqlState == PostgresErrorCodes.UniqueViolation)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}
