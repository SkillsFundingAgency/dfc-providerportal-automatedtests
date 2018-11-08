namespace ApiTesting.Framework.Models
{
    public class UserContext
    {
        public UserContext()
        {
            Post = new Post();
            User = new Users();
            Providers = new Providers();
            LARS = new LARS();
            LARSSearch = new LARSSearch();
        }

        public Post Post { get; set; }

        public Users User { get; set; }

        public Providers Providers { get; set; }

        public LARS LARS { get; set; }
        public LARSSearch LARSSearch { get; set; }
    }
}
