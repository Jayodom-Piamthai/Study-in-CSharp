namespace TodoApi.Models;

// todoitem data model to be use for CRUD and such
public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}