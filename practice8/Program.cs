using System;

class Programm 
{
    public int[] srt1(int[]mass,int number)
    {
        int score = 0;
        int raznica = 0;
        int[] vozvrat= new int[2] {0,0};
        for (int i = 0; i < mass.Length; i++)
        {
            for(int j = 0; j < mass.Length; j++)
            {
                if (mass[i] + mass[j] == number&&j!=i)
                {
                    vozvrat[score] = mass[i];
                    score++;
                    vozvrat[score] = mass[j];
                    i = mass.Length;
                    break;
                }
                else if (mass[i] + mass[j] == number-raznica && j != i)
                {
                    vozvrat[score] = mass[i];
                    score++;
                    vozvrat[score] = mass[j];
                    i = mass.Length;
                    break;
                }
                else if (mass[i] + mass[j] == number + raznica && j != i)
                {
                    vozvrat[score] = mass[i];
                    score++;
                    vozvrat[score] = mass[j];
                    i = mass.Length;
                    break;
                }
            }

            if(i== mass.Length - 1 && vozvrat[0] ==0 && vozvrat[1] == 0)//доделать 16.12
            {
                raznica++;
                i = 0;
            }
        }
        return vozvrat;
        ////////
    }
    public int[] srt2(int[]mass,int number)
    {
        int[] vozvrat = new int[2];
        for (int i = 0; i < mass.Length; i++)
        {
            int first = mass[i];
            int second = number - first;
            int index = Array.BinarySearch(mass, second);
            if (index > -1 && index != i)
            {
                vozvrat[0] = i;
                vozvrat[1] = index;
                return vozvrat;
            }
        }
        throw new Exception("Не найдено.");
    }




        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hashTable = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];

                if (hashTable.ContainsKey(difference))
                {
                    return new int[] { hashTable[difference], i };
                }
                else
                {
                    hashTable[nums[i]] = i;
                }
            }
            throw new Exception("Не найдено.");
        }

    static void Main()
    {
        int[] mass = { 2,6,5,3};
        int number = 9;
        Programm programm = new Programm();
        try
        {
            for (int i = 0; i < programm.srt1(mass, number).Length; i++)
            {
                Console.Write(programm.srt1(mass, number)[i] + " ");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}
