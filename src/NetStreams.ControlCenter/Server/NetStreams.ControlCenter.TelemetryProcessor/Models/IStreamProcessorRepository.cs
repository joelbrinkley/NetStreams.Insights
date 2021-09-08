﻿using System.Threading;
using System.Threading.Tasks;

namespace NetStreams.ControlCenter.TelemetryProcessor.Models
{
    public interface IStreamProcessorRepository
    {
        Task<StreamProcessor> GetAsync(string name, CancellationToken token);
        Task AddAsync(StreamProcessor streamProcessor, CancellationToken cancellationToken);
        Task UpdateAsync(StreamProcessor streamProcessor, CancellationToken cancellationToken);
    }
}
