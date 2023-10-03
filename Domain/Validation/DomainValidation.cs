using Domain.Exceptions;

namespace Domain.Validation;

public class DomainValidation
{
    public static void NotNull(object target, string fieldName)
    {
        if (target is null)
            throw new EntityValidationException($"{fieldName} should not be null");
    }

}