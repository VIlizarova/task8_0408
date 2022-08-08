Console.WriteLine ("Введите число  ");

int number = Convert.ToInt32(Console.ReadLine ());

int even = 2;

string str = "";

while (even <= number)
{
str = str + even;
even = even + 2;
}

Console.WriteLine(str);

// int even = 2;

// int count = 1;

// int length = 0;

// if (number % 2 == 0)
// {
//    length = ((number / 2) - 1); 
// }
// else
// {
//     length = (((number-1) / 2) - 1);
// }

// int[] myarray = new int[length];


//  while (even <= number)
// {
//     myarray.SetValue( even, count );
//     even = even + 2;
//     count = count + 1;
// }

// Array.ForEach(myarray,Console.WriteLine);
