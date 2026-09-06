using Exercise29;

Console.Write("Dibuje un puente: ");
string structure = Console.ReadLine() ?? "";

Bridge bridge = new Bridge(structure);

//every methods have to be validates
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
