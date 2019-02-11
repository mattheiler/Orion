using System;
using Microsoft.Azure.WebJobs.Description;

namespace Azure.DependencyInjection
{
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class InjectAttribute : Attribute
    {
    }
}