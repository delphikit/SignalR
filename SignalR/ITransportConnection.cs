﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace SignalR
{
    public interface ITransportConnection
    {
        IDisposable Receive(string messageId, Action<Exception, PersistentResponse> callback);

        Task<PersistentResponse> ReceiveAsync(CancellationToken timeoutToken);
        Task<PersistentResponse> ReceiveAsync(string messageId, CancellationToken timeoutToken);

        Task SendCommand(SignalCommand command);
    }
}