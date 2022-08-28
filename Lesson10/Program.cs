using System;

public enum Conditions
{
    newBook,
    good,
    bad,
    writeOff
}

public enum Statuses
{
    onShelf,
    atTheReader,
    lost
}

public class bookLibrary
{
    public static int maxAmount = 50000;
    public string nameBook;
    public string codeBook;
    public Statuses statusBook;
    public Conditions bookCondition;

    public string getBookCode()
    {       
        return codeBook;
    }

    public string getBookName()
    {
        return nameBook;
    }

    public void setStatus(Statuses status)
    {
        statusBook = status;
    }

    public Statuses getStatus()
    {
        return statusBook;
    }

    public void setBookCondition(Conditions condition)
    {
        bookCondition = condition;
    }
    public Conditions getBookCondition()
    {
        return bookCondition;
    }
}
//checked
