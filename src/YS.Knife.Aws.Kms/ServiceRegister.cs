﻿using Amazon.KeyManagementService;
using Microsoft.Extensions.DependencyInjection;

namespace YS.Knife.Aws.Kms
{
    public class ServiceRegister : IServiceRegister
    {
        public void RegisterServices(IServiceCollection services, IRegisterContext context)
        {
            services.TryAddAWSService<IAmazonKeyManagementService>();
        }
    }
}
