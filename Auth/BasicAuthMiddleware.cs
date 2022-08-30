namespace Etech.Auth;

using System.Net.Http.Headers;
using System.Text;
using Etech.Bll;

public class BasicAuthMiddleware
{
    private readonly RequestDelegate _next;

    public BasicAuthMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context, IUsuarioBLL usuarioBLL)
    {
        try
        {
            var authHeader = AuthenticationHeaderValue.Parse(context.Request.Headers["Authorization"]);
            if(authHeader.Parameter == null) {
                return;
            }
            var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
            var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':', 2);
            var username = credentials[0];
            var password = credentials[1];

            // authenticate credentials with user service and attach user to http context
            context.Items["Login"] = await usuarioBLL.Autentica(username, password);
        }
        catch
        { }

        await _next(context);
    }
}