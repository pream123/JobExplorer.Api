namespace JobExplorer.Api.Model;

public class JobExplorerModel
{
    public string Id { get; set; }
    public string Position { get; set; }
    public string Company { get; set; }
    public string Location { get; set; }
    public string[] Tags { get; set; }
}