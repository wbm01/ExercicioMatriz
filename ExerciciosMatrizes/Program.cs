internal class Program
{
    private static void Main(string[] args)
    {
        float[,] m = new float[5, 3];
        Random sorteio = new Random();
        /*m[0, 0] = 10; m[0, 1] = 20; m[0, 2] = 30;
        m[1, 0] = 40; m[1, 1] = 50; m[1, 2] = 60;
        m[2, 0] = 70; m[2, 1] = 80; m[2, 2] = 90;
        m[3, 0] = 100; m[3, 1] = 110; m[3, 2] = 120;
        m[4, 0] = 130; m[4, 1] = 140; m[4, 2] = 150;*/

        //Carregar valores na matriz
        for (int c = 0; c < m.GetLength(1)-1; c++)
        {  //Se fosse para percorrer a linha usaria 0 no GetLength,
            //mas como vai percorrer a coluna utilizou o 1

            for (int l = 0; l < m.GetLength(0); l++)
            {
                m[l, c] = sorteio.Next(10000)/100;
            }
        }

        //Cálculo da terceira coluna
        for (int i = 0; i < 5; i++)
        {
            m[i, 2] = (m[i, 0] + m[i, 1]) / 2;
        }

        //Gerar números aleatórios
        for (int l = 0; l < m.GetLength(0); l++)
        {  
            for (int c = 0; c < m.GetLength(1); c++)
            {
                Console.Write("\tm" + "[" + l + "," + c + "]" + "=" + m[l,c]);
            }
            Console.WriteLine();
        }

       
        
    }
}