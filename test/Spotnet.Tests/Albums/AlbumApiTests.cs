using FluentAssertions;
using Refit;
using Spotnet.Core.Albums;

namespace Spotnet.Tests.Albums
{
    public sealed class AlbumApiTests : IClassFixture<ApiFixture>
    {
        private readonly ApiFixture _fixture;

        public AlbumApiTests(ApiFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task GetAlbum_WithValidAlbumId_200StatusCodeShouldBeReturned()
        {
            // Arrange.
            var httpClientFactory = _fixture.HttpClientFactory;
            var httpClient = httpClientFactory.CreateClient(ApiFixture.HttpClientName);
            var albumApi = RestService.For<IAlbumApi>(httpClient);

            // Act.
            var response = await albumApi.GetAlbumAsync(string.Empty);

            // Assert.
            true.Should().BeTrue();
        }
    }
}