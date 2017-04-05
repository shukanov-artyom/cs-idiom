// Null argument checking and null coalesce operator using ?? operator


// Checking constructor parameters befor storing them in object state.
public class Example
{
    private readonly Dependency dependendcy;

    public Example(Dependency dependendcy)
    {
        this.dependendcy = dependendcy ?? 
            throw new ArgumentNullException("dependency");
    }
}

// Null coalesce using multiple ?? operators.
Dependency a = b ?? c ?? new Dependency();
