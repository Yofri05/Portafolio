var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Portafolio_ApiService>("apiservice");

builder.AddProject<Projects.Portafolio_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
