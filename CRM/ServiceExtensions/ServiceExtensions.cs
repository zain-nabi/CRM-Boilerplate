using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;

namespace Triton.CRM.WebApi
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigureTransient(this IServiceCollection services)
        {
            //services.AddTransient<IDashboard, DashboardRepository>();
            //services.AddTransient<ICustomer, CustomerRepository>();
            //services.AddTransient<ICustomerAssessment, CustomerAssessmentRepository>();
            //services.AddTransient<IMeetingsAndCalls, CustomerMeetingRepository>();
            //services.AddTransient<IRates, RateRepository>();
            //services.AddTransient<ICustomerReport, CustomerReportRepository>();
        }

        public static void ConfigureOutputFormatters(this IServiceCollection services)
        {
            services.AddControllers(opt => // or AddMvc()
            {
                // remove formatter that turns nulls into 204 - No Content responses
                // this formatter breaks Angular's Http response JSON parsing
                opt.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>();
            });
        }
    }
}
