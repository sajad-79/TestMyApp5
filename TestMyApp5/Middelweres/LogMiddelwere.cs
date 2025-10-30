namespace TestMyApp5.Middelweres
{ 
    public class LogMiddelwere
    {
        private RequestDelegate _next;
        private static Dictionary<string, int> _requestUrls=new Dictionary<string, int>();
        public LogMiddelwere(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            string path = context.Request.Path.ToString().ToLower();
            if (!_requestUrls.ContainsKey(path)) {
                _requestUrls.Add(path, 1);
                Console.WriteLine($"{path}: 1");

            }
            else
            {
                int count=_requestUrls[path];
                _requestUrls[path] = ++count;
                Console.WriteLine($"{path}: {count}");
            }


            await _next(context);
        }
    }
}
