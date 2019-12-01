using Microsoft.Extensions.DependencyInjection;
using PINValidation.Contracts.Validation;
using PINValidation.Validation;
using PINValidation.Validation.Sections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PINValidation.DependencyInjection
{
    public static class PinValidtorExtension
    {
        public static IServiceCollection AddPinValidator(this IServiceCollection services)
        {
            services.AddScoped<IPinValidator, PinValidator>(x =>
            {
                IList<IPinSectionValidator> validators = new List<IPinSectionValidator>();
                validators.Add(new Length(0));
                validators.Add(new ContentIsDigits(1));
                validators.Add(new Dates(2));
                validators.Add(new Checksum(3));
                return new PinValidator(validators);
            });
            return services;
        }
    }
}
