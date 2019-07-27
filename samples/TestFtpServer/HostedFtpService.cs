// <copyright file="HostedFtpService.cs" company="Fubar Development Junker">
// Copyright (c) Fubar Development Junker. All rights reserved.
// </copyright>

using FubarDev.FtpServer;

namespace TestFtpServer
{
    /// <summary>
    /// Generic host for the FTP server.
    /// </summary>
    public class HostedFtpService : IHostedService
    {
        private readonly IFtpServerHost _ftpServerHost;

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedFtpService"/> class.
        /// </summary>
        /// <param name="ftpServerHost">The FTP server host that gets wrapped as a hosted service.</param>
        public HostedFtpService(
            IFtpServerHost ftpServerHost)
        {
            _ftpServerHost = ftpServerHost;
        }

        /// <inheritdoc />
        public Task StartAsync(CancellationToken cancellationToken)
        {
            return _ftpServerHost.StartAsync(cancellationToken);
        }

        /// <inheritdoc />
        public Task StopAsync(CancellationToken cancellationToken)
        {
            return _ftpServerHost.StopAsync(cancellationToken);
        }
    }
}
