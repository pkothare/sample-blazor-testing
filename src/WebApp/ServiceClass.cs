namespace WebApp
{
    public class ServiceClass
    {
        public int DoSomething(string returnType)
        {
            if(string.IsNullOrWhiteSpace(returnType))
                throw new ArgumentException("Null or empty", nameof(returnType));

            if (returnType.Equals("positive", 
                StringComparison.InvariantCultureIgnoreCase))
                return 1;

            if (returnType.Equals("negative", 
                StringComparison.InvariantCultureIgnoreCase))
                return -1;

            else return 0;
        }
    }
}
