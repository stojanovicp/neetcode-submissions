public class Solution {
    // public int BruteForceCountStudents(int[] students, int[] sandwiches) {
    //     var waitingStudents = new Queue<int>();

    //     foreach(int student in students)
    //     {
    //         waitingStudents.Enqueue(student);
    //     }

    //     for(int i=0; i < sandwiches.Length; i++)
    //     {
    //         int studentsRemaining = waitingStudents.Count;
    //         int rotations = 0;
    //         while(sandwiches[i] != waitingStudents.Peek())
    //         {
    //             int student = waitingStudents.Dequeue();
    //             waitingStudents.Enqueue(student);
    //             rotations++;
    //             if(rotations == studentsRemaining)
    //             {
    //                 return studentsRemaining;
    //             }
    //         }
    //         waitingStudents.Dequeue();
    //     }
    //     return 0;
    // }

    public int CountStudents(int[] students, int[] sandwiches) {
        int wantedRound = 0;
        int wantedSquare = 0;

        foreach(int student in students)
        {
            if(student == 0)
                wantedRound++;
            else
                wantedSquare++;
        }
        
        foreach(int sandwich in sandwiches)
        {
            if(sandwich == 0)
            {
                if (wantedRound == 0)
                    break;

                wantedRound--;
            }
            else
            {
                if (wantedSquare == 0)
                    break;
                wantedSquare--;
            }
        }
        return wantedRound + wantedSquare;
    }
}