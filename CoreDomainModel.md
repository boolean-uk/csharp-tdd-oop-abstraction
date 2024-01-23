```C#
class TodoItem {
    private string Title { get; }
    private string Description { get; }
    private bool Status
    private DateTime date;

    public stirng Title { get { return Title }; set { setTitle() }; }
    public stirng Description { get { return Description }; set { setDescripton() }; }
    public bool isDone { get { return Status }; set { setStatus() }; }
    public string Date {get { date.ToString() }; } 

    public TodoItem(String title, String detail, bool status) {
        // set
    }

    private void setStatus(bool status); // set the private status to the new status
    private void setDescription(string description);
    private void setTitle(string title);
}
```