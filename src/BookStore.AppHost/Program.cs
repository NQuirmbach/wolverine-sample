var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.BookStore_ApiService>("apiservice");

builder.AddProject<Projects.BookStore_ItemService>("itemservice");

builder.AddProject<Projects.BookStore_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
