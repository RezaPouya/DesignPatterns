using System.Threading.Tasks;
using Xunit;

namespace Creational.Singleton
{
    public class SingeltonPatternTest
    {
        [Fact]
        public void Should_Fail_If_There_Is_Two_Instance_Of_Singleton_EagerLoading()
        {
            Assert.Equal(PolicyEagerLoading.GetInstance(), PolicyEagerLoading.GetInstance());
        }

        [Fact]
        public void Should_Fail_If_There_Is_Two_Instance_Of_Singleton_Is_Invoked_EagerLoading()
        {
            Parallel.Invoke(() => PolicyEagerLoading.GetInstance(), () => PolicyEagerLoading.GetInstance());

            Assert.Equal(1, PolicyEagerLoading.Counter);
        }

        [Fact]
        public void Should_Fail_If_There_Is_Two_Instance_Of_Singleton_LazyLoading()
        {
            Assert.Equal(PolicyLazyLoading.GetInstance(), PolicyLazyLoading.GetInstance());
        }

        [Fact]
        public void Should_Fail_If_There_Is_Two_Instance_Of_Singleton_Is_Invoked_LazyLoading()
        {
            Parallel.Invoke(() => PolicyLazyLoading.GetInstance(), () => PolicyLazyLoading.GetInstance());

            Assert.Equal(1, PolicyLazyLoading.Counter);
        }


        [Fact]
        public void Should_Fail_If_There_Is_Two_Instance_Of_Singleton_EagerLoading_With_LazyLoading()
        {
            Assert.Equal(PolicyEagerLoadingWithLazyLoading.GetInstance(), PolicyEagerLoadingWithLazyLoading.GetInstance());
        }

        [Fact]
        public void Should_Fail_If_There_Is_Two_Instance_Of_Singleton_Is_Invoked_EagerLoading_With_LazyLoading()
        {
            Parallel.Invoke(() => PolicyEagerLoadingWithLazyLoading.GetInstance(), () => PolicyEagerLoadingWithLazyLoading.GetInstance());

            Assert.Equal(1, PolicyEagerLoadingWithLazyLoading.Counter);
        }
    }
}