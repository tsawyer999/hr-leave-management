namespace HR.LeaveManagement.Application.Contracts;

public class BadRequestException : Exception
{
    public BadRequestException(string invalidLeaveType, object validationResult)
    {
        throw new NotImplementedException();
    }
}