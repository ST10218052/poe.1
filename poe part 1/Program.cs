// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace poe;
public class POE
{
    String[] ingreList;
    int[] ingreQuantity;
    int[] ingreMeasurements;
    string[] units;
    String[] description;

    string RecipeName;
    int engreNum;
    int n;
    int step;
    int count;
    Boolean m = true;
    public POE()
    {
        String[] ingreList = new String[0];
        int[] ingreQuantity = new int[0];
        int[] ingreMeasurements = new int[0];
        string[] units = new string[0];
        String[] description = new string[0];
    }


    public void EnterRecipe()
    {

        Console.WriteLine("Welcome ");
        Console.WriteLine("enter recipe name ");
        RecipeName = Console.ReadLine();


        Console.WriteLine("Enter  the number of ingridients you want to enter ");
        engreNum = int.Parse(Console.ReadLine());

        ingreList = new string[engreNum];///ttttttt
        ingreQuantity = new int[engreNum];
        ingreMeasurements = new int[engreNum];
        units = new string[engreNum];


        for (int i = 0; i < engreNum; i++)
        {



            //tring units= Console.ReadLine();
            //ngreMeasurements[i] = unitMes(ingreMeasurements[i],units);



            Console.WriteLine("ingredient name");
            ingreList[i] = Console.ReadLine();

            Console.WriteLine("ingredient Quantity");
            ingreQuantity[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("units of the ingredients measurements (mg),(g),(kg),(ml),(l)");
            units[i] = Console.ReadLine();
        }

        Console.WriteLine("num of steps ");
        int step = int.Parse(Console.ReadLine());

        description = new String[step];
        for (int i = 0; i < step; i++)
        {
            Console.WriteLine("please enter  step " + count + " of the recipe");
            description[i] = Console.ReadLine();

            count++;
        }
    }

    public void Display()
    {
        int count1 = 1;
        for (int i = 0; i < ingreList.Length; i++)
        {
            Console.WriteLine(ingreList[i] + " " + ingreQuantity[i] + " " + units[i]);
        }

        for (int i = 0; i < ingreList.Length; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Steps ");
            Console.WriteLine("step " + count1 + description[i]);
            count1++;
        }
    }

    public void ChangeQuantity()
    {

        Console.WriteLine("Choose the factor that you would like ingredients to be affected with: \n 1-0.5(half) \n2-2(double) \n3- 3(triple) \n 4-remain the same");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < engreNum; i++)
        {
            ingreQuantity[i] *= n;
        }
    }

    public void Normal()
    {
        for (int i = 0; i < engreNum; i++)
        {
            ingreQuantity[i] *= n;
        }
    }

    public void clear()
    {
        ingreList = new String[0];
        ingreQuantity = new int[0];
        ingreMeasurements = new int[0];
        units = new string[0];
        description = new string[0];
    }



}


public class poe
{
    public static void Main(String[] args)
    {
        POE pOE = new POE();
        int l;
        do
        {
            Console.WriteLine("1.Enter  Recipe details ");
            Console.WriteLine("2.Display recipe  ");
            Console.WriteLine("3.change Quantity ");
            Console.WriteLine("4.Clear your recipes  ");
            Console.WriteLine("5. set normal Quantity ");
            Console.WriteLine("6.Done  ");

            l = int.Parse(Console.ReadLine());

            switch (l)
            {
                case 0:
                case 1:
                    pOE.EnterRecipe();
                    break;
                case 2:
                    pOE.Display();
                    break;
                case 3:
                    pOE.ChangeQuantity();
                    break;
                case 4:
                    pOE.clear();
                    break;
                case 5:
                    pOE.Normal();
                    break;
            }
        } while (l < 6);
    }
}
