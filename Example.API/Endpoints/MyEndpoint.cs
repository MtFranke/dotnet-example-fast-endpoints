using Example.API.DTO;
using FastEndpoints;

namespace Example.API.Endpoints;

public class MyEndpoint: Endpoint<MyRequest>
{
    public override void Configure()
    {
        Post("/api/user/create");
        AllowAnonymous();
        DontThrowIfValidationFails();

    }

    public override async Task HandleAsync(MyRequest req, CancellationToken ct)
    {
        var response = new MyResponse()
        {
            FullName = req.FirstName + " " + req.LastName,
            IsOver18 = req.Age > 18
        };

        await SendAsync(response, statusCode:200, ct);
    }
}