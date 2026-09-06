using Exercise36;
using Shared;

//Tomar information
string fruits = ConsoleExtension.GetString("ingresa posicion de las frutas: ") ?? "";
string initialPosition = ConsoleExtension.GetString("ingresa la posicion inicial del caballo: ") ?? "";
string movements = ConsoleExtension.GetString("ingresa los movimientos: ") ?? "";

//Create the objects
FruitsField field = new FruitsField(fruits);
Horse horse = new Horse(initialPosition);

string collectedFruits = "";

string[] movementsList = movements.Split(',');

int i = 0;

while (i < movementsList.Length)
{
    horse.Move(movementsList[i]); //Move the horse

    string fruit = field.GetFruit(horse.Position); //Search fruit in the new position

    if (fruit != "")
    {
        collectedFruits += fruit; //Save the collected fruit
    }

    i++;
}

Console.WriteLine("Los frutos recogidos son: " + collectedFruits);
