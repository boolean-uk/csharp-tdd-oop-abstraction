```C#
class TodoItem {
    private string Title { get; }
    private string Detail { get; }
    private string Starus
    private DateTime date;

    public TodoItem(String title, String detail, String status) {
        // set
    }

    public void setStatus(string status); // set the private status to the new status
    public string getDate(); // get the date the TodoItem was created
    public string getStatus(); // return the private status 

    public string getDate(); // return date in string
    public string getStatus(); // return status
    public string getDetail(); // return details
    public string getTitle(); // return title
}
```