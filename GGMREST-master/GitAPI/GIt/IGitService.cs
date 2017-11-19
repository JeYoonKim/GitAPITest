using System.Threading.Tasks;
using GGMREST.Attribute;
using GitAPI.Git.Entity;


namespace GitAPI.Git
{
    public interface IGitService
    {

        [Header("User-Agent", ".NET Framework Test Client")]
        [GET("users/{username}/repos")]
        Task<RequestData<OwnerData>[]> GetOwner([Path("username")]UserName userName = UserName.JeYoonKim);

    }
}
