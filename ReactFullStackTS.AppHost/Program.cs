var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ReactFullStackTS_Server>("reactfullstackts-server");

builder.Build().Run();
