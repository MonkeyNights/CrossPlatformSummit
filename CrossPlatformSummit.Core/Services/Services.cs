namespace CrossPlatformSummit.Core.Services
{
    public static class Services
    {
        readonly static PortableIoC.PortableIoc _ioc = new PortableIoC.PortableIoc();

        public static PortableIoC.PortableIoc IoC
        {
            get
            {
                return _ioc;
            }
        }
    }
}
