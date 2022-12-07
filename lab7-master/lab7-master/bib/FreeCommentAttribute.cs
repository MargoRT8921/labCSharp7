namespace bib;

[AttributeUsage(AttributeTargets.Class)]
public class FreeCommentAttribute : Attribute
{
    public string? Comment { get; }
    public FreeCommentAttribute() { }
    public FreeCommentAttribute(string comment) => Comment = comment;
}