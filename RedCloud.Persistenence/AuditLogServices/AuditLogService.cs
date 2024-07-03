using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Persistenence.AuditLogServices
{
    public interface IAuditLogService
    {
        void LogAudit(AuditLog log);
    }

    public class AuditLogService : IAuditLogService
    {
        private readonly YourDbContext _dbContext;

        public AuditLogService(YourDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void LogAudit(AuditLog log)
        {
            _dbContext.AuditLogs.Add(log);
            _dbContext.SaveChanges();
        }
    }
    internal class AuditLogService
    {
    }
}
