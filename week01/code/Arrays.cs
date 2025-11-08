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

        // SOLUTION:
        // Step 1: Create a new array of doubles with size equal to 'length'
        // Step 2: Loop through the array from index 0 to length-1
        // Step 3: For each index i, calculate the multiple by multiplying 'number' by (i + 1)
        // Step 4: Store the calculated multiple in the array at index i
        // Step 5: After the loop completes, return the array

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result; // replace this return statement with your own
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

        // SOLUTION:
        // Step 1: Calculate the split point (where to divide the list)
        // Step 2: Extract the two portions of the list:
        // Step 3: Clear the original list
        // Step 4: Add backPortion first, then add frontPortion

        int splitPoint = data.Count - amount;

        // Get the portion that will move to the back (from index 0 to splitPoint)
        List<int> frontPortion = data.GetRange(0, splitPoint);

        // Get the portion that will move to the front (from splitPoint to end)
        List<int> backPortion = data.GetRange(splitPoint, amount);

        // Clear the original list
        data.Clear();

        // Add back portion first (this goes to the front)
        data.AddRange(backPortion);

        // Add front portion second (this goes to the back)
        data.AddRange(frontPortion);
    }
}

