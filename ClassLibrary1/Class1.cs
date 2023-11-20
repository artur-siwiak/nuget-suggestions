namespace ClassLibrary1;
public class Class1
{
    private readonly IServiceCollection _serviceCollection; // Ctrl + . doesn't suggest any nuget packages 
    private readonly IMediatr _mediator; // Ctrl + . doesn't suggest any nuget packages
    private readonly AbstractValidator _abstractValidator; // same as above
    private readonly IConfiguration _configuration; // same as above

    // all other items after pressing Ctrl + . are displayed correctly - like: generate type, disable spelling and so one
}
