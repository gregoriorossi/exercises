namespace GlobalErrorHandling.Exceptions
{
    public class CustomerNotFoundException : Exception
    {
        public CustomerNotFoundException(int id)
            : base($"Customer with {id} not found") { }
    }
}
