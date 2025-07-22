namespace JobExplorer.Api.Dtos;

public class JobExplorerReadDto
{
    public string Position { get; set; }
    public string Company { get; set; }
    public string Location { get; set; }
    public string[] Tags { get; set; }
}