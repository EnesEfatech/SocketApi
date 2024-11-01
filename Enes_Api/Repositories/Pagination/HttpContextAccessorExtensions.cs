﻿namespace Enes_Api.Repositories.Pagination
{
    public static class HttpContextAccessorExtensions
    {
        public static string GetRequestUri(this IHttpContextAccessor httpContextAccessor)
        {
            if (httpContextAccessor == null)
            {
                throw new ArgumentNullException(nameof(httpContextAccessor));
            }

            var request = httpContextAccessor.HttpContext.Request;
            return string.Concat(request.Scheme, "://", request.Host.ToUriComponent());
        }

        public static string GetRoute(this IHttpContextAccessor httpContextAccessor)
        {
            if (httpContextAccessor == null)
            {
                throw new ArgumentNullException(nameof(httpContextAccessor));
            }

            return httpContextAccessor.HttpContext.Request.Path.Value;
        }
    }
}
