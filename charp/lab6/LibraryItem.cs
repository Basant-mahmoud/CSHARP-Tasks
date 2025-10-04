using Expert_Level_Library_Management_System;

public abstract class LibraryItem : ILibraryAction
{
    public static int TotalItems = 0;
    private static int NextID = 1;

    public int ItemID { get; }                  // Auto-increment ID
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public bool IsAvailable { get; set; }
    public Location location { get; set; }

    
    public LibraryItem()
    {
        this.ItemID = NextID++;
        this.IsAvailable = true;
        TotalItems++;
    }

    public LibraryItem(string title, string author, int year, bool isAvailable, Location location)
        
    {
        this.Title = title;
        this.Author = author;
        this.Year = year;
        this.IsAvailable = isAvailable;
        this.location = location;
    }

    public abstract void DisplayInfo();

    public virtual void Borrow(string memberName)
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"Item '{Title}' has been borrowed by {memberName}.");
        }
        else
        {
            Console.WriteLine($"Item '{Title}' is not available.");
        }
    }

    public void Return()
    {
        IsAvailable = true;
        Console.WriteLine($"Item '{Title}' has been returned.");
    }
}
