
namespace HelloWorld;

public class UserAgeHandler
{
    public void Handle(int userAge)
    {
        switch (userAge)
        {
            case < 0:
                Console.WriteLine($"userAge '{userAge}' cannot be less than 0");
                return;
            case > 200:
                Console.WriteLine($"userAge '{userAge}' cannot be more than 200");
                return;
            default:
                Console.WriteLine($"You inputted {userAge}");
                break;
        }
    }
}