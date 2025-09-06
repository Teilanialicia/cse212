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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // Create the array that is going to be returned. The length of the array will be the same as the number of multiples
        double[] returnArray = new double[length];
        
        // Start a for loop to put every value in the array
        for (int i = 0; i < length; i++)
        {
            // The multiples are the same as number*i so add that to the array at position i
            returnArray[i] = number*(i+1);
        }

        return returnArray; // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Slice the array into two parts: one that goes from 0 to the total array count minus the amount rotated
        // and then one that goes from the total array count minus the amount rotated to the end
        // Concatenate the beginning slice onto the end slice and then put those values into the data List

        // Get the beginning slice and end slice
        List<int> beginningSlice = data.GetRange(0, data.Count - amount);
        List<int> endSlice = data.GetRange(data.Count - amount, amount);

        // Update the data list
        var newArray = endSlice.Concat(beginningSlice).ToList();

        for (int i = 0; i < newArray.Count; i++)
        {
            data[i] = newArray[i];
        }
    }
}
