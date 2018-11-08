namespace ApiTesting.Framework.Models
{
    public class UserContext
    {
        public UserContext()
        {
            Providers = new Providers();
            LARS = new LARS();
            LARSSearch = new LARSSearch();
        }

        public Providers Providers { get; set; }
        public LARS LARS { get; set; }
        public LARSSearch LARSSearch { get; set; }
    }
}
