using Example.API.DTO;
using Example.API.Services;
using FastEndpoints;

namespace Example.API.Endpoints;

public class UserEndpoint : Endpoint<UserRegisterRequest>
{
    public IUserService Service { get; set; }

    public override void Configure()
    {
        Post("api/register");
        AllowAnonymous();
    }

    public override Task HandleAsync(UserRegisterRequest req, CancellationToken ct)
    {
        Service.Register();
        return base.HandleAsync(req, ct);
    }
}