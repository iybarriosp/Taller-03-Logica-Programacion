using Exercise29;
using Shared;

string structure = ConsoleExtension.GetString("Dibuje el puente: ") ?? "";

Bridge bridge = new Bridge(structure);

//all methods have to be valid
if (bridge.ValidateBases() &&
    bridge.ValidateBridgeSymmetry() &&
    bridge.ValidatePlatform() &&
    bridge.ValidateCharacters() )
{
    Console.WriteLine("VALIDO");
}
else
{
    Console.WriteLine("INVALIDO");
}
