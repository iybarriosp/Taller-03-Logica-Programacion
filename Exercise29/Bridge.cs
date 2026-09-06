namespace Exercise29;

using Shared;
public class Bridge //Represents a bridge
{

    //Properties
    public string Structure //save something like that: *==+===+==*
    { 
        get; 
        set; 
    }  


    //Constructor
    public Bridge(string structure)
    {
        Structure = structure; //Save the representation of the bidge user for example *==+===+==*
    }

    //Methods
    public bool ValidateBases() //Validates that the bridge starts and ends with a base *
    {
     
        if (!Structure.StartsWith("*") || !Structure.EndsWith("*")) //ask if the text starts and ends with *
        {
            return false;
        }
        int position = 1; //start after the first *

        while (position < Structure.Length - 1)
        {
            if (Structure[position] == '*') //find * in the middle
            {
                return false;
            }

            position++;
        }

        return true;
    }

    public bool ValidateBridgeSymmetry()
    {
        int left = 0; //the first position in a string start with 0
        int right = Structure.Length - 1; //the last position is the length - 1

        while (left < right)
        {
            if (Structure[left] != Structure[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    public bool ValidatePlatform()
    {
        int position = 0;
        int platform = 0;
        int middle = Structure.Length / 2;
      


        while (position < Structure.Length)
        {
            if (Structure[position] == '=')//ask if the actual caracter is a =
            {
                platform++; //contador

                //rule 1

                if (platform >= 4)//Don´t allow 4 or more = in a row
                {
                    return false;
                }

                //rule 2
                if (platform == 3)//Find 3 = in a row 
                {
                    if (position - 1 != middle)
                    {
                    return false;
                    }
                }

                //rule 3

                if (platform == 2) //suport before o after of each 2 =
                {
                    bool supportRight = false;
                    bool supportLeft = false;

                    if (position + 1 < Structure.Length)
                    {
                        if (Structure[position + 1] == '+')
                        {
                            supportRight = true;
                        }
                    }

                    if (position - 2 >= 0)
                    {
                        if (Structure[position - 2] == '+')
                        {
                            supportLeft = true;
                        }
                    }

                    if (supportRight == false && supportLeft == false)
                    {
                        return false;
                    }
                }

                
            }
            else
            {
                platform = 0;//if there is not = the sequence finishes and starts again in 0
            }

            position++;//pass the next position
        }

        return true;
    }

    public bool ValidateCharacters() //Validate if the user put an diferente carcter of rules
    {
        int position = 0;

        while (position < Structure.Length)
        {
            if (Structure[position] != '*' &&
                Structure[position] != '=' &&
                Structure[position] != '+')
            {
                return false;
            }

            position++;
        }

        return true;
    }

}