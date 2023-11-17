// See https://aka.ms/new-console-template for more information

using HelloWorld;

Console.WriteLine("Hello, World!");
Console.WriteLine(Environment.OSVersion);
Console.WriteLine(Environment.GetEnvironmentVariable("PATH"));
Console.WriteLine(ThisAssembly.Git.Commit);
Console.WriteLine("WHAT IS UR AGE");
var result = Console.ReadLine();

// I love OOP

int userAge;
try {
  userAge = new UserInputValidator().Validate(result);
} catch (Exception ex) {
  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine("[ERROR] " + ex.Message);
  Console.ResetColor();
  return;
}

var handler = new UserAgeHandler();
handler.Handle(userAge);

new HardwareHandler().Handle();