public class ParameterDemo
{
    // ref parameter: the variable is passed by reference, so changes
    // made inside the method affect the original variable.
    // The variable MUST have a value before it is passed in.
    public void Increase(ref int number)
    {
        number = number + 10;
    }

    // out parameter: used to send a value OUT of the method.
    // The method must assign a value to it before finishing.
    // The variable doesn't need a value before the call.
    public void GetFullName(out string fullname)
    {
        fullname = "Jenisha Rai"; 
    }

    // params parameter: lets you pass any number of ints,
    // which arrive inside the method as an array.
    public int SumAll(params int[] numbers)
    {
        int total = 0;
        foreach (int n in numbers)
        {
            total += n;
        }
        return total;
    }
}