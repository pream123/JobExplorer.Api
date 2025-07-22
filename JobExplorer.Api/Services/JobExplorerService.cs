using AutoMapper;
using System.Text.Json;
using JobExplorer.Api.Dtos;
using JobExplorer.Api.Model;

namespace JobExplorer.Api.Services;

public class JobExplorerService
{
    private readonly HttpClient _httpClient;
    private readonly IMapper _mapper;

    public JobExplorerService(IHttpClientFactory httpClientFactory, IMapper mapper)
    {
        _httpClient = httpClientFactory.CreateClient();
        _mapper = mapper;
    }

    public async Task<List<JobExplorerReadDto>> GetJobsAsync()
    {
        //getting api call using HttpClient
        var response = await _httpClient.GetAsync("https://remoteok.com/api");

        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        var jobs = JsonSerializer.Deserialize<List<JobExplorerModel>>(json, options);
        var filteredJobs = jobs?.Skip(1) ?? new List<JobExplorerModel>();

        return _mapper.Map<List<JobExplorerReadDto>>(filteredJobs);
    }
}