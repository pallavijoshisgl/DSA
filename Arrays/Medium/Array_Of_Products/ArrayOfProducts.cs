using System;

public class ArrayOfproducts
{
    public int[] ArrayOfProducts(int[] array)
    {
        
        int[] productArray = new int[array.Length];
        

        int leftRunningpPoduct = 1;
        for(int i = 0; i<array.Length; i++)
        {
            productArray[i] = leftRunningpPoduct;
            leftRunningpPoduct = leftRunningpPoduct * array[i];
        }

        int rightRunningProduct = 1;
        for (int j = array.Length - 1; j >= 0;j--)
        {
            productArray[j] = productArray[j] * rightRunningProduct;
            rightRunningProduct = rightRunningProduct * array[j];
        }

        return productArray;
    }

    public static void Main(string[] args)
    {

    }
}