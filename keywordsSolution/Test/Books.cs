namespace Library;
public class Book{
    private int [] bookid;

    public Book()
    {
        this.bookid=new int [2];
        this.bookid[0]=9;
        this.bookid[1]=26;
    }

    public int this[int key]
    {
        get{return bookid[key];}
        set{this.bookid[key]=value;}
    }
}