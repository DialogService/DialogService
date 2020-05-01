namespace DialogService.Items
{
    /// <summary>
    /// Defines an item with a content
    /// </summary>
    public interface IContentItem : IContentItem<IDialogItem>
    { }

    /// <summary>
    /// Defines an item with specific content type
    /// </summary>
    /// <typeparam name="T">Content type</typeparam>
    public interface IContentItem<T> : IDialogItem
    {
        T Content { get; set; } 
    }
}
