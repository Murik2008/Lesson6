//Задайте двумерный массив символов (тип char [,]). 
//Создать строку из символов этого массива.
char[,] matrChar = {
{'a','b','c'},
{'d','e','f'},
{'g','h','i'}
};
void PrintCharMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write(matrix[i,l]+ " ");
        }
        Console.WriteLine();
    }
}
PrintCharMatrix(matrChar);
string MatrixToString(char[,] matrix)
{
    string str = String.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            str += matrix[i,l];
        }
    }
    return str;
}
string str = MatrixToString(matrChar);
Console.WriteLine(str);