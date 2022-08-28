namespace Etech.Dal;

public class EmailDAL
{

    private DataContext _context;

    public EmailDAL(DataContext context)
    {
        _context = context;
    }

}