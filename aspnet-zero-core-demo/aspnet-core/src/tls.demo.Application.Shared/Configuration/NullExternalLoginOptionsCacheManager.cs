﻿namespace tls.demo.Configuration
{
    public class NullExternalLoginOptionsCacheManager : IExternalLoginOptionsCacheManager
    {
        public static NullExternalLoginOptionsCacheManager Instance { get; } = new NullExternalLoginOptionsCacheManager();
        public void ClearCache()
        {
        }
    }
}