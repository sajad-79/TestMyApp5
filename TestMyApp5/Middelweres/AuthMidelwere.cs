namespace TestMyApp5.Middelweres
{
    public class AuthMidelwere
    {
        private RequestDelegate _next;
        public AuthMidelwere(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {

            //HttpRequest
            //HttpRequest
            string userName = context.Request.Query["username"];
            string password = context.Request.Query["password"];
            string path = context.Request.Path.ToString();
            if (path.StartsWith("/api/admin"))
            {
                if (userName == "Admin" && password == "12345")
                {
                    await _next(context);
                }
                else
                {
                    await context.Response.WriteAsJsonAsync(new
                    {
                        message = "شما دسترسی لازمه را ندارید."
                    });
                }
            }
            else
            {
                await _next(context);
            }
            await _next(context);
            //HttpResponse
        }
    }
}
