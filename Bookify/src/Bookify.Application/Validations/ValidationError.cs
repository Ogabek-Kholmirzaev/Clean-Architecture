namespace Bookify.Application.Validations;

public sealed record ValidationError(string PropertyName, string ErrorMessage);