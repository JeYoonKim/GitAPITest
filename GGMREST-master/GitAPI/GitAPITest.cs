using System;
using GGMREST.Proxy;
using GitAPI.Git;
using GitAPI.Git.Entity;
using Xunit;

namespace GitAPI
{
    public class GitAPITest
    {
        private IGitService _gitService;

        public GitAPITest()
        {
            Factory factory = new Factory("https://api.github.com/");
            _gitService = factory.Create<IGitService>();
        }

        [Fact]
        public void Owner()
        {
            // Unit Test에선 await 쓰기가 불편함.
            //RequestData<OwnerData> owner = await Service.GetTicker();

            var getOwnerTask = _gitService.GetOwner();
            while (!getOwnerTask.IsCompleted) { }
            RequestData<OwnerData>[] ticker = getOwnerTask.Result;
            Assert.NotNull(ticker);
        }
    }
}
