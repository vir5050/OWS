using System;
using System.Collections.Generic;
using System.Text;

namespace OWSShared.Interfaces
{
    public interface IServerHealthMonitoringJob
    {
        void DoWork();
        void Dispose();
    }
}
