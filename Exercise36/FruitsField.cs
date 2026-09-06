namespace Exercise36;

public class FruitsField //Represents the fruits field
{

    //Properties

    public string Fruits 
    { 
        get; 
        set; 
    }


    //Constructor

     public FruitsField(string fruits)
    {
        Fruits = fruits;
    }


    //Methods

     public string GetFruit(string position) //Search a fruit in the horse position
    {
        string[] fruitsList = Fruits.Split(','); //Separate the fruits

        int i = 0;

        while (i < fruitsList.Length)
        {
            string fruit = fruitsList[i];

            if (fruit.StartsWith(position)) //Compare the horse position with the fruit position
            {
                return fruit[2].ToString(); //Return the fruit symbol
            }

            i++;
        }

        return ""; //There is not fruit in this position
    }

}