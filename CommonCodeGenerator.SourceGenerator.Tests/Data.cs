namespace CommonCodeGenerator;

#pragma warning disable CA1819
// ReSharper disable once PartialTypeWithSinglePart
[GenerateToString]
public partial class Data
{
    public int Id { get; set; }

    public string Name { get; set; } = default!;

    public int[] Values { get; set; } = default!;

    [IgnoreToString]
    public int Ignore { get; set; }
}
#pragma warning restore CA1819

// ReSharper disable once PartialTypeWithSinglePart
[GenerateToString]
public partial class GenericData<T>
{
    public T Value { get; set; } = default!;
}
