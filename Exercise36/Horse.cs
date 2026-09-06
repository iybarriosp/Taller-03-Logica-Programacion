using System.Runtime.ExceptionServices;

namespace Exercise36;

public class Horse //Represents the horse
{

    //Properties
    public string Position 
    { 
        get; 
        set; 
    }


    //Constructor
    public Horse(string position)
    {
        Position = position;
    }


    
    //Methods
public void Move(string movement) //Movement the horse
    {
        char column = Position[0]; //Save the letter of the actual position

        int row = int.Parse(Position[1].ToString()); //Save the number of the actual position. parse to change the number

        if (movement == "DR") //Down 2 and right 1
        {
            column++;
            row -= 2; //Move two rows down
        }

        if (movement == "RD") //Right 2 and down 1
        {
            column = (char)(column + 2); //Move two columns to the right example: C-D-E to right
            row--; //Move one row down
        }

        if (movement == "LD") //Left 2 and down 1
        {
            column = (char)(column - 2); //Move two columns to the left
            row--; //Move one row down
        }

        if (movement == "RU") //Right 2 and up 1
        {
            column = (char)(column + 2); //Move two columns to the right
            row++; //Move one row up
        }

        if (movement == "UR") //Up 2 and right 1
        {
            column++; //Move one column to the right
            row += 2; //Move two rows up
        }

        if (movement == "UL") //Up 2 and left 1
        {
            column--; //Move one column to the left
            row += 2; //Move two rows up
        }

        if (movement == "LU") //Left 2 and up 1
        {
            column = (char)(column - 2); //Move two columns to the left
            row++; //Move one row up
        }

        if (movement == "DL") //Down 2 and left 1
        {
            column--; //Move one column to the left
            row -= 2; //Move two rows down
        }

        Position = column.ToString() + row.ToString(); //Save the new position of the horse
    }
}