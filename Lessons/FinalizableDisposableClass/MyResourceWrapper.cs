namespace FinalizableDisposableClass1;

public class MyResourceWrapper : IDisposable
{
    private bool disposed = false;

    public void Dispose()
    {
        CleanUp(true);
        GC.SuppressFinalize(this);
    }

    private void CleanUp(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                // Free managed resources here
                // e.g., if you had a database connection, close it
            }
            // Free unmanaged resources here
        }
        disposed = true;
    }
    ~MyResourceWrapper()
    {
        CleanUp(false);
    }
}