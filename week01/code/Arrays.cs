using System.Diagnostics;
using System.Runtime.InteropServices;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // create the var for the resulting array
        
        var result = new double[length];

        // populate the array with the multiples of the supplied number

        for (var i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        // return the resulting array

        return result; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        //make result to add the rotated list to
        var result = new List<int>();
        // set variable to get the index of data you need
        var wrap = data.Count - amount;
        for (var i = 0; i < data.Count; i++)
        {
            // this resets the index so once it's out of range the next thing copied will be the first. 
            if (wrap >= data.Count)
            {
                wrap = 0;
            }
            
            result.Add(data[wrap]);

            Debug.WriteLine(string.Join(", ", result));

            // incriment wrap to move to the next item in data
            wrap++;
        }

        // replace data with the result
        data.Clear();
        data.AddRange(result);
    }

}
